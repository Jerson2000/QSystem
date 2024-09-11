using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QSystem.Classes;
using System.Data.SqlClient;
namespace QSystem.Dialogs
{
    public partial class AddApp : Form
    {
        SqlCommand cmd;
        public AddApp()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    Connection.Con.Open();
                    cmd = new SqlCommand("insert into application(name,timestamp) values ('" + textBox1.Text + "',GETDATE());", Connection.Con);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connection.Con.Close();
                    MessageBox.Show("Application Added", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Please enter the application!", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }




    }
}
