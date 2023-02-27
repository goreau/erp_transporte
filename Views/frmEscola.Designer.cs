namespace ERP_Transporte.Views
{
    partial class frmEscola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscola));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbIntegral = new System.Windows.Forms.RadioButton();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.rbManha = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtEspecial = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.btSalva = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Label12
            // 
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.Name = "Label12";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbIntegral);
            this.groupBox4.Controls.Add(this.rbTarde);
            this.groupBox4.Controls.Add(this.rbManha);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.groupBox4.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox4_Validating);
            // 
            // rbIntegral
            // 
            resources.ApplyResources(this.rbIntegral, "rbIntegral");
            this.rbIntegral.Name = "rbIntegral";
            this.rbIntegral.TabStop = true;
            this.rbIntegral.Tag = "3";
            this.rbIntegral.UseVisualStyleBackColor = true;
            this.rbIntegral.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // rbTarde
            // 
            resources.ApplyResources(this.rbTarde, "rbTarde");
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.TabStop = true;
            this.rbTarde.Tag = "2";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // rbManha
            // 
            resources.ApplyResources(this.rbManha, "rbManha");
            this.rbManha.Name = "rbManha";
            this.rbManha.TabStop = true;
            this.rbManha.Tag = "1";
            this.rbManha.UseVisualStyleBackColor = true;
            this.rbManha.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtLink
            // 
            resources.ApplyResources(this.txtLink, "txtLink");
            this.txtLink.Name = "txtLink";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogradouro_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtPeriodo
            // 
            resources.ApplyResources(this.txtPeriodo, "txtPeriodo");
            this.txtPeriodo.Name = "txtPeriodo";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // txtEntrada
            // 
            resources.ApplyResources(this.txtEntrada, "txtEntrada");
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            this.txtEntrada.Validating += new System.ComponentModel.CancelEventHandler(this.txtEntrada_Validating);
            // 
            // txtSaida
            // 
            resources.ApplyResources(this.txtSaida, "txtSaida");
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            this.txtSaida.Validating += new System.ComponentModel.CancelEventHandler(this.txtSaida_Validating);
            // 
            // txtEspecial
            // 
            resources.ApplyResources(this.txtEspecial, "txtEspecial");
            this.txtEspecial.Name = "txtEspecial";
            this.txtEspecial.ValidatingType = typeof(System.DateTime);
            this.txtEspecial.Validating += new System.ComponentModel.CancelEventHandler(this.txtEspecial_Validating);
            // 
            // txtTelefone1
            // 
            resources.ApplyResources(this.txtTelefone1, "txtTelefone1");
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone2
            // 
            resources.ApplyResources(this.txtTelefone2, "txtTelefone2");
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btSalva
            // 
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            resources.ApplyResources(this.btSalva, "btSalva");
            this.btSalva.Name = "btSalva";
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEscola
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.txtEspecial);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmEscola";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbIntegral;
        private System.Windows.Forms.RadioButton rbTarde;
        private System.Windows.Forms.RadioButton rbManha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.MaskedTextBox txtEspecial;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}