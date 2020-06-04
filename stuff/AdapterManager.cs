using System.Net.NetworkInformation;
using System;
using System.Management;

namespace WindowsFormsApp1
{
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

        public int updateAdapterConfiguration(AdapterConfiguration config)
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
                        return 0;
                    } else if (config.dir == SwitchDirection.TO_STATIC)
                    {
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnableStatic");
                        PropertyDataCollection props = newIP.Properties;

                        newIP["IPAddress"] = new string[] { config.ip };

                        if (config.subnet != null)
                            newIP["SubnetMask"] = new string[] { config.subnet };
                        else
                            newIP["SubnetMask"] = new string[] { "255.255.255.0" };

                        if (config.gateway != null)
                        {
                            ManagementBaseObject newGateway = objMO.GetMethodParameters("SetGateways");
                            newGateway["DefaultIPGateway"] = new string[] { config.gateway };
                            objMO.InvokeMethod("SetGateways", newGateway, null);
                        }

                        PropertyDataCollection res = objMO.InvokeMethod("EnableStatic", newIP, null).Properties;
                        UInt32 ret = (UInt32)res["ReturnValue"].Value;
                        return (int)ret;
                    }
                }
            }

            throw new Exception("No suitable adapters found");
        }
    }
}
