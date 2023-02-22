using ERP_Transporte.Auxiliares;
using ERP_Transporte.Entidades;
using ERP_Transporte.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Transporte
{
    public partial class frmMain : Form
    {
        private frmSplash splash;
        private bool done = false;

        public frmMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(HandleFormLoad);
            this.splash = new frmSplash();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();
            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();
            Hardworker worker = new Hardworker();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splash.UpdateProgress(ex.Progress);
            };
            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };
            worker.DoHardWork();
        }

        private void ShowSplashScreen()
        {
            splash.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splash.Close();
            this.splash.Dispose();
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

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVeiculo form = new frmVeiculo(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Veiculo obj = new Veiculo();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 2);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmRota form = new frmRota(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Rota obj = new Rota();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 3);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmFornecedor form = new frmFornecedor(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 4);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarAuxiliaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuxiliar form = new frmAuxiliar();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarContrTráfegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrafego form = new frmTrafego(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trafego obj = new Trafego();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 5);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmPagamento form = new frmPagamento(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamento obj = new Pagamento();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 6);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmRecebimento form = new frmRecebimento(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarRecebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recebimento obj = new Recebimento();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 7);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmColaborador form = new frmColaborador(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Colaborador obj = new Colaborador();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 8);

            form.MdiParent = this;
            form.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre form = new frmSobre();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarDiasLetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDias form = new frmDias(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarDiasLetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dias obj = new Dias();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 9);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmManutencao form = new frmManutencao(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarManutAbastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manutencao obj = new Manutencao();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 10);

            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarAbastecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbastecimento form = new frmAbastecimento(0);
            form.MdiParent = this;
            form.Show();
        }

        private void consultarAbastecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abastecimento obj = new Abastecimento();

            DataTable dt = obj.Consulta();

            frmConsulta form = new frmConsulta(dt, 11);

            form.MdiParent = this;
            form.Show();
        }
    }
}
