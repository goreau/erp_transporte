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
    public partial class frmLiquidacaoEd : Form
    {
        private int id;
        public frmLiquidacaoEd(int id)
        {
            InitializeComponent();
            this.id = id;
           
            this.Edit();
        }

        private void Edit()
        {
            Liquidacao obj = new Liquidacao();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            lblFornecedor.Text = dr["fornecedor"].ToString();
            lblCategoria.Text = dr["categoria"].ToString();
            lblDescricao.Text = dr["descricao"].ToString();
            lblVencimento.Text = dr["vencimento"].ToString().Substring(0, 10);
            lblValor.Text = dr["valor"].ToString();
            lblParcela.Text = dr["parcela"].ToString();

            txtValor.Text = dr["valor_pago"].ToString();
            txtData.Text = dr["data_pago"].ToString();
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Liquidacao ct = new Liquidacao();


            int result = ct.Edit(this);
            if (result == 0)
            {
                MessageBox.Show("Não foi possível alterar o registro! Tente novamente.");
            }
            else
            {
                MessageBox.Show("Registro atualizado!");
                this.Dispose();
            }
        }
    }
}
