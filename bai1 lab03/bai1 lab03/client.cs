using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;

namespace bai1_lab03
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";

            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            output = ip.Address.ToString();
            return output;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            txt_Host.Text = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txt_Host.Text))
                txt_Host.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Host.Text))
            {
                MessageBox.Show("Host không được để trống");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_Port.Text))
            {
                MessageBox.Show("Port không được để trống");
                return;
            }
            else if (string.IsNullOrWhiteSpace(rtxt_Messages.Text))
                return;

            UdpClient udpClient = new UdpClient();
            byte[] sendBytes = Encoding.UTF8.GetBytes(rtxt_Messages.Text);
            int port = Int32.Parse(txt_Port.Text);
            udpClient.Send(sendBytes, sendBytes.Length, txt_Host.Text, port);
        }
    }
}
