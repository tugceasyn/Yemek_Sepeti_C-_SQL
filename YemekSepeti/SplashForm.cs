using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSepeti
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int StartPoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 2;
            ProgressBar1.Value = StartPoint;
            if(ProgressBar1.Value==100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
                GirişForm loginForm = new GirişForm();
                this.Hide();
                loginForm.Show();

            }
        }
    }
}
