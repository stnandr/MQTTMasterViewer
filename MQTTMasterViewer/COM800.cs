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


namespace MQTTMasterViewer
{
    public partial class COM800 : Form
    {
        public COM800()
        {
            InitializeComponent();
            SubscribeCOM800();
            //SubscribeCOM100();

        }

        private async void SubscribeCOM800()
        {
            var tmp = await LoginPage.client.SubscribeAsync("COM800/TMP");
            var order = await LoginPage.client.SubscribeAsync("COM800/ORDER_ID");
            var serial = await LoginPage.client.SubscribeAsync("COM800/SER_NUM");
            var intL1 = await LoginPage.client.SubscribeAsync("COM800/UP_TIME");
            LoginPage.client.ApplicationMessageReceivedAsync += e =>
            {
                switch (e.ApplicationMessage.Topic)
                {

                    case "COM800/TMP":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " °C", temperatureCOM);
                        //temperatureCOM.BeginInvoke((MethodInvoker)delegate () { temperatureCOM.Text += " °C"; ; });
                        break;
                    case "COM800/UP_TIME":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " s", upTimeCOM);
                       // upTimeCOM.BeginInvoke((MethodInvoker)delegate () { upTimeCOM.Text += " s"; ; });
                        break;
                    case "COM800/SER_NUM":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), serialNumCOM);
                        //serialNumCOM.BeginInvoke((MethodInvoker)delegate () { serialNumCOM.Text += ""; ; });
                        break;
                    case "COM800/ORDER_ID":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), orderidCOM);
                       //orderidCOM.BeginInvoke((MethodInvoker)delegate () { orderidCOM.Text += ""; ; });
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