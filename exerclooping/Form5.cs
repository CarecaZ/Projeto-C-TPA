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
    public partial class frmcinco : Form
    {
        public frmcinco()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtC.Clear();
            txtF.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c, f, I;

            c = Convert.ToDouble(txtC.Text);
            I = 10;
            while (I <= 100)
            {
                f = c * 1.8 + 32;
                f = f + I;
                txtF.Text = String.Concat(txtF.Text + "\r\n" + f.ToString());
                I = I+10;
            }
        }
    }
}
