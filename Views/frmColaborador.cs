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
            DataSet ds = obj.Combo(2);

            cmbFuncao.DataSource = ds.Tables[0];
            cmbFuncao.DisplayMember = "nome";
            cmbFuncao.ValueMember = "id";
            cmbFuncao.SelectedIndex = 0;

            ds = obj.Combo(3);

            cmbCategoria.DataSource = ds.Tables[0];
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
            txt.Text = Convert.ToDouble(txt.Text).ToString("F");
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
    }
}
