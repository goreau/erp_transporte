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

            cmbRota.SelectedValue = dr["rota"].ToString();

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
    }
}
