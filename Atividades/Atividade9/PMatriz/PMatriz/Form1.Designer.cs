namespace PMatriz
{
    partial class Form1
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
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListaAlunos = new System.Windows.Forms.Button();
            this.btnCalcularCaracteres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(141, 224);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(156, 125);
            this.btnCalcularMedia.TabIndex = 0;
            this.btnCalcularMedia.Text = "Calcular Médias";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.BtnCalcularMedia_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(58, 30);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(156, 125);
            this.btnInverter.TabIndex = 1;
            this.btnInverter.Text = "Inverter";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.BtnInverter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "Armazém";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnListaAlunos
            // 
            this.btnListaAlunos.Location = new System.Drawing.Point(483, 30);
            this.btnListaAlunos.Name = "btnListaAlunos";
            this.btnListaAlunos.Size = new System.Drawing.Size(156, 125);
            this.btnListaAlunos.TabIndex = 3;
            this.btnListaAlunos.Text = "Lista Alunos";
            this.btnListaAlunos.UseVisualStyleBackColor = true;
            this.btnListaAlunos.Click += new System.EventHandler(this.BtnListaAlunos_Click);
            // 
            // btnCalcularCaracteres
            // 
            this.btnCalcularCaracteres.Location = new System.Drawing.Point(389, 224);
            this.btnCalcularCaracteres.Name = "btnCalcularCaracteres";
            this.btnCalcularCaracteres.Size = new System.Drawing.Size(156, 125);
            this.btnCalcularCaracteres.TabIndex = 4;
            this.btnCalcularCaracteres.Text = "Calcular Caracteres (form 6)";
            this.btnCalcularCaracteres.UseVisualStyleBackColor = true;
            this.btnCalcularCaracteres.Click += new System.EventHandler(this.BtnCalcularCaracteres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularCaracteres);
            this.Controls.Add(this.btnListaAlunos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnCalcularMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListaAlunos;
        private System.Windows.Forms.Button btnCalcularCaracteres;
    }
}

