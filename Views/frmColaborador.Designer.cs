namespace ERP_Transporte.Views
{
    partial class frmColaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaborador));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtDt_admissao = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDt_expedicao = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCnh_categoria = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDt_validade = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemuneracao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(102, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 99;
            this.label1.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(218, 133);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(316, 28);
            this.cmbCategoria.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(167, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 97;
            this.txtId.Visible = false;
            // 
            // btSalva
            // 
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(582, 600);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 15;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click_1);
            this.btSalva.Leave += new System.EventHandler(this.btSalva_Leave);
            // 
            // txtDt_admissao
            // 
            this.txtDt_admissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDt_admissao.Location = new System.Drawing.Point(759, 133);
            this.txtDt_admissao.Mask = "00/00/0000";
            this.txtDt_admissao.Name = "txtDt_admissao";
            this.txtDt_admissao.Size = new System.Drawing.Size(120, 28);
            this.txtDt_admissao.TabIndex = 4;
            this.txtDt_admissao.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(588, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 22);
            this.label11.TabIndex = 95;
            this.label11.Text = "Data Admissão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(568, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 94;
            this.label6.Text = "Função:";
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Location = new System.Drawing.Point(666, 74);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(212, 28);
            this.cmbFuncao.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNome.Location = new System.Drawing.Point(217, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 28);
            this.txtNome.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(133, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 115;
            this.label12.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCpf.Location = new System.Drawing.Point(218, 263);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(174, 28);
            this.txtCpf.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(154, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 22);
            this.label13.TabIndex = 119;
            this.label13.Text = "CPF:";
            // 
            // txtRg
            // 
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRg.Location = new System.Drawing.Point(217, 202);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(175, 28);
            this.txtRg.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(153, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 22);
            this.label14.TabIndex = 117;
            this.label14.Text = "RG:";
            // 
            // txtDt_expedicao
            // 
            this.txtDt_expedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDt_expedicao.Location = new System.Drawing.Point(759, 202);
            this.txtDt_expedicao.Mask = "00/00/0000";
            this.txtDt_expedicao.Name = "txtDt_expedicao";
            this.txtDt_expedicao.Size = new System.Drawing.Size(120, 28);
            this.txtDt_expedicao.TabIndex = 6;
            this.txtDt_expedicao.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(588, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 22);
            this.label15.TabIndex = 121;
            this.label15.Text = "Data Expedição:";
            // 
            // txtCnh
            // 
            this.txtCnh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCnh.Location = new System.Drawing.Point(218, 321);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(174, 28);
            this.txtCnh.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(154, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 22);
            this.label16.TabIndex = 123;
            this.label16.Text = "CNH:";
            // 
            // txtCnh_categoria
            // 
            this.txtCnh_categoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCnh_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCnh_categoria.Location = new System.Drawing.Point(516, 322);
            this.txtCnh_categoria.Name = "txtCnh_categoria";
            this.txtCnh_categoria.Size = new System.Drawing.Size(50, 28);
            this.txtCnh_categoria.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(408, 323);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 22);
            this.label17.TabIndex = 125;
            this.label17.Text = "Categoria:";
            // 
            // txtDt_validade
            // 
            this.txtDt_validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDt_validade.Location = new System.Drawing.Point(759, 319);
            this.txtDt_validade.Mask = "00/00/0000";
            this.txtDt_validade.Name = "txtDt_validade";
            this.txtDt_validade.Size = new System.Drawing.Size(120, 28);
            this.txtDt_validade.TabIndex = 10;
            this.txtDt_validade.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(602, 327);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 22);
            this.label18.TabIndex = 127;
            this.label18.Text = "Data Validade:";
            // 
            // txtMae
            // 
            this.txtMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMae.Location = new System.Drawing.Point(217, 448);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(458, 28);
            this.txtMae.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(153, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 131;
            this.label2.Text = "Mãe:";
            // 
            // txtPai
            // 
            this.txtPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPai.Location = new System.Drawing.Point(218, 385);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(457, 28);
            this.txtPai.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(154, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 129;
            this.label3.Text = "Pai:";
            // 
            // txtDt_nascimento
            // 
            this.txtDt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDt_nascimento.Location = new System.Drawing.Point(218, 508);
            this.txtDt_nascimento.Mask = "00/00/0000";
            this.txtDt_nascimento.Name = "txtDt_nascimento";
            this.txtDt_nascimento.Size = new System.Drawing.Size(120, 28);
            this.txtDt_nascimento.TabIndex = 13;
            this.txtDt_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(50, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 133;
            this.label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(425, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 135;
            this.label5.Text = "Remuneração:";
            // 
            // txtRemuneracao
            // 
            this.txtRemuneracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRemuneracao.Location = new System.Drawing.Point(558, 502);
            this.txtRemuneracao.Name = "txtRemuneracao";
            this.txtRemuneracao.Size = new System.Drawing.Size(117, 28);
            this.txtRemuneracao.TabIndex = 14;
            this.txtRemuneracao.Enter += new System.EventHandler(this.txtRemuneracao_Enter);
            this.txtRemuneracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemuneracao_KeyPress);
            // 
            // frmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 703);
            this.Controls.Add(this.txtRemuneracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDt_nascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDt_validade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCnh_categoria);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDt_expedicao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.txtDt_admissao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFuncao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                        ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.MaskedTextBox txtDt_admissao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtDt_expedicao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCnh_categoria;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtDt_validade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDt_nascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemuneracao;
    }
}