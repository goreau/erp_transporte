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
    public partial class frmPagamento : Form
    {
        private int id;
        public frmPagamento(int id)
        {
            InitializeComponent();
            this.id = id;
            this.populaCombos();

            if (id > 0)
            {
                this.Edit(id);
            }
        }

        private void Edit(int id)
        {
            Pagamento obj = new Pagamento();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            txtDia_vencimento.Text = dr["dia_vencimento"].ToString();
            txtValor.Text = dr["valor"].ToString();


            txtVinculo.Text = dr["vinculo"].ToString();

            if (dr["vinculo"].ToString() == "1")
            {
                rbAdministrativa.Checked = true;
            }
            else
            {
                rbLinha.Checked = true;
            }


            cmbCategoria.SelectedValue = dr["categoria"].ToString();
            cmbFornecedor.SelectedValue = dr["id_fornecedor"].ToString();
            recorrente.Checked = dr["recorrente"].ToString() == "True";
            txtData.Text = dr["data"].ToString();
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Pagamento ct = new Pagamento();
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

        private void populaCombos()
        {
           
            
            Fornecedor forn = new Fornecedor();
            DataTable dt = forn.Combo();

            dt = forn.Combo();

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;


            Auxiliar aux = new Auxiliar();

            dt = aux.Combo(4);

            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = 0;

        }

        private void rbAdministrativa_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtVinculo.Text = li.Tag as string;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.Text = Convert.ToDouble(txt.Text).ToString("F");
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

        #region regionValidate
        private void txtDia_vencimento_Validating(object sender, CancelEventArgs e)
        {
            validaDia();
        }

        private bool validaDia()
        {
            bool bStatus = true;
            if (txtDia_vencimento.Text == "")
            {
                errorProvider1.SetError(txtDia_vencimento, "Favor informar o dia do pagamento");
                bStatus = false;
            }
            else
            {
                int val;
                bool ok = int.TryParse(txtDia_vencimento.Text, out val);
                if (ok)
                {
                    if (val > 31 || val < 1)
                    {
                        errorProvider1.SetError(txtDia_vencimento, "Favor informar um  dia válido");
                        bStatus = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txtDia_vencimento, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDia_vencimento, "Favor informar um número válido");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void cmbFornecedor_Validating(object sender, CancelEventArgs e)
        {
            validateFornecedor();
        }

        private bool validateFornecedor()
        {

            bool bStatus = true;

            if (cmbFornecedor.SelectedValue != null && cmbFornecedor.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbFornecedor, "");
            }
            else
            {
                errorProvider1.SetError(cmbFornecedor, "É necessário informar o beneficiário do pagamento.");
                bStatus = false;
            }

            return bStatus;
        }

        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            validateCategoria();
        }

        private bool validateCategoria()
        {

            bool bStatus = true;

            if (cmbCategoria.SelectedValue != null && cmbCategoria.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbCategoria, "");
            }
            else
            {
                errorProvider1.SetError(cmbCategoria, "É necessário informar a categoria da despeza.");
                bStatus = false;
            }

            return bStatus;
        }

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            validateVinculo();
        }

        private bool validateVinculo()
        {
            bool bStatus = true;
            int _checked = 0;
            foreach (Control c in groupBox4.Controls)
            {
                if (c is RadioButton)
                {
                    if ((c as RadioButton).Checked == true) { _checked++; }
                }
            }
            if (_checked == 0)
            {
                errorProvider1.SetError(groupBox4, "Favor informar o vínculo do pagamento.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(groupBox4, "");
            }

            return bStatus;
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            validaValor();
        }

        private bool validaValor()
        {
            bool bStatus = true;
            if (txtValor.Text == "")
            {
                errorProvider1.SetError(txtValor, "Favor informar o valor do pagamento.");
                bStatus = false;
            }
            else
            {
                double lt;
                bool ok = Double.TryParse(txtValor.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtValor, "");
                }
                else
                {
                    errorProvider1.SetError(txtValor, "Favor informar um valor válido");
                    bStatus = false;
                }
            }

            return bStatus;
        } 
        #endregion
    }
}
