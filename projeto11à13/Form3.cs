using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto11à13
{
    public partial class frmFahrenheit : Form
    {
        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();

            txtCelsius.Focus();
        }

        private void btnEnquanto_Click(object sender, EventArgs e)
        {
            double C, I, F;

            C = Convert.ToDouble(txtCelsius.Text);

            I = 1;

            while(I <= 100)
            {
                F = (C * 1.8) + 32 + (I * 10);
                txtFahrenheit.Text += F + "\r\n";

                I++;
            }
        }

        private void btnRepita_Click(object sender, EventArgs e)
        {
            double C, I, F;

            C = Convert.ToDouble(txtCelsius.Text);

            I = 1;

            do
            {
                F = (C * 1.8) + 32 + (I * 10);
                txtFahrenheit.Text += F + "\r\n";

                I++;
            } while (I <= 100);
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            double C, I, F;

            C = Convert.ToDouble(txtCelsius.Text);

            for (I = 1; I <= 100; I++)
            {
                F = (C * 1.8) + 32 + (I * 10);
                txtFahrenheit.Text += F + "\r\n";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu Menu = new FrmMenu();
            Menu.Show();
        }
    }
}
