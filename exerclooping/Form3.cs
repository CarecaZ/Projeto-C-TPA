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
    public partial class frmtres : Form
    {
        public frmtres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmtres_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, I, R;
            num1 = Convert.ToDouble(txtnum2.Text);

            I = 1;
            do
            {
                R = num1 * I;
                txtresultado2.Text = String.Concat(txtresultado2.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
                I++;
            }
            while (I <= 10);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum2.Clear();
            txtresultado2.Clear();
        }
    }
}
