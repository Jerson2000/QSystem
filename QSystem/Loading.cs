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
    public partial class Loading : Form
    {
        private string wcText;
        private int len = 0;
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (customProgressbar1.Value < customProgressbar1.Maximum)
            {
                if (len < wcText.Length)
                {
                    label1.Text = label1.Text + wcText.ElementAt(len);
                    len++;
                }
                customProgressbar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            wcText = label1.Text;
            label1.Text = "";
        }
        // Form fade out
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                timer2.Stop();
                Close();
            }
            Opacity -= .2;
        }
    }
}
