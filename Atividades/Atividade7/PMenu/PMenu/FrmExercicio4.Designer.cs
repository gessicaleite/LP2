namespace PMenu
{
    partial class FrmExercicio4
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
            this.rchTxtBox = new System.Windows.Forms.RichTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTotalNumericos = new System.Windows.Forms.Button();
            this.btnPrimeiroCharBranco = new System.Windows.Forms.Button();
            this.btnTotalAlfabetico = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rchTxtBox
            // 
            this.rchTxtBox.Location = new System.Drawing.Point(64, 51);
            this.rchTxtBox.Name = "rchTxtBox";
            this.rchTxtBox.Size = new System.Drawing.Size(745, 162);
            this.rchTxtBox.TabIndex = 0;
            this.rchTxtBox.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(253, 250);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 25);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "Resultado: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(641, 337);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(195, 95);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnTotalNumericos
            // 
            this.btnTotalNumericos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTotalNumericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalNumericos.Location = new System.Drawing.Point(32, 337);
            this.btnTotalNumericos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalNumericos.Name = "btnTotalNumericos";
            this.btnTotalNumericos.Size = new System.Drawing.Size(195, 95);
            this.btnTotalNumericos.TabIndex = 22;
            this.btnTotalNumericos.Text = "Total de caracteres numéricos";
            this.btnTotalNumericos.UseVisualStyleBackColor = false;
            this.btnTotalNumericos.Click += new System.EventHandler(this.btnTotalNumericos_Click);
            // 
            // btnPrimeiroCharBranco
            // 
            this.btnPrimeiroCharBranco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrimeiroCharBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroCharBranco.Location = new System.Drawing.Point(235, 337);
            this.btnPrimeiroCharBranco.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeiroCharBranco.Name = "btnPrimeiroCharBranco";
            this.btnPrimeiroCharBranco.Size = new System.Drawing.Size(195, 95);
            this.btnPrimeiroCharBranco.TabIndex = 23;
            this.btnPrimeiroCharBranco.Text = "Posição primeiro caracter branco";
            this.btnPrimeiroCharBranco.UseVisualStyleBackColor = false;
            this.btnPrimeiroCharBranco.Click += new System.EventHandler(this.btnPrimeiroCharBranco_Click);
            // 
            // btnTotalAlfabetico
            // 
            this.btnTotalAlfabetico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTotalAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalAlfabetico.Location = new System.Drawing.Point(438, 337);
            this.btnTotalAlfabetico.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalAlfabetico.Name = "btnTotalAlfabetico";
            this.btnTotalAlfabetico.Size = new System.Drawing.Size(195, 95);
            this.btnTotalAlfabetico.TabIndex = 24;
            this.btnTotalAlfabetico.Text = "Total de caracteres alfabéticos";
            this.btnTotalAlfabetico.UseVisualStyleBackColor = false;
            this.btnTotalAlfabetico.Click += new System.EventHandler(this.btnTotalAlfabetico_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(371, 254);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(207, 22);
            this.txtResultado.TabIndex = 25;
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnTotalAlfabetico);
            this.Controls.Add(this.btnPrimeiroCharBranco);
            this.Controls.Add(this.btnTotalNumericos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rchTxtBox);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBox;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTotalNumericos;
        private System.Windows.Forms.Button btnPrimeiroCharBranco;
        private System.Windows.Forms.Button btnTotalAlfabetico;
        private System.Windows.Forms.TextBox txtResultado;
    }
}