using ERP_Transporte.Entidades;
using ERP_Transporte.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Transporte
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscola form = new frmEscola(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escola obj = new Escola();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 0);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEstudante form = new frmEstudante(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estudante obj = new Estudante();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 1);

            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
