namespace PClasses
{
    partial class FormHorista
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
            this.grpBoxHomeOfficeHorista = new System.Windows.Forms.GroupBox();
            this.rdBtnNaoHorista = new System.Windows.Forms.RadioButton();
            this.rdBtnSimHorista = new System.Windows.Forms.RadioButton();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.txtBoxSalarioHoraHorista = new System.Windows.Forms.TextBox();
            this.txtBoxNomeHorista = new System.Windows.Forms.TextBox();
            this.txtBoxMatriculaHorista = new System.Windows.Forms.TextBox();
            this.lblDtEntradaHorista = new System.Windows.Forms.Label();
            this.lblSalarioHorista = new System.Windows.Forms.Label();
            this.lblNomeHorista = new System.Windows.Forms.Label();
            this.lblMatriculaHorista = new System.Windows.Forms.Label();
            this.txtNumeroHorasHorista = new System.Windows.Forms.TextBox();
            this.lblNumeroHorasHorista = new System.Windows.Forms.Label();
            this.txtDiasFaltaHorista = new System.Windows.Forms.TextBox();
            this.lblDiasFaltaHorista = new System.Windows.Forms.Label();
            this.txtDataEntradaHorista = new System.Windows.Forms.TextBox();
            this.grpBoxHomeOfficeHorista.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxHomeOfficeHorista
            // 
            this.grpBoxHomeOfficeHorista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoxHomeOfficeHorista.Controls.Add(this.rdBtnNaoHorista);
            this.grpBoxHomeOfficeHorista.Controls.Add(this.rdBtnSimHorista);
            this.grpBoxHomeOfficeHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxHomeOfficeHorista.Location = new System.Drawing.Point(259, 371);
            this.grpBoxHomeOfficeHorista.Name = "grpBoxHomeOfficeHorista";
            this.grpBoxHomeOfficeHorista.Size = new System.Drawing.Size(200, 100);
            this.grpBoxHomeOfficeHorista.TabIndex = 21;
            this.grpBoxHomeOfficeHorista.TabStop = false;
            this.grpBoxHomeOfficeHorista.Text = "Trabalha em Home Office?";
            // 
            // rdBtnNaoHorista
            // 
            this.rdBtnNaoHorista.AutoSize = true;
            this.rdBtnNaoHorista.Checked = true;
            this.rdBtnNaoHorista.Location = new System.Drawing.Point(24, 60);
            this.rdBtnNaoHorista.Name = "rdBtnNaoHorista";
            this.rdBtnNaoHorista.Size = new System.Drawing.Size(54, 22);
            this.rdBtnNaoHorista.TabIndex = 1;
            this.rdBtnNaoHorista.TabStop = true;
            this.rdBtnNaoHorista.Text = "Não";
            this.rdBtnNaoHorista.UseVisualStyleBackColor = true;
            // 
            // rdBtnSimHorista
            // 
            this.rdBtnSimHorista.AutoSize = true;
            this.rdBtnSimHorista.Location = new System.Drawing.Point(24, 32);
            this.rdBtnSimHorista.Name = "rdBtnSimHorista";
            this.rdBtnSimHorista.Size = new System.Drawing.Size(52, 22);
            this.rdBtnSimHorista.TabIndex = 0;
            this.rdBtnSimHorista.Text = "Sim";
            this.rdBtnSimHorista.UseVisualStyleBackColor = true;
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciarHorista.Location = new System.Drawing.Point(481, 492);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(162, 94);
            this.btnInstanciarHorista.TabIndex = 19;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.BtnInstanciarHorista_Click);
            // 
            // txtBoxSalarioHoraHorista
            // 
            this.txtBoxSalarioHoraHorista.Location = new System.Drawing.Point(296, 144);
            this.txtBoxSalarioHoraHorista.Name = "txtBoxSalarioHoraHorista";
            this.txtBoxSalarioHoraHorista.Size = new System.Drawing.Size(128, 20);
            this.txtBoxSalarioHoraHorista.TabIndex = 17;
            // 
            // txtBoxNomeHorista
            // 
            this.txtBoxNomeHorista.Location = new System.Drawing.Point(296, 92);
            this.txtBoxNomeHorista.Name = "txtBoxNomeHorista";
            this.txtBoxNomeHorista.Size = new System.Drawing.Size(295, 20);
            this.txtBoxNomeHorista.TabIndex = 16;
            // 
            // txtBoxMatriculaHorista
            // 
            this.txtBoxMatriculaHorista.Location = new System.Drawing.Point(296, 34);
            this.txtBoxMatriculaHorista.Name = "txtBoxMatriculaHorista";
            this.txtBoxMatriculaHorista.Size = new System.Drawing.Size(128, 20);
            this.txtBoxMatriculaHorista.TabIndex = 15;
            // 
            // lblDtEntradaHorista
            // 
            this.lblDtEntradaHorista.AutoSize = true;
            this.lblDtEntradaHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEntradaHorista.Location = new System.Drawing.Point(61, 251);
            this.lblDtEntradaHorista.Name = "lblDtEntradaHorista";
            this.lblDtEntradaHorista.Size = new System.Drawing.Size(195, 20);
            this.lblDtEntradaHorista.TabIndex = 14;
            this.lblDtEntradaHorista.Text = "Data Entrada na Empresa";
            // 
            // lblSalarioHorista
            // 
            this.lblSalarioHorista.AutoSize = true;
            this.lblSalarioHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHorista.Location = new System.Drawing.Point(132, 144);
            this.lblSalarioHorista.Name = "lblSalarioHorista";
            this.lblSalarioHorista.Size = new System.Drawing.Size(124, 20);
            this.lblSalarioHorista.TabIndex = 13;
            this.lblSalarioHorista.Text = "Salário por Hora";
            // 
            // lblNomeHorista
            // 
            this.lblNomeHorista.AutoSize = true;
            this.lblNomeHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeHorista.Location = new System.Drawing.Point(205, 90);
            this.lblNomeHorista.Name = "lblNomeHorista";
            this.lblNomeHorista.Size = new System.Drawing.Size(51, 20);
            this.lblNomeHorista.TabIndex = 12;
            this.lblNomeHorista.Text = "Nome";
            // 
            // lblMatriculaHorista
            // 
            this.lblMatriculaHorista.AutoSize = true;
            this.lblMatriculaHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculaHorista.Location = new System.Drawing.Point(183, 32);
            this.lblMatriculaHorista.Name = "lblMatriculaHorista";
            this.lblMatriculaHorista.Size = new System.Drawing.Size(73, 20);
            this.lblMatriculaHorista.TabIndex = 11;
            this.lblMatriculaHorista.Text = "Matrícula";
            // 
            // txtNumeroHorasHorista
            // 
            this.txtNumeroHorasHorista.Location = new System.Drawing.Point(296, 198);
            this.txtNumeroHorasHorista.Name = "txtNumeroHorasHorista";
            this.txtNumeroHorasHorista.Size = new System.Drawing.Size(128, 20);
            this.txtNumeroHorasHorista.TabIndex = 23;
            // 
            // lblNumeroHorasHorista
            // 
            this.lblNumeroHorasHorista.AutoSize = true;
            this.lblNumeroHorasHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHorasHorista.Location = new System.Drawing.Point(132, 198);
            this.lblNumeroHorasHorista.Name = "lblNumeroHorasHorista";
            this.lblNumeroHorasHorista.Size = new System.Drawing.Size(134, 20);
            this.lblNumeroHorasHorista.TabIndex = 22;
            this.lblNumeroHorasHorista.Text = "Número de Horas";
            // 
            // txtDiasFaltaHorista
            // 
            this.txtDiasFaltaHorista.Location = new System.Drawing.Point(296, 300);
            this.txtDiasFaltaHorista.Name = "txtDiasFaltaHorista";
            this.txtDiasFaltaHorista.Size = new System.Drawing.Size(128, 20);
            this.txtDiasFaltaHorista.TabIndex = 25;
            // 
            // lblDiasFaltaHorista
            // 
            this.lblDiasFaltaHorista.AutoSize = true;
            this.lblDiasFaltaHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasFaltaHorista.Location = new System.Drawing.Point(132, 300);
            this.lblDiasFaltaHorista.Name = "lblDiasFaltaHorista";
            this.lblDiasFaltaHorista.Size = new System.Drawing.Size(103, 20);
            this.lblDiasFaltaHorista.TabIndex = 24;
            this.lblDiasFaltaHorista.Text = "Dias de Falta";
            // 
            // txtDataEntradaHorista
            // 
            this.txtDataEntradaHorista.Location = new System.Drawing.Point(296, 253);
            this.txtDataEntradaHorista.Name = "txtDataEntradaHorista";
            this.txtDataEntradaHorista.Size = new System.Drawing.Size(128, 20);
            this.txtDataEntradaHorista.TabIndex = 24;
            // 
            // FormHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.txtDataEntradaHorista);
            this.Controls.Add(this.txtDiasFaltaHorista);
            this.Controls.Add(this.lblDiasFaltaHorista);
            this.Controls.Add(this.txtNumeroHorasHorista);
            this.Controls.Add(this.lblNumeroHorasHorista);
            this.Controls.Add(this.grpBoxHomeOfficeHorista);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtBoxSalarioHoraHorista);
            this.Controls.Add(this.txtBoxNomeHorista);
            this.Controls.Add(this.txtBoxMatriculaHorista);
            this.Controls.Add(this.lblDtEntradaHorista);
            this.Controls.Add(this.lblSalarioHorista);
            this.Controls.Add(this.lblNomeHorista);
            this.Controls.Add(this.lblMatriculaHorista);
            this.Name = "FormHorista";
            this.Text = "FormHorista";
            this.grpBoxHomeOfficeHorista.ResumeLayout(false);
            this.grpBoxHomeOfficeHorista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxHomeOfficeHorista;
        private System.Windows.Forms.RadioButton rdBtnNaoHorista;
        private System.Windows.Forms.RadioButton rdBtnSimHorista;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.TextBox txtBoxSalarioHoraHorista;
        private System.Windows.Forms.TextBox txtBoxNomeHorista;
        private System.Windows.Forms.TextBox txtBoxMatriculaHorista;
        private System.Windows.Forms.Label lblDtEntradaHorista;
        private System.Windows.Forms.Label lblSalarioHorista;
        private System.Windows.Forms.Label lblNomeHorista;
        private System.Windows.Forms.Label lblMatriculaHorista;
        private System.Windows.Forms.TextBox txtNumeroHorasHorista;
        private System.Windows.Forms.Label lblNumeroHorasHorista;
        private System.Windows.Forms.TextBox txtDiasFaltaHorista;
        private System.Windows.Forms.Label lblDiasFaltaHorista;
        private System.Windows.Forms.TextBox txtDataEntradaHorista;
    }
}