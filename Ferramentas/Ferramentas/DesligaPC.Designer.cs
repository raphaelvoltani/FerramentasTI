namespace Ferramentas
{
    partial class DesligaPC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEscolhaH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesligaMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelaDesl = new System.Windows.Forms.Button();
            this.btnDesligaAgora = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscolhaH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o horario que deseja Desligar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnEscolhaH
            // 
            this.btnEscolhaH.Location = new System.Drawing.Point(168, 82);
            this.btnEscolhaH.Name = "btnEscolhaH";
            this.btnEscolhaH.Size = new System.Drawing.Size(75, 23);
            this.btnEscolhaH.TabIndex = 2;
            this.btnEscolhaH.Text = "Agendar";
            this.btnEscolhaH.UseVisualStyleBackColor = true;
            this.btnEscolhaH.Click += new System.EventHandler(this.btnEscolhaH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnDesligaMin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligue daqui a:";
            // 
            // btnDesligaMin
            // 
            this.btnDesligaMin.Location = new System.Drawing.Point(168, 82);
            this.btnDesligaMin.Name = "btnDesligaMin";
            this.btnDesligaMin.Size = new System.Drawing.Size(75, 23);
            this.btnDesligaMin.TabIndex = 2;
            this.btnDesligaMin.Text = "Agendar";
            this.btnDesligaMin.UseVisualStyleBackColor = true;
            this.btnDesligaMin.Click += new System.EventHandler(this.btnDesligaMin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite em Minutos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDesligaAgora);
            this.groupBox3.Controls.Add(this.btnCancelaDesl);
            this.groupBox3.Location = new System.Drawing.Point(32, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desligar";
            // 
            // btnCancelaDesl
            // 
            this.btnCancelaDesl.Location = new System.Drawing.Point(120, 82);
            this.btnCancelaDesl.Name = "btnCancelaDesl";
            this.btnCancelaDesl.Size = new System.Drawing.Size(148, 23);
            this.btnCancelaDesl.TabIndex = 2;
            this.btnCancelaDesl.Text = "Cancelar o Desligamento";
            this.btnCancelaDesl.UseVisualStyleBackColor = true;
            this.btnCancelaDesl.Click += new System.EventHandler(this.btnCancelaDesl_Click);
            // 
            // btnDesligaAgora
            // 
            this.btnDesligaAgora.Location = new System.Drawing.Point(155, 33);
            this.btnDesligaAgora.Name = "btnDesligaAgora";
            this.btnDesligaAgora.Size = new System.Drawing.Size(75, 23);
            this.btnDesligaAgora.TabIndex = 3;
            this.btnDesligaAgora.Text = "Desligar";
            this.btnDesligaAgora.UseVisualStyleBackColor = true;
            // 
            // DesligaPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DesligaPC";
            this.Text = "DesligaPC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEscolhaH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesligaMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesligaAgora;
        private System.Windows.Forms.Button btnCancelaDesl;
    }
}