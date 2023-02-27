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
    public partial class frmDias : Form
    {
        private int id;
        public frmDias(int id)
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
            Dias obj = new Dias();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbRota.SelectedValue = dr["id_rota"].ToString();

            txtAno.Text = dr["ano"].ToString();
            txtMes.Text = dr["mes"].ToString();
            txtDias.Text = dr["dias"].ToString();
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


            Rota rt = new Rota();
            DataTable dt = rt.Combo();


            cmbRota.DataSource = dt;
            cmbRota.DisplayMember = "nome";
            cmbRota.ValueMember = "id";
            cmbRota.SelectedIndex = 0;

        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Dias ct = new Dias();
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
        
        #region regionValidate
        private void cmbRota_Validating(object sender, CancelEventArgs e)
        {
            validateRota();
        }

        private bool validateRota()
        {
            bool bStatus = true;

            if (cmbRota.SelectedValue != null && cmbRota.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbRota, "");
            }
            else
            {
                errorProvider1.SetError(cmbRota, "Favor informar o trajeto.");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtAno_Validated(object sender, EventArgs e)
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

        private void txtMes_Validating(object sender, CancelEventArgs e)
        {
            validaMes();
        }

        private bool validaMes()
        {
            bool bStatus = true;
            if (txtMes.Text == "")
            {
                errorProvider1.SetError(txtMes, "Favor informar o mês");
                bStatus = false;
            }
            else
            {
                int val;
                bool ok = int.TryParse(txtMes.Text, out val);
                if (ok)
                {
                    if (val > 12 || val < 1)
                    {
                        errorProvider1.SetError(txtMes, "Favor informar um mês válido");
                        bStatus = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txtMes, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtMes, "Favor informar um mês válido");
                    bStatus = false;
                }
            }

            return bStatus;
        }

        private void txtDias_Validating(object sender, CancelEventArgs e)
        {
            validaDias();
        }

        private bool validaDias()
        {
            bool bStatus = true;
            if (txtDias.Text == "")
            {
                errorProvider1.SetError(txtDias, "Favor informar a quantidade de dias letivos");
                bStatus = false;
            }
            else
            {
                int val;
                bool ok = int.TryParse(txtDias.Text, out val);
                if (ok)
                {
                    if (val > 25 || val < 1)
                    {
                        errorProvider1.SetError(txtDias, "Favor informar um número de dias válido");
                        bStatus = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txtDias, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDias, "Favor informar um número válido");
                    bStatus = false;
                }
            }

            return bStatus;
        } 
        #endregion
    }
}
