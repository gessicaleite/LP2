namespace PMatriz
{
    partial class TotalCaracteres
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
            this.btnCalcularCaracteres = new System.Windows.Forms.Button();
            this.lstBoxNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcularCaracteres
            // 
            this.btnCalcularCaracteres.Location = new System.Drawing.Point(91, 152);
            this.btnCalcularCaracteres.Name = "btnCalcularCaracteres";
            this.btnCalcularCaracteres.Size = new System.Drawing.Size(164, 85);
            this.btnCalcularCaracteres.TabIndex = 0;
            this.btnCalcularCaracteres.Text = "Calcular Caracteres";
            this.btnCalcularCaracteres.UseVisualStyleBackColor = true;
            this.btnCalcularCaracteres.Click += new System.EventHandler(this.BtnCalcularCaracteres_Click);
            // 
            // lstBoxNomes
            // 
            this.lstBoxNomes.FormattingEnabled = true;
            this.lstBoxNomes.Location = new System.Drawing.Point(353, 93);
            this.lstBoxNomes.Name = "lstBoxNomes";
            this.lstBoxNomes.Size = new System.Drawing.Size(336, 251);
            this.lstBoxNomes.TabIndex = 1;
            // 
            // TotalCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxNomes);
            this.Controls.Add(this.btnCalcularCaracteres);
            this.Name = "TotalCaracteres";
            this.Text = "TotalCaracteres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCaracteres;
        private System.Windows.Forms.ListBox lstBoxNomes;
    }
}