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
    public partial class frmCômodos : Form
    {
        public frmCômodos()
        {
            InitializeComponent();
            
        }

        double Areatotal;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double larg, compri, area;

            larg = Convert.ToDouble(txtLargura.Text);
            compri = Convert.ToDouble(txtComprimento.Text);

            area = larg * compri;
            Areatotal += area;
            txtArea.Text = area.ToString();
            

            var result = MessageBox.Show("Deseja continuar calculando?", "pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtArea.Clear();
                txtComprimento.Clear();
                txtLargura.Clear();
                txtNome.Clear();
                txtLargura.Focus();
            }
            else
            {
                lblAreatotal.Visible = true;
                txtAreatotal.Visible = true;
                txtAreatotal.Text = Areatotal.ToString();
                Areatotal = 0;
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtComprimento.Clear();
            txtLargura.Clear();
            txtComprimento.Clear();
            txtAreatotal.Clear();
            txtNome.Clear();

            txtAreatotal.Visible = false;
            lblAreatotal.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu Menu = new FrmMenu();
            Menu.Show();
        }
    }
}
