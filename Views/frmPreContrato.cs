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
    public partial class frmPreContrato : Form
    {
        DataRow dr_estudante;
        int id_contrato = 0;

        public frmPreContrato()
        {
            InitializeComponent();
            this.populaAluno();
        }

        private void populaAluno()
        {

            Estudante est = new Estudante();

            DataTable dt_estudante = est.Combo();


            cmbAluno.DataSource = dt_estudante;
            cmbAluno.DisplayMember = "nome";
            cmbAluno.ValueMember = "id";
            cmbAluno.SelectedIndex = 0;

            cmbEst_civil.Items.Insert(0, "-- Selecione --");
            cmbEst_civil.Items.Insert(1, "Solteiro");
            cmbEst_civil.Items.Insert(2, "Casado");
            cmbEst_civil.Items.Insert(3, "União Estável");
            cmbEst_civil.Items.Insert(4, "Viúvo");
            cmbEst_civil.SelectedIndex = 0;
        }

        private void populaResp()
        {

            Estudante obj = new Estudante();

            int aluno = int.Parse(cmbAluno.SelectedValue.ToString());

            dr_estudante = obj.Get(aluno);

            cmbContratante.Items.Insert(0, "-- Selecione --");
            if (dr_estudante["pai"].ToString() != "")
            {
                cmbContratante.Items.Insert(1, dr_estudante["pai"].ToString());
            }
            if (dr_estudante["mae"].ToString() != "")
            {
                cmbContratante.Items.Insert(2, dr_estudante["mae"].ToString());
            }
            if (dr_estudante["responsavel"].ToString() != "")
            {
                cmbContratante.Items.Insert(1, dr_estudante["responsavel"].ToString());
            }
            cmbContratante.SelectedIndex = 0;
        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAluno.SelectedIndex == 0)
            {
                return;
            }
            populaResp();
            
            Contrato ctr = new Contrato();
            int id = int.Parse(dr_estudante["id"].ToString());
            if (id == 0)
            {
                return;
            }
            this.btContrato.Enabled = id > 0;

            DataRow dados = ctr.Get(id);
            if (dados != null)
            {
                this.id_contrato = int.Parse(dados["id"].ToString());
                this.Edit(dados);
            } 
            else
            {
                Estudante obj = new Estudante();
                dr_estudante = obj.Get(id);

                txtLogradouro.Text = dr_estudante["logradouro"].ToString();
                txtNumero.Text = dr_estudante["numero"].ToString();
                txtBairro.Text = dr_estudante["bairro"].ToString();

            }

        }

        private void Edit(DataRow dr)
        {
            txtId.Text = this.id_contrato.ToString();
            txtRg.Text = dr["rg"].ToString();
            txtEmissor.Text = dr["emissor"].ToString();
            txtCpf.Text = dr["cpf"].ToString();
            txtProfissao.Text = dr["profissao"].ToString();
            txtDt_nascimento.Text = dr["dt_nascimento"].ToString();
            cmbContratante.SelectedIndex = Convert.ToInt16(dr["id_contratante"].ToString());
            cmbEst_civil.SelectedIndex = Convert.ToInt16(dr["est_civil"].ToString());
            txtLogradouro.Text = dr["logradouro"].ToString();
            txtNacionalidade.Text = dr["nacionalidade"].ToString();
            txtNaturalidade.Text = dr["naturalidade"].ToString();
            txtNumero.Text = dr["numero"].ToString();
            txtBairro.Text = dr["bairro"].ToString();
            txtValor.Text = dr["valor"].ToString();
            txtDia.Text = dr["dia"].ToString();

            txtTrajeto.Text = dr["trajeto"].ToString();

            if (dr["trajeto"].ToString() == "1")
            {
                rbIda.Checked = true;
            }
            else if (dr["trajeto"].ToString() == "2")
            {
                rbVolta.Checked = true;
            }
            else if (dr["trajeto"].ToString() == "3")
            {
                rbIdaevolta.Checked = true;
            }
            else
            {
                rbOutro.Checked = true;
            }
            txtData.Text = dr["data"].ToString();
            txtTrajeto_esp.Text = dr["trajeto_esp"].ToString();
            chkInativo.Checked = dr["inativo"].ToString().Equals("1");
            txtDt_inativo.Text = dr["dt_inativo"].ToString();
            chkInativo.Enabled = true;
            txtDt_inativo.Enabled = true;
            btSalva.Enabled = !chkInativo.Checked;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Contrato contrato = new Contrato();
            int result = 0;

            if (this.id_contrato == 0)
            {
                result = contrato.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                    this.id_contrato = result;
                    this.btContrato.Enabled = result > 0;
                }
            }
            else
            {
                result = contrato.Edit(this);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                }
            }
        }


        private void btContrato_Click(object sender, EventArgs e)
        {
            frmContrato form = new frmContrato(this.id_contrato);

            form.ShowDialog();
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
            try
            {
                TextBox txt = (sender as TextBox);
                txt.Text = Convert.ToDouble(txt.Text).ToString("F");
            }
            catch (Exception)
            {

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

        private void rbIda_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtTrajeto.Text = li.Tag as string;
        }

        #region Validate
        private void cmbContratante_Validating(object sender, CancelEventArgs e)
        {
            validateContratante();
        }

        private bool validateContratante()
        {

            bool bStatus = true;

            if (cmbContratante.SelectedItem != null && cmbContratante.SelectedItem.ToString() != "0")
            {
                errorProvider1.SetError(cmbContratante, "");
            }
            else
            {
                errorProvider1.SetError(cmbContratante, "É necessário informar o resaponsável pelo contrato.");
                bStatus = false;
            }

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

        private bool validateNacionalidade()
        {
            bool bStatus = true;
            if (txtNacionalidade.Text == "")
            {
                errorProvider1.SetError(txtNacionalidade, "Favor informar a nacionalidade do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNacionalidade, "");
            return bStatus;
        }

        private bool validateNaturalidade()
        {
            bool bStatus = true;
            if (txtNaturalidade.Text == "")
            {
                errorProvider1.SetError(txtNaturalidade, "Favor informar a naturalidade do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtNaturalidade, "");
            return bStatus;
        }

        private void txtNacionalidade_Validating(object sender, CancelEventArgs e)
        {
            validateNacionalidade();
        }

        private void txtNaturalidade_Validating(object sender, CancelEventArgs e)
        {
            validateNaturalidade();
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

        private bool validateData()
        {
            bool bStatus = true;

            txtData.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtData.Text == "")
            {
                errorProvider1.SetError(txtData, "Informe a data de vigência do contrato");
            }
            else
            {
                txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(txtData.Text, out dt);
                if (success)
                {
                    errorProvider1.SetError(txtData, "");
                }
                else
                {
                    errorProvider1.SetError(txtData, "Informe uma data válida");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void cmbEst_civil_Validating(object sender, CancelEventArgs e)
        {
            validateEstCivil();
        }

        private bool validateEstCivil()
        {

            bool bStatus = true;

            if (cmbEst_civil.SelectedItem != null && cmbEst_civil.SelectedItem.ToString() != "0")
            {
                errorProvider1.SetError(cmbEst_civil, "");
            }
            else
            {
                errorProvider1.SetError(cmbEst_civil, "É necessário informar o estado civil do contratante.");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtProfissao_Validating(object sender, CancelEventArgs e)
        {
            validateProfissao();
        }

        private bool validateProfissao()
        {
            bool bStatus = true;
            if (txtProfissao.Text == "")
            {
                errorProvider1.SetError(txtProfissao, "Favor informar a profissão do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtProfissao, "");
            return bStatus;
        }

        private bool validateTrajeto()
        {
            bool bStatus = true;
            int _checked = 0;

            foreach (Control c in groupBox4.Controls)
            {
                if (c is RadioButton)
                {
                    if ((c as RadioButton).Checked == true) { _checked = int.Parse(c.Tag.ToString()); }
                }
            }
            if (_checked == 0)
            {
                errorProvider1.SetError(groupBox4, "Favor informar o trajeto do estudante.");
                bStatus = false;
            }
            else
            {
                if (_checked == 4)
                {
                    if (txtTrajeto_esp.Text == "")
                    {
                        errorProvider1.SetError(groupBox4, "Favor especificar o trajeto que será utilizado pelo estudante.");
                    }
                    else
                    {
                        errorProvider1.SetError(groupBox4, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(groupBox4, "");
                }

            }

            return bStatus;
        }

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            validateTrajeto();
        }

        private void txtRg_Validating(object sender, CancelEventArgs e)
        {
            validateRg();
        }

        private bool validateRg()
        {
            bool bStatus = true;
            txtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtRg.Text == "")
            {
                errorProvider1.SetError(txtRg, "Favor informar o número do RG do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtRg, "");
            txtRg.TextMaskFormat = MaskFormat.IncludeLiterals;
            return bStatus;
        }

        private bool validateEmissor()
        {
            bool bStatus = true;
            if (txtEmissor.Text == "")
            {
                errorProvider1.SetError(txtEmissor, "Favor informar o órgão emissor do RG do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtEmissor, "");
            return bStatus;
        }

        private void txtEmissor_Validating(object sender, CancelEventArgs e)
        {
            validateEmissor();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            validateCpf();
        }

        private bool validateCpf()
        {
            bool bStatus = true;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCpf.Text == "")
            {
                errorProvider1.SetError(txtCpf, "Favor informar o número do RG do contratante");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtCpf, "");
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            return bStatus;
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            validaUnitario();
        }

        private bool validaUnitario()
        {
            bool bStatus = true;
            if (txtValor.Text == "")
            {
                errorProvider1.SetError(txtValor, "Favor informar o valor mensal do contrato.");
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

        private void txtDia_Validating(object sender, CancelEventArgs e)
        {
            validateDia();
        }

        private bool validateDia()
        {
            bool bStatus = true;
            if (txtDia.Text == "")
            {
                errorProvider1.SetError(txtDia, "Favor informar o dia de vencimento do contrato.");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtDia, "");
            return bStatus;
        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            validateData();
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkInativo.Checked)
            {
                MessageBox.Show("Inativando um contrato, fará com que ele não seja mais passível de edição.","Atenção!");
            }
        }

        
    }
}
