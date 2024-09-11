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
using QSystem.UserControls;
namespace QSystem.Dialogs
{
    public partial class EditRequirement : Form
    {
        private int id = UserControls.Request.id;
        private string appName = UserControls.Request.appName;
        private string requirement = UserControls.Request.requirement;

        SqlCommand cmd;
        public EditRequirement()
        {
            InitializeComponent();
            label2.Text = appName;
            textBox1.Text = requirement;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the requirement.", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Connection.Con.Open();
                    cmd = new SqlCommand("update requirements set requirements = '" + textBox1.Text + "' where id =" + id + ";", Connection.Con);
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Updated Successfully", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    Connection.Con.Close();
                }
            }
        }
    }
}
