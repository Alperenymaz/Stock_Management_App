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
    public partial class InventoryManagementSystem : Form
    {
        public InventoryManagementSystem()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alpic\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void showPass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_checkBox.Checked == true)
            {
                password_textbox.isPassword = false;
            }
            else
                password_textbox.isPassword = true;
        }

        private void userName_textbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_textbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) from user_table where " +
            "Username='"+userName_textbox.Text+"'and Password='"+password_textbox.Text+"'",db);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or Username Try Again!");
            }

            db.Close();
        }
    }
}
