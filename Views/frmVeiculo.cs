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
    public partial class frmVeiculo : Form
    {
        private int id;
        public frmVeiculo(int id)
        {
            InitializeComponent();
            this.id = id;

            if (id > 0)
            {
                this.Edit(id);
            }
        }

        private void Edit(int id)
        {
            Veiculo obj = new Veiculo();

            DataRow dr = obj.Get(id);
            
            txtId.Text = dr["id"].ToString();

            txtPlaca.Text = dr["placa"].ToString();
            txtModelo.Text = dr["modelo"].ToString();
            txtAno.Text = dr["ano"].ToString();
            txtRenavam.Text = dr["renavam"].ToString();
            txtCapacidade.Text = dr["capacidade"].ToString();


            txtCombustivel.Text = dr["combustivel"].ToString();

            if (dr["combustivel"].ToString() == "1")
            {
                rbAlcool.Checked = true;
            }
            else if (dr["combustivel"].ToString() == "2")
            {
                rbGasolina.Checked = true;
            }
            else if (dr["combustivel"].ToString() == "3")
            {
                rbDiesel.Checked = true;
            }
            else
            {
                rbFlex.Checked = true;
            }

            txtValor.Text = dr["valor"].ToString();
            txtEntrada.Text = dr["entrada"].ToString();

            txtOleo.Text = dr["oleo"].ToString();
            txtFiltros.Text = dr["filtros"].ToString();
            txtLicenciamento.Text = dr["licenciamento"].ToString();
            
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Veiculo obj = new Veiculo();
            int result = 0;

            if (id == 0)
            {
                result = obj.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                    this.Limpa();
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

        private void rbAlcool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtCombustivel.Text = li.Tag as string;
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
            if (txt.Text != "")
            {
                txt.Text = Convert.ToDouble(txt.Text).ToString("F");
            }
            
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            validateModelo();
        }

        private bool validateModelo()
        {
            bool bStatus = true;
            if (txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "Favor informar o modelo do veículo");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtModelo, "");
            return bStatus;
        }

        private void txtPlaca_Validating(object sender, CancelEventArgs e)
        {
            validatePlaca();
        }

        private bool validatePlaca()
        {
            bool bStatus = true;
            if (txtPlaca.Text == "")
            {
                errorProvider1.SetError(txtPlaca, "Favor informar a placa do veículo");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtPlaca, "");
            return bStatus;
        }

        private void txtAno_Validating(object sender, CancelEventArgs e)
        {
            validaAno();
        }

        private bool validaAno()
        {
            bool bStatus = true;
            if (txtAno.Text == "")
            {
                errorProvider1.SetError(txtAno, "Favor informar o ano");
                bStatus = false;
            }
            else
            {
                int val;
                bool ok = int.TryParse(txtAno.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtAno, "");
                }
                else
                {
                    errorProvider1.SetError(txtAno, "Favor informar um ano válido");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtRenavam_Validating(object sender, CancelEventArgs e)
        {

        }

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            validateCombustivel();
        }

        private bool validateCombustivel()
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
                errorProvider1.SetError(groupBox4, "Favor informar o tipo de combustível.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(groupBox4, "");
            }

            return bStatus;
        }

        private void txtCapacidade_Validating(object sender, CancelEventArgs e)
        {
            validaCapacidade();
        }

        private bool validaCapacidade()
        {
            bool bStatus = true;
            if (txtCapacidade.Text == "")
            {
                errorProvider1.SetError(txtCapacidade, "Favor informar a capacidade do veículo");
                bStatus = false;
            }
            else
            {
                int val;
                bool ok = int.TryParse(txtCapacidade.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtCapacidade, "");
                }
                else
                {
                    errorProvider1.SetError(txtCapacidade, "Favor informar um número válido");
                    bStatus = false;
                }
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
                errorProvider1.SetError(txtValor, "Favor informar o valor do veículo.");
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

        private void txtEntrada_Validating(object sender, CancelEventArgs e)
        {
            validateEntrada();
        }

        private bool validateEntrada()
        {
            bool bStatus = true;
            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(txtEntrada.Text, out dt);
            if (success)
            {
                errorProvider1.SetError(txtEntrada, "");
            }
            else
            {
                errorProvider1.SetError(txtEntrada, "Informe uma data de entrada válida");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtOleo_Validating(object sender, CancelEventArgs e)
        {
            validaOleo();
        }

        private bool validaOleo()
        {
            bool bStatus = true;
            if (txtOleo.Text == "")
            {
                errorProvider1.SetError(txtOleo, "Favor informar a quilometragem da troca de óleo");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtOleo.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtOleo, "");
                }
                else
                {
                    errorProvider1.SetError(txtOleo, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtLicenciamento_Validating(object sender, CancelEventArgs e)
        {
            validateLicenciamento();
        }

        private bool validateLicenciamento()
        {
            bool bStatus = true;
            txtLicenciamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtLicenciamento.Text == "")
            {
                errorProvider1.SetError(txtLicenciamento, "");
            }
            else
            {
                txtLicenciamento.TextMaskFormat = MaskFormat.IncludeLiterals;
                
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtLicenciamento.Text, out dt);
                if (success)
                {
                    errorProvider1.SetError(txtLicenciamento, "");
                }
                else
                {
                    errorProvider1.SetError(txtLicenciamento, "Informe uma data prevista para o licenciamento");
                    bStatus = false;
                }

            }
            return bStatus;
        }

        private void txtFiltros_Validating(object sender, CancelEventArgs e)
        {
            validaFiltro();
        }

        private bool validaFiltro()
        {
            bool bStatus = true;
            if (txtFiltros.Text == "")
            {
                errorProvider1.SetError(txtFiltros, "Favor informar a quilometragem da troca de óleo");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtFiltros.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtFiltros, "");
                }
                else
                {
                    errorProvider1.SetError(txtFiltros, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }
    }
}
