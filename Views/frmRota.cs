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
    public partial class frmRota : Form
    {
        private int id;
        public frmRota( int id)
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
            Rota obj = new Rota();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            cmbEscola.SelectedValue = dr["id_escola"].ToString();
            txtKm.Text = dr["km"].ToString();
            txtValor_km.Text = dr["valor_km"].ToString();
        }

        private void populaCombos()
        {
            

            Escola obj = new Escola();

            DataTable dt = obj.Combo();

            cmbEscola.DataSource = dt;
            cmbEscola.DisplayMember = "nome";
            cmbEscola.ValueMember = "id";
            cmbEscola.SelectedIndex = 0;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Rota obj = new Rota();
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

        private void txtValor_km_Leave(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            txt.Text = Convert.ToDouble(txt.Text).ToString("F");
        }

        private void txtValor_km_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_km_Enter(object sender, EventArgs e)
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
