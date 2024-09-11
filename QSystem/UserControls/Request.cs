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

namespace QSystem.UserControls
{
    public partial class Request : UserControl
    {
        public static int appID = 0;        
        SqlCommand cmd;
        SqlDataReader dr;


        public static int id =0;
        public static string requirement = "";
        public static string appName = "";
        public Request()
        {
            InitializeComponent();
            PopulateCombo();           
            numLimit.Visible = false;
            btnSave.Visible = false;
            //cbApp.SelectedIndex = 0;
            Load += Request_Load;
            GetLimit();
            GetTodayLogs();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            GetAppID(cbApp.SelectedItem.ToString());            
            EditBTNGridView();
            DeleteBTNGridView();                     
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(numLimit.Visible == false && btnSave.Visible == false)
            {

                btnEdit.Text = "Cancel";
                btnEdit.IconChar = FontAwesome.Sharp.IconChar.Times;
                btnEdit.BackColor = Color.PaleVioletRed;

                numLimit.Visible = true;
                btnSave.Visible = true;

            }
            else
            {
                btnEdit.Text = "Update Limit";
                btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnEdit.BackColor = Color.Khaki;

                numLimit.Visible = false;
                btnSave.Visible = false;
            }


        }

        //Count all from today logs and put in the request label
        public void GetTodayLogs()
        {
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select COUNT(id) as LogsCount from logs where DAY(timestamp) = DAY(GETDATE()) and status ='pending';", Connection.Con);
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


        public void GetLimit()
        {
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select limit from limit;", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbLimit.Text = dr.GetInt32(0).ToString();
                }
                dr.Close();
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(numLimit.Value == 0 )
            {
                MessageBox.Show("Please input the Queue Limit per day");
            }
            else
            {
                try
                {
                    Connection.Con.Open();
                    cmd = new SqlCommand("update limit  set limit ="+ numLimit.Value+ ";", Connection.Con);
                    cmd.ExecuteNonQuery();                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Updated", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Con.Close();
                    GetLimit();


                    btnEdit.Text = "Update Limit";
                    btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
                    btnEdit.BackColor = Color.Khaki;
                    numLimit.Visible = false;
                    btnSave.Visible = false;

                }
            }
        }
        // get app id using selecteditem
        public void GetAppID(string app_name)
        {
            try
            {
                Connection.Con.Open();
                cmd = new SqlCommand("select * from application where name= '"+app_name+"';", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    appID = dr.GetInt32(0);                   
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Con.Close();
                PopulateGridView();
            }           
        }

        public void PopulateCombo()
        {
            try
            {
                Connection.Con.Close();
                Connection.Con.Open();
                cmd = new SqlCommand("select * from application order by id ASC", Connection.Con);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                cbApp.Items.Clear();
                while (dr.Read())
                {
                 //   appID = dr.GetInt32(0);
                    cbApp.Items.Add(dr.GetString(1));
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Con.Close();
                cbApp.SelectedIndex = 0;
            }

        }


        public void PopulateGridView()
        {
            try
            {
                string query = "select * from requirements where app_id="+appID+" order by app_id desc";
                SqlDataAdapter sda = new SqlDataAdapter(query, Connection.Con);

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


        }
       
        private void cbApp_SelectionChangeCommitted(object sender, EventArgs e)
        {
           GetAppID(cbApp.SelectedItem.ToString());
            
        }

        private void DeleteBTNGridView()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();           
            img.Image = QSystem.Properties.Resources.delete;
            dataGridView1.Columns.Add(img);
            img.Width = 50;
            img.HeaderText = "Delete";
            img.Name = "delete";
        }
        private void EditBTNGridView()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = QSystem.Properties.Resources.edit;
            dataGridView1.Columns.Add(img);
            img.Width = 50;
            img.HeaderText = "Edit";
            img.Name = "edit";
        }


        // Add requirement on selectitem in combo box application
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Requirements require = new Requirements();
            require.ShowDialog();
            PopulateGridView();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 0)
            {
                id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                appName = cbApp.SelectedItem.ToString();
                requirement = dataGridView1.CurrentRow.Cells["requirements"].Value.ToString();

                EditRequirement edit = new EditRequirement();
                edit.ShowDialog();
                PopulateGridView();

            }
            else if (e.ColumnIndex == 1)
            {
                id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                DialogResult res = MessageBox.Show("Are you sure you want to delete this requirement, from "+cbApp.SelectedItem.ToString()+" ?","QMS",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    try
                    {
                        Connection.Con.Open();
                        cmd = new SqlCommand("delete from requirements where id =" + id + ";", Connection.Con);
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "QMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        MessageBox.Show("Deleted Successfully", "QMS", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                        Connection.Con.Close();

                        PopulateGridView();
                    }
                }
                else
                {

                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Dialogs.Applications app = new Dialogs.Applications();
            app.ShowDialog();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateCombo();
        }
    }
}
