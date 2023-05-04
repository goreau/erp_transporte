namespace ERP_Transporte.Views
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgConsulta
            // 
            this.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgConsulta.Location = new System.Drawing.Point(0, 0);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.RowHeadersWidth = 62;
            this.dgConsulta.RowTemplate.Height = 28;
            this.dgConsulta.Size = new System.Drawing.Size(1530, 573);
            this.dgConsulta.TabIndex = 0;
            this.dgConsulta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dgConsulta.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsulta_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btFiltrar);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 82);
            this.panel1.TabIndex = 3;
            // 
            // btClear
            // 
            this.btClear.Image = global::ERP_Transporte.Properties.Resources.grid_16;
            this.btClear.Location = new System.Drawing.Point(243, 18);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(212, 49);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Remover ";
            this.btClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Image = global::ERP_Transporte.Properties.Resources.filter_16;
            this.btFiltrar.Location = new System.Drawing.Point(12, 18);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(212, 49);
            this.btFiltrar.TabIndex = 3;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Image = global::ERP_Transporte.Properties.Resources.delete_24;
            this.btDelete.Location = new System.Drawing.Point(1134, 18);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(204, 49);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Excluir";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.Image = global::ERP_Transporte.Properties.Resources.edite_24;
            this.btEdit.Location = new System.Drawing.Point(821, 18);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(204, 49);
            this.btEdit.TabIndex = 0;
            this.btEdit.Text = "Editar";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 655);
            this.Controls.Add(this.dgConsulta);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.Activated += new System.EventHandler(this.frmConsulta_Load);
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btClear;
    }
}