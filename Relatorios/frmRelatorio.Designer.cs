namespace ERP_Transporte.Relatorios
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.txtFinal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbRota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEscola = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.btRelat = new System.Windows.Forms.Button();
            this.pnLiquidacao = new System.Windows.Forms.Panel();
            this.txtPgtoFim = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPgtoIni = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVencFim = new System.Windows.Forms.MaskedTextBox();
            this.lblDataLiquiFim = new System.Windows.Forms.Label();
            this.txtVencIni = new System.Windows.Forms.MaskedTextBox();
            this.lblDataLiquiIni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.pnFiltro.SuspendLayout();
            this.pnLiquidacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnFiltro.Controls.Add(this.txtFinal);
            this.pnFiltro.Controls.Add(this.label2);
            this.pnFiltro.Controls.Add(this.txtInicio);
            this.pnFiltro.Controls.Add(this.label11);
            this.pnFiltro.Controls.Add(this.label18);
            this.pnFiltro.Controls.Add(this.cmbRota);
            this.pnFiltro.Controls.Add(this.label1);
            this.pnFiltro.Controls.Add(this.cmbEscola);
            this.pnFiltro.Controls.Add(this.label6);
            this.pnFiltro.Controls.Add(this.cmbVeiculo);
            this.pnFiltro.Controls.Add(this.label7);
            this.pnFiltro.Controls.Add(this.cmbFornecedor);
            this.pnFiltro.Controls.Add(this.btRelat);
            this.pnFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(1872, 185);
            this.pnFiltro.TabIndex = 1;
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(1165, 115);
            this.txtFinal.Mask = "00/00/0000";
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(120, 28);
            this.txtFinal.TabIndex = 162;
            this.txtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1059, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 163;
            this.label2.Text = "Data Final:";
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(1165, 37);
            this.txtInicio.Mask = "00/00/0000";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(120, 28);
            this.txtInicio.TabIndex = 160;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1053, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 22);
            this.label11.TabIndex = 161;
            this.label11.Text = "Data Inicial:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(543, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 159;
            this.label18.Text = "Trajeto:";
            // 
            // cmbRota
            // 
            this.cmbRota.FormattingEnabled = true;
            this.cmbRota.Location = new System.Drawing.Point(621, 117);
            this.cmbRota.Name = "cmbRota";
            this.cmbRota.Size = new System.Drawing.Size(340, 28);
            this.cmbRota.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(62, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 157;
            this.label1.Text = "Escola:";
            // 
            // cmbEscola
            // 
            this.cmbEscola.FormattingEnabled = true;
            this.cmbEscola.Location = new System.Drawing.Point(152, 117);
            this.cmbEscola.Name = "cmbEscola";
            this.cmbEscola.Size = new System.Drawing.Size(342, 28);
            this.cmbEscola.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(62, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 155;
            this.label6.Text = "Veículo:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(152, 37);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(342, 30);
            this.cmbVeiculo.TabIndex = 154;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(508, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 153;
            this.label7.Text = "Fornecedor:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(621, 40);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(340, 30);
            this.cmbFornecedor.TabIndex = 152;
            // 
            // btRelat
            // 
            this.btRelat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRelat.BackColor = System.Drawing.Color.LimeGreen;
            this.btRelat.Image = global::ERP_Transporte.Properties.Resources.print_24;
            this.btRelat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelat.Location = new System.Drawing.Point(1463, 56);
            this.btRelat.Name = "btRelat";
            this.btRelat.Size = new System.Drawing.Size(243, 67);
            this.btRelat.TabIndex = 0;
            this.btRelat.Text = "Gerar Relatório";
            this.btRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRelat.UseVisualStyleBackColor = false;
            this.btRelat.Click += new System.EventHandler(this.btRelat_Click);
            // 
            // pnLiquidacao
            // 
            this.pnLiquidacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnLiquidacao.Controls.Add(this.label12);
            this.pnLiquidacao.Controls.Add(this.cmbSituacao);
            this.pnLiquidacao.Controls.Add(this.txtPgtoFim);
            this.pnLiquidacao.Controls.Add(this.label8);
            this.pnLiquidacao.Controls.Add(this.txtPgtoIni);
            this.pnLiquidacao.Controls.Add(this.label9);
            this.pnLiquidacao.Controls.Add(this.txtVencFim);
            this.pnLiquidacao.Controls.Add(this.lblDataLiquiFim);
            this.pnLiquidacao.Controls.Add(this.txtVencIni);
            this.pnLiquidacao.Controls.Add(this.lblDataLiquiIni);
            this.pnLiquidacao.Controls.Add(this.label5);
            this.pnLiquidacao.Controls.Add(this.cmbCategoria);
            this.pnLiquidacao.Controls.Add(this.label10);
            this.pnLiquidacao.Controls.Add(this.comboBox4);
            this.pnLiquidacao.Controls.Add(this.button1);
            this.pnLiquidacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLiquidacao.Location = new System.Drawing.Point(0, 185);
            this.pnLiquidacao.Name = "pnLiquidacao";
            this.pnLiquidacao.Size = new System.Drawing.Size(1872, 183);
            this.pnLiquidacao.TabIndex = 164;
            // 
            // txtPgtoFim
            // 
            this.txtPgtoFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPgtoFim.Location = new System.Drawing.Point(969, 108);
            this.txtPgtoFim.Mask = "00/00/0000";
            this.txtPgtoFim.Name = "txtPgtoFim";
            this.txtPgtoFim.Size = new System.Drawing.Size(120, 28);
            this.txtPgtoFim.TabIndex = 166;
            this.txtPgtoFim.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(863, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 167;
            this.label8.Text = "Pgto Final:";
            // 
            // txtPgtoIni
            // 
            this.txtPgtoIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPgtoIni.Location = new System.Drawing.Point(969, 30);
            this.txtPgtoIni.Mask = "00/00/0000";
            this.txtPgtoIni.Name = "txtPgtoIni";
            this.txtPgtoIni.Size = new System.Drawing.Size(120, 28);
            this.txtPgtoIni.TabIndex = 164;
            this.txtPgtoIni.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(857, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 165;
            this.label9.Text = "Pgto Inicial:";
            // 
            // txtVencFim
            // 
            this.txtVencFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencFim.Location = new System.Drawing.Point(698, 108);
            this.txtVencFim.Mask = "00/00/0000";
            this.txtVencFim.Name = "txtVencFim";
            this.txtVencFim.Size = new System.Drawing.Size(120, 28);
            this.txtVencFim.TabIndex = 162;
            this.txtVencFim.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataLiquiFim
            // 
            this.lblDataLiquiFim.AutoSize = true;
            this.lblDataLiquiFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLiquiFim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDataLiquiFim.Location = new System.Drawing.Point(538, 116);
            this.lblDataLiquiFim.Name = "lblDataLiquiFim";
            this.lblDataLiquiFim.Size = new System.Drawing.Size(153, 22);
            this.lblDataLiquiFim.TabIndex = 163;
            this.lblDataLiquiFim.Text = "Vencimento Final:";
            // 
            // txtVencIni
            // 
            this.txtVencIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencIni.Location = new System.Drawing.Point(698, 33);
            this.txtVencIni.Mask = "00/00/0000";
            this.txtVencIni.Name = "txtVencIni";
            this.txtVencIni.Size = new System.Drawing.Size(120, 28);
            this.txtVencIni.TabIndex = 160;
            this.txtVencIni.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataLiquiIni
            // 
            this.lblDataLiquiIni.AutoSize = true;
            this.lblDataLiquiIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLiquiIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDataLiquiIni.Location = new System.Drawing.Point(532, 39);
            this.lblDataLiquiIni.Name = "lblDataLiquiIni";
            this.lblDataLiquiIni.Size = new System.Drawing.Size(159, 22);
            this.lblDataLiquiIni.TabIndex = 161;
            this.lblDataLiquiIni.Text = "Vencimento Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(53, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 159;
            this.label5.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(152, 113);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(340, 28);
            this.cmbCategoria.TabIndex = 158;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(39, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 22);
            this.label10.TabIndex = 153;
            this.label10.Text = "Fornecedor:";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(152, 36);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(340, 30);
            this.comboBox4.TabIndex = 152;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Image = global::ERP_Transporte.Properties.Resources.print_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1516, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Relatório";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btRelat_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP_Transporte.Relatorios.rptListaAlunos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(97, 461);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1991, 65535);
            this.reportViewer1.TabIndex = 165;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(1118, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 33);
            this.label12.TabIndex = 169;
            this.label12.Text = "Situação:";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(1231, 71);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(191, 30);
            this.cmbSituacao.TabIndex = 168;
            this.cmbSituacao.SelectedIndexChanged += new System.EventHandler(this.cmbSituacao_SelectedIndexChanged);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 938);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnLiquidacao);
            this.Controls.Add(this.pnFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.pnLiquidacao.ResumeLayout(false);
            this.pnLiquidacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnFiltro;
        private System.Windows.Forms.Button btRelat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEscola;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbRota;
        private System.Windows.Forms.MaskedTextBox txtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnLiquidacao;
        private System.Windows.Forms.MaskedTextBox txtPgtoFim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtPgtoIni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtVencFim;
        private System.Windows.Forms.Label lblDataLiquiFim;
        private System.Windows.Forms.MaskedTextBox txtVencIni;
        private System.Windows.Forms.Label lblDataLiquiIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSituacao;
    }
}