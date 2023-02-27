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
    public partial class frmEscola : Form
    {
        private int id;
        public frmEscola(int id)
        {
            InitializeComponent();
            this.id = id;

            if (id > 0)
            {
                this.Edit(id);
            }
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Escola escola = new Escola();
            int result = 0;

            if (id == 0)
            {
                result = escola.Add(this);
                if (result > 0)
                {
                    this.Limpa();
                    MessageBox.Show("Registro inserido!");
                }
            } else
            {
                result = escola.Edit(this);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                    this.Dispose();
                }
            }


        }

        private void rbManha_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtPeriodo.Text = li.Tag as string;
        }

        private void Edit(int id)
        {
            Escola escola = new Escola();

            DataRow dr = escola.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            txtLogradouro.Text = dr["logradouro"].ToString();
            txtNumero.Text = dr["numero"].ToString();
            txtBairro.Text = dr["bairro"].ToString();
            txtLink.Text = dr["link"].ToString();

            txtTelefone1.Text = dr["telefone"].ToString();
            txtTelefone2.Text = dr["telefone2"].ToString();

            txtPeriodo.Text = dr["periodo"].ToString();

            if (dr["periodo"].ToString() == "1")
            {
                rbManha.Checked = true;
            }
            else if (dr["periodo"].ToString() == "2")
            {
                rbTarde.Checked = true;
            }
            else
            {
                rbIntegral.Checked = true;
            }


            txtEntrada.Text = dr["entrada"].ToString();
            txtSaida.Text = dr["saida"].ToString();
            txtEspecial.Text = dr["especial"].ToString();
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

        #region regionValidate
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            validateName();
        }

        private bool validateName()
        {
            bool bStatus = true;
            if (txtNome.Text == "")
            {
                errorProvider1.SetError(txtNome, "Favor informar o nome");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNome, "");
            return bStatus;
        }

        private void txtLogradouro_Validating(object sender, CancelEventArgs e)
        {
            validateLogradouro();
        }

        private bool validateLogradouro()
        {
            bool bStatus = true;
            if (txtLogradouro.Text == "")
            {
                errorProvider1.SetError(txtLogradouro, "Favor informar o logradouro");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtLogradouro, "");
            return bStatus;
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            validateNumero();
        }

        private bool validateNumero()
        {
            bool bStatus = true;
            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Favor informar o número do imóvel");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNumero, "");
            return bStatus;
        }

        private void txtBairro_Validating(object sender, CancelEventArgs e)
        {
            validateBairro();
        }

        private bool validateBairro()
        {
            bool bStatus = true;
            if (txtBairro.Text == "")
            {
                errorProvider1.SetError(txtBairro, "Favor informar o bairro");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtBairro, "");
            return bStatus;
        }

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            validatePeriodo();
        }

        private bool validatePeriodo()
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
                errorProvider1.SetError(groupBox4, "Favor informar a forma de pagamento.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(groupBox4, "");
            }

            return bStatus;
        }

        private void txtEntrada_Validating(object sender, CancelEventArgs e)
        {
            validaEntrada();
        }

        private bool validaEntrada()
        {
            bool bStatus = true;

            txtEntrada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtEntrada.Text == "")
            {
                errorProvider1.SetError(txtEntrada, "");
            }
            else
            {
                DateTime val;
                txtEntrada.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool ok = DateTime.TryParse(txtEntrada.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtEntrada, "");
                }
                else
                {
                    errorProvider1.SetError(txtEntrada, "Favor informar uma hora válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtSaida_Validating(object sender, CancelEventArgs e)
        {
            validaSaida();
        }

        private bool validaSaida()
        {
            bool bStatus = true;

            txtSaida.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtSaida.Text == "")
            {
                errorProvider1.SetError(txtSaida, "");
            }
            else
            {
                DateTime val;
                txtSaida.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool ok = DateTime.TryParse(txtSaida.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtSaida, "");
                }
                else
                {
                    errorProvider1.SetError(txtSaida, "Favor informar uma hora válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtEspecial_Validating(object sender, CancelEventArgs e)
        {
            validaEspecial();
        }

        private bool validaEspecial()
        {
            bool bStatus = true;

            txtEspecial.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtEspecial.Text == "")
            {
                errorProvider1.SetError(txtEspecial, "");
            }
            else
            {
                DateTime val;
                txtEspecial.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool ok = DateTime.TryParse(txtEspecial.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtEspecial, "");
                }
                else
                {
                    errorProvider1.SetError(txtEspecial, "Favor informar uma hora válida");
                    bStatus = false;
                }
            }

            return bStatus;
        } 
        #endregion
    }
}
