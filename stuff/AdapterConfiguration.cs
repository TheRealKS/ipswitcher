using System.Net;

namespace WindowsFormsApp1
{
    public class AdapterConfiguration
    {
        public SwitchDirection dir = SwitchDirection.TO_STATIC;
        public int id = 0;
        public string ip;
        public string subnet;
        public string gateway;

        public bool verify()
        {
            if (dir == SwitchDirection.TO_DHCP)
            {
                return true;
            }

            if (ip.Equals(null))
            {
                return false;
            }

            IPAddress ipa;
            if (!IPAddress.TryParse(ip, out ipa))
            {
                return false;
            }

            if (subnet != null)
            {
                if (!IPAddress.TryParse(subnet, out ipa))
                {
                    return false;
                }
            }

            if (gateway != null)
            {
                if (!IPAddress.TryParse(gateway, out ipa))
                {
                    return false;
                }
            }

            return true;
        }
    }
}