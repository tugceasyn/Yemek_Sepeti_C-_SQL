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
using DGVPrinterHelper;

namespace YemekSepeti
{
    public partial class SatılanlarForm : Form
    {
        DGVPrinter printer = new DGVPrinter();
        SqlConnect slCon = new SqlConnect();

        public SatılanlarForm()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Kategori";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1_kategori.DataSource = table;
            comboBox1_kategori.ValueMember = "KatIsım";
        }
        private void getTable()
        {
            string selectQuerry = "SELECT  YemekIsim,YemekFiyat FROM Yemekler";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_yemekler.DataSource = table;
        }

        private void getSellTable()
        {
            string selectQuerry = "SELECT  * FROM Fatura";
            SqlCommand command = new SqlCommand(selectQuerry, slCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_satışliste.DataSource = table;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            label_tarih.Text = DateTime.Today.ToShortDateString();
            getSellTable();
        }

        private void dataGridView_yemekler_Click(object sender, EventArgs e)
        {
            TextBox2_name.Text = dataGridView_yemekler.SelectedRows[0].Cells[0].Value.ToString();
            TextBox3_fiyat.Text = dataGridView_yemekler.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Fatura VALUES(" + TextBox_id.Text + ",'" + label1_name.Text + "','" + label_tarih.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, slCon.GetCon());
                slCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slCon.CloseCon();
                getSellTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            // Yazdırmak için DGVPrinter'a ihtiyacımız var. PDF dosyası indirmemizi,oluşturmamızı sağlıyor.
            printer.Title = "Yemek Sepeti Satış Listesi ";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_satışliste);
        }

        private void label2_logout_Click(object sender, EventArgs e)
        {
            GirişForm login = new GirişForm();
            login.Show();
            this.Hide();
        }

        private void label1_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int grandTotal = 0, n = 0;
        private void button_addorder_Click(object sender, EventArgs e)
        {
            if (TextBox2_name.Text == "" || TextBox1_qyt.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int Total = Convert.ToInt32(TextBox3_fiyat.Text) * Convert.ToInt32(TextBox1_qyt.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_satislar);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox2_name.Text;
                addRow.Cells[2].Value = TextBox3_fiyat.Text;
                addRow.Cells[3].Value = TextBox1_qyt.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_satislar.Rows.Add(addRow);
                grandTotal += Total;
            }
        }

    }
}
