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

            DataTable dt = obj.Combo();

            cmbVeiculo.DataSource = dt;
            cmbVeiculo.DisplayMember = "nome";
            cmbVeiculo.ValueMember = "id";
            cmbVeiculo.SelectedIndex = 0;

            Fornecedor forn = new Fornecedor();

            dt = forn.Combo();

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;


            Auxiliar aux = new Auxiliar();

            dt = aux.Combo(4);

            cmbMotivo.DataSource = dt;
            cmbMotivo.DisplayMember = "nome";
            cmbMotivo.ValueMember = "id";
            cmbMotivo.SelectedIndex = 0;

        }

        private void Edit(int id)
        {
            Trafego ct = new Trafego();

            DataRow dr = ct.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbVeiculo.SelectedValue = dr["id_veiculo"].ToString();
            cmbFornecedor.SelectedValue = dr["id_fornecedor"].ToString();
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

        #region Validate
        private void txtKm_partida_Validating(object sender, CancelEventArgs e)
        {
            validaKmPartida();
        }

        private bool validaKmPartida()
        {
            bool bStatus = true;
            if (txtKm_partida.Text == "")
            {
                errorProvider1.SetError(txtKm_partida, "Favor informar a quilometragem de partida");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtKm_partida.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtKm_partida, "");
                }
                else
                {
                    errorProvider1.SetError(txtKm_partida, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtKm_chegada_Validating(object sender, CancelEventArgs e)
        {
            validaKmChegada();
        }

        private bool validaKmChegada()
        {
            bool bStatus = true;
            if (txtKm_chegada.Text == "")
            {
                errorProvider1.SetError(txtKm_chegada, "Favor informar a quilometragem de chegada");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtKm_chegada.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtKm_chegada, "");
                }
                else
                {
                    errorProvider1.SetError(txtKm_chegada, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void cmbVeiculo_Validating(object sender, CancelEventArgs e)
        {
            validateVeiculo();
        }

        private bool validateVeiculo()
        {
            bool bStatus = true;

            if (cmbVeiculo.SelectedValue != null && cmbVeiculo.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbVeiculo, "");
            }
            else
            {
                errorProvider1.SetError(cmbVeiculo, "Favor informar o veículo.");
                bStatus = false;
            }

            return bStatus;
        }

        private void cmbMotivo_Validating(object sender, CancelEventArgs e)
        {
            validateMotivo();
        }

        private bool validateMotivo()
        {
            bool bStatus = true;

            if (cmbMotivo.SelectedValue != null && cmbMotivo.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbMotivo, "");
            }
            else
            {
                errorProvider1.SetError(cmbMotivo, "Favor informar o motivo do deslocamento.");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            validateData();
        }

        private bool validateData()
        {
            bool bStatus = true;
  
            DateTime dt;
            bool success = DateTime.TryParse(txtData.Text, out dt);
            if (success)
            {
                if (dt > DateTime.Now)
                {
                    errorProvider1.SetError(txtData, "A data não pode ser superior à data atual.");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(txtData, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtData, "Informe uma data válida");
                bStatus = false;
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
                errorProvider1.SetError(cmbFornecedor, "É necessário informar o fornecedor.");
                bStatus = false;
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
                errorProvider1.SetError(txtValor, "Favor informar o valor do serviço.");
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

        private void txtKm_Validating(object sender, CancelEventArgs e)
        {
            validaKm();
        }

        private bool validaKm()
        {
            bool bStatus = true;
            if (txtKm.Text == "")
            {
                errorProvider1.SetError(txtKm, "Favor informar a quilometragem");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtKm.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtKm, "");
                }
                else
                {
                    errorProvider1.SetError(txtKm, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtLitros_Validating(object sender, CancelEventArgs e)
        {
            validaLitros();
        }

        private bool validaLitros()
        {
            bool bStatus = true;
            if (txtLitros.Text == "")
            {
                errorProvider1.SetError(txtLitros, "Favor informar a quantidade abastecida");
                bStatus = false;
            }
            else
            {
                double lt;
                bool ok = Double.TryParse(txtLitros.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtLitros, "");
                }
                else
                {
                    errorProvider1.SetError(txtLitros, "Favor informar uma quantidade válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtPartida_Validating(object sender, CancelEventArgs e)
        {
            validaPartida();
        }

        private bool validaPartida()
        {
            bool bStatus = true;

            txtPartida.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtPartida.Text == "")
            {
                errorProvider1.SetError(txtPartida, "");
            }
            else
            {
                DateTime val;
                txtPartida.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool ok = DateTime.TryParse(txtPartida.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtPartida, "");
                }
                else
                {
                    errorProvider1.SetError(txtPartida, "Favor informar uma hora válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtChegada_Validating(object sender, CancelEventArgs e)
        {
            validaChegada();
        }

        private bool validaChegada()
        {
            bool bStatus = true;

            txtChegada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtChegada.Text == "")
            {
                errorProvider1.SetError(txtChegada, "");
            }
            else
            {
                DateTime val;
                txtChegada.TextMaskFormat = MaskFormat.IncludeLiterals;

                bool ok = DateTime.TryParse(txtChegada.Text, out val);
                if (ok)
                {
                    errorProvider1.SetError(txtChegada, "");
                }
                else
                {
                    errorProvider1.SetError(txtChegada, "Favor informar uma hora válida");
                    bStatus = false;
                }
            }

            return bStatus;
        } 
        #endregion
    }
}
