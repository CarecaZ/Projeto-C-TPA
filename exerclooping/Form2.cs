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
    public partial class frmdois : Form
    {
        public frmdois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num, result, I;
            num = Convert.ToDouble(txttabu.Text);
            I = 1;
            while (I <= 10)
            {
                result = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num.ToString() + " X " + I.ToString() + " = " + result.ToString());
                I++;
            }
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttabu.Clear();
            txtresult.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void txttabu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
