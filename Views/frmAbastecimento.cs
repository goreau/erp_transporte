using ERP_Transporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Transporte.Views
{
    public partial class frmAbastecimento : Form
    {
        private int id;
        public frmAbastecimento(int id)
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

            DataTable dt = obj.Combo();

            cmbVeiculo.DataSource = dt;
            cmbVeiculo.DisplayMember = "nome";
            cmbVeiculo.ValueMember = "id";
            cmbVeiculo.SelectedIndex = 0;

            Fornecedor obj2 = new Fornecedor();

            dt = obj2.Combo();

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files | *.jpg;*.jpeg;*.png;*.pdf"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                txtArquivo.Text = dialog.FileName; 
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

        private void rbCartao_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtPagamento.Text = li.Tag as string;
        }

        private void rbAlcool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtCombustivel.Text = li.Tag as string;
        }

        private void Edit(int id)
        {
            Abastecimento estudante = new Abastecimento();

            DataRow dr = estudante.Get(id);

            txtId.Text = dr["id"].ToString();

            cmbVeiculo.SelectedValue = dr["id_veiculo"].ToString();
            txtKm.Text = dr["km"].ToString();

            cmbFornecedor.SelectedValue = dr["id_fornecedor"].ToString();
            txtLitros.Text = dr["litros"].ToString();
            txtValor.Text = dr["valor_litro"].ToString();

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

            txtVencimento.Text = dr["vencimento"].ToString();
            string arq = dr["arquivo"].ToString();
            string[] partes = arq.Split('/');
            
            txtArquivo.Text = partes.Last();
            txtData.Text = dr["data"].ToString();

            btPreview.Visible = dr["arquivo"].ToString() != "";

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

        private void btSalva_Click(object sender, EventArgs e)
        {
            Abastecimento estudante = new Abastecimento();
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

        private void btPreview_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory + "Uploads\\";
                Bitmap img = new Bitmap(Path.Combine(path,txtArquivo.Text));

                form.StartPosition = FormStartPosition.CenterScreen;
                form.ClientSize = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;

                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }
    }
}
