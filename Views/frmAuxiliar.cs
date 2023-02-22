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
    public partial class frmAuxiliar : Form
    {
        private int id, tp, qt;
        private Auxiliar aux = new Auxiliar();
        public frmAuxiliar()
        {
            InitializeComponent();
            rbRamo.Checked = true;
            this.tp = 1;
            loadDados();

        }

        private void loadDados()
        {
            DataTable dd = aux.Consulta(tp);
            dgDados.DataSource = dd;
            this.qt = dd.Rows.Count;
            dgDados.Columns[0].Visible = false;
        }


        private void btSalva_Click_1(object sender, EventArgs e)
        {          
            int result = 0;

            if (id == 0)
            {
                result = aux.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                }
            }
            else
            {
                result = aux.Edit(this, id);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                }
            }
            loadDados();
            Limpar();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgDados.SelectedRows.Count  > 0)
            {
                int idx = dgDados.SelectedRows[0].Index;

                this.id = Convert.ToInt32(dgDados.Rows[idx].Cells[0].Value.ToString());

                DataRow dr = aux.Get(id);

                this.id = Convert.ToInt32(dr["id"].ToString());

                txtNome.Text = dr["nome"].ToString();
            } 
            else
            {
                MessageBox.Show("Selecione uma linha para edição.");
            }
            

        }

        private void Limpar()
        {
            txtNome.Text = "";
            id=0;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
    
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgDados.SelectedRows.Count > 0)
            {
                string message = "Confirma a exclusão desse registro? Essa ação não poderá ser desfeita.";
                string caption = "Atenção";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons);


                if (result == DialogResult.Yes)
                {
                    int idx = dgDados.SelectedRows[0].Index;

                    this.id = Convert.ToInt32(dgDados.Rows[idx].Cells[0].Value.ToString());

                    aux.Delete(id);

                    loadDados();
                    Limpar();

                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para exclusão.");
            }
        }

        private void dgDados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rbRamo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtTipo.Text = li.Tag as string;

            this.tp =  Convert.ToInt16(li.Tag.ToString());

            loadDados();
        }
    }
}
