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
using QSystem.UserControls;
using QSystem.Classes;
namespace QSystem.Dialogs
{
    public partial class Requirements : Form
    {
        private int id = 0;

        SqlCommand cmd;
        SqlDataReader dr;
        public Requirements()
        {
            InitializeComponent();
            Load += Requirements_Load;
        }

        private void Requirements_Load(object sender, EventArgs e)
        {            
            GetAppName();
        }

        public void GetAppName()
        {
            id = UserControls.Request.appID;
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select * from application where id ="+id, Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbApp.Text = dr.GetString(1).ToString();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Con.Close();
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {            
            //MessageBox.Show(id.ToString());

            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter the requirement.","QMS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Connection.Con.Open();
                    cmd = new SqlCommand("insert into requirements (app_id,requirements) values("+id+",'"+textBox1.Text+"');", Connection.Con);
                    cmd.ExecuteNonQuery();
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Added Successfully", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    Connection.Con.Close();
                }
            }

        }
    }
}
