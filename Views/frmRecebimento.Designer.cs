namespace ERP_Transporte.Views
{
    partial class frmRecebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecebimento));
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRota = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstudante = new System.Windows.Forms.ComboBox();
            this.btRecibo = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(266, 100);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(85, 28);
            this.txtAno.TabIndex = 124;
            this.txtAno.Validating += new System.ComponentModel.CancelEventHandler(this.txtAno_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(198, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 22);
            this.label10.TabIndex = 125;
            this.label10.Text = "Ano:";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(267, 296);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 28);
            this.txtValor.TabIndex = 122;
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
            this.label8.Location = new System.Drawing.Point(188, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 123;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(192, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 121;
            this.label7.Text = "Rota:";
            // 
            // cmbRota
            // 
            this.cmbRota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRota.FormattingEnabled = true;
            this.cmbRota.Location = new System.Drawing.Point(267, 167);
            this.cmbRota.Name = "cmbRota";
            this.cmbRota.Size = new System.Drawing.Size(340, 30);
            this.cmbRota.TabIndex = 120;
            this.cmbRota.SelectedIndexChanged += new System.EventHandler(this.cmbRota_SelectedIndexChanged);
            this.cmbRota.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRota_Validating);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(375, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 117;
            this.txtId.Visible = false;
            // 
            // btSalva
            // 
            this.btSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(519, 434);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 116;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtMes
            // 
            this.txtMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(522, 100);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(85, 28);
            this.txtMes.TabIndex = 128;
            this.txtMes.Validating += new System.ComponentModel.CancelEventHandler(this.txtMes_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(444, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 129;
            this.label1.Text = "Mês:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(149, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 131;
            this.label2.Text = "Estudante:";
            // 
            // cmbEstudante
            // 
            this.cmbEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudante.FormattingEnabled = true;
            this.cmbEstudante.Location = new System.Drawing.Point(266, 231);
            this.cmbEstudante.Name = "cmbEstudante";
            this.cmbEstudante.Size = new System.Drawing.Size(340, 30);
            this.cmbEstudante.TabIndex = 130;
            // 
            // btRecibo
            // 
            this.btRecibo.Enabled = false;
            this.btRecibo.Image = global::ERP_Transporte.Properties.Resources.file_preview_20;
            this.btRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRecibo.Location = new System.Drawing.Point(97, 434);
            this.btRecibo.Name = "btRecibo";
            this.btRecibo.Size = new System.Drawing.Size(287, 60);
            this.btRecibo.TabIndex = 132;
            this.btRecibo.Text = "Recibo";
            this.btRecibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRecibo.UseVisualStyleBackColor = true;
            this.btRecibo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(461, 294);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(145, 28);
            this.txtData.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(402, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 169;
            this.label3.Text = "Data:";
            // 
            // frmRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 528);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRecibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstudante);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRota);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btSalva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recebimento";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRota;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstudante;
        private System.Windows.Forms.Button btRecibo;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label3;
    }
}