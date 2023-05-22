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
    public partial class frmDespesa : Form
    {
        private int id;
        private int pn1;
        private int pn2;
        private DataTable details;
        private bool edDetail;
        private bool start = true;

        public frmDespesa(int id)
        {
            InitializeComponent();

            this.id = id;
            this.populaCombos();
            details = new DataTable();

            this.MyResize();
            this.edDetail = false;

            if (id > 0)
            {
                this.Edit(id);
            } 
            else
            {
                txtTipoPgto.Text = "1";
                txtIdDetail.Text = "0";
                rbVista.Checked = true;
                details.Columns.Add("Id".ToString());
                details.Columns.Add("Parcela".ToString());
                details.Columns.Add("Vencimento".ToString());
                details.Columns.Add("Valor".ToString());
            }

            this.dgDetails.DataSource = details;
            dgDetails.Columns[0].Visible = false;
        }

        private void MyResize()
        {
            this.pn1 = this.splitContainer1.Panel1.Width;
            this.pn2 = this.splitContainer1.Panel2.Width;
        }

        private void Edit(int id)
        {
            Despesa obj = new Despesa();

            DataRow dr = obj.Get(id);

            txtId.Text = dr["id"].ToString();

            txtData.Text = dr["data"].ToString();
            txtValor.Text = dr["valor"].ToString();
            txtNF.Text = dr["notaFiscal"].ToString();
            txtDescricao.Text = dr["descricao"].ToString();

            txtTipoPgto.Text = dr["id_tipo"].ToString();

            if (dr["id_tipo"].ToString() == "1")
            {
                rbVista.Checked = true;
            }
            else
            {
                rbParcelado.Checked = true;
            }

            txtMetodoPgto.Text = dr["id_metodo"].ToString();

            switch (dr["id_Metodo"].ToString())
            {
                case "1":
                    rbCartao.Checked = true;
                    break;
                case "2":
                    rbBoleto.Checked = true;
                    break;
                default:
                    rbPix.Checked = true;
                    break;
            }

            cmbCategoria.SelectedValue = dr["id_categoria"].ToString();
            cmbFornecedor.SelectedValue = dr["id_fornecedor"].ToString();

            details = obj.Details(id);
           
        }

        private void rbParcelado_CheckedChanged(object sender, EventArgs e)
        {
            if (start && this.id == 0)
            {
                start = false;
                splitContainer2.Visible = false;
                this.Size = new Size(this.pn1, this.Size.Height);
                return;
            }
            RadioButton li = (sender as RadioButton);
            txtTipoPgto.Text = li.Tag as string;
            if (li.Tag as string == "2")
            {
                splitContainer2.Visible = true;
                if(li.Checked)
                    this.Size = new Size(this.pn1 + this.pn2, this.Size.Height);
                splitContainer1.SplitterDistance = this.pn1;
                splitContainer2.SplitterDistance = (int) this.Size.Height / 4;

            }
            else
            {
                splitContainer2.Visible = false;
                if (li.Checked)
                {
                    this.Size = new Size(this.pn1, this.Size.Height);                    
                }
            }
            this.tamForm();
        }

        private void tamForm()
        {
            try
            {
                Screen myScreen = Screen.FromControl(this);


                this.Location = new Point(myScreen.Bounds.Width / 2 - this.Width / 2 + myScreen.Bounds.Location.X,
                                        myScreen.Bounds.Height / 2 - this.Height / 2 + myScreen.Bounds.Location.Y);
            }
            catch (Exception)
            {
            }
            
        }

        private void populaCombos()
        {


            Fornecedor forn = new Fornecedor();
            DataTable dt = forn.Combo();

            dt = forn.Combo();

            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.SelectedIndex = 0;


            Auxiliar aux = new Auxiliar();

            dt = aux.Combo(4);

            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.SelectedIndex = 0;

        }


        private void rbCartão_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtMetodoPgto.Text = li.Tag as string;
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            //this.Resize();
        }

        private void splitContainer2_Resize(object sender, EventArgs e)
        {
            //this.Resize();
        }

        private void btSaveDetail_Click(object sender, EventArgs e)
        {
            DataRow dr;

            if (txtIdDetail.Text.ToString() == "0")
            {
                dr = this.details.NewRow();
                dr["id"] = "0";
                dr["parcela"] = txtParcelaDetail.Text;
                dr["vencimento"] = dtVencimentoDetail.Text;
                dr["valor"] = txtValorDetail.Text;
                details.Rows.Add(dr);
                details.AcceptChanges();

                dtVencimentoDetail.Value = dtVencimentoDetail.Value.AddMonths(1);
                txtParcelaDetail.Text = (int.Parse(txtParcelaDetail.Text) + 1).ToString();
            } 
            else
            {
                this.edDetail = true;
                foreach (DataRow row in details.Rows) // search whole table
                {
                    if (row["id"].ToString() == txtIdDetail.Text.ToString()) // if id==2
                    {
                        row["parcela"] = txtParcelaDetail.Text;
                        row["vencimento"] = dtVencimentoDetail.Text;
                        row["valor"] = txtValorDetail.Text;
                        details.AcceptChanges();
                    }
                }
            }
            dgDetails.DataSource = null;
            dgDetails.DataSource = details;
            dgDetails.Columns[0].Visible = false;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Despesa ct = new Despesa();
            int result = 0;

            if (id == 0)
            {
                result = ct.Add(this, details);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                    this.Limpa();
                }
            }
            else
            {
                result = ct.Edit(this, details, edDetail);

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

        private void dgDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgDetails.Rows.Count > 0 && this.id > 0)
            {
                txtIdDetail.Text = dgDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtParcelaDetail.Text = dgDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtVencimentoDetail.Text = dgDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValorDetail.Text = dgDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
