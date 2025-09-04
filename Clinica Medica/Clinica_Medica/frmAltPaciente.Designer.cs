namespace Clinica_Medica
{
    partial class frmAltPaciente
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
            this.lab_gerenc_cad_pac = new System.Windows.Forms.Label();
            this.lab_alt_pac_buscar = new System.Windows.Forms.Label();
            this.btn_alt_pac_incluir = new System.Windows.Forms.Button();
            this.btn_alt_pac_alterar = new System.Windows.Forms.Button();
            this.btn_alt_pac_excluir = new System.Windows.Forms.Button();
            this.btn_alt_pac_voltar = new System.Windows.Forms.Button();
            this.dataGridView_alt_paciente = new System.Windows.Forms.DataGridView();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_CliDataSet1 = new Clinica_Medica.Med_CliDataSet1();
            this.pacientesTableAdapter = new Clinica_Medica.Med_CliDataSet1TableAdapters.PacientesTableAdapter();
            this.txb_alt_pacin_buscar = new System.Windows.Forms.TextBox();
            this.btn_busca_pac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alt_paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_CliDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_gerenc_cad_pac
            // 
            this.lab_gerenc_cad_pac.AutoSize = true;
            this.lab_gerenc_cad_pac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_gerenc_cad_pac.Location = new System.Drawing.Point(44, 31);
            this.lab_gerenc_cad_pac.Name = "lab_gerenc_cad_pac";
            this.lab_gerenc_cad_pac.Size = new System.Drawing.Size(385, 25);
            this.lab_gerenc_cad_pac.TabIndex = 0;
            this.lab_gerenc_cad_pac.Text = "Gerenciar Cadastros dos Pacientes";
            // 
            // lab_alt_pac_buscar
            // 
            this.lab_alt_pac_buscar.AutoSize = true;
            this.lab_alt_pac_buscar.Location = new System.Drawing.Point(485, 40);
            this.lab_alt_pac_buscar.Name = "lab_alt_pac_buscar";
            this.lab_alt_pac_buscar.Size = new System.Drawing.Size(40, 13);
            this.lab_alt_pac_buscar.TabIndex = 1;
            this.lab_alt_pac_buscar.Text = "Buscar";
            // 
            // btn_alt_pac_incluir
            // 
            this.btn_alt_pac_incluir.Location = new System.Drawing.Point(47, 379);
            this.btn_alt_pac_incluir.Name = "btn_alt_pac_incluir";
            this.btn_alt_pac_incluir.Size = new System.Drawing.Size(94, 32);
            this.btn_alt_pac_incluir.TabIndex = 2;
            this.btn_alt_pac_incluir.Text = "Incluir";
            this.btn_alt_pac_incluir.UseVisualStyleBackColor = true;
            this.btn_alt_pac_incluir.Click += new System.EventHandler(this.btn_alt_pac_incluir_Click);
            // 
            // btn_alt_pac_alterar
            // 
            this.btn_alt_pac_alterar.Location = new System.Drawing.Point(186, 379);
            this.btn_alt_pac_alterar.Name = "btn_alt_pac_alterar";
            this.btn_alt_pac_alterar.Size = new System.Drawing.Size(92, 32);
            this.btn_alt_pac_alterar.TabIndex = 3;
            this.btn_alt_pac_alterar.Text = "Alterar";
            this.btn_alt_pac_alterar.UseVisualStyleBackColor = true;
            this.btn_alt_pac_alterar.Click += new System.EventHandler(this.btn_alt_pac_alterar_Click);
            // 
            // btn_alt_pac_excluir
            // 
            this.btn_alt_pac_excluir.Location = new System.Drawing.Point(318, 379);
            this.btn_alt_pac_excluir.Name = "btn_alt_pac_excluir";
            this.btn_alt_pac_excluir.Size = new System.Drawing.Size(96, 32);
            this.btn_alt_pac_excluir.TabIndex = 4;
            this.btn_alt_pac_excluir.Text = "Excluir";
            this.btn_alt_pac_excluir.UseVisualStyleBackColor = true;
            this.btn_alt_pac_excluir.Click += new System.EventHandler(this.btn_alt_pac_excluir_Click);
            // 
            // btn_alt_pac_voltar
            // 
            this.btn_alt_pac_voltar.Location = new System.Drawing.Point(681, 379);
            this.btn_alt_pac_voltar.Name = "btn_alt_pac_voltar";
            this.btn_alt_pac_voltar.Size = new System.Drawing.Size(97, 32);
            this.btn_alt_pac_voltar.TabIndex = 5;
            this.btn_alt_pac_voltar.Text = "Voltar";
            this.btn_alt_pac_voltar.UseVisualStyleBackColor = true;
            this.btn_alt_pac_voltar.Click += new System.EventHandler(this.btn_alt_pac_voltar_Click);
            // 
            // dataGridView_alt_paciente
            // 
            this.dataGridView_alt_paciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_alt_paciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_alt_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alt_paciente.Location = new System.Drawing.Point(12, 82);
            this.dataGridView_alt_paciente.Name = "dataGridView_alt_paciente";
            this.dataGridView_alt_paciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_alt_paciente.Size = new System.Drawing.Size(776, 166);
            this.dataGridView_alt_paciente.TabIndex = 6;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.med_CliDataSet1;
            // 
            // med_CliDataSet1
            // 
            this.med_CliDataSet1.DataSetName = "Med_CliDataSet1";
            this.med_CliDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // txb_alt_pacin_buscar
            // 
            this.txb_alt_pacin_buscar.Location = new System.Drawing.Point(531, 36);
            this.txb_alt_pacin_buscar.Name = "txb_alt_pacin_buscar";
            this.txb_alt_pacin_buscar.Size = new System.Drawing.Size(141, 20);
            this.txb_alt_pacin_buscar.TabIndex = 7;
            // 
            // btn_busca_pac
            // 
            this.btn_busca_pac.Location = new System.Drawing.Point(706, 35);
            this.btn_busca_pac.Name = "btn_busca_pac";
            this.btn_busca_pac.Size = new System.Drawing.Size(71, 20);
            this.btn_busca_pac.TabIndex = 8;
            this.btn_busca_pac.Text = "Buscar";
            this.btn_busca_pac.UseVisualStyleBackColor = true;
            this.btn_busca_pac.Click += new System.EventHandler(this.btn_busca_pac_Click);
            // 
            // frmAltPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_busca_pac);
            this.Controls.Add(this.txb_alt_pacin_buscar);
            this.Controls.Add(this.dataGridView_alt_paciente);
            this.Controls.Add(this.btn_alt_pac_voltar);
            this.Controls.Add(this.btn_alt_pac_excluir);
            this.Controls.Add(this.btn_alt_pac_alterar);
            this.Controls.Add(this.btn_alt_pac_incluir);
            this.Controls.Add(this.lab_alt_pac_buscar);
            this.Controls.Add(this.lab_gerenc_cad_pac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltPaciente";
            this.Load += new System.EventHandler(this.frmAltPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alt_paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_CliDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_gerenc_cad_pac;
        private System.Windows.Forms.Label lab_alt_pac_buscar;
        private System.Windows.Forms.Button btn_alt_pac_incluir;
        private System.Windows.Forms.Button btn_alt_pac_alterar;
        private System.Windows.Forms.Button btn_alt_pac_excluir;
        private System.Windows.Forms.Button btn_alt_pac_voltar;
        private System.Windows.Forms.DataGridView dataGridView_alt_paciente;
        private Med_CliDataSet1 med_CliDataSet1;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private Med_CliDataSet1TableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.TextBox txb_alt_pacin_buscar;
        private System.Windows.Forms.Button btn_busca_pac;
    }
}