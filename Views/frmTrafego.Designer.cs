namespace ERP_Transporte.Views
{
    partial class frmTrafego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrafego));
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtKm_partida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartida = new System.Windows.Forms.MaskedTextBox();
            this.txtChegada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKm_chegada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtData.Location = new System.Drawing.Point(644, 135);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 28);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(584, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 68;
            this.label11.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(124, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "Veículo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(214, 71);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(316, 28);
            this.cmbVeiculo.TabIndex = 1;
            this.cmbVeiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVeiculo_Validating);
            // 
            // txtKm_partida
            // 
            this.txtKm_partida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm_partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKm_partida.Location = new System.Drawing.Point(370, 203);
            this.txtKm_partida.Name = "txtKm_partida";
            this.txtKm_partida.Size = new System.Drawing.Size(160, 28);
            this.txtKm_partida.TabIndex = 5;
            this.txtKm_partida.Validating += new System.ComponentModel.CancelEventHandler(this.txtKm_partida_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(321, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "Km:";
            // 
            // btSalva
            // 
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(468, 537);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 12;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(666, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 72;
            this.txtId.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(750, 942);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 60);
            this.button1.TabIndex = 71;
            this.button1.Text = "Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(124, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Motivo:";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(214, 138);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(316, 28);
            this.cmbMotivo.TabIndex = 2;
            this.cmbMotivo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMotivo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(120, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "Partida:";
            // 
            // txtPartida
            // 
            this.txtPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPartida.Location = new System.Drawing.Point(214, 203);
            this.txtPartida.Mask = "90:00";
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(66, 28);
            this.txtPartida.TabIndex = 4;
            this.txtPartida.ValidatingType = typeof(System.DateTime);
            this.txtPartida.Validating += new System.ComponentModel.CancelEventHandler(this.txtPartida_Validating);
            // 
            // txtChegada
            // 
            this.txtChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtChegada.Location = new System.Drawing.Point(214, 266);
            this.txtChegada.Mask = "90:00";
            this.txtChegada.Name = "txtChegada";
            this.txtChegada.Size = new System.Drawing.Size(66, 28);
            this.txtChegada.TabIndex = 6;
            this.txtChegada.ValidatingType = typeof(System.DateTime);
            this.txtChegada.Validating += new System.ComponentModel.CancelEventHandler(this.txtChegada_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(104, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Chegada:";
            // 
            // txtKm_chegada
            // 
            this.txtKm_chegada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm_chegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKm_chegada.Location = new System.Drawing.Point(370, 266);
            this.txtKm_chegada.Name = "txtKm_chegada";
            this.txtKm_chegada.Size = new System.Drawing.Size(160, 28);
            this.txtKm_chegada.TabIndex = 7;
            this.txtKm_chegada.Validating += new System.ComponentModel.CancelEventHandler(this.txtKm_chegada_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(321, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Km:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(84, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 83;
            this.label7.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(214, 335);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(316, 28);
            this.cmbFornecedor.TabIndex = 8;
            this.cmbFornecedor.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFornecedor_Validating);
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValor.Location = new System.Drawing.Point(644, 332);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 28);
            this.txtValor.TabIndex = 9;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(580, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 85;
            this.label8.Text = "Valor:";
            // 
            // txtKm
            // 
            this.txtKm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtKm.Location = new System.Drawing.Point(214, 402);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(120, 28);
            this.txtKm.TabIndex = 10;
            this.txtKm.Validating += new System.ComponentModel.CancelEventHandler(this.txtKm_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(150, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 87;
            this.label9.Text = "Km:";
            // 
            // txtLitros
            // 
            this.txtLitros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLitros.Location = new System.Drawing.Point(446, 402);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(85, 28);
            this.txtLitros.TabIndex = 11;
            this.txtLitros.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtLitros.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtLitros.Validating += new System.ComponentModel.CancelEventHandler(this.txtLitros_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(382, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 89;
            this.label10.Text = "Litros:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTrafego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 643);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtChegada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKm_chegada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVeiculo);
            this.Controls.Add(this.txtKm_partida);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTrafego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tráfego";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.TextBox txtKm_partida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPartida;
        private System.Windows.Forms.MaskedTextBox txtChegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKm_chegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}