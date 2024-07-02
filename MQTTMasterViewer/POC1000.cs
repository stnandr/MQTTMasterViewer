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
    public partial class POC1000 : Form
    {
        public POC1000()
        {
            InitializeComponent();
            SubscribePOC1000();
            //SubscribeCOM100();

        }

        private async void SubscribePOC1000()
        {
            var tmp = await LoginPage.client.SubscribeAsync("POC1000/TMP");
            var order = await LoginPage.client.SubscribeAsync("POC1000/ORDER_ID");
            var serial = await LoginPage.client.SubscribeAsync("POC1000/SER_NUM");
            var intL1 = await LoginPage.client.SubscribeAsync("POC1000/INT_L1");
            var vtgL1 = await LoginPage.client.SubscribeAsync("POC1000/VTG_L1");
            LoginPage.client.ApplicationMessageReceivedAsync += e =>
            {
                switch (e.ApplicationMessage.Topic)
                {

                    case "POC1000/TMP":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " °C", tempPOC);
                       // tempPOC.BeginInvoke((MethodInvoker)delegate () { tempPOC.Text += " °C"; ; });
                        break;
                    case "POC1000/VTG_L1":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment)+ " V", volatagePOC);
                        //volatagePOC.BeginInvoke((MethodInvoker)delegate () { volatagePOC.Text += " V"; ; });
                        break;
                    case "POC1000/SER_NUM":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), serialNumPOC);
                        //serialNumPOC.BeginInvoke((MethodInvoker)delegate () { serialNumPOC.Text += ""; ; });
                        break;
                    case "POC1000/INT_L1":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment) + " A", intensityPOC);
                        //intensityPOC.BeginInvoke((MethodInvoker)delegate () { intensityPOC.Text += " A"; ; });
                        break;
                    case "POC1000/ORDER_ID":
                        SetText(Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment), orderidPOC);
                        //orderidPOC.BeginInvoke((MethodInvoker)delegate () { orderidPOC.Text += ""; ; });
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