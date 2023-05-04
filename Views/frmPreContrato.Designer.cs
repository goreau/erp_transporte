namespace ERP_Transporte.Views
{
    partial class frmPreContrato
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btContrato = new System.Windows.Forms.Button();
            this.btSalva = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEmissor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEst_civil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaturalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrajeto = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbIdaevolta = new System.Windows.Forms.RadioButton();
            this.rbVolta = new System.Windows.Forms.RadioButton();
            this.rbIda = new System.Windows.Forms.RadioButton();
            this.txtTrajeto_esp = new System.Windows.Forms.TextBox();
            this.lbTraj_esp = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.txtDt_inativo = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btContrato);
            this.panel2.Controls.Add(this.btSalva);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 743);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 98);
            this.panel2.TabIndex = 1;
            // 
            // btContrato
            // 
            this.btContrato.Enabled = false;
            this.btContrato.Image = global::ERP_Transporte.Properties.Resources.file_preview_20;
            this.btContrato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btContrato.Location = new System.Drawing.Point(245, 19);
            this.btContrato.Name = "btContrato";
            this.btContrato.Size = new System.Drawing.Size(297, 60);
            this.btContrato.TabIndex = 91;
            this.btContrato.Text = "Contrato";
            this.btContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btContrato.UseVisualStyleBackColor = true;
            this.btContrato.Click += new System.EventHandler(this.btContrato_Click);
            // 
            // btSalva
            // 
            this.btSalva.Image = global::ERP_Transporte.Properties.Resources.selecionado_24;
            this.btSalva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalva.Location = new System.Drawing.Point(642, 19);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(297, 60);
            this.btSalva.TabIndex = 20;
            this.btSalva.Text = "Salvar";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(922, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 26);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // cmbAluno
            // 
            this.cmbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(211, 57);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(604, 30);
            this.cmbAluno.TabIndex = 1;
            this.cmbAluno.SelectedIndexChanged += new System.EventHandler(this.cmbAluno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dados para geração de contrato";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(771, 414);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(149, 26);
            this.txtCpf.TabIndex = 13;
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(166, 417);
            this.txtRg.Mask = "90.000.000-aa";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(128, 26);
            this.txtRg.TabIndex = 11;
            this.txtRg.Validating += new System.ComponentModel.CancelEventHandler(this.txtRg_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 22);
            this.label11.TabIndex = 143;
            this.label11.Text = "Dia Vencimento:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(481, 494);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(96, 26);
            this.txtDia.TabIndex = 15;
            this.txtDia.Validating += new System.ComponentModel.CancelEventHandler(this.txtDia_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 141;
            this.label10.Text = "Valor Total:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(166, 497);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 26);
            this.txtValor.TabIndex = 14;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBairro.Location = new System.Drawing.Point(809, 214);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(349, 28);
            this.txtBairro.TabIndex = 5;
            this.txtBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtBairro_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(725, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 139;
            this.label7.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumero.Location = new System.Drawing.Point(616, 214);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 28);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(528, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 138;
            this.label8.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLogradouro.Location = new System.Drawing.Point(166, 214);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(349, 28);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogradouro_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(36, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 137;
            this.label9.Text = "Logradouro:";
            // 
            // txtDt_nascimento
            // 
            this.txtDt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDt_nascimento.Location = new System.Drawing.Point(1004, 276);
            this.txtDt_nascimento.Mask = "00/00/0000";
            this.txtDt_nascimento.Name = "txtDt_nascimento";
            this.txtDt_nascimento.Size = new System.Drawing.Size(154, 28);
            this.txtDt_nascimento.TabIndex = 8;
            this.txtDt_nascimento.ValidatingType = typeof(System.DateTime);
            this.txtDt_nascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDt_nascimento_Validating);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(890, 279);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 22);
            this.label24.TabIndex = 133;
            this.label24.Text = "Nascimento:";
            // 
            // txtEmissor
            // 
            this.txtEmissor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmissor.Location = new System.Drawing.Point(481, 412);
            this.txtEmissor.Name = "txtEmissor";
            this.txtEmissor.Size = new System.Drawing.Size(96, 28);
            this.txtEmissor.TabIndex = 12;
            this.txtEmissor.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmissor_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(339, 415);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 22);
            this.label23.TabIndex = 131;
            this.label23.Text = "Orgão Emissor:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(700, 417);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 22);
            this.label21.TabIndex = 129;
            this.label21.Text = "CPF:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(102, 415);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 22);
            this.label20.TabIndex = 128;
            this.label20.Text = "RG:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(64, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 127;
            this.label12.Text = "Est Civil:";
            // 
            // cmbEst_civil
            // 
            this.cmbEst_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEst_civil.FormattingEnabled = true;
            this.cmbEst_civil.Location = new System.Drawing.Point(166, 348);
            this.cmbEst_civil.Name = "cmbEst_civil";
            this.cmbEst_civil.Size = new System.Drawing.Size(200, 30);
            this.cmbEst_civil.TabIndex = 9;
            this.cmbEst_civil.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEst_civil_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "Profissão:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.Location = new System.Drawing.Point(629, 348);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(291, 28);
            this.txtProfissao.TabIndex = 10;
            this.txtProfissao.Validating += new System.ComponentModel.CancelEventHandler(this.txtProfissao_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 123;
            this.label5.Text = "Naturalidade:";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNaturalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturalidade.Location = new System.Drawing.Point(521, 276);
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(291, 28);
            this.txtNaturalidade.TabIndex = 7;
            this.txtNaturalidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaturalidade_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 121;
            this.label4.Text = "Nacionalidade:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.Location = new System.Drawing.Point(166, 276);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(200, 28);
            this.txtNacionalidade.TabIndex = 6;
            this.txtNacionalidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtNacionalidade_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 119;
            this.label3.Text = "Contratante:";
            // 
            // txtTrajeto
            // 
            this.txtTrajeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTrajeto.Location = new System.Drawing.Point(68, 581);
            this.txtTrajeto.Name = "txtTrajeto";
            this.txtTrajeto.Size = new System.Drawing.Size(55, 28);
            this.txtTrajeto.TabIndex = 145;
            this.txtTrajeto.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbOutro);
            this.groupBox4.Controls.Add(this.rbIdaevolta);
            this.groupBox4.Controls.Add(this.rbVolta);
            this.groupBox4.Controls.Add(this.rbIda);
            this.groupBox4.Location = new System.Drawing.Point(166, 556);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 78);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trajeto";
            this.groupBox4.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox4_Validating);
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbOutro.Location = new System.Drawing.Point(337, 25);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(74, 24);
            this.rbOutro.TabIndex = 4;
            this.rbOutro.TabStop = true;
            this.rbOutro.Tag = "4";
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            this.rbOutro.CheckedChanged += new System.EventHandler(this.rbIda_CheckedChanged);
            // 
            // rbIdaevolta
            // 
            this.rbIdaevolta.AutoSize = true;
            this.rbIdaevolta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbIdaevolta.Location = new System.Drawing.Point(196, 25);
            this.rbIdaevolta.Name = "rbIdaevolta";
            this.rbIdaevolta.Size = new System.Drawing.Size(111, 24);
            this.rbIdaevolta.TabIndex = 3;
            this.rbIdaevolta.TabStop = true;
            this.rbIdaevolta.Tag = "3";
            this.rbIdaevolta.Text = "Ida e Volta";
            this.rbIdaevolta.UseVisualStyleBackColor = true;
            this.rbIdaevolta.CheckedChanged += new System.EventHandler(this.rbIda_CheckedChanged);
            // 
            // rbVolta
            // 
            this.rbVolta.AutoSize = true;
            this.rbVolta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbVolta.Location = new System.Drawing.Point(107, 25);
            this.rbVolta.Name = "rbVolta";
            this.rbVolta.Size = new System.Drawing.Size(71, 24);
            this.rbVolta.TabIndex = 2;
            this.rbVolta.TabStop = true;
            this.rbVolta.Tag = "2";
            this.rbVolta.Text = "Volta";
            this.rbVolta.UseVisualStyleBackColor = true;
            this.rbVolta.CheckedChanged += new System.EventHandler(this.rbIda_CheckedChanged);
            // 
            // rbIda
            // 
            this.rbIda.AutoSize = true;
            this.rbIda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbIda.Location = new System.Drawing.Point(30, 25);
            this.rbIda.Name = "rbIda";
            this.rbIda.Size = new System.Drawing.Size(57, 24);
            this.rbIda.TabIndex = 1;
            this.rbIda.TabStop = true;
            this.rbIda.Tag = "1";
            this.rbIda.Text = "Ida";
            this.rbIda.UseVisualStyleBackColor = true;
            this.rbIda.CheckedChanged += new System.EventHandler(this.rbIda_CheckedChanged);
            // 
            // txtTrajeto_esp
            // 
            this.txtTrajeto_esp.Enabled = false;
            this.txtTrajeto_esp.Location = new System.Drawing.Point(771, 583);
            this.txtTrajeto_esp.Name = "txtTrajeto_esp";
            this.txtTrajeto_esp.Size = new System.Drawing.Size(387, 26);
            this.txtTrajeto_esp.TabIndex = 146;
            // 
            // lbTraj_esp
            // 
            this.lbTraj_esp.AutoSize = true;
            this.lbTraj_esp.Location = new System.Drawing.Point(660, 586);
            this.lbTraj_esp.Name = "lbTraj_esp";
            this.lbTraj_esp.Size = new System.Drawing.Size(91, 20);
            this.lbTraj_esp.TabIndex = 147;
            this.lbTraj_esp.Text = "Especificar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Enabled = false;
            this.chkInativo.Location = new System.Drawing.Point(166, 682);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(82, 24);
            this.chkInativo.TabIndex = 148;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            this.chkInativo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtDt_inativo
            // 
            this.txtDt_inativo.Enabled = false;
            this.txtDt_inativo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDt_inativo.Location = new System.Drawing.Point(418, 682);
            this.txtDt_inativo.Name = "txtDt_inativo";
            this.txtDt_inativo.Size = new System.Drawing.Size(139, 26);
            this.txtDt_inativo.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 686);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 150;
            this.label13.Text = "Data Inativação:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(766, 152);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(154, 28);
            this.txtData.TabIndex = 151;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(700, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 22);
            this.label14.TabIndex = 152;
            this.label14.Text = "Data:";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(167, 160);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(60, 20);
            this.lblResponsavel.TabIndex = 153;
            this.lblResponsavel.Text = "label15";
            // 
            // frmPreContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 841);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDt_inativo);
            this.Controls.Add(this.chkInativo);
            this.Controls.Add(this.lbTraj_esp);
            this.Controls.Add(this.txtTrajeto_esp);
            this.Controls.Add(this.txtTrajeto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDt_nascimento);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtEmissor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbEst_civil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaturalidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPreContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Contrato";
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btContrato;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDt_nascimento;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtEmissor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEst_civil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaturalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrajeto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbIdaevolta;
        private System.Windows.Forms.RadioButton rbVolta;
        private System.Windows.Forms.RadioButton rbIda;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.TextBox txtTrajeto_esp;
        private System.Windows.Forms.Label lbTraj_esp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker txtDt_inativo;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblResponsavel;
    }
}