using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTMasterViewer
{
    public partial class MasterViewerUI : Form
    {
        public MasterViewerUI()
        {
            InitializeComponent();
            bunifuBreakerButton_Click(this, new EventArgs());
        }
        public Point mouseLocation;

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            fillPanel.Controls.Add(childForm);
            fillPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void breakerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Breaker());
        }

        private void poc1000Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new POC1000());
        }

        private void com100Button_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new COM100());
        }

        private void bunifuBreakerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Breaker());
        }

        private void bunifuPocButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new POC1000());
        }

        private void bunifuCOM800Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new COM800());
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void bunfiuExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
