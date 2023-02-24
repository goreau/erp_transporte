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
    }
}
