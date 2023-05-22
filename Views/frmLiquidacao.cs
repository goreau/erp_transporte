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
    public partial class frmLiquidacao : Form
    {
        private DataTable dados;

        public frmLiquidacao()
        {
            InitializeComponent();
            this.loadDados();
        }

        private void loadDados()
        {
            Despesa desp = new Despesa();
            this.dados = desp.getAbertos();
            
            dgAbertos.DataSource = this.dados;
           
           
            DataGridViewButtonColumn dgvButton = new DataGridViewButtonColumn();
            dgvButton.FlatStyle = FlatStyle.Popup;
            dgvButton.HeaderText = "Button";
            dgvButton.Name = "Button";
            dgvButton.UseColumnTextForButtonValue = true;
            dgvButton.DefaultCellStyle.BackColor = Color.Honeydew;
            dgvButton.DefaultCellStyle.ForeColor = Color.DarkBlue;

            dgvButton.Text = "Pagar";
            dgAbertos.Columns.Add(dgvButton);

            dgAbertos.Columns[0].Visible = false;
            dgAbertos.AllowUserToAddRows = false;
        }

        private void dgAbertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                int id = int.Parse(dgAbertos.Rows[e.RowIndex].Cells[1].Value.ToString());
                MessageBox.Show("sel " + id);

                Despesa desp = new Despesa();
                
                
                DataRow dr = desp.GetWithDetail(id);

                lblFornecedor.Text = dr["fornecedor"].ToString();
                lblCategoria.Text = dr["categoria"].ToString();
                lblDescricao.Text = dr["descricao"].ToString();
                lblVencimento.Text = dr["vencimento"].ToString().Substring(0, 10);
                lblValor.Text = dr["valor"].ToString();
                lblParcela.Text = dr["parcela"].ToString();

                txtValor.Text = dr["valor"].ToString();
                txtIdMaster.Text = id.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Liquidacao ct = new Liquidacao();
            

            int result = ct.Add(this);
            if (result == 0)
            {
                MessageBox.Show("Não foi possível salvar o registro! Tente novamente.");
            }
            else
            {
                MessageBox.Show("Registro inserido!");
                this.Limpa();
                this.loadDados();
            } 
        }

        private void Limpa()
        {
            foreach (Control ctrl in this.Controls)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }           
            }

            lblFornecedor.Text = "";
            lblCategoria.Text = "";
            lblDescricao.Text = "";
            lblVencimento.Text = "";
            lblValor.Text = "";
            lblParcela.Text = "";

            txtValor.Text = "";
            txtIdMaster.Text = "0";
        }
    }
}
