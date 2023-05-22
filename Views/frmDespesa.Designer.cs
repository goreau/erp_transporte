namespace ERP_Transporte.Views
{
    partial class frmDespesa
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMetodoPgto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPix = new System.Windows.Forms.RadioButton();
            this.rbBoleto = new System.Windows.Forms.RadioButton();
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.txtTipoPgto = new System.Windows.Forms.TextBox();
            this.grpFormaPgto = new System.Windows.Forms.GroupBox();
            this.rbParcelado = new System.Windows.Forms.RadioButton();
            this.rbVista = new System.Windows.Forms.RadioButton();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.txtIdDetail = new System.Windows.Forms.TextBox();
            this.txtParcelaDetail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtVencimentoDetail = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDetail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btSalva = new System.Windows.Forms.Button();
            this.btSaveDetail = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpFormaPgto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.txtMetodoPgto);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTipoPgto);
            this.splitContainer1.Panel1.Controls.Add(this.grpFormaPgto);
            this.splitContainer1.Panel1.Controls.Add(this.txtNF);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtData);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtValor);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFornecedor);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.txtId);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1417, 758);
            this.splitContainer1.SplitterDistance = 688;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // txtMetodoPgto
            // 
            this.txtMetodoPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPgto.Location = new System.Drawing.Point(67, 541);
            this.txtMetodoPgto.Name = "txtMetodoPgto";
            this.txtMetodoPgto.Size = new System.Drawing.Size(55, 28);
            this.txtMetodoPgto.TabIndex = 204;
            this.txtMetodoPgto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPix);
            this.groupBox1.Controls.Add(this.rbBoleto);
            this.groupBox1.Controls.Add(this.rbCartao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(159, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 87);
            this.groupBox1.TabIndex = 203;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método Pgto";
            // 
            // rbPix
            // 
            this.rbPix.AutoSize = true;
            this.rbPix.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbPix.Location = new System.Drawing.Point(292, 37);
            this.rbPix.Name = "rbPix";
            this.rbPix.Size = new System.Drawing.Size(60, 26);
            this.rbPix.TabIndex = 4;
            this.rbPix.Tag = "3";
            this.rbPix.Text = "Pix";
            this.rbPix.UseVisualStyleBackColor = true;
            this.rbPix.CheckedChanged += new System.EventHandler(this.rbCartão_CheckedChanged);
            // 
            // rbBoleto
            // 
            this.rbBoleto.AutoSize = true;
            this.rbBoleto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbBoleto.Location = new System.Drawing.Point(168, 35);
            this.rbBoleto.Name = "rbBoleto";
            this.rbBoleto.Size = new System.Drawing.Size(86, 26);
            this.rbBoleto.TabIndex = 3;
            this.rbBoleto.Tag = "2";
            this.rbBoleto.Text = "Boleto";
            this.rbBoleto.UseVisualStyleBackColor = true;
            this.rbBoleto.CheckedChanged += new System.EventHandler(this.rbCartão_CheckedChanged);
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCartao.Location = new System.Drawing.Point(44, 35);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(89, 26);
            this.rbCartao.TabIndex = 1;
            this.rbCartao.TabStop = true;
            this.rbCartao.Tag = "1";
            this.rbCartao.Text = "Cartão";
            this.rbCartao.UseVisualStyleBackColor = true;
            this.rbCartao.CheckedChanged += new System.EventHandler(this.rbCartão_CheckedChanged);
            // 
            // txtTipoPgto
            // 
            this.txtTipoPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPgto.Location = new System.Drawing.Point(81, 449);
            this.txtTipoPgto.Name = "txtTipoPgto";
            this.txtTipoPgto.Size = new System.Drawing.Size(55, 28);
            this.txtTipoPgto.TabIndex = 202;
            this.txtTipoPgto.Visible = false;
            // 
            // grpFormaPgto
            // 
            this.grpFormaPgto.Controls.Add(this.rbParcelado);
            this.grpFormaPgto.Controls.Add(this.rbVista);
            this.grpFormaPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormaPgto.Location = new System.Drawing.Point(159, 402);
            this.grpFormaPgto.Name = "grpFormaPgto";
            this.grpFormaPgto.Size = new System.Drawing.Size(426, 87);
            this.grpFormaPgto.TabIndex = 201;
            this.grpFormaPgto.TabStop = false;
            this.grpFormaPgto.Text = "Tipo Pgto";
            // 
            // rbParcelado
            // 
            this.rbParcelado.AutoSize = true;
            this.rbParcelado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbParcelado.Location = new System.Drawing.Point(246, 35);
            this.rbParcelado.Name = "rbParcelado";
            this.rbParcelado.Size = new System.Drawing.Size(116, 26);
            this.rbParcelado.TabIndex = 3;
            this.rbParcelado.Tag = "2";
            this.rbParcelado.Text = "Parcelado";
            this.rbParcelado.UseVisualStyleBackColor = true;
            this.rbParcelado.CheckedChanged += new System.EventHandler(this.rbParcelado_CheckedChanged);
            // 
            // rbVista
            // 
            this.rbVista.AutoSize = true;
            this.rbVista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbVista.Location = new System.Drawing.Point(44, 35);
            this.rbVista.Name = "rbVista";
            this.rbVista.Size = new System.Drawing.Size(92, 26);
            this.rbVista.TabIndex = 1;
            this.rbVista.TabStop = true;
            this.rbVista.Tag = "1";
            this.rbVista.Text = "A Vista";
            this.rbVista.UseVisualStyleBackColor = true;
            this.rbVista.CheckedChanged += new System.EventHandler(this.rbParcelado_CheckedChanged);
            // 
            // txtNF
            // 
            this.txtNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNF.Location = new System.Drawing.Point(231, 255);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(120, 28);
            this.txtNF.TabIndex = 199;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(103, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 200;
            this.label3.Text = "Nota Fiscal:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(231, 58);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(145, 28);
            this.txtData.TabIndex = 197;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(155, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 198;
            this.label2.Text = "Data:";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(463, 255);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 28);
            this.txtValor.TabIndex = 195;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(389, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 196;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(100, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 194;
            this.label7.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(231, 125);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(354, 30);
            this.cmbFornecedor.TabIndex = 193;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(114, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 192;
            this.label1.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(230, 190);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(355, 30);
            this.cmbCategoria.TabIndex = 191;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(543, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 190;
            this.txtId.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.btSaveDetail);
            this.splitContainer2.Panel1.Controls.Add(this.txtValorDetail);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.dtVencimentoDetail);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txtParcelaDetail);
            this.splitContainer2.Panel1.Controls.Add(this.txtIdDetail);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgDetails);
            this.splitContainer2.Size = new System.Drawing.Size(725, 758);
            this.splitContainer2.SplitterDistance = 196;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Resize += new System.EventHandler(this.splitContainer2_Resize);
            // 
            // dgDetails
            // 
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetails.Location = new System.Drawing.Point(0, 0);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.RowHeadersWidth = 62;
            this.dgDetails.RowTemplate.Height = 28;
            this.dgDetails.Size = new System.Drawing.Size(721, 554);
            this.dgDetails.TabIndex = 0;
            this.dgDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetails_RowEnter);
            // 
            // txtIdDetail
            // 
            this.txtIdDetail.Location = new System.Drawing.Point(49, 124);
            this.txtIdDetail.Name = "txtIdDetail";
            this.txtIdDetail.Size = new System.Drawing.Size(64, 26);
            this.txtIdDetail.TabIndex = 0;
            this.txtIdDetail.Visible = false;
            // 
            // txtParcelaDetail
            // 
            this.txtParcelaDetail.Location = new System.Drawing.Point(94, 68);
            this.txtParcelaDetail.Name = "txtParcelaDetail";
            this.txtParcelaDetail.Size = new System.Drawing.Size(100, 26);
            this.txtParcelaDetail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parcela:";
            // 
            // dtVencimentoDetail
            // 
            this.dtVencimentoDetail.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimentoDetail.Location = new System.Drawing.Point(348, 71);
            this.dtVencimentoDetail.Name = "dtVencimentoDetail";
            this.dtVencimentoDetail.Size = new System.Drawing.Size(135, 26);
            this.dtVencimentoDetail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor:";
            // 
            // txtValorDetail
            // 
            this.txtValorDetail.Location = new System.Drawing.Point(584, 74);
            this.txtValorDetail.Name = "txtValorDetail";
            this.txtValorDetail.Size = new System.Drawing.Size(100, 26);
            this.txtValorDetail.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btSalva);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 111);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(299, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Parcelas";
            // 
            // btSalva
            // 
            this.btSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(341, 25);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 189;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // btSaveDetail
            // 
            this.btSaveDetail.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSaveDetail.Location = new System.Drawing.Point(444, 124);
            this.btSaveDetail.Name = "btSaveDetail";
            this.btSaveDetail.Size = new System.Drawing.Size(196, 50);
            this.btSaveDetail.TabIndex = 7;
            this.btSaveDetail.Text = "Adicionar";
            this.btSaveDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSaveDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSaveDetail.UseVisualStyleBackColor = true;
            this.btSaveDetail.Click += new System.EventHandler(this.btSaveDetail_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(234, 315);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(351, 63);
            this.txtDescricao.TabIndex = 205;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 206;
            this.label10.Text = "Descrição:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFormaPgto.ResumeLayout(false);
            this.grpFormaPgto.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtMetodoPgto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPix;
        private System.Windows.Forms.RadioButton rbBoleto;
        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.TextBox txtTipoPgto;
        private System.Windows.Forms.GroupBox grpFormaPgto;
        private System.Windows.Forms.RadioButton rbParcelado;
        private System.Windows.Forms.RadioButton rbVista;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btSaveDetail;
        private System.Windows.Forms.TextBox txtValorDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtVencimentoDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParcelaDetail;
        private System.Windows.Forms.TextBox txtIdDetail;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}