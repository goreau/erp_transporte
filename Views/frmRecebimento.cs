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
    public partial class frmRecebimento : Form
    {
        private int id;
        public frmRecebimento(int id)
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
            Recebimento obj = new Recebimento();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbRota.SelectedValue = dr["id_rota"].ToString();

            txtAno.Text = dr["ano"].ToString();
            txtMes.Text = dr["mes"].ToString();
            txtValor.Text = dr["valor"].ToString();
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Recebimento ct = new Recebimento();
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
            Rota rt = new Rota();
            DataTable dt = rt.Combo();


            cmbRota.DataSource = dt;
            cmbRota.DisplayMember = "nome";
            cmbRota.ValueMember = "id";
            cmbRota.SelectedIndex = 0;

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

        #region regionValidate
        private void txtAno_Validating(object sender, CancelEventArgs e)
        {
            validaAno();
        }

        private bool validaAno()
        {
            bool bStatus = true;
            if (txtAno.Text == "")
            {
                errorProvider1.SetError(txtAno, "Favor informar o ano de referência");
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
                    errorProvider1.SetError(txtAno, "Favor informar um número válido");
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

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            validaValor();
        }

        private bool validaValor()
        {
            bool bStatus = true;
            if (txtValor.Text == "")
            {
                errorProvider1.SetError(txtValor, "Favor informar o valor do recebimento.");
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
