using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MQTTMasterViewer;
using MQTTnet.Client;
using MQTTnet.Server;
using static System.Net.Mime.MediaTypeNames;

namespace MQTTMasterViewer
{
    public partial class Breaker : Form
    {
        private
            bool CONNECTED = false;
        public Breaker()
        {
            InitializeComponent();
            if (CONNECTED == false)
            {
                Subscribe3VA();
                CONNECTED = true;
            }
            CreateHandle();
            //SubscribeCOM100();
        }

        private async void Subscribe3VA()
        {
            var uptime = await LoginPage.client.SubscribeAsync("3VA/UP_TIME");
            var order = await LoginPage.client.SubscribeAsync("3VA/ORDER_ID");
            var serial = await LoginPage.client.SubscribeAsync("3VA/SER_NUM");
            var intL1 = await LoginPage.client.SubscribeAsync("3VA/INT_L1");
            var intL2 = await LoginPage.client.SubscribeAsync("3VA/INT_L2");
            var intL3 = await LoginPage.client.SubscribeAsync("3VA/INT_L3");
            var intAVG = await LoginPage.client.SubscribeAsync("3VA/INT_AVG");
            var tmp = await LoginPage.client.SubscribeAsync("3VA/TMP");
            LoginPage.client.ApplicationMessageReceivedAsync += e =>
            {
                switch (e.ApplicationMessage.Topic)
                {
                    case "3VA/UP_TIME":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " s", oprHours3VA);
                        //BeginInvoke((MethodInvoker)delegate () { oprHours3VA.Text += " s"; ; });
                        break;
                    case "3VA/TMP":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " °C", temperature3VA);
                        //temperature3VA.BeginInvoke((MethodInvoker)delegate () { temperature3VA.Text += " °C"; ; });
                        break;
                    case "3VA/Voltage_L1":
                        //SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " V", volatageL13VA);
                        //volatageL13VA.BeginInvoke((MethodInvoker)delegate () { volatageL13VA.Text += " V"; ; });
                        break;
                    case "3VA/Voltage_L2":
                        // SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " V", voltageL23VA);
                        // voltageL23VA.BeginInvoke((MethodInvoker)delegate () { voltageL23VA.Text += " V"; ; });
                        break;
                    case "3VA/Voltage_L3":
                        // SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " V", voltageL33VA);
                        // voltageL33VA.BeginInvoke((MethodInvoker)delegate () { voltageL33VA.Text += " V"; ; });
                        break;
                    case "3VA/INT_L1":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " A", intensityL13VA);
                        //intensityL13VA.BeginInvoke((MethodInvoker)delegate () { intensityL13VA.Text += " A"; ; });
                        break;
                    case "3VA/INT_L2":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " A", intensityL23VA);
                        //intensityL23VA.BeginInvoke((MethodInvoker)delegate () { intensityL23VA.Text += " A"; ; });
                        break;
                    case "3VA/INT_L3":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " A", intensityL3);
                        //intensityL3.BeginInvoke((MethodInvoker)delegate () { intensityL3.Text += " A"; ; });
                        break;
                    case "3VA/INT_AVG":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " A", intensityMax);
                        // intensityMax.BeginInvoke((MethodInvoker)delegate () { intensityMax.Text += " A"; ; });
                        break;
                    case "3VA/ORDER_ID":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), orderid3VA);
                        break;
                    case "3VA/SER_NUM":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), serialNum);
                        break;

                    default:
                        break;


                }
                return Task.CompletedTask;
            };
        }

        /* private async void SubscribeCOM100()
         {
             var first = await LoginPage.client.SubscribeAsync("COM100");
             LoginPage.client.ApplicationMessageReceivedAsync += e =>
             {
                 if(e.ApplicationMessage.Topic == "COM100")
                 {
                     SetTextCOM(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment));
                     //operatingLabel.Text =  Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment);
                 }
                 return Task.CompletedTask;
             };
         }
        */

        delegate void SetTextCallback(string text, Label Label);

        private void SetText(string text, Label Label)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (Label.InvokeRequired)
            {
                Label.BeginInvoke((MethodInvoker)delegate () { Label.Text = text; ; });
                //SetTextCallback d = new SetTextCallback(SetText);
                //this.Invoke(d, new object[] { text });
            }
            else
            {
                Label.Text = text;
            }
        }

        private void Breaker_Load(object sender, EventArgs e)
        {

        }

        private void orderid3VA_Text_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel6_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void temperature3VA_Click(object sender, EventArgs e)
        {

        }
        /* private void SetTextCOM(string text)
{
// InvokeRequired required compares the thread ID of the
// calling thread to the thread ID of the creating thread.
// If these threads are different, it returns true.
if (this.operatingLabel.InvokeRequired)
{
SetTextCallback d = new SetTextCallback(SetTextCOM);
this.Invoke(d, new object[] { text });
}
else
{
this.COM100label.Text = text;
}


}
*/
    }
}
