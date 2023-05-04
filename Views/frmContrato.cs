using ERP_Transporte.Auxiliares;
using ERP_Transporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Transporte.Views
{
    public partial class frmContrato : Form
    {
        int id = 0;
        public frmContrato(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();

            DataRow dr_emp = emp.Get(4);

            Contrato contr = new Contrato();

            DataRow dr_contr = contr.ContratoData(id);

            int aluno = int.Parse(dr_contr["id_aluno"].ToString());

            Estudante est = new Estudante();

            DataRow dr_est = est.Contrato(aluno);


            decimal day = decimal.Parse(dr_contr["dia"].ToString());
            decimal valor = decimal.Parse(dr_contr["valor"].ToString());
            Conversor conv = new Conversor();
            string ext = Conversor.Escrever_Valor_Extenso(day);

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dia_pgto", day.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dia_pgto_ext", ext));

            string resp = "";
            string telresp = "";
            string[] parent;
            string quali = "";

            
            resp = dr_est["NomeResp"].ToString();
            telresp = dr_est["TelResp"].ToString();
            parent = new string[3] { " ", " ", "X" };
            quali = dr_est["Qualificacao"].ToString();
            

            string[] period;

            if (dr_est["Periodo"].ToString() == "1")
            {
                period = new string[3] { "X", " ", " " };
            }
            else if (dr_est["Periodo"].ToString() == "2")
            {
                period = new string[3] { " ", "X", " " };
            }
            else
            {
                period = new string[3] { " ", " ", "X" };
            }

            string[] trajeto;
            string outroTraj = "";

            if (dr_contr["trajeto"].ToString() == "1")
            {
                trajeto = new string[4] { "X", " ", " ", " " };
            }
            else if (dr_contr["trajeto"].ToString() == "2")
            {
                trajeto = new string[4] { " ", "X", " ", " " };
            }
            else if (dr_contr["trajeto"].ToString() == "3")
            {
                trajeto = new string[4] { " ", " ", "X", " " };
            } 
            else
            {
                trajeto = new string[4] { " ", " ", " ", "X" };
                outroTraj = dr_contr["trajeto_esp"].ToString();
            }
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nome", resp));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rg", dr_contr["RG"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rg_uf", dr_contr["Emissor"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nacionalidade", dr_contr["Nacionalidade"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("estado_civil", dr_contr["EstadoCivil"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cpf", dr_contr["CPF"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("profissao", dr_contr["Profissao"].ToString()));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data_nasc", dr_contr["Nascimento"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("naturalidade", dr_contr["Naturalidade"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("celular", telresp));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("endereco", dr_contr["Endereco"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pai", parent[0]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mae", parent[1]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("resp", parent[2]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("quali", quali));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("estudante", dr_est["nome"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("est_nasc", dr_est["Nascimento"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ra", dr_est["RA"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("escola", dr_est["Escola"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("esc_tel", dr_est["TelEscola"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("esc_endereco", dr_est["EndEscola"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("valor", valor.ToString()));
            ext = Conversor.EscreverExtenso(valor);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("valor_ext", ext));

            //Empresa
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_nome", dr_emp["nome"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_cnpj", dr_emp["cnpj"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_cidade", dr_emp["cidade"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_endereco", dr_emp["endereco"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_telefone1", dr_emp["telefone1"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emp_telefone2", dr_emp["telefone2"].ToString()));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("per_manha", period[0]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("per_tarde", period[1]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("per_int", period[2]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("entrada", dr_est["entrada"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("saida", dr_est["saida"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("serie", dr_est["serie"].ToString()));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("traj_i", trajeto[0]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("traj_v", trajeto[1]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("traj_iv", trajeto[2]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("traj_o", trajeto[3]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("traj_sp", outroTraj));

            this.reportViewer1.RefreshReport();
        }
    }
}
