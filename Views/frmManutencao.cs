﻿using ERP_Transporte.Entidades;
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
    public partial class frmManutencao : Form
    {
        private int id;
        public frmManutencao(int id)
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

            Veiculo obj = new Veiculo();

            DataSet ds = obj.Combo();

            cmbVeiculo.DataSource = ds.Tables[0];
            cmbVeiculo.DisplayMember = "nome";
            cmbVeiculo.ValueMember = "id";
            cmbVeiculo.SelectedIndex = 0;

            Fornecedor obj2 = new Fornecedor();

            ds = obj2.Combo();

            cmbFornecedor.DataSource = ds.Tables[0];
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
            //    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
          //      {
                    // ...
          //      }
            }
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Manutencao estudante = new Manutencao();
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
            txtPagamento.Text = li.Tag as string;
        }

        private void Edit(int id)
        {
            Manutencao estudante = new Manutencao();

            DataRow dr = estudante.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbVeiculo.SelectedValue = dr["veiculo"].ToString();
            txtKm.Text = dr["km"].ToString();

            cmbFornecedor.SelectedValue = dr["fornecedor"].ToString();
            txtValor.Text = dr["valor"].ToString();

            txtPagamento.Text = dr["pagamento"].ToString();

            if (dr["pagamento"].ToString() == "1")
            {
                rbCartao.Checked = true;
            }
            else if (dr["periodo"].ToString() == "2")
            {
                rbDinheiro.Checked = true;
            }
            else
            {
                rbCheque.Checked = true;
            }
            
            txtVencimento.Text = dr["vencimento"].ToString();

            txtDescricao.Text = dr["descricao"].ToString();
            txtArquivo.Text = dr["arquivo"].ToString();
             
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
    }
}
