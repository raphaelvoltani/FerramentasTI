namespace Clinica_Medica
{
    partial class frm_tela_altera_medico
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
            this.btm_voltaraddmedico = new System.Windows.Forms.Button();
            this.btm_gravaraddmedico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_nascmedico = new System.Windows.Forms.DateTimePicker();
            this.msk_telmedico = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpfmedico = new System.Windows.Forms.MaskedTextBox();
            this.txb_especmedico = new System.Windows.Forms.TextBox();
            this.txb_crmmedico = new System.Windows.Forms.TextBox();
            this.txb_emailmedico = new System.Windows.Forms.TextBox();
            this.txb_nomemedico = new System.Windows.Forms.TextBox();
            this.lab_especmedico = new System.Windows.Forms.Label();
            this.lab_emailmedico = new System.Windows.Forms.Label();
            this.lab_telmedico = new System.Windows.Forms.Label();
            this.lab_CPFmedico = new System.Windows.Forms.Label();
            this.lab_CRMmedico = new System.Windows.Forms.Label();
            this.lab_datanascmedico = new System.Windows.Forms.Label();
            this.lab_nomemedico = new System.Windows.Forms.Label();
            this.lbl_altera_medico = new System.Windows.Forms.Label();
            this.lab_codmed1 = new System.Windows.Forms.Label();
            this.lab_codmed2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btm_voltaraddmedico
            // 
            this.btm_voltaraddmedico.Location = new System.Drawing.Point(708, 234);
            this.btm_voltaraddmedico.Name = "btm_voltaraddmedico";
            this.btm_voltaraddmedico.Size = new System.Drawing.Size(75, 23);
            this.btm_voltaraddmedico.TabIndex = 7;
            this.btm_voltaraddmedico.Text = "Voltar";
            this.btm_voltaraddmedico.UseVisualStyleBackColor = true;
            this.btm_voltaraddmedico.Click += new System.EventHandler(this.btm_voltaraddmedico_Click);
            // 
            // btm_gravaraddmedico
            // 
            this.btm_gravaraddmedico.Location = new System.Drawing.Point(627, 234);
            this.btm_gravaraddmedico.Name = "btm_gravaraddmedico";
            this.btm_gravaraddmedico.Size = new System.Drawing.Size(75, 23);
            this.btm_gravaraddmedico.TabIndex = 6;
            this.btm_gravaraddmedico.Text = "Gravar";
            this.btm_gravaraddmedico.UseVisualStyleBackColor = true;
            this.btm_gravaraddmedico.Click += new System.EventHandler(this.btm_gravaraddmedico_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_nascmedico);
            this.groupBox1.Controls.Add(this.msk_telmedico);
            this.groupBox1.Controls.Add(this.msk_cpfmedico);
            this.groupBox1.Controls.Add(this.txb_especmedico);
            this.groupBox1.Controls.Add(this.txb_crmmedico);
            this.groupBox1.Controls.Add(this.txb_emailmedico);
            this.groupBox1.Controls.Add(this.txb_nomemedico);
            this.groupBox1.Controls.Add(this.lab_especmedico);
            this.groupBox1.Controls.Add(this.lab_emailmedico);
            this.groupBox1.Controls.Add(this.lab_telmedico);
            this.groupBox1.Controls.Add(this.lab_CPFmedico);
            this.groupBox1.Controls.Add(this.lab_CRMmedico);
            this.groupBox1.Controls.Add(this.lab_datanascmedico);
            this.groupBox1.Controls.Add(this.lab_nomemedico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais - MÉDICOS";
            // 
            // dtp_nascmedico
            // 
            this.dtp_nascmedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nascmedico.Location = new System.Drawing.Point(116, 60);
            this.dtp_nascmedico.Name = "dtp_nascmedico";
            this.dtp_nascmedico.Size = new System.Drawing.Size(119, 21);
            this.dtp_nascmedico.TabIndex = 13;
            this.dtp_nascmedico.Value = new System.DateTime(2025, 7, 1, 0, 0, 0, 0);
            // 
            // msk_telmedico
            // 
            this.msk_telmedico.Location = new System.Drawing.Point(328, 60);
            this.msk_telmedico.Mask = "(00)00000-0000";
            this.msk_telmedico.Name = "msk_telmedico";
            this.msk_telmedico.Size = new System.Drawing.Size(126, 21);
            this.msk_telmedico.TabIndex = 12;
            // 
            // msk_cpfmedico
            // 
            this.msk_cpfmedico.Location = new System.Drawing.Point(622, 24);
            this.msk_cpfmedico.Mask = "000.000.000-00";
            this.msk_cpfmedico.Name = "msk_cpfmedico";
            this.msk_cpfmedico.Size = new System.Drawing.Size(148, 21);
            this.msk_cpfmedico.TabIndex = 11;
            // 
            // txb_especmedico
            // 
            this.txb_especmedico.Location = new System.Drawing.Point(384, 100);
            this.txb_especmedico.Name = "txb_especmedico";
            this.txb_especmedico.Size = new System.Drawing.Size(386, 21);
            this.txb_especmedico.TabIndex = 10;
            // 
            // txb_crmmedico
            // 
            this.txb_crmmedico.Location = new System.Drawing.Point(70, 100);
            this.txb_crmmedico.Name = "txb_crmmedico";
            this.txb_crmmedico.Size = new System.Drawing.Size(198, 21);
            this.txb_crmmedico.TabIndex = 9;
            // 
            // txb_emailmedico
            // 
            this.txb_emailmedico.Location = new System.Drawing.Point(515, 60);
            this.txb_emailmedico.Name = "txb_emailmedico";
            this.txb_emailmedico.Size = new System.Drawing.Size(255, 21);
            this.txb_emailmedico.TabIndex = 8;
            // 
            // txb_nomemedico
            // 
            this.txb_nomemedico.Location = new System.Drawing.Point(70, 21);
            this.txb_nomemedico.Name = "txb_nomemedico";
            this.txb_nomemedico.Size = new System.Drawing.Size(493, 21);
            this.txb_nomemedico.TabIndex = 7;
            // 
            // lab_especmedico
            // 
            this.lab_especmedico.AutoSize = true;
            this.lab_especmedico.Location = new System.Drawing.Point(274, 103);
            this.lab_especmedico.Name = "lab_especmedico";
            this.lab_especmedico.Size = new System.Drawing.Size(104, 15);
            this.lab_especmedico.TabIndex = 6;
            this.lab_especmedico.Text = "Especialização";
            // 
            // lab_emailmedico
            // 
            this.lab_emailmedico.AutoSize = true;
            this.lab_emailmedico.Location = new System.Drawing.Point(460, 66);
            this.lab_emailmedico.Name = "lab_emailmedico";
            this.lab_emailmedico.Size = new System.Drawing.Size(49, 15);
            this.lab_emailmedico.TabIndex = 5;
            this.lab_emailmedico.Text = "E-Mail";
            // 
            // lab_telmedico
            // 
            this.lab_telmedico.AutoSize = true;
            this.lab_telmedico.Location = new System.Drawing.Point(241, 62);
            this.lab_telmedico.Name = "lab_telmedico";
            this.lab_telmedico.Size = new System.Drawing.Size(81, 15);
            this.lab_telmedico.TabIndex = 4;
            this.lab_telmedico.Text = "Tel. Celular";
            // 
            // lab_CPFmedico
            // 
            this.lab_CPFmedico.AutoSize = true;
            this.lab_CPFmedico.Location = new System.Drawing.Point(569, 24);
            this.lab_CPFmedico.Name = "lab_CPFmedico";
            this.lab_CPFmedico.Size = new System.Drawing.Size(33, 15);
            this.lab_CPFmedico.TabIndex = 3;
            this.lab_CPFmedico.Text = "CPF";
            // 
            // lab_CRMmedico
            // 
            this.lab_CRMmedico.AutoSize = true;
            this.lab_CRMmedico.Location = new System.Drawing.Point(17, 103);
            this.lab_CRMmedico.Name = "lab_CRMmedico";
            this.lab_CRMmedico.Size = new System.Drawing.Size(38, 15);
            this.lab_CRMmedico.TabIndex = 2;
            this.lab_CRMmedico.Text = "CRM";
            // 
            // lab_datanascmedico
            // 
            this.lab_datanascmedico.AutoSize = true;
            this.lab_datanascmedico.Location = new System.Drawing.Point(17, 62);
            this.lab_datanascmedico.Name = "lab_datanascmedico";
            this.lab_datanascmedico.Size = new System.Drawing.Size(93, 15);
            this.lab_datanascmedico.TabIndex = 1;
            this.lab_datanascmedico.Text = "Data de Nasc";
            // 
            // lab_nomemedico
            // 
            this.lab_nomemedico.AutoSize = true;
            this.lab_nomemedico.Location = new System.Drawing.Point(17, 24);
            this.lab_nomemedico.Name = "lab_nomemedico";
            this.lab_nomemedico.Size = new System.Drawing.Size(45, 15);
            this.lab_nomemedico.TabIndex = 0;
            this.lab_nomemedico.Text = "Nome";
            // 
            // lbl_altera_medico
            // 
            this.lbl_altera_medico.AutoSize = true;
            this.lbl_altera_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altera_medico.Location = new System.Drawing.Point(12, 21);
            this.lbl_altera_medico.Name = "lbl_altera_medico";
            this.lbl_altera_medico.Size = new System.Drawing.Size(292, 25);
            this.lbl_altera_medico.TabIndex = 4;
            this.lbl_altera_medico.Text = "Altera Informações Médico";
            // 
            // lab_codmed1
            // 
            this.lab_codmed1.AutoSize = true;
            this.lab_codmed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_codmed1.Location = new System.Drawing.Point(582, 31);
            this.lab_codmed1.Name = "lab_codmed1";
            this.lab_codmed1.Size = new System.Drawing.Size(112, 16);
            this.lab_codmed1.TabIndex = 8;
            this.lab_codmed1.Text = "Código Médico";
            // 
            // lab_codmed2
            // 
            this.lab_codmed2.AutoSize = true;
            this.lab_codmed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_codmed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_codmed2.Location = new System.Drawing.Point(702, 28);
            this.lab_codmed2.Name = "lab_codmed2";
            this.lab_codmed2.Size = new System.Drawing.Size(87, 22);
            this.lab_codmed2.TabIndex = 9;
            this.lab_codmed2.Text = "                   ";
            this.lab_codmed2.Click += new System.EventHandler(this.lab_codmed2_Click);
            // 
            // frm_tela_altera_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.lab_codmed2);
            this.Controls.Add(this.lab_codmed1);
            this.Controls.Add(this.btm_voltaraddmedico);
            this.Controls.Add(this.btm_gravaraddmedico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_altera_medico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_tela_altera_medico";
            this.Text = "frm_tela_altera_medico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_voltaraddmedico;
        private System.Windows.Forms.Button btm_gravaraddmedico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_nascmedico;
        private System.Windows.Forms.MaskedTextBox msk_telmedico;
        private System.Windows.Forms.MaskedTextBox msk_cpfmedico;
        private System.Windows.Forms.TextBox txb_especmedico;
        private System.Windows.Forms.TextBox txb_crmmedico;
        private System.Windows.Forms.TextBox txb_emailmedico;
        private System.Windows.Forms.TextBox txb_nomemedico;
        private System.Windows.Forms.Label lab_especmedico;
        private System.Windows.Forms.Label lab_emailmedico;
        private System.Windows.Forms.Label lab_telmedico;
        private System.Windows.Forms.Label lab_CPFmedico;
        private System.Windows.Forms.Label lab_CRMmedico;
        private System.Windows.Forms.Label lab_datanascmedico;
        private System.Windows.Forms.Label lab_nomemedico;
        private System.Windows.Forms.Label lbl_altera_medico;
        private System.Windows.Forms.Label lab_codmed1;
        private System.Windows.Forms.Label lab_codmed2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}