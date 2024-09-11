using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QSystem.Classes;
namespace QSystem.Dialogs
{
    public partial class EditApp : Form
    {
        SqlCommand cmd;
        public EditApp()
        {
            InitializeComponent();
        }       

        private void EditApp_Load(object sender, EventArgs e)
        {
            textBox1.Text = Applications.name;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {                
                Connection.Con.Open();
                cmd = new SqlCommand("update application set name='" + textBox1.Text + "' where id=" + Applications.id,Connection.Con);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Con.Close();
                MessageBox.Show("Update Success", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
