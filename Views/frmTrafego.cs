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
    public partial class frmTrafego : Form
    {
        private int id;
        public frmTrafego(int id)
        {
            InitializeComponent();
            this.id = id;
            this.populaCombos();

            if (id > 0)
            {
                this.Edit(id);
            }
        }

        private void populaCombos()
        {
            Veiculo obj = new Veiculo();

            DataSet ds = obj.Combo();

            cmbVeiculo.DataSource = ds.Tables[0];
            cmbVeiculo.DisplayMember = "nome";
            cmbVeiculo.ValueMember = "id";
            cmbVeiculo.SelectedIndex = 0;

            Fornecedor forn = new Fornecedor();

            ds = forn.Combo();

            cmbFornecedor.DataSource = ds.Tables[0];
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;


            Auxiliar aux = new Auxiliar();

            ds = aux.Combo(4);

            cmbMotivo.DataSource = ds.Tables[0];
            cmbMotivo.DisplayMember = "nome";
            cmbMotivo.ValueMember = "id";
            cmbMotivo.SelectedIndex = 0;

        }

        private void Edit(int id)
        {
            Trafego ct = new Trafego();

            DataRow dr = ct.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbVeiculo.SelectedValue = dr["veiculo"].ToString();
            cmbFornecedor.SelectedValue = dr["fornecedor"].ToString();
            cmbMotivo.SelectedValue = dr["motivo"].ToString();

            txtData.Text = dr["data"].ToString();
            txtPartida.Text = dr["partida"].ToString();
            txtKm_partida.Text = dr["km_partida"].ToString();
            txtChegada.Text = dr["chegada"].ToString();
            txtKm_chegada.Text = dr["km_chegada"].ToString();

            txtValor.Text = dr["valor"].ToString();
            txtKm.Text = dr["km"].ToString();
            txtLitros.Text = dr["litros"].ToString();         
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Trafego ct = new Trafego();
            int result = 0;

            if (id == 0)
            {
                result = ct.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                    this.Limpa();
                }
            }
            else
            {
                result = ct.Edit(this);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                    this.Dispose();
                }
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
                //for combobox
                ComboBox cb = ctrl as ComboBox;
                if (cb != null)
                {
                    cb.ResetText();
                    cb.Text = null;
                }
                //for rich textbox
                RichTextBox rtxtbox = ctrl as RichTextBox;
                if (rtxtbox != null)
                {
                    rtxtbox.Clear();
                }
                //for radio button
                if (ctrl is RadioButton)
                {
                    RadioButton rb = ctrl as RadioButton;
                    if (rb.Checked == true)
                    {
                        rb.Checked = false;
                    }
                }
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            String x = "";
            for (int i = 0; i <= txt.Text.Length - 1; i++)
            {
                if ((txt.Text[i] >= '0' &&
                    txt.Text[i] <= '9') ||
                    txt.Text[i] == ',')
                {
                    x += txt.Text[i];
                }
            }
            txt.Text = x;
            txt.SelectAll();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (sender as TextBox);
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.Text = Convert.ToDouble(txt.Text).ToString("F");
        }
    }
}
