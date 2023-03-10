namespace ERP_Transporte.Views
{
    partial class frmEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudante));
            this.txtTel_pai = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtRa_rg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbIntegral = new System.Windows.Forms.RadioButton();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.rbManha = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEscola = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel_mae = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTel_resp = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtResp_qualif = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbId_rota = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTel_pai
            // 
            this.txtTel_pai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTel_pai.Location = new System.Drawing.Point(596, 377);
            this.txtTel_pai.Mask = "(99) 90000-0000";
            this.txtTel_pai.Name = "txtTel_pai";
            this.txtTel_pai.Size = new System.Drawing.Size(154, 28);
            this.txtTel_pai.TabIndex = 9;
            this.txtTel_pai.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(735, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 28);
            this.txtId.TabIndex = 56;
            this.txtId.Visible = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPeriodo.Location = new System.Drawing.Point(613, 254);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(55, 28);
            this.txtPeriodo.TabIndex = 55;
            this.txtPeriodo.Visible = false;
            // 
            // txtRa_rg
            // 
            this.txtRa_rg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRa_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRa_rg.Location = new System.Drawing.Point(185, 314);
            this.txtRa_rg.Name = "txtRa_rg";
            this.txtRa_rg.Size = new System.Drawing.Size(153, 28);
            this.txtRa_rg.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(90, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "RA/RG:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBairro.Location = new System.Drawing.Point(184, 128);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(349, 28);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(100, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumero.Location = new System.Drawing.Point(655, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 28);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(567, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLogradouro.Location = new System.Drawing.Point(185, 75);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(349, 28);
            this.txtLogradouro.TabIndex = 1;
            this.txtLogradouro.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogradouro_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Logradouro:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbIntegral);
            this.groupBox4.Controls.Add(this.rbTarde);
            this.groupBox4.Controls.Add(this.rbManha);
            this.groupBox4.Location = new System.Drawing.Point(184, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 60);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Período";
            this.groupBox4.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox4_Validating);
            // 
            // rbIntegral
            // 
            this.rbIntegral.AutoSize = true;
            this.rbIntegral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbIntegral.Location = new System.Drawing.Point(278, 25);
            this.rbIntegral.Name = "rbIntegral";
            this.rbIntegral.Size = new System.Drawing.Size(88, 24);
            this.rbIntegral.TabIndex = 3;
            this.rbIntegral.TabStop = true;
            this.rbIntegral.Tag = "3";
            this.rbIntegral.Text = "Integral";
            this.rbIntegral.UseVisualStyleBackColor = true;
            this.rbIntegral.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // rbTarde
            // 
            this.rbTarde.AutoSize = true;
            this.rbTarde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbTarde.Location = new System.Drawing.Point(172, 25);
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.Size = new System.Drawing.Size(75, 24);
            this.rbTarde.TabIndex = 2;
            this.rbTarde.TabStop = true;
            this.rbTarde.Tag = "2";
            this.rbTarde.Text = "Tarde";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // rbManha
            // 
            this.rbManha.AutoSize = true;
            this.rbManha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbManha.Location = new System.Drawing.Point(44, 25);
            this.rbManha.Name = "rbManha";
            this.rbManha.Size = new System.Drawing.Size(83, 24);
            this.rbManha.TabIndex = 1;
            this.rbManha.TabStop = true;
            this.rbManha.Tag = "1";
            this.rbManha.Text = "Manhã";
            this.rbManha.UseVisualStyleBackColor = true;
            this.rbManha.CheckedChanged += new System.EventHandler(this.rbManha_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(502, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNome.Location = new System.Drawing.Point(184, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(506, 28);
            this.txtNome.TabIndex = 0;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome:";
            // 
            // cmbEscola
            // 
            this.cmbEscola.FormattingEnabled = true;
            this.cmbEscola.Location = new System.Drawing.Point(184, 183);
            this.cmbEscola.Name = "cmbEscola";
            this.cmbEscola.Size = new System.Drawing.Size(316, 28);
            this.cmbEscola.TabIndex = 4;
            this.cmbEscola.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEscola_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(94, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 58;
            this.label6.Text = "Escola:";
            // 
            // txtDt_nascimento
            // 
            this.txtDt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDt_nascimento.Location = new System.Drawing.Point(596, 311);
            this.txtDt_nascimento.Mask = "00/00/0000";
            this.txtDt_nascimento.Name = "txtDt_nascimento";
            this.txtDt_nascimento.Size = new System.Drawing.Size(154, 28);
            this.txtDt_nascimento.TabIndex = 7;
            this.txtDt_nascimento.ValidatingType = typeof(System.DateTime);
            this.txtDt_nascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDt_nascimento_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(482, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 22);
            this.label11.TabIndex = 60;
            this.label11.Text = "Nascimento:";
            // 
            // btSalva
            // 
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(454, 776);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 23;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtPai
            // 
            this.txtPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPai.Location = new System.Drawing.Point(184, 377);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(316, 28);
            this.txtPai.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(120, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 22);
            this.label13.TabIndex = 61;
            this.label13.Text = "Pai:";
            // 
            // txtMae
            // 
            this.txtMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMae.Location = new System.Drawing.Point(184, 436);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(316, 28);
            this.txtMae.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(120, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mãe:";
            // 
            // txtTel_mae
            // 
            this.txtTel_mae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTel_mae.Location = new System.Drawing.Point(596, 436);
            this.txtTel_mae.Mask = "(99) 90000-0000";
            this.txtTel_mae.Name = "txtTel_mae";
            this.txtTel_mae.Size = new System.Drawing.Size(154, 28);
            this.txtTel_mae.TabIndex = 11;
            this.txtTel_mae.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(502, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 22);
            this.label14.TabIndex = 64;
            this.label14.Text = "Telefone:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResponsavel.Location = new System.Drawing.Point(184, 493);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(316, 28);
            this.txtResponsavel.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(42, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 22);
            this.label15.TabIndex = 69;
            this.label15.Text = "Responsável:";
            // 
            // txtTel_resp
            // 
            this.txtTel_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTel_resp.Location = new System.Drawing.Point(596, 493);
            this.txtTel_resp.Mask = "(99) 90000-0000";
            this.txtTel_resp.Name = "txtTel_resp";
            this.txtTel_resp.Size = new System.Drawing.Size(154, 28);
            this.txtTel_resp.TabIndex = 13;
            this.txtTel_resp.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(502, 499);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 22);
            this.label16.TabIndex = 68;
            this.label16.Text = "Telefone:";
            // 
            // txtResp_qualif
            // 
            this.txtResp_qualif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResp_qualif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtResp_qualif.Location = new System.Drawing.Point(184, 551);
            this.txtResp_qualif.Name = "txtResp_qualif";
            this.txtResp_qualif.Size = new System.Drawing.Size(316, 28);
            this.txtResp_qualif.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(16, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 22);
            this.label17.TabIndex = 71;
            this.label17.Text = "Qualidade Resp:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(94, 611);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 74;
            this.label18.Text = "Trajeto:";
            // 
            // cmbId_rota
            // 
            this.cmbId_rota.FormattingEnabled = true;
            this.cmbId_rota.Location = new System.Drawing.Point(184, 605);
            this.cmbId_rota.Name = "cmbId_rota";
            this.cmbId_rota.Size = new System.Drawing.Size(506, 28);
            this.cmbId_rota.TabIndex = 21;
            this.cmbId_rota.Validating += new System.ComponentModel.CancelEventHandler(this.cmbId_rota_Validating);
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(184, 668);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(564, 67);
            this.txtObs.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(112, 668);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 22);
            this.label22.TabIndex = 88;
            this.label22.Text = "Obs:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSerie.Location = new System.Drawing.Point(652, 183);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(96, 28);
            this.txtSerie.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(588, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 90;
            this.label8.Text = "Série:";
            // 
            // frmEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 877);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbId_rota);
            this.Controls.Add(this.txtResp_qualif);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTel_resp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel_mae);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDt_nascimento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEscola);
            this.Controls.Add(this.txtTel_pai);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtRa_rg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSalva);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudante";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtTel_pai;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtRa_rg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbIntegral;
        private System.Windows.Forms.RadioButton rbTarde;
        private System.Windows.Forms.RadioButton rbManha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEscola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDt_nascimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTel_mae;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtTel_resp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtResp_qualif;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbId_rota;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label8;
    }
}