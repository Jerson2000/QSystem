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
namespace QSystem.UserControls
{
    public partial class Dashboard : UserControl
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter sda;
        public Dashboard()
        {
            InitializeComponent();
        }
        public void GetTodayLogs()
        {
            try
            {
                
                cmd = new SqlCommand("select COUNT(id) as LogsCount from logs where DAY(timestamp) = DAY(GETDATE()) and status ='pending';", Connection.Con);
                Connection.Con.Close();
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbReq.Text = dr.GetInt32(0).ToString();
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
                Console.WriteLine("logs executed");
            }
        }

        public void GetLogs()
        {
            try
            {
                Connection.Con.Open();              
                sda = new SqlDataAdapter("select * from logs order by id desc;", Connection.Con);

                var ds = new DataSet();
                ds.Clear();
                sda.Fill(ds);
                sda.Dispose();
                dataGridView1.DataSource = ds.Tables[0];
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("logs executed");
            }
        }


        public void GetLimit()
        {
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select limit from limit", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbLimit.Text = dr.GetInt32(0).ToString();
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
                Console.WriteLine("Limit executed");
            }
        }

        public void GetQDone()
        {
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select COUNT(id) as Done from logs where (status = 'Done' or status = 'Cancelled' ) and DAY(timestamp) = DAY(GETDATE());", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbDone.Text = dr.GetInt32(0).ToString();
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
                Console.WriteLine("Limit executed");
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTodayLogs();
            GetLogs();
            GetQDone();
            GetLimit();
        }

    }
}
