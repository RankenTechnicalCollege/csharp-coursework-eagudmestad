using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        List<Computer> rankenComputers = new List<Computer>();
        public Form1()
        {
            InitializeComponent();
            rankenComputers.Add(new Computer("My-Desktop", "127.0.0.1", new int[] { 20, 21, 23, 25, 53, 80, 123, 389, 443 }));
            rankenComputers.Add(new Computer("google-public-dns-a", "8.8.8.8", new int[] { 53 }));
            rankenComputers.Add(new Computer("ranken.edu", "47.44.246.80", new int[] { 25, 80, 443 }));
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ShowComputer(ScanIpAddress(txtIPAddress.Text));
        }

        public Computer ScanIpAddress(string ipAddress)
        {
            Computer searchComputer = null;

            for (int i = 0; i < rankenComputers.Count; i++)
            {
                if(rankenComputers[i].IpAddress.Equals(ipAddress))
                {
                    searchComputer = rankenComputers[i];
                }
            }
            return searchComputer;
        }

        public void ShowComputer(Computer computer)
        {
            if(computer == null)
            {
                lblName.Text = "Request Timed Out";
                lblIPAddress.Text = "127.0.0.1";
                lblServices.Text = "None";
            }
            else
            {
                lblName.Text = computer.Name;
                lblIPAddress.Text = computer.IpAddress;

                StringBuilder computerServices = new StringBuilder();

                int[] theseServices = computer.Services;

                for (int i = 0; i < theseServices.Length; i++)
                {
                    switch(theseServices[i])
                    {
                        case 20:
                            computerServices.Append("20: FTP_DATA\n");
                            break;
                        case 21:
                            computerServices.Append("21: FTP_CONTROL\n");
                            break;
                        case 23:
                            computerServices.Append("23: TELNET\n");
                            break;
                        case 25:
                            computerServices.Append("25: SMTP\n");
                            break;
                        case 53:
                            computerServices.Append("53: DNS\n");
                            break;
                        case 80:
                            computerServices.Append("80: TELNET\n");
                            break;
                        case 123:
                            computerServices.Append("123: NTP\n");
                            break;
                        case 389:
                            computerServices.Append("389: LDAP\n");
                            break;
                        case 443:
                            computerServices.Append("443: HTTPS\n");
                            break;
                    }
                }

                lblServices.Text = computerServices.ToString();
            }
        }
    }
}
