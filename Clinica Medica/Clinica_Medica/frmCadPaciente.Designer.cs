namespace Clinica_Medica
{
    partial class frmCadPaciente
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
            this.lab_cadpacientes = new System.Windows.Forms.Label();
            this.gbx_cadpacientespessoais = new System.Windows.Forms.GroupBox();
            this.msk_pacien_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_pacien_tel = new System.Windows.Forms.MaskedTextBox();
            this.dtp_pacien_datanasc = new System.Windows.Forms.DateTimePicker();
            this.txb_pacien_email = new System.Windows.Forms.TextBox();
            this.txb_pacien_nome = new System.Windows.Forms.TextBox();
            this.gbx_cadpasc_rh = new System.Windows.Forms.GroupBox();
            this.radbt_rh_negativo = new System.Windows.Forms.RadioButton();
            this.radbt_rh_positivo = new System.Windows.Forms.RadioButton();
            this.gbx_cadpasc_tpsang = new System.Windows.Forms.GroupBox();
            this.radbt_tipsag_ab = new System.Windows.Forms.RadioButton();
            this.radbt_tipsag_o = new System.Windows.Forms.RadioButton();
            this.radbt_tipsag_b = new System.Windows.Forms.RadioButton();
            this.radbt_tipsag_a = new System.Windows.Forms.RadioButton();
            this.gbx_cadpascestcivil = new System.Windows.Forms.GroupBox();
            this.radbt_estciv_viuvo = new System.Windows.Forms.RadioButton();
            this.radbt_estciv_divorciado = new System.Windows.Forms.RadioButton();
            this.radbt_estciv_separado = new System.Windows.Forms.RadioButton();
            this.radbt_estciv_casado = new System.Windows.Forms.RadioButton();
            this.radbt_estciv_solteiro = new System.Windows.Forms.RadioButton();
            this.lab_cadpac_CPF = new System.Windows.Forms.Label();
            this.lab_cadpac_telef = new System.Windows.Forms.Label();
            this.lab_cadpac_datanasc = new System.Windows.Forms.Label();
            this.lab_cadpac_email = new System.Windows.Forms.Label();
            this.lab_cadpac_nome = new System.Windows.Forms.Label();
            this.gbx_cadpacientesender = new System.Windows.Forms.GroupBox();
            this.cmb_pacien_uf = new System.Windows.Forms.ComboBox();
            this.txb_pacien_cidade = new System.Windows.Forms.TextBox();
            this.txb_pacien_complemento = new System.Windows.Forms.TextBox();
            this.txb_pacien_bairro = new System.Windows.Forms.TextBox();
            this.txb_pacien_numero = new System.Windows.Forms.TextBox();
            this.txb_pacien_logradouro = new System.Windows.Forms.TextBox();
            this.msk_paciente_cep = new System.Windows.Forms.MaskedTextBox();
            this.lab_ender_cidade = new System.Windows.Forms.Label();
            this.lab_ender_complemento = new System.Windows.Forms.Label();
            this.lab_ender_uf = new System.Windows.Forms.Label();
            this.lab_ender_bairro = new System.Windows.Forms.Label();
            this.lab_ender_numero = new System.Windows.Forms.Label();
            this.lab_ender_logradouro = new System.Windows.Forms.Label();
            this.lab_ender_cep = new System.Windows.Forms.Label();
            this.gbx_cadpacientesacomp = new System.Windows.Forms.GroupBox();
            this.txb_pacien_nomeacomp = new System.Windows.Forms.TextBox();
            this.msk_pac_acompanhante_tel = new System.Windows.Forms.MaskedTextBox();
            this.lab_acomp_tel = new System.Windows.Forms.Label();
            this.lab_acomp_nome = new System.Windows.Forms.Label();
            this.ckb_paciente_acompanhante = new System.Windows.Forms.CheckBox();
            this.btm_addpacien_gravar = new System.Windows.Forms.Button();
            this.btm_addpacien_voltar = new System.Windows.Forms.Button();
            this.gbx_cadpacientespessoais.SuspendLayout();
            this.gbx_cadpasc_rh.SuspendLayout();
            this.gbx_cadpasc_tpsang.SuspendLayout();
            this.gbx_cadpascestcivil.SuspendLayout();
            this.gbx_cadpacientesender.SuspendLayout();
            this.gbx_cadpacientesacomp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_cadpacientes
            // 
            this.lab_cadpacientes.AutoSize = true;
            this.lab_cadpacientes.Location = new System.Drawing.Point(31, 28);
            this.lab_cadpacientes.Name = "lab_cadpacientes";
            this.lab_cadpacientes.Size = new System.Drawing.Size(114, 13);
            this.lab_cadpacientes.TabIndex = 0;
            this.lab_cadpacientes.Text = "Cadastro de Pacientes";
            // 
            // gbx_cadpacientespessoais
            // 
            this.gbx_cadpacientespessoais.Controls.Add(this.msk_pacien_cpf);
            this.gbx_cadpacientespessoais.Controls.Add(this.msk_pacien_tel);
            this.gbx_cadpacientespessoais.Controls.Add(this.dtp_pacien_datanasc);
            this.gbx_cadpacientespessoais.Controls.Add(this.txb_pacien_email);
            this.gbx_cadpacientespessoais.Controls.Add(this.txb_pacien_nome);
            this.gbx_cadpacientespessoais.Controls.Add(this.gbx_cadpasc_rh);
            this.gbx_cadpacientespessoais.Controls.Add(this.gbx_cadpasc_tpsang);
            this.gbx_cadpacientespessoais.Controls.Add(this.gbx_cadpascestcivil);
            this.gbx_cadpacientespessoais.Controls.Add(this.lab_cadpac_CPF);
            this.gbx_cadpacientespessoais.Controls.Add(this.lab_cadpac_telef);
            this.gbx_cadpacientespessoais.Controls.Add(this.lab_cadpac_datanasc);
            this.gbx_cadpacientespessoais.Controls.Add(this.lab_cadpac_email);
            this.gbx_cadpacientespessoais.Controls.Add(this.lab_cadpac_nome);
            this.gbx_cadpacientespessoais.Location = new System.Drawing.Point(12, 59);
            this.gbx_cadpacientespessoais.Name = "gbx_cadpacientespessoais";
            this.gbx_cadpacientespessoais.Size = new System.Drawing.Size(875, 127);
            this.gbx_cadpacientespessoais.TabIndex = 1;
            this.gbx_cadpacientespessoais.TabStop = false;
            this.gbx_cadpacientespessoais.Text = "Dados Passoais";
            // 
            // msk_pacien_cpf
            // 
            this.msk_pacien_cpf.Location = new System.Drawing.Point(545, 19);
            this.msk_pacien_cpf.Mask = "000.000.000-00";
            this.msk_pacien_cpf.Name = "msk_pacien_cpf";
            this.msk_pacien_cpf.Size = new System.Drawing.Size(125, 20);
            this.msk_pacien_cpf.TabIndex = 2;
            // 
            // msk_pacien_tel
            // 
            this.msk_pacien_tel.Location = new System.Drawing.Point(375, 43);
            this.msk_pacien_tel.Mask = "(00)00000-0000";
            this.msk_pacien_tel.Name = "msk_pacien_tel";
            this.msk_pacien_tel.Size = new System.Drawing.Size(100, 20);
            this.msk_pacien_tel.TabIndex = 4;
            // 
            // dtp_pacien_datanasc
            // 
            this.dtp_pacien_datanasc.Location = new System.Drawing.Point(129, 46);
            this.dtp_pacien_datanasc.Name = "dtp_pacien_datanasc";
            this.dtp_pacien_datanasc.Size = new System.Drawing.Size(160, 20);
            this.dtp_pacien_datanasc.TabIndex = 3;
            // 
            // txb_pacien_email
            // 
            this.txb_pacien_email.Location = new System.Drawing.Point(554, 45);
            this.txb_pacien_email.Name = "txb_pacien_email";
            this.txb_pacien_email.Size = new System.Drawing.Size(265, 20);
            this.txb_pacien_email.TabIndex = 5;
            // 
            // txb_pacien_nome
            // 
            this.txb_pacien_nome.Location = new System.Drawing.Point(59, 19);
            this.txb_pacien_nome.Name = "txb_pacien_nome";
            this.txb_pacien_nome.Size = new System.Drawing.Size(450, 20);
            this.txb_pacien_nome.TabIndex = 1;
            // 
            // gbx_cadpasc_rh
            // 
            this.gbx_cadpasc_rh.Controls.Add(this.radbt_rh_negativo);
            this.gbx_cadpasc_rh.Controls.Add(this.radbt_rh_positivo);
            this.gbx_cadpasc_rh.Location = new System.Drawing.Point(691, 76);
            this.gbx_cadpasc_rh.Name = "gbx_cadpasc_rh";
            this.gbx_cadpasc_rh.Size = new System.Drawing.Size(184, 45);
            this.gbx_cadpasc_rh.TabIndex = 7;
            this.gbx_cadpasc_rh.TabStop = false;
            this.gbx_cadpasc_rh.Text = "RH";
            // 
            // radbt_rh_negativo
            // 
            this.radbt_rh_negativo.AutoSize = true;
            this.radbt_rh_negativo.Location = new System.Drawing.Point(106, 19);
            this.radbt_rh_negativo.Name = "radbt_rh_negativo";
            this.radbt_rh_negativo.Size = new System.Drawing.Size(68, 17);
            this.radbt_rh_negativo.TabIndex = 16;
            this.radbt_rh_negativo.TabStop = true;
            this.radbt_rh_negativo.Text = "Negativo";
            this.radbt_rh_negativo.UseVisualStyleBackColor = true;
            // 
            // radbt_rh_positivo
            // 
            this.radbt_rh_positivo.AutoSize = true;
            this.radbt_rh_positivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radbt_rh_positivo.Location = new System.Drawing.Point(14, 20);
            this.radbt_rh_positivo.Name = "radbt_rh_positivo";
            this.radbt_rh_positivo.Size = new System.Drawing.Size(62, 17);
            this.radbt_rh_positivo.TabIndex = 15;
            this.radbt_rh_positivo.TabStop = true;
            this.radbt_rh_positivo.Text = "Positivo";
            this.radbt_rh_positivo.UseVisualStyleBackColor = true;
            // 
            // gbx_cadpasc_tpsang
            // 
            this.gbx_cadpasc_tpsang.Controls.Add(this.radbt_tipsag_ab);
            this.gbx_cadpasc_tpsang.Controls.Add(this.radbt_tipsag_o);
            this.gbx_cadpasc_tpsang.Controls.Add(this.radbt_tipsag_b);
            this.gbx_cadpasc_tpsang.Controls.Add(this.radbt_tipsag_a);
            this.gbx_cadpasc_tpsang.Location = new System.Drawing.Point(479, 76);
            this.gbx_cadpasc_tpsang.Name = "gbx_cadpasc_tpsang";
            this.gbx_cadpasc_tpsang.Size = new System.Drawing.Size(200, 45);
            this.gbx_cadpasc_tpsang.TabIndex = 6;
            this.gbx_cadpasc_tpsang.TabStop = false;
            this.gbx_cadpasc_tpsang.Text = "Tipo Sanguíneo";
            // 
            // radbt_tipsag_ab
            // 
            this.radbt_tipsag_ab.AutoSize = true;
            this.radbt_tipsag_ab.Location = new System.Drawing.Point(141, 20);
            this.radbt_tipsag_ab.Name = "radbt_tipsag_ab";
            this.radbt_tipsag_ab.Size = new System.Drawing.Size(39, 17);
            this.radbt_tipsag_ab.TabIndex = 14;
            this.radbt_tipsag_ab.TabStop = true;
            this.radbt_tipsag_ab.Text = "AB";
            this.radbt_tipsag_ab.UseVisualStyleBackColor = true;
            // 
            // radbt_tipsag_o
            // 
            this.radbt_tipsag_o.AutoSize = true;
            this.radbt_tipsag_o.Location = new System.Drawing.Point(6, 19);
            this.radbt_tipsag_o.Name = "radbt_tipsag_o";
            this.radbt_tipsag_o.Size = new System.Drawing.Size(33, 17);
            this.radbt_tipsag_o.TabIndex = 11;
            this.radbt_tipsag_o.TabStop = true;
            this.radbt_tipsag_o.Text = "O";
            this.radbt_tipsag_o.UseVisualStyleBackColor = true;
            // 
            // radbt_tipsag_b
            // 
            this.radbt_tipsag_b.AutoSize = true;
            this.radbt_tipsag_b.Location = new System.Drawing.Point(103, 20);
            this.radbt_tipsag_b.Name = "radbt_tipsag_b";
            this.radbt_tipsag_b.Size = new System.Drawing.Size(32, 17);
            this.radbt_tipsag_b.TabIndex = 13;
            this.radbt_tipsag_b.TabStop = true;
            this.radbt_tipsag_b.Text = "B";
            this.radbt_tipsag_b.UseVisualStyleBackColor = true;
            // 
            // radbt_tipsag_a
            // 
            this.radbt_tipsag_a.AutoSize = true;
            this.radbt_tipsag_a.Location = new System.Drawing.Point(55, 20);
            this.radbt_tipsag_a.Name = "radbt_tipsag_a";
            this.radbt_tipsag_a.Size = new System.Drawing.Size(32, 17);
            this.radbt_tipsag_a.TabIndex = 12;
            this.radbt_tipsag_a.TabStop = true;
            this.radbt_tipsag_a.Text = "A";
            this.radbt_tipsag_a.UseVisualStyleBackColor = true;
            // 
            // gbx_cadpascestcivil
            // 
            this.gbx_cadpascestcivil.Controls.Add(this.radbt_estciv_viuvo);
            this.gbx_cadpascestcivil.Controls.Add(this.radbt_estciv_divorciado);
            this.gbx_cadpascestcivil.Controls.Add(this.radbt_estciv_separado);
            this.gbx_cadpascestcivil.Controls.Add(this.radbt_estciv_casado);
            this.gbx_cadpascestcivil.Controls.Add(this.radbt_estciv_solteiro);
            this.gbx_cadpascestcivil.Location = new System.Drawing.Point(6, 76);
            this.gbx_cadpascestcivil.Name = "gbx_cadpascestcivil";
            this.gbx_cadpascestcivil.Size = new System.Drawing.Size(467, 45);
            this.gbx_cadpascestcivil.TabIndex = 5;
            this.gbx_cadpascestcivil.TabStop = false;
            this.gbx_cadpascestcivil.Text = "Estado Civil";
            // 
            // radbt_estciv_viuvo
            // 
            this.radbt_estciv_viuvo.AutoSize = true;
            this.radbt_estciv_viuvo.Location = new System.Drawing.Point(376, 19);
            this.radbt_estciv_viuvo.Name = "radbt_estciv_viuvo";
            this.radbt_estciv_viuvo.Size = new System.Drawing.Size(52, 17);
            this.radbt_estciv_viuvo.TabIndex = 10;
            this.radbt_estciv_viuvo.TabStop = true;
            this.radbt_estciv_viuvo.Text = "Viúvo";
            this.radbt_estciv_viuvo.UseVisualStyleBackColor = true;
            this.radbt_estciv_viuvo.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radbt_estciv_divorciado
            // 
            this.radbt_estciv_divorciado.AutoSize = true;
            this.radbt_estciv_divorciado.Location = new System.Drawing.Point(285, 19);
            this.radbt_estciv_divorciado.Name = "radbt_estciv_divorciado";
            this.radbt_estciv_divorciado.Size = new System.Drawing.Size(76, 17);
            this.radbt_estciv_divorciado.TabIndex = 9;
            this.radbt_estciv_divorciado.TabStop = true;
            this.radbt_estciv_divorciado.Text = "Divorciado";
            this.radbt_estciv_divorciado.UseVisualStyleBackColor = true;
            // 
            // radbt_estciv_separado
            // 
            this.radbt_estciv_separado.AutoSize = true;
            this.radbt_estciv_separado.Location = new System.Drawing.Point(194, 20);
            this.radbt_estciv_separado.Name = "radbt_estciv_separado";
            this.radbt_estciv_separado.Size = new System.Drawing.Size(71, 17);
            this.radbt_estciv_separado.TabIndex = 8;
            this.radbt_estciv_separado.Text = "Separado";
            this.radbt_estciv_separado.UseVisualStyleBackColor = true;
            this.radbt_estciv_separado.CheckedChanged += new System.EventHandler(this.radbt_estciv_separado_CheckedChanged);
            // 
            // radbt_estciv_casado
            // 
            this.radbt_estciv_casado.AutoSize = true;
            this.radbt_estciv_casado.Location = new System.Drawing.Point(103, 20);
            this.radbt_estciv_casado.Name = "radbt_estciv_casado";
            this.radbt_estciv_casado.Size = new System.Drawing.Size(61, 17);
            this.radbt_estciv_casado.TabIndex = 7;
            this.radbt_estciv_casado.TabStop = true;
            this.radbt_estciv_casado.Text = "Casado";
            this.radbt_estciv_casado.UseVisualStyleBackColor = true;
            // 
            // radbt_estciv_solteiro
            // 
            this.radbt_estciv_solteiro.AutoSize = true;
            this.radbt_estciv_solteiro.Location = new System.Drawing.Point(20, 20);
            this.radbt_estciv_solteiro.Name = "radbt_estciv_solteiro";
            this.radbt_estciv_solteiro.Size = new System.Drawing.Size(60, 17);
            this.radbt_estciv_solteiro.TabIndex = 6;
            this.radbt_estciv_solteiro.Text = "Solteiro";
            this.radbt_estciv_solteiro.UseVisualStyleBackColor = true;
            // 
            // lab_cadpac_CPF
            // 
            this.lab_cadpac_CPF.AutoSize = true;
            this.lab_cadpac_CPF.Location = new System.Drawing.Point(515, 23);
            this.lab_cadpac_CPF.Name = "lab_cadpac_CPF";
            this.lab_cadpac_CPF.Size = new System.Drawing.Size(27, 13);
            this.lab_cadpac_CPF.TabIndex = 4;
            this.lab_cadpac_CPF.Text = "CPF";
            // 
            // lab_cadpac_telef
            // 
            this.lab_cadpac_telef.AutoSize = true;
            this.lab_cadpac_telef.Location = new System.Drawing.Point(309, 46);
            this.lab_cadpac_telef.Name = "lab_cadpac_telef";
            this.lab_cadpac_telef.Size = new System.Drawing.Size(60, 13);
            this.lab_cadpac_telef.TabIndex = 3;
            this.lab_cadpac_telef.Text = "Tel. Celular";
            // 
            // lab_cadpac_datanasc
            // 
            this.lab_cadpac_datanasc.AutoSize = true;
            this.lab_cadpac_datanasc.Location = new System.Drawing.Point(19, 46);
            this.lab_cadpac_datanasc.Name = "lab_cadpac_datanasc";
            this.lab_cadpac_datanasc.Size = new System.Drawing.Size(104, 13);
            this.lab_cadpac_datanasc.TabIndex = 2;
            this.lab_cadpac_datanasc.Text = "Data de Nascimento";
            // 
            // lab_cadpac_email
            // 
            this.lab_cadpac_email.AutoSize = true;
            this.lab_cadpac_email.Location = new System.Drawing.Point(510, 46);
            this.lab_cadpac_email.Name = "lab_cadpac_email";
            this.lab_cadpac_email.Size = new System.Drawing.Size(32, 13);
            this.lab_cadpac_email.TabIndex = 1;
            this.lab_cadpac_email.Text = "Email";
            // 
            // lab_cadpac_nome
            // 
            this.lab_cadpac_nome.AutoSize = true;
            this.lab_cadpac_nome.Location = new System.Drawing.Point(18, 23);
            this.lab_cadpac_nome.Name = "lab_cadpac_nome";
            this.lab_cadpac_nome.Size = new System.Drawing.Size(35, 13);
            this.lab_cadpac_nome.TabIndex = 0;
            this.lab_cadpac_nome.Text = "Nome";
            // 
            // gbx_cadpacientesender
            // 
            this.gbx_cadpacientesender.Controls.Add(this.cmb_pacien_uf);
            this.gbx_cadpacientesender.Controls.Add(this.txb_pacien_cidade);
            this.gbx_cadpacientesender.Controls.Add(this.txb_pacien_complemento);
            this.gbx_cadpacientesender.Controls.Add(this.txb_pacien_bairro);
            this.gbx_cadpacientesender.Controls.Add(this.txb_pacien_numero);
            this.gbx_cadpacientesender.Controls.Add(this.txb_pacien_logradouro);
            this.gbx_cadpacientesender.Controls.Add(this.msk_paciente_cep);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_cidade);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_complemento);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_uf);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_bairro);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_numero);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_logradouro);
            this.gbx_cadpacientesender.Controls.Add(this.lab_ender_cep);
            this.gbx_cadpacientesender.Location = new System.Drawing.Point(12, 192);
            this.gbx_cadpacientesender.Name = "gbx_cadpacientesender";
            this.gbx_cadpacientesender.Size = new System.Drawing.Size(875, 127);
            this.gbx_cadpacientesender.TabIndex = 2;
            this.gbx_cadpacientesender.TabStop = false;
            this.gbx_cadpacientesender.Text = "Endereço";
            // 
            // cmb_pacien_uf
            // 
            this.cmb_pacien_uf.FormattingEnabled = true;
            this.cmb_pacien_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmb_pacien_uf.Location = new System.Drawing.Point(773, 55);
            this.cmb_pacien_uf.Name = "cmb_pacien_uf";
            this.cmb_pacien_uf.Size = new System.Drawing.Size(54, 21);
            this.cmb_pacien_uf.TabIndex = 21;
            // 
            // txb_pacien_cidade
            // 
            this.txb_pacien_cidade.Location = new System.Drawing.Point(404, 84);
            this.txb_pacien_cidade.Name = "txb_pacien_cidade";
            this.txb_pacien_cidade.Size = new System.Drawing.Size(374, 20);
            this.txb_pacien_cidade.TabIndex = 23;
            // 
            // txb_pacien_complemento
            // 
            this.txb_pacien_complemento.Location = new System.Drawing.Point(101, 84);
            this.txb_pacien_complemento.Name = "txb_pacien_complemento";
            this.txb_pacien_complemento.Size = new System.Drawing.Size(230, 20);
            this.txb_pacien_complemento.TabIndex = 22;
            // 
            // txb_pacien_bairro
            // 
            this.txb_pacien_bairro.Location = new System.Drawing.Point(267, 55);
            this.txb_pacien_bairro.Name = "txb_pacien_bairro";
            this.txb_pacien_bairro.Size = new System.Drawing.Size(260, 20);
            this.txb_pacien_bairro.TabIndex = 20;
            // 
            // txb_pacien_numero
            // 
            this.txb_pacien_numero.Location = new System.Drawing.Point(68, 55);
            this.txb_pacien_numero.Name = "txb_pacien_numero";
            this.txb_pacien_numero.Size = new System.Drawing.Size(100, 20);
            this.txb_pacien_numero.TabIndex = 19;
            // 
            // txb_pacien_logradouro
            // 
            this.txb_pacien_logradouro.Location = new System.Drawing.Point(312, 22);
            this.txb_pacien_logradouro.Name = "txb_pacien_logradouro";
            this.txb_pacien_logradouro.Size = new System.Drawing.Size(539, 20);
            this.txb_pacien_logradouro.TabIndex = 18;
            // 
            // msk_paciente_cep
            // 
            this.msk_paciente_cep.Location = new System.Drawing.Point(53, 22);
            this.msk_paciente_cep.Mask = "99999-999";
            this.msk_paciente_cep.Name = "msk_paciente_cep";
            this.msk_paciente_cep.Size = new System.Drawing.Size(100, 20);
            this.msk_paciente_cep.TabIndex = 17;
            // 
            // lab_ender_cidade
            // 
            this.lab_ender_cidade.AutoSize = true;
            this.lab_ender_cidade.Location = new System.Drawing.Point(358, 87);
            this.lab_ender_cidade.Name = "lab_ender_cidade";
            this.lab_ender_cidade.Size = new System.Drawing.Size(40, 13);
            this.lab_ender_cidade.TabIndex = 6;
            this.lab_ender_cidade.Text = "Cidade";
            // 
            // lab_ender_complemento
            // 
            this.lab_ender_complemento.AutoSize = true;
            this.lab_ender_complemento.Location = new System.Drawing.Point(24, 87);
            this.lab_ender_complemento.Name = "lab_ender_complemento";
            this.lab_ender_complemento.Size = new System.Drawing.Size(71, 13);
            this.lab_ender_complemento.TabIndex = 5;
            this.lab_ender_complemento.Text = "Complemento";
            // 
            // lab_ender_uf
            // 
            this.lab_ender_uf.AutoSize = true;
            this.lab_ender_uf.Location = new System.Drawing.Point(746, 58);
            this.lab_ender_uf.Name = "lab_ender_uf";
            this.lab_ender_uf.Size = new System.Drawing.Size(21, 13);
            this.lab_ender_uf.TabIndex = 4;
            this.lab_ender_uf.Text = "UF";
            // 
            // lab_ender_bairro
            // 
            this.lab_ender_bairro.AutoSize = true;
            this.lab_ender_bairro.Location = new System.Drawing.Point(228, 58);
            this.lab_ender_bairro.Name = "lab_ender_bairro";
            this.lab_ender_bairro.Size = new System.Drawing.Size(34, 13);
            this.lab_ender_bairro.TabIndex = 3;
            this.lab_ender_bairro.Text = "Bairro";
            // 
            // lab_ender_numero
            // 
            this.lab_ender_numero.AutoSize = true;
            this.lab_ender_numero.Location = new System.Drawing.Point(18, 58);
            this.lab_ender_numero.Name = "lab_ender_numero";
            this.lab_ender_numero.Size = new System.Drawing.Size(44, 13);
            this.lab_ender_numero.TabIndex = 2;
            this.lab_ender_numero.Text = "Número";
            // 
            // lab_ender_logradouro
            // 
            this.lab_ender_logradouro.AutoSize = true;
            this.lab_ender_logradouro.Location = new System.Drawing.Point(228, 25);
            this.lab_ender_logradouro.Name = "lab_ender_logradouro";
            this.lab_ender_logradouro.Size = new System.Drawing.Size(61, 13);
            this.lab_ender_logradouro.TabIndex = 1;
            this.lab_ender_logradouro.Text = "Logradouro";
            // 
            // lab_ender_cep
            // 
            this.lab_ender_cep.AutoSize = true;
            this.lab_ender_cep.Location = new System.Drawing.Point(19, 25);
            this.lab_ender_cep.Name = "lab_ender_cep";
            this.lab_ender_cep.Size = new System.Drawing.Size(28, 13);
            this.lab_ender_cep.TabIndex = 0;
            this.lab_ender_cep.Text = "CEP";
            // 
            // gbx_cadpacientesacomp
            // 
            this.gbx_cadpacientesacomp.Controls.Add(this.txb_pacien_nomeacomp);
            this.gbx_cadpacientesacomp.Controls.Add(this.msk_pac_acompanhante_tel);
            this.gbx_cadpacientesacomp.Controls.Add(this.lab_acomp_tel);
            this.gbx_cadpacientesacomp.Controls.Add(this.lab_acomp_nome);
            this.gbx_cadpacientesacomp.Location = new System.Drawing.Point(12, 348);
            this.gbx_cadpacientesacomp.Name = "gbx_cadpacientesacomp";
            this.gbx_cadpacientesacomp.Size = new System.Drawing.Size(708, 42);
            this.gbx_cadpacientesacomp.TabIndex = 3;
            this.gbx_cadpacientesacomp.TabStop = false;
            this.gbx_cadpacientesacomp.Text = "Acompanhante";
            this.gbx_cadpacientesacomp.Visible = false;
            // 
            // txb_pacien_nomeacomp
            // 
            this.txb_pacien_nomeacomp.Location = new System.Drawing.Point(59, 16);
            this.txb_pacien_nomeacomp.Name = "txb_pacien_nomeacomp";
            this.txb_pacien_nomeacomp.Size = new System.Drawing.Size(385, 20);
            this.txb_pacien_nomeacomp.TabIndex = 25;
            // 
            // msk_pac_acompanhante_tel
            // 
            this.msk_pac_acompanhante_tel.Location = new System.Drawing.Point(516, 16);
            this.msk_pac_acompanhante_tel.Mask = "(00)00000-0000";
            this.msk_pac_acompanhante_tel.Name = "msk_pac_acompanhante_tel";
            this.msk_pac_acompanhante_tel.Size = new System.Drawing.Size(125, 20);
            this.msk_pac_acompanhante_tel.TabIndex = 26;
            // 
            // lab_acomp_tel
            // 
            this.lab_acomp_tel.AutoSize = true;
            this.lab_acomp_tel.Location = new System.Drawing.Point(453, 20);
            this.lab_acomp_tel.Name = "lab_acomp_tel";
            this.lab_acomp_tel.Size = new System.Drawing.Size(57, 13);
            this.lab_acomp_tel.TabIndex = 1;
            this.lab_acomp_tel.Text = "Tel.Celular";
            // 
            // lab_acomp_nome
            // 
            this.lab_acomp_nome.AutoSize = true;
            this.lab_acomp_nome.Location = new System.Drawing.Point(20, 20);
            this.lab_acomp_nome.Name = "lab_acomp_nome";
            this.lab_acomp_nome.Size = new System.Drawing.Size(35, 13);
            this.lab_acomp_nome.TabIndex = 0;
            this.lab_acomp_nome.Text = "Nome";
            // 
            // ckb_paciente_acompanhante
            // 
            this.ckb_paciente_acompanhante.AutoSize = true;
            this.ckb_paciente_acompanhante.Location = new System.Drawing.Point(16, 325);
            this.ckb_paciente_acompanhante.Name = "ckb_paciente_acompanhante";
            this.ckb_paciente_acompanhante.Size = new System.Drawing.Size(98, 17);
            this.ckb_paciente_acompanhante.TabIndex = 24;
            this.ckb_paciente_acompanhante.Text = "Acompanhante";
            this.ckb_paciente_acompanhante.UseVisualStyleBackColor = true;
            this.ckb_paciente_acompanhante.CheckedChanged += new System.EventHandler(this.ckb_paciente_acompanhante_CheckedChanged);
            // 
            // btm_addpacien_gravar
            // 
            this.btm_addpacien_gravar.Location = new System.Drawing.Point(703, 413);
            this.btm_addpacien_gravar.Name = "btm_addpacien_gravar";
            this.btm_addpacien_gravar.Size = new System.Drawing.Size(75, 23);
            this.btm_addpacien_gravar.TabIndex = 27;
            this.btm_addpacien_gravar.Text = "Gravar";
            this.btm_addpacien_gravar.UseVisualStyleBackColor = true;
            this.btm_addpacien_gravar.Click += new System.EventHandler(this.btm_addpacien_gravar_Click);
            // 
            // btm_addpacien_voltar
            // 
            this.btm_addpacien_voltar.Location = new System.Drawing.Point(795, 413);
            this.btm_addpacien_voltar.Name = "btm_addpacien_voltar";
            this.btm_addpacien_voltar.Size = new System.Drawing.Size(75, 23);
            this.btm_addpacien_voltar.TabIndex = 28;
            this.btm_addpacien_voltar.Text = "Voltar";
            this.btm_addpacien_voltar.UseVisualStyleBackColor = true;
            this.btm_addpacien_voltar.Click += new System.EventHandler(this.btm_addpacien_voltar_Click);
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btm_addpacien_voltar);
            this.Controls.Add(this.btm_addpacien_gravar);
            this.Controls.Add(this.ckb_paciente_acompanhante);
            this.Controls.Add(this.gbx_cadpacientesacomp);
            this.Controls.Add(this.gbx_cadpacientesender);
            this.Controls.Add(this.gbx_cadpacientespessoais);
            this.Controls.Add(this.lab_cadpacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadPaciente";
            this.gbx_cadpacientespessoais.ResumeLayout(false);
            this.gbx_cadpacientespessoais.PerformLayout();
            this.gbx_cadpasc_rh.ResumeLayout(false);
            this.gbx_cadpasc_rh.PerformLayout();
            this.gbx_cadpasc_tpsang.ResumeLayout(false);
            this.gbx_cadpasc_tpsang.PerformLayout();
            this.gbx_cadpascestcivil.ResumeLayout(false);
            this.gbx_cadpascestcivil.PerformLayout();
            this.gbx_cadpacientesender.ResumeLayout(false);
            this.gbx_cadpacientesender.PerformLayout();
            this.gbx_cadpacientesacomp.ResumeLayout(false);
            this.gbx_cadpacientesacomp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_cadpacientes;
        private System.Windows.Forms.GroupBox gbx_cadpacientespessoais;
        private System.Windows.Forms.GroupBox gbx_cadpasc_rh;
        private System.Windows.Forms.GroupBox gbx_cadpasc_tpsang;
        private System.Windows.Forms.GroupBox gbx_cadpascestcivil;
        private System.Windows.Forms.Label lab_cadpac_CPF;
        private System.Windows.Forms.Label lab_cadpac_telef;
        private System.Windows.Forms.Label lab_cadpac_datanasc;
        private System.Windows.Forms.Label lab_cadpac_email;
        private System.Windows.Forms.Label lab_cadpac_nome;
        private System.Windows.Forms.GroupBox gbx_cadpacientesender;
        private System.Windows.Forms.Label lab_ender_cep;
        private System.Windows.Forms.GroupBox gbx_cadpacientesacomp;
        private System.Windows.Forms.RadioButton radbt_estciv_viuvo;
        private System.Windows.Forms.RadioButton radbt_estciv_divorciado;
        private System.Windows.Forms.RadioButton radbt_estciv_separado;
        private System.Windows.Forms.RadioButton radbt_estciv_casado;
        private System.Windows.Forms.RadioButton radbt_estciv_solteiro;
        private System.Windows.Forms.CheckBox ckb_paciente_acompanhante;
        private System.Windows.Forms.RadioButton radbt_tipsag_ab;
        private System.Windows.Forms.RadioButton radbt_tipsag_o;
        private System.Windows.Forms.RadioButton radbt_tipsag_b;
        private System.Windows.Forms.RadioButton radbt_tipsag_a;
        private System.Windows.Forms.RadioButton radbt_rh_negativo;
        private System.Windows.Forms.RadioButton radbt_rh_positivo;
        private System.Windows.Forms.Label lab_ender_cidade;
        private System.Windows.Forms.Label lab_ender_complemento;
        private System.Windows.Forms.Label lab_ender_uf;
        private System.Windows.Forms.Label lab_ender_bairro;
        private System.Windows.Forms.Label lab_ender_numero;
        private System.Windows.Forms.Label lab_ender_logradouro;
        private System.Windows.Forms.Label lab_acomp_tel;
        private System.Windows.Forms.Label lab_acomp_nome;
        private System.Windows.Forms.ComboBox cmb_pacien_uf;
        private System.Windows.Forms.TextBox txb_pacien_cidade;
        private System.Windows.Forms.TextBox txb_pacien_complemento;
        private System.Windows.Forms.TextBox txb_pacien_bairro;
        private System.Windows.Forms.TextBox txb_pacien_numero;
        private System.Windows.Forms.TextBox txb_pacien_logradouro;
        private System.Windows.Forms.MaskedTextBox msk_paciente_cep;
        private System.Windows.Forms.MaskedTextBox msk_pac_acompanhante_tel;
        private System.Windows.Forms.MaskedTextBox msk_pacien_tel;
        private System.Windows.Forms.DateTimePicker dtp_pacien_datanasc;
        private System.Windows.Forms.TextBox txb_pacien_email;
        private System.Windows.Forms.TextBox txb_pacien_nome;
        private System.Windows.Forms.TextBox txb_pacien_nomeacomp;
        private System.Windows.Forms.MaskedTextBox msk_pacien_cpf;
        private System.Windows.Forms.Button btm_addpacien_gravar;
        private System.Windows.Forms.Button btm_addpacien_voltar;
    }
}