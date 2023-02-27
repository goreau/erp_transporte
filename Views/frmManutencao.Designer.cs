namespace ERP_Transporte.Views
{
    partial class frmManutencao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManutencao));
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btPreview = new System.Windows.Forms.Button();
            this.btArquivo = new System.Windows.Forms.Button();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtOldArq = new System.Windows.Forms.TextBox();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPagamento
            // 
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.Location = new System.Drawing.Point(84, 312);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(55, 28);
            this.txtPagamento.TabIndex = 129;
            this.txtPagamento.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbCheque);
            this.groupBox4.Controls.Add(this.rbDinheiro);
            this.groupBox4.Controls.Add(this.rbCartao);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(155, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 87);
            this.groupBox4.TabIndex = 127;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento";
            this.groupBox4.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox4_Validating);
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
            this.rbCheque.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDinheiro.Location = new System.Drawing.Point(156, 35);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(102, 26);
            this.rbDinheiro.TabIndex = 3;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Tag = "2";
            this.rbDinheiro.Text = "Dinheiro";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            this.rbDinheiro.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
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
            this.rbCartao.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // txtKm
            // 
            this.txtKm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(769, 115);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(120, 28);
            this.txtKm.TabIndex = 125;
            this.txtKm.Validating += new System.ComponentModel.CancelEventHandler(this.txtKm_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(628, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 22);
            this.label10.TabIndex = 126;
            this.label10.Text = "Kilometragem:";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(769, 193);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 28);
            this.txtValor.TabIndex = 123;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(695, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 124;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(116, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(241, 196);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(340, 30);
            this.cmbFornecedor.TabIndex = 121;
            this.cmbFornecedor.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFornecedor_Validating);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(54, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 118;
            this.txtId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(151, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 133;
            this.label6.Text = "Veículo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(241, 115);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(342, 30);
            this.cmbVeiculo.TabIndex = 132;
            this.cmbVeiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVeiculo_Validating);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Location = new System.Drawing.Point(769, 310);
            this.txtVencimento.Mask = "00/00/0000";
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(120, 28);
            this.txtVencimento.TabIndex = 134;
            this.txtVencimento.ValidatingType = typeof(System.DateTime);
            this.txtVencimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtVencimento_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(642, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
            this.label11.TabIndex = 135;
            this.label11.Text = "Vencimento:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(128, 430);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 22);
            this.label22.TabIndex = 137;
            this.label22.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(241, 427);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(648, 67);
            this.txtDescricao.TabIndex = 136;
            // 
            // btPreview
            // 
            this.btPreview.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btPreview.Image = global::ERP_Transporte.Properties.Resources.file_preview_20;
            this.btPreview.Location = new System.Drawing.Point(797, 551);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(92, 46);
            this.btPreview.TabIndex = 140;
            this.btPreview.UseVisualStyleBackColor = false;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btArquivo
            // 
            this.btArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArquivo.Image = global::ERP_Transporte.Properties.Resources.image_20;
            this.btArquivo.Location = new System.Drawing.Point(225, 551);
            this.btArquivo.Name = "btArquivo";
            this.btArquivo.Size = new System.Drawing.Size(154, 46);
            this.btArquivo.TabIndex = 138;
            this.btArquivo.Text = "Arquivo";
            this.btArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btArquivo.UseVisualStyleBackColor = true;
            this.btArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSalva
            // 
            this.btSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(592, 651);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 117;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(398, 562);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(384, 35);
            this.txtArquivo.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(170, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 167;
            this.label2.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(241, 39);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(172, 28);
            this.txtData.TabIndex = 168;
            this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // txtOldArq
            // 
            this.txtOldArq.Location = new System.Drawing.Point(120, 562);
            this.txtOldArq.Name = "txtOldArq";
            this.txtOldArq.Size = new System.Drawing.Size(72, 26);
            this.txtOldArq.TabIndex = 173;
            this.txtOldArq.Visible = false;
            // 
            // txtNewFile
            // 
            this.txtNewFile.Location = new System.Drawing.Point(67, 562);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(47, 26);
            this.txtNewFile.TabIndex = 172;
            this.txtNewFile.Text = "0";
            this.txtNewFile.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 750);
            this.Controls.Add(this.txtOldArq);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.btArquivo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtDescricao);
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
            this.Name = "frmManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutencao";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.MaskedTextBox txtVencimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btArquivo;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Label txtArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtOldArq;
        private System.Windows.Forms.TextBox txtNewFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}