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
    public partial class frmEmpresa : Form
    {
        private int id;
        public frmEmpresa(int id)
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
            Empresa emp = new Empresa();

            DataRow dr = emp.Consulta(id);

            txtId.Text = dr["id"].ToString();

            txtNome.Text = dr["nome"].ToString();
            txtNome_fantasia.Text = dr["nome_fantasia"].ToString();
            txtCnpj.Text = dr["cnpj"].ToString();
            txtCidade.Text = dr["cidade"].ToString();
            txtUf.Text = dr["uf"].ToString();
            txtLogradouro.Text = dr["logradouro"].ToString();
            txtNumero.Text = dr["numero"].ToString();
            txtBairro.Text = dr["bairro"].ToString();
            txtContato1.Text = dr["contato1"].ToString();
            txtTelefone1.Text = dr["telefone1"].ToString();
            txtContato2.Text = dr["contato2"].ToString();
            txtTelefone2.Text = dr["telefone2"].ToString();
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            int result = 0;

            if (id == 0)
            {
                result = emp.Add(this);
                if (result > 0)
                {
                    MessageBox.Show("Registro inserido!");
                }
            }
            else
            {
                result = emp.Edit(this);

                if (result > 0)
                {
                    MessageBox.Show("Registro atualizado!");
                }
            }

        }
    }
}
