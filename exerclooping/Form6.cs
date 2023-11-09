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
    public partial class frmSeis : Form
    {
        public frmSeis()
        {
            InitializeComponent();
        }
        double areatotal;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double larg, comp, area;

            larg = Convert.ToDouble(txtl.Text);
            comp = Convert.ToDouble(txtc.Text);

            area = larg * comp;
            areatotal += area;
            txtresult.Text = area.ToString();

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtc.Clear();
                txtl.Clear();
                txtresult.Clear();
                txtn.Clear();
            }
            else
            {
                lblAt.Visible = true;
                txtresult.Visible = true;
                txtresult.Text = areatotal.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtl.Clear();
            txtresult.Clear();
            txtn.Clear();
        }
    }
}
