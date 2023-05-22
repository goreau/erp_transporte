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
                txtOldArq.Text = dialog.FileName;
                txtNewFile.Text = "1";
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

            cmbVeiculo.SelectedValue = dr["id_veiculo"].ToString();
            txtKm.Text = dr["km"].ToString();

            cmbFornecedor.SelectedValue = dr["id_fornecedor"].ToString();
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

            string arq = dr["arquivo"].ToString();
            string[] partes = arq.Split('\\');

            txtArquivo.Text = partes.Last();

            txtOldArq.Text = arq;

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

        private void btPreview_Click(object sender, EventArgs e)
        {
            
            
            using (Form form = new Form())
            {
                Bitmap img = new Bitmap(txtOldArq.Text);

                form.StartPosition = FormStartPosition.CenterScreen;
                if (img.Size.Height > 400)
                {
                    int fator = img.Size.Height / 400;
                    Size sz = new Size(img.Size.Width / fator, img.Size.Height / fator);
                    img = new Bitmap(img, sz);
                }
                form.ClientSize = img.Size;
                form.ShowIcon = false;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MinimizeBox = false;
                form.MaximizeBox = false;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;

                form.Controls.Add(pb);
                form.ShowDialog();
            }

        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            validateData();
        }

        private bool validateData()
        {
            bool bStatus = true;

            DateTime dt;
            bool success = DateTime.TryParse(txtData.Text, out dt);
            if (success)
            {
                if (dt > DateTime.Now)
                {
                    errorProvider1.SetError(txtData, "A data não pode ser superior à data atual.");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(txtData, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtData, "Informe uma data válida");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtVencimento_Validating(object sender, CancelEventArgs e)
        {
            validateVencimento();
        }

        private bool validateVencimento()
        {
            bool bStatus = true;

            DateTime dt;
            bool success = DateTime.TryParse(txtVencimento.Text, out dt);
            if (success)
            {
                errorProvider1.SetError(txtVencimento, "");
            }
            else
            {
                errorProvider1.SetError(txtVencimento, "Informe uma data válida");
                bStatus = false;
            }

            return bStatus;
        }

        private void cmbVeiculo_Validating(object sender, CancelEventArgs e)
        {
            validateVeiculo();
        }

        private bool validateVeiculo()
        {

            bool bStatus = true;

            if (cmbVeiculo.SelectedValue != null && cmbVeiculo.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbVeiculo, "");
            }
            else
            {
                errorProvider1.SetError(cmbVeiculo, "É necessário informar o veículo.");
                bStatus = false;
            }

            return bStatus;
        }

        private void cmbFornecedor_Validating(object sender, CancelEventArgs e)
        {
            validateFornecedor();
        }

        private bool validateFornecedor()
        {

            bool bStatus = true;

            if (cmbFornecedor.SelectedValue != null && cmbFornecedor.SelectedValue.ToString() != "0")
            {
                errorProvider1.SetError(cmbFornecedor, "");
            }
            else
            {
                errorProvider1.SetError(cmbFornecedor, "É necessário informar o fornecedor do serviço.");
                bStatus = false;
            }

            return bStatus;
        }

        private void txtKm_Validating(object sender, CancelEventArgs e)
        {
            validaKm();
        }

        private bool validaKm()
        {
            bool bStatus = true;
            if (txtKm.Text == "")
            {
                errorProvider1.SetError(txtKm, "Favor informar a quilometragem");
                bStatus = false;
            }
            else
            {
                int lt;
                bool ok = int.TryParse(txtKm.Text, out lt);
                if (ok)
                {
                    errorProvider1.SetError(txtKm, "");
                }
                else
                {
                    errorProvider1.SetError(txtKm, "Favor informar uma quilometragem válida");
                    bStatus = false;
                }
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
                errorProvider1.SetError(txtValor, "Favor informar o valor do serviço.");
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

        private void groupBox4_Validating(object sender, CancelEventArgs e)
        {
            validateFormaPgto();
        }

        private bool validateFormaPgto()
        {
            bool bStatus = true;
            int _checked = 0;
            foreach (Control c in groupBox4.Controls)
            {
                if (c is RadioButton)
                {
                    if ((c as RadioButton).Checked == true) { _checked++; }
                }
            }
            if (_checked == 0)
            {
                errorProvider1.SetError(groupBox4, "Favor informar a forma de pagamento.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(groupBox4, "");
            }

            return bStatus;
        }


    }

}
