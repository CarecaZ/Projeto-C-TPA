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
    public partial class frmsete : Form
    {
        public frmsete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtf.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f, I;

            c = Convert.ToDouble(txtc.Text);
            I = 10;
            do
            {
                f = c * 1.8 + 32;
                f = f + I;
                txtf.Text = String.Concat(txtf.Text + "\r\n" + f.ToString());
                I = I + 10;
            }
            while (I <= 100);
            
        }
    }
}
