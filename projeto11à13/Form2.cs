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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnEnquanto_Click(object sender, EventArgs e)
        {
            double I, Num, Tab;

            Num = Convert.ToDouble(txtNum.Text);

            I = 1;

            while (I <= 10)
            {
                Tab = Num * I;
                txtResultado.Text = String.Concat(txtResultado.Text + "\r\n" + Tab.ToString());
                I++;
            }
        }

        private void btnRepita_Click(object sender, EventArgs e)
        {
            double I, Num, Tab;

            Num = Convert.ToDouble(txtNum.Text);

            I = 1;

            do
            {
                Tab = Num * I;
                txtResultado.Text = String.Concat(txtResultado.Text + "\r\n" + Tab.ToString());
                I++;
            } while (I <= 10);
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            double I, Num, Tab;

            Num = Convert.ToDouble(txtNum.Text);

            

            for(I = 1; I<=10; I++)
            {
                Tab = Num * I;
                txtResultado.Text += Tab + "\r\n";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResultado.Clear();

            txtNum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu Menu = new FrmMenu();
            Menu.Show();
        }
    }
}
