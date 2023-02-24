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
    public partial class frmFornecedor : Form
    {
        private int id;
        public frmFornecedor(int id)
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
            Fornecedor obj = new Fornecedor();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            cmbCategoria.SelectedValue = dr["categoria"].ToString();
            txtTelefone.Text = dr["telefone"].ToString();
        }

        private void populaCombos()
        {


            Auxiliar obj = new Auxiliar();

            DataTable dt = obj.Combo(1);

            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = 0;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
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
    }
}
