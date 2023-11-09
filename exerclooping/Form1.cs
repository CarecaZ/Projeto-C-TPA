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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdois dois = new frmdois();
            dois.Show();
        }

        private void paraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtres tres = new frmtres();
            tres.Show();
        }

        private void entToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmquatro quatro = new frmquatro();
            quatro.Show();            
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void enquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcinco cinco = new frmcinco();
            cinco.Show();
        }

        private void áreaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeis seis = new frmSeis();
            seis.Show();
        }

        private void paraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsete sete = new frmsete();
            sete.Show();
        }

        private void repitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmoito oito = new frmoito();
            oito.Show();
        }
    }
}
