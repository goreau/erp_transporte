﻿namespace ERP_Transporte.Views
{
    partial class frmAbastecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbastecimento));
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btArquivo = new System.Windows.Forms.Button();
            this.txtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFlex = new System.Windows.Forms.RadioButton();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbGasolina = new System.Windows.Forms.RadioButton();
            this.rbAlcool = new System.Windows.Forms.RadioButton();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(399, 525);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(573, 28);
            this.txtArquivo.TabIndex = 157;
            // 
            // btArquivo
            // 
            this.btArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArquivo.Location = new System.Drawing.Point(255, 522);
            this.btArquivo.Name = "btArquivo";
            this.btArquivo.Size = new System.Drawing.Size(138, 34);
            this.btArquivo.TabIndex = 156;
            this.btArquivo.Text = "Arquivo";
            this.btArquivo.UseVisualStyleBackColor = true;
            this.btArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Location = new System.Drawing.Point(852, 297);
            this.txtVencimento.Mask = "00/00/0000";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(120, 28);
            this.txtVencimento.TabIndex = 152;
            this.txtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(725, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
            this.label11.TabIndex = 153;
            this.label11.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(179, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 151;
            this.label6.Text = "Veículo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(269, 100);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(342, 30);
            this.cmbVeiculo.TabIndex = 150;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.Location = new System.Drawing.Point(82, 295);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(55, 28);
            this.txtPagamento.TabIndex = 149;
            this.txtPagamento.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbCheque);
            this.groupBox4.Controls.Add(this.rbDinheiro);
            this.groupBox4.Controls.Add(this.rbCartao);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(183, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 87);
            this.groupBox4.TabIndex = 148;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCheque.Location = new System.Drawing.Point(288, 35);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(98, 26);
            this.rbCheque.TabIndex = 4;
            this.rbCheque.TabStop = true;
            this.rbCheque.Tag = "3";
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbCartao_CheckedChanged);
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDinheiro.Location = new System.Drawing.Point(164, 35);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(102, 26);
            this.rbDinheiro.TabIndex = 3;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Tag = "2";
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            this.rbDinheiro.CheckedChanged += new System.EventHandler(this.rbCartao_CheckedChanged);
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCartao.Location = new System.Drawing.Point(43, 35);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(89, 26);
            this.rbCartao.TabIndex = 1;
            this.rbCartao.TabStop = true;
            this.rbCartao.Tag = "1";
            this.rbCartao.Text = "Cartão";
            this.rbCartao.UseVisualStyleBackColor = true;
            this.rbCartao.CheckedChanged += new System.EventHandler(this.rbCartao_CheckedChanged);
            // 
            // txtKm
            // 
            this.txtKm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(852, 103);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(120, 28);
            this.txtKm.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(711, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 22);
            this.label10.TabIndex = 147;
            this.label10.Text = "Kilometragem:";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(852, 420);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 28);
            this.txtValor.TabIndex = 144;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(737, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 145;
            this.label8.Text = "Valor Litro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(144, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 143;
            this.label7.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(269, 181);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(340, 30);
            this.cmbFornecedor.TabIndex = 142;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(82, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 141;
            this.txtId.Visible = false;
            // 
            // btSalva
            // 
            this.btSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(606, 610);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 140;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(82, 405);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(55, 28);
            this.txtCombustivel.TabIndex = 159;
            this.txtCombustivel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFlex);
            this.groupBox1.Controls.Add(this.rbDiesel);
            this.groupBox1.Controls.Add(this.rbGasolina);
            this.groupBox1.Controls.Add(this.rbAlcool);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(182, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 77);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combustível";
            // 
            // rbFlex
            // 
            this.rbFlex.AutoSize = true;
            this.rbFlex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFlex.Location = new System.Drawing.Point(434, 25);
            this.rbFlex.Name = "rbFlex";
            this.rbFlex.Size = new System.Drawing.Size(69, 26);
            this.rbFlex.TabIndex = 4;
            this.rbFlex.TabStop = true;
            this.rbFlex.Tag = "4";
            this.rbFlex.Text = "Flex";
            this.rbFlex.UseVisualStyleBackColor = true;
            this.rbFlex.CheckedChanged += new System.EventHandler(this.rbAlcool_CheckedChanged);
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDiesel.Location = new System.Drawing.Point(314, 25);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(85, 26);
            this.rbDiesel.TabIndex = 3;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Tag = "3";
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            this.rbDiesel.CheckedChanged += new System.EventHandler(this.rbAlcool_CheckedChanged);
            // 
            // rbGasolina
            // 
            this.rbGasolina.AutoSize = true;
            this.rbGasolina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbGasolina.Location = new System.Drawing.Point(172, 25);
            this.rbGasolina.Name = "rbGasolina";
            this.rbGasolina.Size = new System.Drawing.Size(106, 26);
            this.rbGasolina.TabIndex = 2;
            this.rbGasolina.TabStop = true;
            this.rbGasolina.Tag = "2";
            this.rbGasolina.Text = "Gasolina";
            this.rbGasolina.UseVisualStyleBackColor = true;
            this.rbGasolina.CheckedChanged += new System.EventHandler(this.rbAlcool_CheckedChanged);
            // 
            // rbAlcool
            // 
            this.rbAlcool.AutoSize = true;
            this.rbAlcool.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbAlcool.Location = new System.Drawing.Point(44, 25);
            this.rbAlcool.Name = "rbAlcool";
            this.rbAlcool.Size = new System.Drawing.Size(84, 26);
            this.rbAlcool.TabIndex = 1;
            this.rbAlcool.TabStop = true;
            this.rbAlcool.Tag = "1";
            this.rbAlcool.Text = "Álcool";
            this.rbAlcool.UseVisualStyleBackColor = true;
            this.rbAlcool.CheckedChanged += new System.EventHandler(this.rbAlcool_CheckedChanged);
            // 
            // txtLitros
            // 
            this.txtLitros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitros.Location = new System.Drawing.Point(852, 181);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(120, 28);
            this.txtLitros.TabIndex = 160;
            this.txtLitros.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtLitros.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(775, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 161;
            this.label1.Text = "Litros:";
            // 
            // frmAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 727);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btArquivo);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVeiculo);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btSalva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbastecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btArquivo;
        private System.Windows.Forms.MaskedTextBox txtVencimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbDinheiro;
        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFlex;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbGasolina;
        private System.Windows.Forms.RadioButton rbAlcool;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label1;
    }
}