using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        AdapterManager am;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            am = new AdapterManager(this);

            IP_ONE.Text = Properties.Settings.Default.ip_one;
            IP_TWO.Text = Properties.Settings.Default.ip_two;
            IP_THREE.Text = Properties.Settings.Default.ip_three;

            SUBNET_ONE.Text = Properties.Settings.Default.subnet_one;
            SUBNET_TWO.Text = Properties.Settings.Default.subnet_two;
            SUBNET_THREE.Text = Properties.Settings.Default.subnet_three;

            GATEWAY_ONE.Text = Properties.Settings.Default.gateway_one;
            GATEWAY_TWO.Text = Properties.Settings.Default.gateway_two;
            GATEWAY_THREE.Text = Properties.Settings.Default.gateway_three;
        }

        public void addAdapter(string nm)
        {
            AdapterList.Items.Add(nm);
        }

        private void applyConfig(AdapterConfiguration c)
        {
            int index = AdapterList.SelectedIndex;
            if (AdapterList.SelectedIndex == -1) {
                status.Text = "You must select an adapter first!";
                return;
            }

            try
            {
                ConfigSettingResult i = am.updateAdapterConfiguration(c);
                string text = "";
                if (i.sub_ip == 0 && i.gateway < 1) {
                    text = "Applied settings : " + (c.id > 0 ? c.id.ToString() : "DHCP");
                } else {
                    if (i.sub_ip == 0 && i.gateway > 0) {
                        text = "Could not set gateway. Code " + i.gateway.ToString();
                        if (i.gateway == 68 || i.gateway == 71) {
                            text += " (This indicates a bad input parameter!)";
                        } else if (i.gateway == 67) {
                            text += " (Are you administrator?)";
                        } else if (i.gateway == 1) {
                            text += " (You may need to reboot)";
                        }
                    } else if (i.sub_ip > 0 && i.gateway == -1) {
                        text = "Could not set ip and/or subnet. Code " + i.sub_ip.ToString();
                        if (i.sub_ip == 68 || i.sub_ip == 66 || i.sub_ip == 70) {
                            text += " (This indicates a bad input parameter!)";
                        } else if (i.sub_ip == 67) {
                            text += " (Are you administrator?)";
                        } else if (i.gateway == 1) {
                            text += " (You may need to reboot)";
                        }
                    } else if (i.sub_ip < 0) {
                        text = "Could not set apply settings. Code 67";
                        if (i.sub_ip == 67 || i.gateway == 67) {
                            text += " (Are you administrator?)";
                        }
                    } else {
                        text = "Could not set apply settings. Code " + i.sub_ip.ToString();
                    }
                }

                status.Text = text;
            } catch (Exception ex)
            {
                //Do something with exception;
                status.Text = "Error: " + ex.ToString();
            }
        }

        private void AdapterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            am.setCurrentAdapter(AdapterList.SelectedItem.ToString());
        }

        private void Applyone_Click(object sender, EventArgs e)
        {
            AdapterConfiguration config = new AdapterConfiguration();
            config.ip = IP_ONE.Text;
            config.id = 1;
            if (!String.IsNullOrEmpty(SUBNET_ONE.Text))
            {
                config.subnet = SUBNET_ONE.Text;
            }
            if (!String.IsNullOrEmpty(GATEWAY_ONE.Text))
            {
                config.gateway = GATEWAY_ONE.Text;
            }

            applyConfig(config);
        }

        private void Applytwo_Click(object sender, EventArgs e)
        {
            AdapterConfiguration config = new AdapterConfiguration();
            config.ip = IP_TWO.Text;
            config.id = 2;
            if (!String.IsNullOrEmpty(SUBNET_TWO.Text))
            {
                config.subnet = SUBNET_TWO.Text;
            }
            if (!String.IsNullOrEmpty(GATEWAY_TWO.Text))
            {
                config.gateway = GATEWAY_TWO.Text;
            }

            applyConfig(config);
        }

        private void Applythree_Click(object sender, EventArgs e)
        {
            AdapterConfiguration config = new AdapterConfiguration();
            config.ip = IP_THREE.Text;
            config.id = 3;
            if (!String.IsNullOrEmpty(SUBNET_THREE.Text))
            {
                config.subnet = SUBNET_THREE.Text;
            }
            if (!String.IsNullOrEmpty(GATEWAY_THREE.Text))
            {
                config.gateway = GATEWAY_THREE.Text;
            }

            applyConfig(config);
        }

        private void DHCP_Click(object sender, EventArgs e)
        {
            AdapterConfiguration config = new AdapterConfiguration();
            config.dir = SwitchDirection.TO_DHCP;

            applyConfig(config);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ip_one = IP_ONE.Text;
            Properties.Settings.Default.ip_two = IP_TWO.Text;
            Properties.Settings.Default.ip_three = IP_THREE.Text;

            Properties.Settings.Default.subnet_one = SUBNET_ONE.Text;
            Properties.Settings.Default.subnet_two = SUBNET_TWO.Text;
            Properties.Settings.Default.subnet_three = SUBNET_THREE.Text;

            Properties.Settings.Default.gateway_one = GATEWAY_ONE.Text;
            Properties.Settings.Default.gateway_two = GATEWAY_TWO.Text;
            Properties.Settings.Default.gateway_three = GATEWAY_THREE.Text;

            status.Text = "Saved!";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
