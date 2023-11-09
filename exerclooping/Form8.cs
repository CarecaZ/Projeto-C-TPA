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
    public partial class frmoito : Form
    {
        public frmoito()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtf.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f, I;

            for(I = 10; I<=100; I = I + 10)
            {
                c = Convert.ToDouble(txtc.Text);
                f = c * 1.8 + 32;
                f = f + I;
                txtf.Text = String.Concat(txtf.Text + "\r\n" + f.ToString());
            }
             
            }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }
    }

        
}
