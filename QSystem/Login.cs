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
    public partial class Login : Form
    {
        public static string email = "admin@admin.com";
        public static string pass = "1234";
        public Login()
        {
            InitializeComponent();
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textBox1.PasswordChar = default;
            }
            else
            {
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textBox1.PasswordChar = '*';

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == email && textBox1.Text == pass)
            {
                Main main = new Main();
                main.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Credentials, Please try again!", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
