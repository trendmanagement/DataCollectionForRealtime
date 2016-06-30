using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace RealTimeImitator
{
    public partial class MainForm : Form
    {
        int countQuery = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxNames.SelectedIndex = 0;
        }

        void SendCQGQuery(string name, string CQGquery)
        {
            int port = 8005; 
            string address = "127.0.0.1"; 

            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);

                string message = string.Format("Realtime name: {0}, CQG qeury: {1}", name, CQGquery);
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                data = new byte[256]; 
                StringBuilder builder = new StringBuilder();
                int bytes = 0; 

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                labelStatus.Text = ("Ansver from server: " + builder.ToString());

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            catch (Exception ex)
            {
                labelStatus.Text = "Error: " + ex.Message;
            }
        }

        private void buttonSendQuery_Click(object sender, EventArgs e)
        {
            string message = string.Format("Query #{0}", countQuery);

            labelQuery.Text = message;

            SendCQGQuery(comboBoxNames.SelectedItem.ToString(), message);
            ++countQuery;
        }
    }
}
