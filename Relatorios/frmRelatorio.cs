using ERP_Transporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 1 - Lista Alunos
 * 2 - Lista Escolas
 * 3 - Abastecimento
 * 4 - Manutencao
 * 5 - Rendimento por Rota
 * 
 * */

namespace ERP_Transporte.Relatorios
{
    public partial class frmRelatorio : Form
    {
        DataTable dt = new DataTable();
        int tipo;
        string reportPath = "";
        public frmRelatorio(int tp)
        {
            InitializeComponent();
            this.tipo = tp;
            this.MontaStruct();
        }

        private void populaCombos()
        {
            foreach (Control ctrl in this.Controls)
            {
                ComboBox cb = ctrl as ComboBox;
                if (cb != null)
                {
                    cb.Enabled = false;
                }
                RichTextBox rtxtbox = ctrl as RichTextBox;
                if (rtxtbox != null)
                {
                    rtxtbox.Enabled = false;
                }
            }

            int[] arrEscola = { 1 };
            int[] arrRota = { 5,6 };
            int[] arrVeiculo = { 3,4 };
            int[] arrFornecedor = { 3,4 };
            int[] arrPeriodo = { 3,4,5,6 };

            cmbEscola.Enabled = arrEscola.Contains(this.tipo);
            cmbRota.Enabled = arrRota.Contains(this.tipo);
            cmbVeiculo.Enabled = arrVeiculo.Contains(this.tipo);
            cmbFornecedor.Enabled = arrFornecedor.Contains(this.tipo);
            txtInicio.Enabled = arrPeriodo.Contains(this.tipo);
            txtFinal.Enabled = arrPeriodo.Contains(this.tipo);

            if (cmbEscola.Enabled)
            {
                Escola obj = new Escola();

                DataTable dt = obj.Combo();

                cmbEscola.DataSource = dt;
                cmbEscola.DisplayMember = "nome";
                cmbEscola.ValueMember = "id";
                cmbEscola.SelectedIndex = 0;
            }

            if (cmbRota.Enabled)
            {
                Rota obj = new Rota();

                DataTable dt = obj.Combo();

                cmbRota.DataSource = dt;
                cmbRota.DisplayMember = "nome";
                cmbRota.ValueMember = "id";
                cmbRota.SelectedIndex = 0;
            }

            if (cmbVeiculo.Enabled)
            {
                Veiculo obj = new Veiculo();

                DataTable dt = obj.Combo();

                cmbVeiculo.DataSource = dt;
                cmbVeiculo.DisplayMember = "nome";
                cmbVeiculo.ValueMember = "id";
                cmbVeiculo.SelectedIndex = 0;
            }

            if (cmbFornecedor.Enabled)
            {
                Fornecedor obj = new Fornecedor();

                DataTable dt = obj.Combo();

                cmbFornecedor.DataSource = dt;
                cmbFornecedor.DisplayMember = "nome";
                cmbFornecedor.ValueMember = "id";
                cmbFornecedor.SelectedIndex = 0;
            }
        }

        private void MontaStruct()
        {
            this.populaCombos();
            switch (this.tipo)
            {
                case 1:
                    reportPath = @"Relatorios\rptListaAlunos.rdlc";
                    break;
                case 2:
                    reportPath = @"Relatorios\rptListaEscola.rdlc";
                    break;
                case 3:
                    reportPath = @"Relatorios\rptAbastecimento.rdlc";
                    break;
                case 4:
                    reportPath = @"Relatorios\rptManutencao.rdlc";
                    break;
                case 5:
                    reportPath = @"Relatorios\rptReceitaRota.rdlc";
                    break;
                case 6:
                    reportPath = @"Relatorios\rptPrevRecurso.rdlc";
                    break;
            }
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            string exeFolder = Path.GetDirectoryName(Application.ExecutablePath);

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Left = 0;
            this.Top = 0;
            // Path.Combine(exeFolder, @"Relatorios\rptListaEscola.rdlc");
            // this.reportViewer1.LocalReport.ReportPath = @"C:\Users\usuario\Documents\vsProjects\ERP Transporte\Relatorios\rptListaEscola.rdlc";

        }

        private string getDados()
        {
            string filt = " WHERE 1";
            string fant = "  ";
            if (cmbEscola.SelectedValue != null)
            {
                if ( cmbEscola.SelectedValue.ToString() != "0") 
                {
                    filt += " AND p.id_escola=" + cmbEscola.SelectedValue.ToString();
                    fant += "Escola: " + cmbEscola.GetItemText(cmbEscola.SelectedItem) + ", "; //cmbEscola.SelectedText + ", ";
                }
            }
            
            if (cmbRota.SelectedValue != null)
            {
                if (cmbRota.SelectedValue.ToString() != "0")
                {
                    filt += " AND p.id_rota=" + cmbRota.SelectedValue.ToString();
                    fant += "Trajeto: " + cmbRota.GetItemText(cmbRota.SelectedItem) + ", "; //cmbEscola.SelectedText + ", ";
                }
            }

            if (cmbVeiculo.SelectedValue != null)
            {
                if(cmbVeiculo.SelectedValue.ToString() != "0")
                {
                    filt += " AND p.id_veiculo=" + cmbVeiculo.SelectedValue.ToString();
                    fant += "Veículo: " + cmbVeiculo.GetItemText(cmbVeiculo.SelectedItem) + ", "; //cmbEscola.SelectedText + ", ";
                }
            }

            if (cmbFornecedor.SelectedValue != null)
            {
                if (cmbFornecedor.SelectedValue.ToString() != "0")
                {
                    filt += " AND p.id_fornecedor=" + cmbFornecedor.SelectedValue.ToString();
                    fant += "Fornecedor: " + cmbFornecedor.GetItemText(cmbFornecedor.SelectedItem) + ", "; //cmbEscola.SelectedText + ", ";
                }
            }

            
            if (valorReal(txtInicio) != "")
            {
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtInicio.Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                filt += " AND p.data >='" + data + "'";
                fant += "Data: " + txtInicio.Text + ", "; //cmbEscola.SelectedText + ", ";
            }

            if (valorReal(txtFinal) != "")
            {
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtFinal.Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                filt += " AND p.data <='" + data + "'";
                fant += "Data: " + txtFinal.Text + ", "; //cmbEscola.SelectedText + ", ";
            }

            switch (this.tipo)
            {
                case 1:
                    ListaAluno rel = new ListaAluno();

                    this.dt = rel.getDados(filt);
                    break;
                case 2:
                    ListaEscolas rel2 = new ListaEscolas();

                    this.dt = rel2.getDados(filt);
                    break;
                case 3:
                    ListaAbastecimento rel3 = new ListaAbastecimento();

                    this.dt = rel3.getDados(filt);
                    break;
                case 4:
                    ManutencaoMaster rel4 = new ManutencaoMaster();

                    this.dt = rel4.getDados(filt);
                    break;
                case 5:
                    RendimentoRota rel5 = new RendimentoRota();

                    this.dt = rel5.getDados(filt);
                    break;
                case 6:
                    PrevisaoRecurso rel6 = new PrevisaoRecurso();

                    this.dt = rel6.getDados(filt);
                    break;
            }

            return fant.Substring(0, fant.Length - 2);
        }

        private string valorReal(MaskedTextBox input)
        {
            input.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
            string valor = input.Text; //texto não formatado
            input.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            return valor;
        }

        private void btRelat_Click(object sender, EventArgs e)
        {
            string fant = this.getDados();

            this.reportViewer1.LocalReport.ReportPath = reportPath;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            if (fant != "")
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Filtro", "Filtros: " + fant));
            }
            
            this.reportViewer1.RefreshReport();
        }
    }
}
