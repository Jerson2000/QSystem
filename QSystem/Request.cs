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
using QSystem.Dialogs;
namespace QSystem
{
    public partial class Request : Form
    {
        private int qLimit = 0;
        private int qSize = 0;
        private int incrementDay = 0;
        private int qNo = 0;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string test = "asd";
        public Request()
        {
            Login logn = new Login();
            logn.Show();


            GetLimit();
            GetQList();
            InitializeComponent();
            PopulateCombo();
        }
        public void PopulateCombo()
        {
            try
            {                
                cmd = new SqlCommand("select * from application", Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                cbApp.Items.Clear();
                while (dr.Read())
                {

                    cbApp.Items.Add(dr.GetString(1));
                }
                dr.Close();
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get queue limit per day
        public void GetLimit()
        {

            try
            {                               
                cmd = new SqlCommand("select * from limit", Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();                
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    qLimit = dr.GetInt32(1);
                    incrementDay = dr.GetInt32(2);
                    
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
                Console.WriteLine("GetLimit EXECUTED");
            }

        }


        // Update increDay in table limit
        public void UpDayIncre()
        {
            try
            {
               
                cmd = new SqlCommand("update limit set dayIncre =" + incrementDay, Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();                                
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("update increment day");
            }

        }



        //Count all the qno (queue number) in the specified sched(today)
        public void GetQList()
        {
            GetLimit();
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select Count(qno) as qSize from queue where DAY(sched) = DAY(DATEADD(day,"+incrementDay+",GETDATE()));", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    qSize = dr.GetInt32(0);
                }
                dr.Close();
                Connection.Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // get queue number last value
        public void GetQ()
        {
            try
            {
                // test
                //cmd = new SqlCommand("select qno from queue where DAY(sched) = DATEPART(day, DATEADD(day,0,GETDATE())) order by id DESC;", Connection.Con);

                cmd = new SqlCommand("select qno from queue where DAY(sched) = DAY(DATEADD(day," + incrementDay + ",GETDATE())) and id = IDENT_CURRENT('queue');", Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    qNo = dr.GetInt32(0);
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
                Console.WriteLine("GetQ EXECUTED");
            }
        }
               
        public void IncreQNo()
        {
            
            GetQ();
            if (qSize == qLimit)
            {
                qNo = 1;

                // Incrementing date when the que == to limit it change schedule date
                incrementDay++;
                UpDayIncre();
            }
            else
            {
                if(qNo == 0)
                {
                    qNo = 1;
                }
                else
                {
                    qNo++;
                }
                
            }
            
        }

        public void InsertLogs()
        {
            string name = "";
            string stats = "";
            try
            {
                cmd = new SqlCommand("select (fname +' '+lname+' '+mi) as name,status from queue where id = IDENT_CURRENT('queue');", Connection.Con);
                Connection.Con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = dr.GetString(0);
                    stats = dr.GetString(1);
                    
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
                Connection.Con.Open();
                cmd = new SqlCommand("insert into logs(name,status,timestamp) values ('"+name+"','"+stats+"',GETDATE());", Connection.Con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("insert logs executed");
                Connection.Con.Close();

            }
        }



        // Request BTN
        private void iconButton1_Click(object sender, EventArgs e)
        {
            GetQList();         
            IncreQNo();
            if (tbFName.Text.Equals("") && tbLName.Text.Equals("") && tbEmail.Text.Equals(""))
            {
                MessageBox.Show("Fill in all fields!", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Gender!", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbApp.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Application!", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(numAge.Value == 1 || numContNo.Text == "")
            {
                MessageBox.Show("Please enter Age/Contact Number", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    //string query = "insert into queue (fname,lname,mi,age,gender,contno,email,application,qno,sched,status,timestamp)" +
                    //"values ('jerson','lname','',21,'male',1234,'jerson@email.com','CENOMAR',"+IncreQNo()+",DATEADD(day,"+IncreDateSched(qSize)+",GETDATE()),'pending',CURRENT_TIMESTAMP);";
                    string query = "insert into queue (fname,lname,mi,age,gender,contno,email,application,qno,sched,status,timestamp)" +
                        "values ('" + tbFName.Text + "','" + tbLName.Text + "','" + tbMI.Text + "'," + numAge.Value + ",'" + cbSex.SelectedItem.ToString() + "'," + numContNo.Text + ",'" + tbEmail.Text + "','" + cbApp.SelectedItem.ToString() + "'," + qNo + ",DATEADD(day," + incrementDay + ",GETDATE()),'pending',CURRENT_TIMESTAMP);";
                    cmd = new SqlCommand(query, Connection.Con);
                    Connection.Con.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Request Send", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SchedulePopup pop = new SchedulePopup();                   
                    tbFName.Text = "";
                    tbLName.Text = "";
                    tbMI.Text = "";
                    tbEmail.Text = "";
                    cbSex.SelectedIndex = -1;
                    cbApp.SelectedIndex = -1;                   
                    numContNo.Text = "";


                    InsertLogs(); //Execute First before dialog

                    pop.ShowDialog();
                }

            }
            
        }

        private void Request_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to close this form ?", "Closing Form...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;     
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateCombo();
        }
    }
}

    
