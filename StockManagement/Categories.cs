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

namespace StockManagement
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alpic\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void func()
        {
            try
            {
                db.Open();
                string query = "select * from catTable";
                SqlDataAdapter da = new SqlDataAdapter(query, db);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                catDataGT.DataSource = ds.Tables[0];
                db.Close();

            }
            catch
            {

                throw;
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            func();
        }

        private void userDataGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catID_textbox.Text = catDataGT.SelectedRows[0].Cells[0].Value.ToString();
            catName_textbox.Text = catDataGT.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("insert into catTable values("+catID_textbox.Text+",'"+catName_textbox.Text+"')", db);
                cmd.ExecuteNonQuery();
                db.Close();
                func();
            }
            catch
            {

            }
        }

        private void catName_textbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(catID_textbox.Text == "")
            {
                MessageBox.Show("Enter the CategoryID");
            }
            else
            {
                db.Open();
                string query2 = "delete from catTable where CategoryID='" + catID_textbox.Text + "';";
                SqlCommand cmd = new SqlCommand(query2, db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category is Deleted");
                db.Close();
                func();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update catTable set CategoryName='" + catName_textbox.Text + "'where CategoryID='" + catID_textbox.Text + "'", db);
                cmd.ExecuteNonQuery();
                db.Close();
                func();
            }
            catch
            {

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
