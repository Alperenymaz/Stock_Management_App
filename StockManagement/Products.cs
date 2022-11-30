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
    public partial class Products : Form
    {
        bool control;
        int menu_width;
        public Products()
        {
            InitializeComponent();
            control = false;
            menu_width = menu_panel.Width;
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alpic\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void func()
        {
            try
            {
                db.Open();
                string query = "select * from productTable";
                SqlDataAdapter da = new SqlDataAdapter(query, db);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductDataGT.DataSource = ds.Tables[0];
                db.Close();

            }
            catch
            {

                throw;
            }
        }
        void filterCat()
        {
            try
            {
                db.Open();
                string query = "select*from productTAble where Kategori='" + comboBox1.SelectedValue.ToString() + "'";
                SqlDataAdapter ds = new SqlDataAdapter(query, db);
                SqlCommandBuilder builder=new SqlCommandBuilder(ds);
                var da = new DataSet();
                ds.Fill(da);
                ProductDataGT.DataSource = da.Tables[0];
                db.Close();
            }
            catch
            {

            }
        }
        void category()
        {
            string query = "select * from catTable";
            SqlCommand cmd = new SqlCommand(query, db);
            SqlDataReader rdr;
            try
            {
                db.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "CategoryName";
                comboBox1.DataSource = dt;
                db.Close();
            }
            catch
            {

                throw;
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            category();
            func();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (control)
            {
                menu_panel.Width = menu_panel.Width + 10;
                if (menu_panel.Width >= menu_width)
                {
                    timer1.Stop();
                    control = false;
                    this.Refresh();
                }
            }
            else
            {
                menu_panel.Width = menu_panel.Width - 10;
                if (menu_panel.Width <= 0)
                {
                    timer1.Stop();
                    control = true;
                    this.Refresh();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("insert into productTable values('" + sırano_textbox.Text + "','" + comboBox1.SelectedValue.ToString() + "','" + makara_textbox.Text + "','" + unicom_textbox.Text + "','" + marka_textbox.Text + "','" + core_textbox.Text + "','" + fiber_textbox.Text + "','" + kod_textbox.Text + "','" + adet_textbox.Text + "','" + stok_textbox.Text + "','" + kalan_textbox.Text + "')", db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                db.Close();
                func();
            }
            catch
            {

            }
            //////////////////////////////////////////
            /*using (SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alpic\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {

                    using (var cmd = new SqlCommand("INSERT INTO productTable ( SıraNo,MakaraNo,UnicomKodu,Marka,Core,Fiber,Kod,Metre,Kategori)VALUES(@SıraNo,MakaraNo,@UnicomKodu,@Marka,@Core,@Fiber,@Kod,@Metre,@Kategori)"))
                    {

                        cmd.Connection = db;
                        cmd.Parameters.Add("@SıraNo", sırano_textbox.Text);
                        cmd.Parameters.Add("@MakaraNo", makara_textbox.Text);
                        cmd.Parameters.Add("@UnicomKodu", unicom_textbox.Text);
                        cmd.Parameters.Add("@Marka", marka_textbox.Text);
                        cmd.Parameters.Add("@Core", core_textbox.Text);
                        cmd.Parameters.Add("@Fiber", fiber_textbox.Text);
                        cmd.Parameters.Add("@Kod", kod_textbox.Text);
                        cmd.Parameters.Add("@Metre", metre_textbox.Text);
                        cmd.Parameters.Add("@Kategori", comboBox1.GetItemText(comboBox1.SelectedItem));

                        db.Open()
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                        }
                        else
                        {
                            MessageBox.Show("Record failed");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error during insert: " + e.Message);
                }
            }*/
        }
            /////////////////////////////////////////////////
        private void ProductDataGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sırano_textbox.Text = ProductDataGT.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.SelectedValue = ProductDataGT.SelectedRows[0].Cells[1].Value.ToString();
            makara_textbox.Text = ProductDataGT.SelectedRows[0].Cells[2].Value.ToString();
            unicom_textbox.Text = ProductDataGT.SelectedRows[0].Cells[3].Value.ToString();
            marka_textbox.Text = ProductDataGT.SelectedRows[0].Cells[4].Value.ToString();
            core_textbox.Text = ProductDataGT.SelectedRows[0].Cells[5].Value.ToString();
            fiber_textbox.Text = ProductDataGT.SelectedRows[0].Cells[6].Value.ToString();
            kod_textbox.Text = ProductDataGT.SelectedRows[0].Cells[7].Value.ToString();
            adet_textbox.Text = ProductDataGT.SelectedRows[0].Cells[8].Value.ToString();
            stok_textbox.Text= ProductDataGT.SelectedRows[0].Cells[9].Value.ToString(); 
            kalan_textbox.Text= ProductDataGT.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (sırano_textbox.Text == "")
            {
                MessageBox.Show("Enter the Sıra No");
            }
            else
            {
                db.Open();
                string query1 = "delete from productTable where SıraNo='" + sırano_textbox.Text + "';";
                SqlCommand cmd = new SqlCommand(query1, db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prod is Deleted");
                db.Close();
                func();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterCat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            func();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
