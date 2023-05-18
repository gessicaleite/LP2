namespace PLacos
{
    partial class FormExercicio4
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCargo = new System.Windows.Forms.TextBox();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.txtBoxProducao = new System.Windows.Forms.TextBox();
            this.txtBoxGratificacao = new System.Windows.Forms.TextBox();
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(598, 415);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 24);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Salário Bruto: ";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(745, 409);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(160, 30);
            this.txtResultado.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(676, 212);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(221, 62);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(35, 48);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 22);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(35, 121);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(64, 22);
            this.lblCargo.TabIndex = 19;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(35, 194);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(87, 22);
            this.lblMatricula.TabIndex = 20;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducao.Location = new System.Drawing.Point(35, 267);
            this.lblProducao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(92, 22);
            this.lblProducao.TabIndex = 21;
            this.lblProducao.Text = "Produção:";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificacao.Location = new System.Drawing.Point(35, 413);
            this.lblGratificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(111, 22);
            this.lblGratificacao.TabIndex = 22;
            this.lblGratificacao.Text = "Gratificação:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(35, 340);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(71, 22);
            this.lblSalario.TabIndex = 23;
            this.lblSalario.Text = "Salário:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(676, 86);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(221, 62);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(178, 42);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(258, 28);
            this.txtBoxNome.TabIndex = 25;
            // 
            // txtBoxCargo
            // 
            this.txtBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCargo.Location = new System.Drawing.Point(178, 115);
            this.txtBoxCargo.Name = "txtBoxCargo";
            this.txtBoxCargo.Size = new System.Drawing.Size(258, 28);
            this.txtBoxCargo.TabIndex = 26;
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMatricula.Location = new System.Drawing.Point(178, 188);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(258, 28);
            this.txtBoxMatricula.TabIndex = 27;
            // 
            // txtBoxProducao
            // 
            this.txtBoxProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProducao.Location = new System.Drawing.Point(178, 261);
            this.txtBoxProducao.Name = "txtBoxProducao";
            this.txtBoxProducao.Size = new System.Drawing.Size(258, 28);
            this.txtBoxProducao.TabIndex = 28;
            // 
            // txtBoxGratificacao
            // 
            this.txtBoxGratificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGratificacao.Location = new System.Drawing.Point(178, 407);
            this.txtBoxGratificacao.Name = "txtBoxGratificacao";
            this.txtBoxGratificacao.Size = new System.Drawing.Size(258, 28);
            this.txtBoxGratificacao.TabIndex = 29;
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalario.Location = new System.Drawing.Point(178, 334);
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(258, 28);
            this.txtBoxSalario.TabIndex = 29;
            // 
            // FormExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 569);
            this.Controls.Add(this.txtBoxSalario);
            this.Controls.Add(this.txtBoxGratificacao);
            this.Controls.Add(this.txtBoxProducao);
            this.Controls.Add(this.txtBoxMatricula);
            this.Controls.Add(this.txtBoxCargo);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNome);
            this.Name = "FormExercicio4";
            this.Text = "FormExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCargo;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.TextBox txtBoxProducao;
        private System.Windows.Forms.TextBox txtBoxGratificacao;
        private System.Windows.Forms.TextBox txtBoxSalario;
    }
}