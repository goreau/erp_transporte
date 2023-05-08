using ERP_Transporte.Auxiliares;
using ERP_Transporte.Entidades;
using ERP_Transporte.Relatorios;
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
    public partial class frmRecibo : Form
    {
        int id;
        public frmRecibo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {
            DadosEmpresa emp = new DadosEmpresa();

            DataTable dt = emp.getDados();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            Recebimento obj = new Recebimento();

            DataRow dr = obj.Recibo(this.id);

            decimal valor = decimal.Parse(dr["valor"].ToString());

         //   Conversor conv = new Conversor();

            string extenso = Conversor.EscreverExtenso(valor);
            string mes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt16(dr["mes"].ToString()));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pagador", dr["pagador"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("valor", dr["valor"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cpf", dr["cpf"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", dr["data"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("extenso", extenso));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ano", dr["ano"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mes", mes));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
