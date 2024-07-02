using MQTTnet;
using MQTTnet.Client;

namespace MQTTMasterViewer
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public
            static IMqttClient client
        { get; set; }

       /* private async void connectButton_Click(object sender, EventArgs e)
        {
            string broker = srvAddrTextBox.Text;
            int port = 1883;
            string clientId = Guid.NewGuid().ToString();
            string username = usrNameTextBox.Text;
            string password = pswTextBox.Text;

            // Create a MQTT client factory
            var factory = new MqttFactory();

            // Create a MQTT client instance
            client = factory.CreateMqttClient();

            // Create MQTT client options
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(broker, port) // MQTT broker address and port
                .WithCredentials(username, password) // Set username and password
                .WithClientId(clientId)
                .WithCleanSession()
                .Build();

            // Connect to MQTT broker
            try
            {
                var connectResult = await client.ConnectAsync(options);

                if (connectResult.ResultCode == MqttClientConnectResultCode.Success)
                {
                    MessageBox.Show("Connected to MQTT broker successfully.");
                    this.Hide();
                    new MasterViewerUI().Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid credentials");
            }


        }
       */

        private void closeButtonLogin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {

            string broker = srvAddrTextBox.Text;
            int port = 1883;
            string clientId = Guid.NewGuid().ToString();
            string username = usrNameTextBox.Text;
            string password = pswTextBox.Text;

            // Create a MQTT client factory
            var factory = new MqttFactory();

            // Create a MQTT client instance
            client = factory.CreateMqttClient();

            // Create MQTT client options
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(broker, port) // MQTT broker address and port
                .WithCredentials(username, password) // Set username and password
                .WithClientId(clientId)
                .WithCleanSession()
                .Build();

            // Connect to MQTT broker
            try
            {
                var connectResult = await client.ConnectAsync(options);

                if (connectResult.ResultCode == MqttClientConnectResultCode.Success)
                {
                    MessageBox.Show("Connected to MQTT broker successfully.");
                    this.Hide();
                    new MasterViewerUI().Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
