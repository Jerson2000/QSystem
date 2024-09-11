using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSystem
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            Load += Main_Load;

        }

        private void Main_Load(object sender, EventArgs e)
        {
           SetActivePanel(dashboard1);
        }

        // Toggle BTN
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(panel1.Size.Width == 200)
            {
                panel1.Size = new System.Drawing.Size(0, 505);
            }
            else if(panel1.Size.Width == 0)
            {
                panel1.Size = new System.Drawing.Size(200, 505);
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        public void SetActivePanel(UserControl control)
        {
            dashboard1.Visible = false;
            request2.Visible = false;
            queue1.Visible = false;
            control.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SetActivePanel(request2);
            label1.Text = "Request";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
            label1.Text = "Dashboard";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SetActivePanel(queue1);
            label1.Text = "Queue";
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {          
            Close();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Signing Out...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                 e.Cancel = true;
            }
            else
            {
                Login login = new Login();
                login.Show();
            }
           
        }
    }
}
