using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing.Text;
using System.Drawing;

namespace IpSwitcher
{
    public partial class IpSwitcherForm : Form
    {
        private string originalIpAddress;
        private string originalSubnetMask;
        private string originalGateway;

        public IpSwitcherForm()
        {
            InitializeComponent();
            GetCurrentIpAddress();
            SystemEvents.SessionEnding += new SessionEndingEventHandler(OnSessionEnding);
            ApplyOrbitronFont(this);
        }

        private void GetCurrentIpAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            originalIpAddress = ip.Address.ToString();
                            originalSubnetMask = ip.IPv4Mask.ToString();
                            foreach (GatewayIPAddressInformation gateway in ni.GetIPProperties().GatewayAddresses)
                            {
                                if (gateway.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                {
                                    originalGateway = gateway.Address.ToString();
                                }
                            }
                            currentIpLabel.Text = $"Current IP: {originalIpAddress}";
                            UpdateWebBrowserContent(originalIpAddress);
                            return;
                        }
                    }
                }
            }
        }

        private void switchIpButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string newIpAddress = $"192.168.1.{rand.Next(2, 255)}"; // Random IP in the 192.168.1.x range
            string subnetMask = "255.255.255.0"; // Default subnet mask
            string gateway = "192.168.1.1"; // Default gateway

            SetIpAddress(newIpAddress, subnetMask, gateway);
            GetCurrentIpAddress(); // Update the current IP label with the new IP address
        }

        private void SetIpAddress(string ipAddress, string subnetMask, string gateway)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", $"interface ip set address name=\"Ethernet\" static {ipAddress} {subnetMask} {gateway}")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = Process.Start(psi);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();

            MessageBox.Show(output, "IP Switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetIpAddress()
        {
            SetIpAddress(originalIpAddress, originalSubnetMask, originalGateway);
        }

        private void OnSessionEnding(object sender, SessionEndingEventArgs e)
        {
            ResetIpAddress();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            settingsPanel.Visible = true;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void UpdateWebBrowserContent(string ipAddress)
        {
            string htmlContent = $@"
                <html>
                <head>
                    <link href='https://fonts.googleapis.com/css2?family=Orbitron&display=swap' rel='stylesheet'>
                    <style>
                        body {{
                            font-family: 'Orbitron', sans-serif;
                            background-color: #f0f0f0;
                            margin: 0;
                            padding: 20px;
                        }}
                        .ip-address {{
                            font-size: 24px;
                            color: #333;
                        }}
                    </style>
                </head>
                <body>
                    <div class='ip-address'>Your IP Address: {ipAddress}</div>
                </body>
                </html>";

            webBrowser.DocumentText = htmlContent;
        }

        private void ApplyOrbitronFont(Control control)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Orbitron-Regular.ttf"); // Ensure the .ttf file is in the application directory

            Font orbitronFont = new Font(pfc.Families[0], 12, FontStyle.Regular);

            control.Font = orbitronFont;
            foreach (Control childControl in control.Controls)
            {
                ApplyOrbitronFont(childControl);
            }
        }
    }
}
