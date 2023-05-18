namespace PLacos
{
    partial class FormExercicio1
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
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.lblTxt = new System.Windows.Forms.Label();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnLetrasR = new System.Windows.Forms.Button();
            this.btnParLetra = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(32, 49);
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(472, 350);
            this.rchTxt.TabIndex = 0;
            this.rchTxt.Text = "";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(29, 23);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(187, 13);
            this.lblTxt.TabIndex = 2;
            this.lblTxt.Text = "Digite um texto de até 100 caracteres:";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(540, 49);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(166, 50);
            this.btnEspacoBranco.TabIndex = 3;
            this.btnEspacoBranco.Text = "Espaços em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.BtnEspacoBranco_Click);
            // 
            // btnLetrasR
            // 
            this.btnLetrasR.Location = new System.Drawing.Point(540, 122);
            this.btnLetrasR.Name = "btnLetrasR";
            this.btnLetrasR.Size = new System.Drawing.Size(166, 50);
            this.btnLetrasR.TabIndex = 4;
            this.btnLetrasR.Text = "Letras \'R\'";
            this.btnLetrasR.UseVisualStyleBackColor = true;
            this.btnLetrasR.Click += new System.EventHandler(this.BtnLetrasR_Click);
            // 
            // btnParLetra
            // 
            this.btnParLetra.Location = new System.Drawing.Point(540, 196);
            this.btnParLetra.Name = "btnParLetra";
            this.btnParLetra.Size = new System.Drawing.Size(166, 50);
            this.btnParLetra.TabIndex = 5;
            this.btnParLetra.Text = "Pares de letras";
            this.btnParLetra.UseVisualStyleBackColor = true;
            this.btnParLetra.Click += new System.EventHandler(this.BtnParLetra_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(540, 273);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(606, 376);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(537, 378);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(45, 18);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Total:";
            // 
            // FormExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnParLetra);
            this.Controls.Add(this.btnLetrasR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.rchTxt);
            this.Name = "FormExercicio1";
            this.Text = "FormExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnLetrasR;
        private System.Windows.Forms.Button btnParLetra;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}