namespace ERP_Transporte.Views
{
    partial class frmAuxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuxiliar));
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbDeslocamento = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbFuncao = new System.Windows.Forms.RadioButton();
            this.rbRamo = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSalva = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDados.Location = new System.Drawing.Point(0, 340);
            this.dgDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgDados.Name = "dgDados";
            this.dgDados.RowHeadersWidth = 62;
            this.dgDados.Size = new System.Drawing.Size(802, 352);
            this.dgDados.TabIndex = 0;
            this.dgDados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_RowEnter);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(380, 22);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(55, 28);
            this.txtTipo.TabIndex = 71;
            this.txtTipo.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbDeslocamento);
            this.groupBox4.Controls.Add(this.rbCategoria);
            this.groupBox4.Controls.Add(this.rbFuncao);
            this.groupBox4.Controls.Add(this.rbRamo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(93, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 106);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo";
            // 
            // rbDeslocamento
            // 
            this.rbDeslocamento.AutoSize = true;
            this.rbDeslocamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbDeslocamento.Location = new System.Drawing.Point(422, 45);
            this.rbDeslocamento.Name = "rbDeslocamento";
            this.rbDeslocamento.Size = new System.Drawing.Size(149, 26);
            this.rbDeslocamento.TabIndex = 4;
            this.rbDeslocamento.TabStop = true;
            this.rbDeslocamento.Tag = "4";
            this.rbDeslocamento.Text = "Deslocamento";
            this.rbDeslocamento.UseVisualStyleBackColor = true;
            this.rbDeslocamento.CheckedChanged += new System.EventHandler(this.rbRamo_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbCategoria.Location = new System.Drawing.Point(286, 45);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(113, 26);
            this.rbCategoria.TabIndex = 3;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Tag = "3";
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbRamo_CheckedChanged);
            // 
            // rbFuncao
            // 
            this.rbFuncao.AutoSize = true;
            this.rbFuncao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbFuncao.Location = new System.Drawing.Point(156, 45);
            this.rbFuncao.Name = "rbFuncao";
            this.rbFuncao.Size = new System.Drawing.Size(95, 26);
            this.rbFuncao.TabIndex = 2;
            this.rbFuncao.TabStop = true;
            this.rbFuncao.Tag = "2";
            this.rbFuncao.Text = "Função";
            this.rbFuncao.UseVisualStyleBackColor = true;
            this.rbFuncao.CheckedChanged += new System.EventHandler(this.rbRamo_CheckedChanged);
            // 
            // rbRamo
            // 
            this.rbRamo.AutoSize = true;
            this.rbRamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbRamo.Location = new System.Drawing.Point(44, 45);
            this.rbRamo.Name = "rbRamo";
            this.rbRamo.Size = new System.Drawing.Size(82, 26);
            this.rbRamo.TabIndex = 1;
            this.rbRamo.TabStop = true;
            this.rbRamo.Tag = "1";
            this.rbRamo.Text = "Ramo";
            this.rbRamo.UseVisualStyleBackColor = true;
            this.rbRamo.CheckedChanged += new System.EventHandler(this.rbRamo_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(194, 188);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(499, 28);
            this.txtNome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(90, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Descrição:";
            // 
            // btSalva
            // 
            this.btSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(93, 262);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(178, 52);
            this.btSalva.TabIndex = 3;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click_1);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = global::ERP_Transporte.Properties.Resources.edite_24;
            this.btEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btEdit.Location = new System.Drawing.Point(304, 262);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(178, 52);
            this.btEdit.TabIndex = 82;
            this.btEdit.Text = "Editar";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::ERP_Transporte.Properties.Resources.delete_24;
            this.btDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDelete.Location = new System.Drawing.Point(516, 262);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(178, 52);
            this.btDelete.TabIndex = 83;
            this.btDelete.Text = "Excluir";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // frmAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 692);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auxiliar";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbFuncao;
        private System.Windows.Forms.RadioButton rbRamo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.RadioButton rbDeslocamento;
    }
}