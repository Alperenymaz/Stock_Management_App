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
    public partial class Users : Form
    {

        public Users()
        {
            InitializeComponent();

        }
        SqlConnection db =  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alpic\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void func()
        {
            try
            {
                db.Open();
                string query = "select * from user_table";
                SqlDataAdapter da = new SqlDataAdapter(query, db);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userDataGT.DataSource = ds.Tables[0];
                db.Close();
                
            }
            catch
            {

            }
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("insert into user_table values('" + uname_textbox.Text + "','" + upassword_textbox.Text + "')", db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added");
                db.Close();
                func();
            }
            catch
            {

            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            func();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (upassword_textbox.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                db.Open();
                string query1 = "delete from user_table where Password='" + upassword_textbox.Text + "';";
                SqlCommand cmd = new SqlCommand(query1, db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User is Deleted");
                db.Close();
                func();
            }
        }

        private void userDataGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uname_textbox.Text = userDataGT.SelectedRows[0].Cells[0].Value.ToString();
            upassword_textbox.Text = userDataGT.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update user_table set UserName='"+uname_textbox.Text+"',Password'"+upassword_textbox.Text+"'", db);
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
