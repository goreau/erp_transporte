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
        public frmConsulta(DataTable dd, int tab)
        {
            InitializeComponent();
            this.loadDados(dd);
            this.idxTabela = tab;
        }

        private void loadDados(DataTable dd)
        {
            this.dados = dd;
            dgConsulta.DataSource = this.dados;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            /*DataGridViewButtonColumn btedit = new DataGridViewButtonColumn();
            btedit.Name = "colBtedit";
            btedit.Text = "Editar";
            int idx = dgConsulta.ColumnCount;
            int columnIndex = idx;
            if (dgConsulta.Columns["colBtedit"] == null)
            {
                dgConsulta.Columns.Insert(columnIndex, btedit);
            }*/
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == dgConsulta.Columns["colBtedit"].Index)
            {
                MessageBox.Show("Editar");
            }*/
        }

        private void dgConsulta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Convert.ToInt32(dgConsulta.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Form fEdit;
            switch (idxTabela)
            {
                case 1:
                    fEdit = new frmEstudante(idSelecionado);
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
            var height = 40;
            foreach (DataGridViewRow dr in dgConsulta.Rows)
            {
                height += dr.Height;
            }

            dgConsulta.Height = height;
        }
    }
}
