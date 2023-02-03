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
    public partial class GirişForm : Form
    {
        SqlConnect slCon = new SqlConnect();
        public GirişForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label6_EXIT.ForeColor = Color.Red;

        }

        private void label6_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label6_EXIT.ForeColor = Color.Goldenrod;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Goldenrod;
        }

        private void label6_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TextBox1_username.Clear();
            TextBox2_password.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1_username.Text == "" || TextBox2_password.Text == "")
            {
                MessageBox.Show("Please Enter your Username and Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_ROL.SelectedIndex > -1)

                {
                    if (comboBox_ROL.SelectedItem.ToString() == "KULLANICI")
                    {
                        if (TextBox1_username.Text == "Kullanıcı" && TextBox2_password.Text == "Kullanıcı123")
                        {
                            ÜrünlerForm product = new ÜrünlerForm();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Kullanıcı please enter your password and username", "Miss Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        }
    }
