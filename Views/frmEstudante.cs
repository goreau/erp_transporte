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
    public partial class frmEstudante : Form
    {
        private int id;
        public frmEstudante(int id)
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
            cmbEst_civil.Items.Insert(0, "-- Selecione --");
            cmbEst_civil.Items.Insert(1, "Solteiro");
            cmbEst_civil.Items.Insert(2, "Casado");
            cmbEst_civil.Items.Insert(3, "União Estável");
            cmbEst_civil.Items.Insert(4, "Viúvo");
            cmbEst_civil.SelectedIndex = 0;

            Escola obj = new Escola();

            DataSet ds = obj.Combo();

            cmbEscola.DataSource = ds.Tables[0];
            cmbEscola.DisplayMember = "nome";
            cmbEscola.ValueMember = "id";
            cmbEscola.SelectedIndex = 0;

            cmbId_rota.Items.Insert(0, "-- Selecione --");
            cmbId_rota.Items.Insert(1, "rota 1");
            cmbId_rota.Items.Insert(2, "rota 2");
            cmbId_rota.SelectedIndex = 0;
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            int result = 0;

            if (id == 0)
            {
                result = estudante.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
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

        private void rbManha_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            txtPeriodo.Text = li.Tag as string;
        }

        private void Edit(int id)
        {
            Estudante estudante = new Estudante();

            DataRow dr = estudante.Get(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            txtLogradouro.Text = dr["logradouro"].ToString();
            txtNumero.Text = dr["numero"].ToString();
            txtBairro.Text = dr["bairro"].ToString();
            
            cmbEscola.SelectedValue = dr["id_escola"].ToString();

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

            txtRa_rg.Text = dr["ra_rg"].ToString();
            txtDt_nascimento.Text = dr["dt_nascimento"].ToString();

            txtPai.Text = dr["pai"].ToString();
            txtTel_pai.Text = dr["tel_pai"].ToString();
            txtMae.Text = dr["mae"].ToString();
            txtTel_mae.Text = dr["tel_mae"].ToString();

            txtResponsavel.Text = dr["responsavel"].ToString();
            txtTel_resp.Text = dr["tel_resp"].ToString();
            txtResp_qualif.Text = dr["resp_qualif"].ToString();

            txtNaturalidade.Text = dr["naturalidade"].ToString();
            txtNacionalidade.Text = dr["nacionalidade"].ToString();
            txtRg.Text = dr["rg"].ToString();
            txtCpf.Text = dr["cpf"].ToString();

            cmbId_rota.SelectedIndex = Convert.ToInt16(dr["id_rota"].ToString());
            cmbEst_civil.SelectedIndex = Convert.ToInt16(dr["est_civil"].ToString());

            txtObs.Text = dr["obs"].ToString();
        }

        private void btSalva_Click_1(object sender, EventArgs e)
        {
            Estudante obj = new Estudante();
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
    }
}
