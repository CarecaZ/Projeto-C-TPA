using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerclooping
{
    public partial class frmquatro : Form
    {
        public frmquatro()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTabu.Clear();
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, I, R;

           
            for(I = 1; I<=10; I++)
            {
                num1 = Convert.ToDouble(txtTabu.Text);
                R = num1 * I;
                txtResultado.Text = String.Concat(txtResultado.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
            }
        }
    }
}
