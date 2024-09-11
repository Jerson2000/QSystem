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
    public partial class Applications : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;

        public static int id;
        public static string name;
        public Applications()
        {
            InitializeComponent();
            Populate();
            EditBTNGridView();
            DeleteBTNGridView();
        }

        private void Populate()
        {
            try
            {               
                sda = new SqlDataAdapter("select * from application",Connection.Con);
                var ds = new DataSet();
                ds.Clear();
                sda.Fill(ds);
                sda.Dispose();
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(SqlException ex)
            {
               MessageBox.Show(ex.Message,"QMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("data fetched to gridview.");
            }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 0)
            {
                id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();

                EditApp edit = new EditApp();
                edit.ShowDialog();
                Populate();

            }
            else if (e.ColumnIndex == 1)
            {
                id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                DialogResult res = MessageBox.Show("Are you sure you want to delete this application?", "QMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        Connection.Con.Open();
                        cmd = new SqlCommand("delete from application where id =" + id + ";", Connection.Con);
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

                        Populate();
                    }
                }
                else
                {

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AddApp add = new AddApp();
            add.ShowDialog();
            Populate();

        }
    }
}
