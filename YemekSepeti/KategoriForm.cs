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
    public partial class KategoriForm : Form
    {

        SqlConnect slCon= new SqlConnect();
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_kategori.DataSource = table;
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Kategori VALUES("+ TextBox1_id.Text + ",'" + TextBox2_name.Text + "','" + TextBox3_desc.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully","Add Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                slCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button2_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1_id.Text == "" || TextBox2_name.Text == "" || TextBox3_desc.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string updateQuerry = "UPDATE Kategori SET KatIsım='" + TextBox2_name.Text + "', KatAcık='" + TextBox3_desc.Text + "' WHERE KatId=" + TextBox1_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuerry, slCon.GetCon());
                    slCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void clear()
        {
            TextBox1_id.Clear();
            TextBox2_name.Clear();
            TextBox3_desc.Clear();
        }

        private void button3_delete_Click(object sender, EventArgs e)
        {

            try
            {
                string deleteQuery = "DELETE FROM Kategori WHERE KatId ="+TextBox1_id.Text+"";
                SqlCommand command = new SqlCommand(deleteQuery, slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully","Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slCon.CloseCon();
                getTable();
                clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_kategori_Click(object sender, EventArgs e)
        {
            TextBox1_id.Text = dataGridView_kategori.SelectedRows[0].Cells[0].Value.ToString();
            TextBox2_name.Text = dataGridView_kategori.SelectedRows[0].Cells[1].Value.ToString();
            TextBox3_desc.Text = dataGridView_kategori.SelectedRows[0].Cells[2].Value.ToString();
        }
    
        private void label_logout_Click(object sender, EventArgs e)
        {
            GirişForm login = new GirişForm();
            login.Show();
            this.Hide();
        }

        private void button6_product_Click(object sender, EventArgs e)
        {
            ÜrünlerForm product = new ÜrünlerForm();
            product.Show();
            this.Hide();
        }

        private void label1_logout_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void label1_logout_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Goldenrod;
        }

        private void label1_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_exit_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void label1_exit_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Goldenrod;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
