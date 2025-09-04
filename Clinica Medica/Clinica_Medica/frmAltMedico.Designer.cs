namespace Clinica_Medica
{
    partial class frmAltMedico
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
            this.lab_geren_cad_med = new System.Windows.Forms.Label();
            this.lab_buscar = new System.Windows.Forms.Label();
            this.txb_alt_med_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView_alt_medico = new System.Windows.Forms.DataGridView();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.med_CliDataSet = new Clinica_Medica.Med_CliDataSet();
            this.medicosTableAdapter = new Clinica_Medica.Med_CliDataSetTableAdapters.MedicosTableAdapter();
            this.btn_alt_med_add = new System.Windows.Forms.Button();
            this.btn_alt_med_altera = new System.Windows.Forms.Button();
            this.btn_alt_med_exclui = new System.Windows.Forms.Button();
            this.btn_alt_med_voltar = new System.Windows.Forms.Button();
            this.btn_busca_med = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alt_medico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_CliDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_geren_cad_med
            // 
            this.lab_geren_cad_med.AutoSize = true;
            this.lab_geren_cad_med.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_geren_cad_med.Location = new System.Drawing.Point(12, 9);
            this.lab_geren_cad_med.Name = "lab_geren_cad_med";
            this.lab_geren_cad_med.Size = new System.Drawing.Size(352, 28);
            this.lab_geren_cad_med.TabIndex = 0;
            this.lab_geren_cad_med.Text = "Gerenciar Cadastro dos Médicos";
            // 
            // lab_buscar
            // 
            this.lab_buscar.AutoSize = true;
            this.lab_buscar.Location = new System.Drawing.Point(467, 20);
            this.lab_buscar.Name = "lab_buscar";
            this.lab_buscar.Size = new System.Drawing.Size(40, 13);
            this.lab_buscar.TabIndex = 1;
            this.lab_buscar.Text = "Buscar";
            // 
            // txb_alt_med_buscar
            // 
            this.txb_alt_med_buscar.Location = new System.Drawing.Point(513, 13);
            this.txb_alt_med_buscar.Name = "txb_alt_med_buscar";
            this.txb_alt_med_buscar.Size = new System.Drawing.Size(247, 20);
            this.txb_alt_med_buscar.TabIndex = 2;
            // 
            // dataGridView_alt_medico
            // 
            this.dataGridView_alt_medico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_alt_medico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_alt_medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_alt_medico.Location = new System.Drawing.Point(14, 49);
            this.dataGridView_alt_medico.Name = "dataGridView_alt_medico";
            this.dataGridView_alt_medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_alt_medico.Size = new System.Drawing.Size(848, 203);
            this.dataGridView_alt_medico.TabIndex = 3;
            this.dataGridView_alt_medico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.med_CliDataSet;
            // 
            // med_CliDataSet
            // 
            this.med_CliDataSet.DataSetName = "Med_CliDataSet";
            this.med_CliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // btn_alt_med_add
            // 
            this.btn_alt_med_add.Location = new System.Drawing.Point(17, 415);
            this.btn_alt_med_add.Name = "btn_alt_med_add";
            this.btn_alt_med_add.Size = new System.Drawing.Size(75, 23);
            this.btn_alt_med_add.TabIndex = 4;
            this.btn_alt_med_add.Text = "Incluir";
            this.btn_alt_med_add.UseVisualStyleBackColor = true;
            this.btn_alt_med_add.Click += new System.EventHandler(this.btn_alt_med_add_Click);
            // 
            // btn_alt_med_altera
            // 
            this.btn_alt_med_altera.Location = new System.Drawing.Point(159, 415);
            this.btn_alt_med_altera.Name = "btn_alt_med_altera";
            this.btn_alt_med_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_alt_med_altera.TabIndex = 5;
            this.btn_alt_med_altera.Text = "Alterar";
            this.btn_alt_med_altera.UseVisualStyleBackColor = true;
            this.btn_alt_med_altera.Click += new System.EventHandler(this.btn_alt_med_altera_Click);
            // 
            // btn_alt_med_exclui
            // 
            this.btn_alt_med_exclui.Location = new System.Drawing.Point(289, 415);
            this.btn_alt_med_exclui.Name = "btn_alt_med_exclui";
            this.btn_alt_med_exclui.Size = new System.Drawing.Size(75, 23);
            this.btn_alt_med_exclui.TabIndex = 6;
            this.btn_alt_med_exclui.Text = "Excluir";
            this.btn_alt_med_exclui.UseVisualStyleBackColor = true;
            this.btn_alt_med_exclui.Click += new System.EventHandler(this.btn_alt_med_exclui_Click);
            // 
            // btn_alt_med_voltar
            // 
            this.btn_alt_med_voltar.Location = new System.Drawing.Point(757, 415);
            this.btn_alt_med_voltar.Name = "btn_alt_med_voltar";
            this.btn_alt_med_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_alt_med_voltar.TabIndex = 7;
            this.btn_alt_med_voltar.Text = "Voltar";
            this.btn_alt_med_voltar.UseVisualStyleBackColor = true;
            this.btn_alt_med_voltar.Click += new System.EventHandler(this.btn_alt_med_voltar_Click);
            // 
            // btn_busca_med
            // 
            this.btn_busca_med.Location = new System.Drawing.Point(791, 12);
            this.btn_busca_med.Name = "btn_busca_med";
            this.btn_busca_med.Size = new System.Drawing.Size(71, 20);
            this.btn_busca_med.TabIndex = 9;
            this.btn_busca_med.Text = "Buscar";
            this.btn_busca_med.UseVisualStyleBackColor = true;
            this.btn_busca_med.Click += new System.EventHandler(this.btn_busca_med_Click);
            // 
            // frmAltMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.btn_busca_med);
            this.Controls.Add(this.btn_alt_med_voltar);
            this.Controls.Add(this.btn_alt_med_exclui);
            this.Controls.Add(this.btn_alt_med_altera);
            this.Controls.Add(this.btn_alt_med_add);
            this.Controls.Add(this.dataGridView_alt_medico);
            this.Controls.Add(this.txb_alt_med_buscar);
            this.Controls.Add(this.lab_buscar);
            this.Controls.Add(this.lab_geren_cad_med);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Cadastro dos Médicos";
            this.Load += new System.EventHandler(this.frmAltMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_alt_medico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_CliDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_geren_cad_med;
        private System.Windows.Forms.Label lab_buscar;
        private System.Windows.Forms.TextBox txb_alt_med_buscar;
        private System.Windows.Forms.DataGridView dataGridView_alt_medico;
        private Med_CliDataSet med_CliDataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private Med_CliDataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.Button btn_alt_med_add;
        private System.Windows.Forms.Button btn_alt_med_altera;
        private System.Windows.Forms.Button btn_alt_med_exclui;
        private System.Windows.Forms.Button btn_alt_med_voltar;
        private System.Windows.Forms.Button btn_busca_med;
    }
}