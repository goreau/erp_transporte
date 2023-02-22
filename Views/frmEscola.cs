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

    }
}
