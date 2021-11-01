using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_AULA1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        double Ent1, Ent2, Res;

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);
            Res = Ent1 / Ent2;
            lblCalculo.Text = Res.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);
            Res = Ent1 * Ent2;
            lblCalculo.Text = Res.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);
            Res = Ent1 - Ent2;
            lblCalculo.Text = Res.ToString();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);
            Res = Ent1 + Ent2;
            lblCalculo.Text = Res.ToString();
        }
    }
}
