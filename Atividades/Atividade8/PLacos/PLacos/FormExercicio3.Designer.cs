namespace PLacos
{
    partial class FormExercicio3
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTxt = new System.Windows.Forms.Label();
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.btnPalindrono = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(750, 264);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(221, 62);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(49, 51);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(222, 16);
            this.lblTxt.TabIndex = 12;
            this.lblTxt.Text = "Digite um texto de até 50 caracteres:";
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(53, 83);
            this.rchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(628, 315);
            this.rchTxt.TabIndex = 11;
            this.rchTxt.Text = "";
            // 
            // btnPalindrono
            // 
            this.btnPalindrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalindrono.Location = new System.Drawing.Point(750, 83);
            this.btnPalindrono.Margin = new System.Windows.Forms.Padding(4);
            this.btnPalindrono.Name = "btnPalindrono";
            this.btnPalindrono.Size = new System.Drawing.Size(221, 62);
            this.btnPalindrono.TabIndex = 22;
            this.btnPalindrono.Text = "Palíndrono?";
            this.btnPalindrono.UseVisualStyleBackColor = true;
            this.btnPalindrono.Click += new System.EventHandler(this.btnPalindrono_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(750, 181);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(221, 34);
            this.txtResultado.TabIndex = 23;
            // 
            // FormExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnPalindrono);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.rchTxt);
            this.Name = "FormExercicio3";
            this.Text = "FormExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Button btnPalindrono;
        private System.Windows.Forms.TextBox txtResultado;
    }
}