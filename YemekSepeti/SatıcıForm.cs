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
    public partial class SatıcıForm : Form
    {
        SqlConnect slCon = new SqlConnect();
        public SatıcıForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Satici";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_satici.DataSource = table;
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Satici VALUES(" + TextBox1_id.Text + ",'" + TextBox2_name.Text + "','" + TextBox3_cesit.Text + "','"+TextBox1_phoneno.Text+"','"+TextBox2_adres.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void clear()
        {
            TextBox1_id.Clear();
            TextBox2_name.Clear();
            TextBox3_cesit.Clear();
            TextBox1_phoneno.Clear();
            TextBox2_adres.Clear();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button2_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1_id.Text == "" || TextBox2_name.Text == "" || TextBox3_cesit.Text == "" || TextBox1_phoneno.Text=="" || TextBox2_adres.Text=="")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string updateQuerry = "UPDATE Satici SET SaticiIsim='" + TextBox2_name.Text + "', SaticiCesit='" + TextBox3_cesit.Text + "', SaticiNo='"+TextBox1_phoneno.Text+"',SaticiPass='"+TextBox2_adres.Text+ "' WHERE SaticiId=" + TextBox1_id.Text +" ";
                    SqlCommand command = new SqlCommand(updateQuerry, slCon.GetCon());
                    slCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Satici Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_satici_Click(object sender, EventArgs e)
        {

            TextBox1_id.Text = dataGridView_satici.SelectedRows[0].Cells[0].Value.ToString();
            TextBox2_name.Text = dataGridView_satici.SelectedRows[0].Cells[1].Value.ToString();
            TextBox3_cesit.Text = dataGridView_satici.SelectedRows[0].Cells[2].Value.ToString();
            TextBox1_phoneno.Text= dataGridView_satici.SelectedRows[0].Cells[3].Value.ToString();
            TextBox2_adres.Text= dataGridView_satici.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Satici WHERE SaticiId =" + TextBox1_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Satici Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slCon.CloseCon();
                getTable();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_logout_MouseEnter(object sender, EventArgs e)
        {
            label2_logout.ForeColor = Color.Red;
        }

        private void label2_logout_MouseLeave(object sender, EventArgs e)
        {
            label2_logout.ForeColor = Color.Goldenrod;
        }

        private void label2_logout_Click(object sender, EventArgs e)
        {
            GirişForm login = new GirişForm();
            login.Show();
            this.Hide();
        }

        private void label3_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_exit_MouseEnter(object sender, EventArgs e)
        {
            label3_exit.ForeColor = Color.Red;
        }

        private void label3_exit_MouseLeave(object sender, EventArgs e)
        {
            label3_exit.ForeColor = Color.Goldenrod;
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ÜrünlerForm product = new ÜrünlerForm();
            product.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SatılanlarForm selling = new SatılanlarForm();
            selling.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            KategoriForm kategori = new KategoriForm();
            kategori.Show();
            this.Hide();
        }
    }
}
