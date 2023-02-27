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
    public partial class frmColaborador : Form
    {
        private int id; 
        public frmColaborador(int id)
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
            Auxiliar obj = new Auxiliar();
            DataTable dt = obj.Combo(2);

            cmbFuncao.DataSource = dt;
            cmbFuncao.DisplayMember = "nome";
            cmbFuncao.ValueMember = "id";
            cmbFuncao.SelectedIndex = 0;

            dt = obj.Combo(3);

            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = 0;
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

        private void Edit(int id)
        {
            Colaborador colaborador = new Colaborador();

            DataRow dr = colaborador.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            cmbFuncao.SelectedValue = dr["funcao"].ToString();
            cmbCategoria.SelectedValue = dr["categoria"].ToString();
            txtDt_admissao.Text = dr["dt_admissao"].ToString();
            txtRg.Text = dr["rg"].ToString();
            txtDt_expedicao.Text = dr["dt_expedicao"].ToString();
            txtCpf.Text = dr["cpf"].ToString();
            txtCnh.Text = dr["cnh"].ToString();
            txtCnh_categoria.Text = dr["cnh_categoria"].ToString();
            txtDt_validade.Text = dr["dt_validade"].ToString();
            txtDt_nascimento.Text = dr["dt_nascimento"].ToString();           

            txtPai.Text = dr["pai"].ToString();
            txtMae.Text = dr["mae"].ToString();
            txtRemuneracao.Text = dr["remuneracao"].ToString();
        }

        private void btSalva_Click_1(object sender, EventArgs e)
        {
            Colaborador obj = new Colaborador();
            int result = 0;

            if (id == 0)
            {
                result = obj.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                }
            }
            else
            {
                result = obj.Edit(this);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                    this.Dispose();
                }
            }
        }

        private void btSalva_Leave(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            try
            {
                txt.Text = Convert.ToDouble(txt.Text).ToString("F");
            }
            catch (Exception)
            {
                txt.Text = "";
            }
            
        }

        private void txtRemuneracao_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (sender as TextBox);
                txt.Text = Convert.ToDouble(txt.Text).ToString("F");
            }
            catch (Exception)
            {

            }
        }

        private void txtRemuneracao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRemuneracao_Enter(object sender, EventArgs e)
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

        private void cmbFuncao_Validating(object sender, CancelEventArgs e)
        {
            validateFuncao();
        }

        private bool validateFuncao()
        {

            bool bStatus = true;

            if (cmbFuncao.SelectedValue != null && cmbFuncao.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbFuncao, "");
            }
            else
            {
                errorProvider1.SetError(cmbFuncao, "É necessário informar a função exercida pelo colaborador.");
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
                errorProvider1.SetError(cmbCategoria, "É necessário informar onde foi feito o abastecimento.");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtDt_admissao_Validating(object sender, CancelEventArgs e)
        {
            validateAdmissao();
        }

        private bool validateAdmissao()
        {
            bool bStatus = true;
            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(txtDt_admissao.Text, out dt);
            if (success)
            {
                if (dt > DateTime.Now)
                {
                    errorProvider1.SetError(txtDt_admissao, "A data não pode ser superior à data atual.");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(txtDt_admissao, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtDt_admissao, "Informe uma data válida");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtDt_expedicao_Validating(object sender, CancelEventArgs e)
        {
            validateExpedicao();
        }

        private bool validateExpedicao()
        {
            bool bStatus = true;

            txtDt_expedicao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtDt_expedicao.Text == "")
            {
                errorProvider1.SetError(txtDt_expedicao, "");
            }
            else
            {
                txtDt_nascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtDt_expedicao.Text, out dt);
                if (success)
                {
                    errorProvider1.SetError(txtDt_expedicao, "");
                }
                else
                {
                    errorProvider1.SetError(txtDt_expedicao, "Informe uma data válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtDt_validade_Validating(object sender, CancelEventArgs e)
        {
            validateValidade();
        }

        private bool validateValidade()
        {
            bool bStatus = true;

            txtDt_validade.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtDt_validade.Text == "")
            {
                errorProvider1.SetError(txtDt_validade, "");
            }
            else
            {
                txtDt_nascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
                string data = "";
                DateTime dt;
                txtDt_validade.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool success = DateTime.TryParse(txtDt_validade.Text, out dt);
                if (success)
                {
                    errorProvider1.SetError(txtDt_validade, "");
                }
                else
                {
                    errorProvider1.SetError(txtDt_validade, "Informe uma data válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtDt_nascimento_Validating(object sender, CancelEventArgs e)
        {
            validateNascimento();
        }

        private bool validateNascimento()
        {
            bool bStatus = true;

            txtDt_nascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtDt_nascimento.Text == "")
            {
                errorProvider1.SetError(txtDt_nascimento, "");
            }
            else
            {
                txtDt_nascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtDt_nascimento.Text, out dt);
                if (success)
                {
                    errorProvider1.SetError(txtDt_nascimento, "");
                }
                else
                {
                    errorProvider1.SetError(txtDt_nascimento, "Informe uma data válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtRemuneracao_Validating(object sender, CancelEventArgs e)
        {
            validaRemuneracao();
        }

        private bool validaRemuneracao()
        {
            bool bStatus = true;
            if (txtRemuneracao.Text == "")
            {
                errorProvider1.SetError(txtRemuneracao, "Favor informar o valor da remuneração mensal");
                bStatus = false;
            }
            else
            {
                double lt;
                bool ok = Double.TryParse(txtRemuneracao.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtRemuneracao, "");
                }
                else
                {
                    errorProvider1.SetError(txtRemuneracao, "Favor informar um valor válido");
                    bStatus = false;
                }
            }

            return bStatus;
        } 
        #endregion
    }
}
