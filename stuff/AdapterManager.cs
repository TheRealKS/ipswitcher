using System.Net.NetworkInformation;
using System;
using System.Management;
using System.Reflection;

namespace WindowsFormsApp1
{
    struct ConfigSettingResult {
        public int sub_ip;
        public int gateway;
    }

    class AdapterManager
    {
        NetworkInterface[] interfaces;
        string currentAdapter;

        public AdapterManager(Form1 f1)
        {
            this.interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface i in this.interfaces)
            {
                if (i.OperationalStatus.Equals(OperationalStatus.Up))
                {
                    f1.addAdapter(i.Name);
                }
            }
        }

        public bool setCurrentAdapter(string nm)
        {
            foreach (NetworkInterface i in this.interfaces)
            {
                if (i.Name.Equals(nm))
                {
                    currentAdapter = i.Id;
                    return true;
                }
            }
            return false;
        }

        public ConfigSettingResult updateAdapterConfiguration(AdapterConfiguration config)
        {   
            if (!config.verify())
            {
                throw new Exception("Some property was not set correctly");
            }

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                bool enabled = (bool)objMO["IPEnabled"];
                string id = (string)objMO["SettingID"];
                if ((bool)objMO["IPEnabled"] && ((string)objMO["SettingID"]).Equals(this.currentAdapter))
                {
                    if (config.dir == SwitchDirection.TO_DHCP)
                    {
                        objMO.InvokeMethod("EnableDHCP", null);
                        ConfigSettingResult result = new ConfigSettingResult();
                        result.sub_ip = 0;
                        result.gateway = 0;
                        return result;
                    } else if (config.dir == SwitchDirection.TO_STATIC)
                    {
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnableStatic");
                        PropertyDataCollection props = newIP.Properties;

                        newIP["IPAddress"] = new string[] { config.ip };

                        if (config.subnet != null)
                            newIP["SubnetMask"] = new string[] { config.subnet };
                        else
                            newIP["SubnetMask"] = new string[] { "255.255.255.0" };

                        PropertyDataCollection res = objMO.InvokeMethod("EnableStatic", newIP, null).Properties;
                        UInt32 ret = (UInt32)res["ReturnValue"].Value;
                        int ipretval = (int)ret;
                        int gatewayretval = -1;

                        if (config.gateway != null)
                        {
                            ManagementBaseObject newGateway = objMO.GetMethodParameters("SetGateways");
                            newGateway["DefaultIPGateway"] = new string[] { config.gateway };
                            PropertyDataCollection result = objMO.InvokeMethod("SetGateways", newGateway, null).Properties;
                            UInt32 retval = (UInt32)result["ReturnValue"].Value;
                            gatewayretval = (int)retval;
                        }

                        ConfigSettingResult resultstruct = new ConfigSettingResult();
                        resultstruct.sub_ip = ipretval;
                        resultstruct.gateway = gatewayretval;
                        return resultstruct;
                    }
                }
            }

            throw new Exception("No suitable adapters found");
        }
    }
}
