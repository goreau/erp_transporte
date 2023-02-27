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
    public partial class frmEstudante : Form
    {
        private int id;
        public frmEstudante(int id)
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
            cmbEst_civil.Items.Insert(0, "-- Selecione --");
            cmbEst_civil.Items.Insert(1, "Solteiro");
            cmbEst_civil.Items.Insert(2, "Casado");
            cmbEst_civil.Items.Insert(3, "União Estável");
            cmbEst_civil.Items.Insert(4, "Viúvo");
            cmbEst_civil.SelectedIndex = 0;

            Escola obj = new Escola();

            DataTable dt = obj.Combo();

            cmbEscola.DataSource = dt;
            cmbEscola.DisplayMember = "nome";
            cmbEscola.ValueMember = "id";
            cmbEscola.SelectedIndex = 0;

            Rota rt = new Rota();

            dt = rt.Combo();

            cmbId_rota.DataSource = dt;
            cmbId_rota.DisplayMember = "nome";
            cmbId_rota.ValueMember = "id";
            cmbId_rota.SelectedIndex = 0;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            int result = 0;

            if (id == 0)
            {
                result = estudante.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                    this.Limpa();
                }
            }
            else
            {
                result = estudante.Edit(this);

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

        private void rbManha_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtPeriodo.Text = li.Tag as string;
        }

        private void Edit(int id)
        {
            Estudante estudante = new Estudante();

            DataRow dr = estudante.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            txtLogradouro.Text = dr["logradouro"].ToString();
            txtNumero.Text = dr["numero"].ToString();
            txtBairro.Text = dr["bairro"].ToString();
            
            cmbEscola.SelectedValue = dr["id_escola"].ToString();

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

            txtRa_rg.Text = dr["ra_rg"].ToString();
            txtDt_nascimento.Text = dr["dt_nascimento"].ToString();

            txtPai.Text = dr["pai"].ToString();
            txtTel_pai.Text = dr["tel_pai"].ToString();
            txtMae.Text = dr["mae"].ToString();
            txtTel_mae.Text = dr["tel_mae"].ToString();

            txtResponsavel.Text = dr["responsavel"].ToString();
            txtTel_resp.Text = dr["tel_resp"].ToString();
            txtResp_qualif.Text = dr["resp_qualif"].ToString();

            txtNaturalidade.Text = dr["naturalidade"].ToString();
            txtNacionalidade.Text = dr["nacionalidade"].ToString();
            txtRg.Text = dr["rg"].ToString();
            txtCpf.Text = dr["cpf"].ToString();

            cmbId_rota.SelectedValue = Convert.ToInt16(dr["id_rota"].ToString());
            cmbEst_civil.SelectedIndex = Convert.ToInt16(dr["est_civil"].ToString());

            txtObs.Text = dr["obs"].ToString();
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

        private void cmbEscola_Validating(object sender, CancelEventArgs e)
        {
            validateEscola();
        }

        private bool validateEscola()
        {

            bool bStatus = true;

            if (cmbEscola.SelectedValue != null && cmbEscola.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbEscola, "");
            }
            else
            {
                errorProvider1.SetError(cmbEscola, "É necessário informar a escola.");
                bStatus = false;
            }

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
                errorProvider1.SetError(groupBox4, "Favor informar o período de estudo.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(groupBox4, "");
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

        private void cmbId_rota_Validating(object sender, CancelEventArgs e)
        {
            validateRota();
        }

        private bool validateRota()
        {

            bool bStatus = true;

            if (cmbId_rota.SelectedValue != null && cmbId_rota.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbId_rota, "");
            }
            else
            {
                errorProvider1.SetError(cmbId_rota, "É necessário informar o trajeto do aluno.");
                bStatus = false;
            }

            return bStatus;
        } 
        #endregion
    }
}
