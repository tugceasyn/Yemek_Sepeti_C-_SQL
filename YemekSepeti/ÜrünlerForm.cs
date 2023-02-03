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

namespace YemekSepeti
{
    public partial class ÜrünlerForm : Form
    {
        SqlConnect slCon = new SqlConnect();
        public ÜrünlerForm()
        {
            InitializeComponent();
        }

        private void button6_category_Click(object sender, EventArgs e)
        {
            KategoriForm kategori = new KategoriForm();
            kategori.Show();
            this.Hide();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_kategori.DataSource = table;
            comboBox_kategori.ValueMember = "KatIsım";
            comboBox1_kategori.DataSource = table;
            comboBox1_kategori.ValueMember = "KatIsım";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Yemekler";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_yemekler.DataSource = table;
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox3_price.Clear();
            TextBox4_quantity.Clear();
            comboBox_kategori.SelectedIndex = 0;
            comboBox1_kategori.SelectedIndex = 0;
        }


        private void button1_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Yemekler VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox3_price.Text + "','" + TextBox4_quantity.Text + "', '"+comboBox_kategori.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_update_Click(object sender, EventArgs e)
        {
         
     
                try
                {

                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox4_quantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string updatequery = "UPDATE Yemekler SET YemekIsim='" + TextBox_name.Text + "',YemekFiyat='" + TextBox3_price.Text + "',YemekMiktar='" + TextBox4_quantity.Text + "',YemekKategori='" + comboBox_kategori.Text + "'WHERE YemekId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updatequery, slCon.GetCon());
                    slCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    slCon.CloseCon();
                    getTable();
                    clear();
                }
            }
           
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void dataGridView_yemekler_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_yemekler.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text =dataGridView_yemekler.SelectedRows[0].Cells[1].Value.ToString();
            TextBox3_price.Text = dataGridView_yemekler.SelectedRows[0].Cells[2].Value.ToString();
            TextBox4_quantity.Text = dataGridView_yemekler.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_kategori.SelectedValue= dataGridView_yemekler.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Yemekler WHERE YemekId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, slCon.GetCon());
                    slCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    slCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox1_kategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Yemekler WHERE YemekKategori='"+comboBox1_kategori+"'";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_yemekler.DataSource = table;
        }

        private void label6_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_EXIT_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void label6_EXIT_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Goldenrod;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Goldenrod;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            GirişForm login = new GirişForm();
            login.Show();
            this.Hide();
        }

        private void button5_seller_Click(object sender, EventArgs e)
        {
            SatıcıForm seller = new SatıcıForm();
            seller.Show();
            this.Hide();
        }

        private void button7_selling_Click(object sender, EventArgs e)
        {
            SatılanlarForm selling = new SatılanlarForm();
            selling.Show();
            this.Hide();
        }
    }
}
