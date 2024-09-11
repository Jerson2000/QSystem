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
    public partial class Queue : UserControl
    {
        private int id = 0;
        private int currentQ = 0;       
        private string done = "Done";
        private string cancel = "Cancelled";

        private int x = 1010;

        DataTable dt;
        SqlCommand cmd;
        public Queue()
        {
           
            InitializeComponent();
            Load += Queue_Load;
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            GetQ();
            Populate();
           // noQToday.Visible = false;
        }

        public void GetQ()
        {
            try
            {
                Connection.Con.Open();
                dt = new DataTable("Queue");
                string query = "select qno from queue where DAY(sched) = DAY(getdate()) order by id DESC;";
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection.Con);
                var ds = new DataSet();
                dt.Clear();
                sda.Fill(dt);

                //Datatable to objects fname, lname, mi, age, gender, contno, email, application, qno, sched, status, timestamp

                foreach (DataRow row in dt.Rows)
                {
                    currentQ = Convert.ToInt32(row["qno"]);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //if (currentQ == -1)
                //{
                //    noQToday.BringToFront();
                //    noQToday.Visible = true;
                //}
                //else
                //{
                //    noQToday.SendToBack();
                //    noQToday.Visible = false;
                //}
                Connection.Con.Close();
            }
        }

        public void Populate()
        {
            try
            {
                Connection.Con.Open();
                dt = new DataTable("Queue");
                string query = "select * from queue where DAY(sched) = DAY(getdate()) and qno='" + currentQ + "' order by id ASC;";
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection.Con);
                var ds = new DataSet();
                dt.Clear(); 
                sda.Fill(dt);

                //Datatable to objects fname, lname, mi, age, gender, contno, email, application, qno, sched, status, timestamp
                if (dt.Rows.Count > 0)
                {
                    panel1.Visible = true;
                    timer1.Stop();
                    noQToday.Visible = false;
                    foreach (DataRow row in dt.Rows)
                    {

                        id = Convert.ToInt32(row["id"]);
                        lbName.Text = row["fname"].ToString() + " " + row["mi"].ToString() + " " + row["lname"].ToString();
                        lbAge.Text = row["age"].ToString();
                        lbSex.Text = row["gender"].ToString();
                        lbStats.Text = row["status"].ToString();
                        lbApp.Text = row["application"].ToString();
                        lbQNo.Text = row["qno"].ToString();
                        lbSched.Text = row["sched"].ToString();
                    }
                }
                else
                {
                    panel1.Visible = false;
                    noQToday.Visible = true;
                    timer1.Start();
                }
                    
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Con.Close();    
                                 
                //if(lbStats.Text == "Status")
                //{
                //    panel1.Visible = false;
                //    noQToday.Visible = true;
                //    timer1.Start();
                //}
                //else
                //{
                //    panel1.Visible = true;
                //    timer1.Stop();
                //    noQToday.Visible = false;
                //}
            }

        }

        public void Done()
        {
            try
            {
                Connection.Con.Open();
                string query = "update queue set status='" + done + "' where id=" + id + ";";
                cmd = new SqlCommand(query, Connection.Con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Successfully Updated!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.Con.Close();

            }



        }
        public void Cancel()
        {

            try
            {
                Connection.Con.Open();
                string query = "update queue set status='" + cancel + "' where id=" + id + ";";
                cmd = new SqlCommand(query, Connection.Con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Successfully Updated!");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.Con.Close();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string stats = lbStats.Text;
            
            if (stats == "pending" || stats == "Status")
            {
                MessageBox.Show("Cannot proceed! the current queue still pending please mark it as done or cancel.");                
            }
            else
            {
                try
                {
                    Connection.Con.Open();
                    cmd = new SqlCommand("insert into logs(name,status,timestamp) values ('" + lbName.Text + "','" + lbStats.Text + "',GETDATE());", Connection.Con);
                    cmd.ExecuteNonQuery();
                    Connection.Con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    try
                    {
                        Connection.Con.Open();
                        string query = "delete from queue where id=" + id + ";";
                        cmd = new SqlCommand(query, Connection.Con);
                        cmd.ExecuteNonQuery();
                        currentQ++;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Deleted Successfully!");
                        Connection.Con.Close();
                        Populate();

                        
                    }
                }
                
            }
        }
        // DONE BTN
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Done();
            Populate();
        }
        // CANCEL BTN
        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to mark this queue as Cancelled?", "QMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Cancel();
                Populate();
            }
            else
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x <= -845)
            {
                x = 1010;
            }
            lbNoQ2Day.Location = new Point(x -= 7, 24);
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
