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
    public partial class frmConsulta : Form
    {
        private DataTable dados;
        private int idxTabela;
        private int idSelecionado;
        private DataTable filtered;
        

        public frmConsulta(DataTable dd, int tab)
        {
            InitializeComponent();
            this.loadDados(dd);
            this.idxTabela = tab;
        }

        private void loadDados(DataTable dd)
        {
            this.dados = dd;
            this.filtered = new DataTable();

            dgConsulta.DataSource = this.dados;
            
            if (dados.Rows.Count > 0)
                dgConsulta.Columns[0].Visible = false;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width - 20;
            if (dgConsulta.Rows.Count > 20)
            {
                this.Height = Screen.PrimaryScreen.Bounds.Height;
            }
            else
            {
                int tam = dgConsulta.Rows.Count * 40;
                this.Height = tam > 300 ? tam : 300;

            }
            
            this.Left = 0;
            this.Top = 0;
        }


        private void dgConsulta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dados.Rows.Count > 0)
            {
                idSelecionado = Convert.ToInt32(dgConsulta.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Form fEdit;
            switch (idxTabela)
            {
                case 1:
                    fEdit = new frmEstudante(idSelecionado);
                    break;
                case 2:
                    fEdit = new frmVeiculo(idSelecionado);
                    break;
                case 3:
                    fEdit = new frmRota(idSelecionado);
                    break;
                case 4:
                    fEdit = new frmFornecedor(idSelecionado);
                    break;
                case 5:
                    fEdit = new frmTrafego(idSelecionado);
                    break;
                case 6:
                    fEdit = new frmPagamento(idSelecionado);
                    break;
                case 7:
                    fEdit = new frmRecebimento(idSelecionado);
                    break;
                case 8:
                    fEdit = new frmColaborador(idSelecionado);
                    break;
                case 9:
                    fEdit = new frmDias(idSelecionado);
                    break;
                case 10:
                    fEdit = new frmManutencao(idSelecionado);
                    break;
                case 11:
                    fEdit = new frmAbastecimento(idSelecionado);
                    break;
                case 12:
                    fEdit = new frmDespesa(idSelecionado);
                    break;
                case 13:
                    fEdit = new frmLiquidacaoEd(idSelecionado);
                    break;
                default:
                    fEdit = new frmEscola(idSelecionado);
                    break;
            }

            fEdit.ShowDialog();
            DataTable dd = null;

            switch (idxTabela)
            {
                case 0:
                    Escola esc = new Escola();
                    dd = esc.Consulta();
                    break;
                case 1:
                    Estudante est = new Estudante();
                    dd = est.Consulta();
                    break;
                case 2:
                    Veiculo vei = new Veiculo();
                    dd = vei.Consulta();
                    break;
                case 3:
                    Rota rt = new Rota();
                    dd = rt.Consulta();
                    break;
                case 4:
                    Fornecedor frn = new Fornecedor();
                    dd = frn.Consulta();
                    break;
                case 5:
                    Trafego tfg = new Trafego();
                    dd = tfg.Consulta();
                    break;
                case 6:
                    Pagamento pg = new Pagamento();
                    dd = pg.Consulta();
                    break;
                case 7:
                    Recebimento rec = new Recebimento();
                    dd = rec.Consulta();
                    break;
                case 8:
                    Colaborador col = new Colaborador();
                    dd = col.Consulta();
                    break;
                case 9:
                    Dias dias = new Dias();
                    dd = dias.Consulta();
                    break;
                case 10:
                    Manutencao man = new Manutencao();
                    dd = man.Consulta();
                    break;
                case 11:
                    Abastecimento ab = new Abastecimento();
                    dd = ab.Consulta();
                    break;
                case 12:
                    Despesa dp = new Despesa();
                    dd = dp.Consulta();
                    break;
                case 13:
                    Liquidacao lq = new Liquidacao();
                    dd = lq.Consulta();
                    break;
            }

            this.loadDados(dd);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string message = "Confirma a exclusão desse registro? Essa ação não poderá ser desfeita.";
            string caption = "Atenção";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons);
            

            if (result == DialogResult.Yes)
            {
                DataTable dd = null;
                switch (idxTabela)
                {
                    case 1:
                        Estudante est = new Estudante();
                        dd = est.Delete(idSelecionado);
                        break;
                    default:
                        Escola esc = new Escola();
                        dd = esc.Delete(idSelecionado);
                        break;
                }
                this.loadDados(dd);
            }

            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           /* var height = 40;
            foreach (DataGridViewRow dr in dgConsulta.Rows)
            {
                height += dr.Height;
            }

            dgConsulta.Height = height;*/
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var value = dgConsulta.SelectedCells[0].Value.ToString();
            var col = dgConsulta.SelectedCells[0].ColumnIndex;

            Type tp = this.dados.Columns[col].DataType;
            string name = this.dados.Columns[col].ColumnName;

            if (this.filtered.Rows.Count > 0)
            {
                if (tp == typeof(Int32))
                {
                    filtered = this.filtered.AsEnumerable()
                      .Where(row => row.Field<int>(name) == int.Parse(value))
                      .CopyToDataTable();

                }
                else if (tp == typeof(String))
                {
                    filtered = this.filtered.AsEnumerable()
                      .Where(row => row.Field<String>(name) == value)
                      .CopyToDataTable();
                }
                else if (tp == typeof(DateTime))
                {
                    filtered = this.filtered.AsEnumerable()
                      .Where(row => row.Field<DateTime>(name) == DateTime.Parse(value))
                      .CopyToDataTable();
                }
                else
                {
                    filtered = this.filtered.AsEnumerable()
                      .Where(row => row.Field<decimal>(name) == Decimal.Parse(value))
                      .CopyToDataTable();
                }
            } 
            else
            {
                if (tp == typeof(Int32))
                {
                    filtered = this.dados.AsEnumerable()
                      .Where(row => row.Field<int>(name) == int.Parse(value))
                      .CopyToDataTable();

                }
                else if (tp == typeof(String))
                {
                    filtered = this.dados.AsEnumerable()
                      .Where(row => row.Field<String>(name) == value)
                      .CopyToDataTable();
                }
                else if (tp == typeof(DateTime))
                {
                    filtered = this.dados.AsEnumerable()
                      .Where(row => row.Field<DateTime>(name) == DateTime.Parse(value))
                      .CopyToDataTable();
                }
                else
                {
                    filtered = this.dados.AsEnumerable()
                      .Where(row => row.Field<decimal>(name) == Decimal.Parse(value))
                      .CopyToDataTable();
                }
            }


            this.dgConsulta.DataSource = filtered;

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.dgConsulta.DataSource = dados;
            this.filtered.Clear();
        }
    }
}
