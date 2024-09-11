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
    public partial class SchedulePopup : Form
    {
        private int x = 783;
        SqlCommand cmd;
        SqlDataReader dr;
        private int appID;
        public SchedulePopup()
        {
            InitializeComponent();
            Load += SchedulePopup_Load;
        }

        private void SchedulePopup_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
            GetData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(x <= -835)
            {
                x = 783;
            }
            label3.Location = new Point(x-=5, 16);
        }


        public void GetData()
        {
            try
            {
                cmd = new SqlCommand("" +
                    "select (fname +' '+lname+' '+mi) as name,age,gender,contno,email,application,qno," +
                    "(DATENAME(month,sched)+', '+DATENAME(day,sched)+', '+DATENAME(year,sched) ) as sched,status from queue where id = IDENT_CURRENT('queue');", Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();                
                while (dr.Read())
                {
                    lbName.Text = dr.GetString(0).ToString();
                    lbAge.Text = dr.GetInt32(1).ToString();
                    lbSex.Text = dr.GetString(2).ToString();
                    lbContno.Text = dr.GetInt64(3).ToString();
                    lbEmail.Text = dr.GetString(4).ToString();
                    lbApp.Text = dr.GetString(5).ToString();
                    lbQno.Text = dr.GetInt32(6).ToString();
                    lbSched.Text = dr.GetString(7).ToString();
                    lbStats.Text = dr.GetString(8).ToString();                    
                }
                dr.Close();
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                try
                {
                    cmd = new SqlCommand("select * from application where name='"+lbApp.Text+"';", Connection.Con);
                    Connection.Con.Open();
                    cmd.ExecuteNonQuery();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        appID = dr.GetInt32(0);
                    }
                    dr.Close();
                    Connection.Con.Close();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Console.WriteLine("Get appID EXECUTED");
                    GetRequirement();

                }
            }
        }

        public void GetRequirement()
        {
            try
            {
                cmd = new SqlCommand("select requirements from requirements where app_id="+appID, Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add("* " + dr.GetString(0).ToString());
                }
                dr.Close();
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Get requirements EXECUTED");
            }
        }
    }

    
}
