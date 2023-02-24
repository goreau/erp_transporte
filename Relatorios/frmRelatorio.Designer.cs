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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.pnFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERP_Transporte.Relatorios.rptListaAlunos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 203);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1651, 755);
            this.reportViewer1.TabIndex = 0;
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
            this.pnFiltro.Size = new System.Drawing.Size(1651, 203);
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
            this.btRelat.Location = new System.Drawing.Point(1378, 66);
            this.btRelat.Name = "btRelat";
            this.btRelat.Size = new System.Drawing.Size(243, 67);
            this.btRelat.TabIndex = 0;
            this.btRelat.Text = "Gerar Relatório";
            this.btRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRelat.UseVisualStyleBackColor = false;
            this.btRelat.Click += new System.EventHandler(this.btRelat_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 958);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
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
    }
}