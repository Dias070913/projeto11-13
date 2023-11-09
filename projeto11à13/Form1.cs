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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void exercício11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada Tabuada = new frmTabuada();
            Tabuada.Show();
        }

        private void exercício12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFahrenheit Fahrenheit = new frmFahrenheit();
            Fahrenheit.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCômodos Cômodos = new frmCômodos();
            Cômodos.Show();
        }
    }
}
