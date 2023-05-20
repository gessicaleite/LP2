namespace PDescontos
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnCalcularDescontos = new System.Windows.Forms.Button();
            this.gpBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdBtnFeminino = new System.Windows.Forms.RadioButton();
            this.chckBoxCasado = new System.Windows.Forms.CheckBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.txtBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.mkdTxtBoxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.numUpDownFilhos = new System.Windows.Forms.NumericUpDown();
            this.txtBoxINSS = new System.Windows.Forms.TextBox();
            this.txtBoxIR = new System.Windows.Forms.TextBox();
            this.txtBoxSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtBoxDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtBoxDescontoIR = new System.Windows.Forms.TextBox();
            this.txtBoxSalarioLiquido = new System.Windows.Forms.TextBox();
            this.gpBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(31, 55);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(204, 25);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome do Funcionário:";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(105, 133);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(130, 25);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto:";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(64, 211);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(171, 25);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de Filhos:";
            // 
            // btnCalcularDescontos
            // 
            this.btnCalcularDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDescontos.Location = new System.Drawing.Point(437, 294);
            this.btnCalcularDescontos.Name = "btnCalcularDescontos";
            this.btnCalcularDescontos.Size = new System.Drawing.Size(236, 92);
            this.btnCalcularDescontos.TabIndex = 3;
            this.btnCalcularDescontos.Text = "Calcular Descontos";
            this.btnCalcularDescontos.UseVisualStyleBackColor = true;
            this.btnCalcularDescontos.Click += new System.EventHandler(this.btnCalcularDescontos_Click);
            // 
            // gpBoxSexo
            // 
            this.gpBoxSexo.Controls.Add(this.rdBtnMasculino);
            this.gpBoxSexo.Controls.Add(this.rdBtnFeminino);
            this.gpBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxSexo.Location = new System.Drawing.Point(706, 39);
            this.gpBoxSexo.Name = "gpBoxSexo";
            this.gpBoxSexo.Size = new System.Drawing.Size(219, 158);
            this.gpBoxSexo.TabIndex = 4;
            this.gpBoxSexo.TabStop = false;
            this.gpBoxSexo.Text = "Sexo";
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.Location = new System.Drawing.Point(27, 95);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(122, 29);
            this.rdBtnMasculino.TabIndex = 1;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdBtnFeminino
            // 
            this.rdBtnFeminino.AutoSize = true;
            this.rdBtnFeminino.Checked = true;
            this.rdBtnFeminino.Location = new System.Drawing.Point(27, 45);
            this.rdBtnFeminino.Name = "rdBtnFeminino";
            this.rdBtnFeminino.Size = new System.Drawing.Size(113, 29);
            this.rdBtnFeminino.TabIndex = 0;
            this.rdBtnFeminino.TabStop = true;
            this.rdBtnFeminino.Text = "Feminino";
            this.rdBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // chckBoxCasado
            // 
            this.chckBoxCasado.AutoSize = true;
            this.chckBoxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxCasado.Location = new System.Drawing.Point(733, 241);
            this.chckBoxCasado.Name = "chckBoxCasado";
            this.chckBoxCasado.Size = new System.Drawing.Size(103, 29);
            this.chckBoxCasado.TabIndex = 5;
            this.chckBoxCasado.Text = "Casado";
            this.chckBoxCasado.UseVisualStyleBackColor = true;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(31, 409);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 25);
            this.lblResposta.TabIndex = 6;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(93, 479);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(135, 25);
            this.lblINSS.TabIndex = 7;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(122, 557);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(106, 25);
            this.lblIR.TabIndex = 8;
            this.lblIR.Text = "Alíquota IR";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFamilia.Location = new System.Drawing.Point(88, 635);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(140, 25);
            this.lblSalarioFamilia.TabIndex = 9;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(701, 635);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(141, 25);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoINSS.Location = new System.Drawing.Point(701, 479);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(147, 25);
            this.lblDescontoINSS.TabIndex = 11;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIR
            // 
            this.lblDescontoIR.AutoSize = true;
            this.lblDescontoIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoIR.Location = new System.Drawing.Point(701, 557);
            this.lblDescontoIR.Name = "lblDescontoIR";
            this.lblDescontoIR.Size = new System.Drawing.Size(118, 25);
            this.lblDescontoIR.TabIndex = 12;
            this.lblDescontoIR.Text = "Desconto IR";
            // 
            // txtBoxNomeFuncionario
            // 
            this.txtBoxNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomeFuncionario.Location = new System.Drawing.Point(256, 55);
            this.txtBoxNomeFuncionario.Name = "txtBoxNomeFuncionario";
            this.txtBoxNomeFuncionario.Size = new System.Drawing.Size(251, 30);
            this.txtBoxNomeFuncionario.TabIndex = 13;
            // 
            // mkdTxtBoxSalarioBruto
            // 
            this.mkdTxtBoxSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdTxtBoxSalarioBruto.Location = new System.Drawing.Point(256, 128);
            this.mkdTxtBoxSalarioBruto.Mask = "0000.00";
            this.mkdTxtBoxSalarioBruto.Name = "mkdTxtBoxSalarioBruto";
            this.mkdTxtBoxSalarioBruto.Size = new System.Drawing.Size(120, 30);
            this.mkdTxtBoxSalarioBruto.TabIndex = 14;
            // 
            // numUpDownFilhos
            // 
            this.numUpDownFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownFilhos.Location = new System.Drawing.Point(256, 206);
            this.numUpDownFilhos.Name = "numUpDownFilhos";
            this.numUpDownFilhos.Size = new System.Drawing.Size(120, 30);
            this.numUpDownFilhos.TabIndex = 15;
            // 
            // txtBoxINSS
            // 
            this.txtBoxINSS.Enabled = false;
            this.txtBoxINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxINSS.Location = new System.Drawing.Point(249, 474);
            this.txtBoxINSS.Name = "txtBoxINSS";
            this.txtBoxINSS.Size = new System.Drawing.Size(196, 30);
            this.txtBoxINSS.TabIndex = 16;
            // 
            // txtBoxIR
            // 
            this.txtBoxIR.Enabled = false;
            this.txtBoxIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIR.Location = new System.Drawing.Point(249, 552);
            this.txtBoxIR.Name = "txtBoxIR";
            this.txtBoxIR.Size = new System.Drawing.Size(196, 30);
            this.txtBoxIR.TabIndex = 17;
            // 
            // txtBoxSalarioFamilia
            // 
            this.txtBoxSalarioFamilia.Enabled = false;
            this.txtBoxSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalarioFamilia.Location = new System.Drawing.Point(249, 630);
            this.txtBoxSalarioFamilia.Name = "txtBoxSalarioFamilia";
            this.txtBoxSalarioFamilia.Size = new System.Drawing.Size(251, 30);
            this.txtBoxSalarioFamilia.TabIndex = 18;
            // 
            // txtBoxDescontoINSS
            // 
            this.txtBoxDescontoINSS.Enabled = false;
            this.txtBoxDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescontoINSS.Location = new System.Drawing.Point(869, 476);
            this.txtBoxDescontoINSS.Name = "txtBoxDescontoINSS";
            this.txtBoxDescontoINSS.Size = new System.Drawing.Size(251, 30);
            this.txtBoxDescontoINSS.TabIndex = 19;
            // 
            // txtBoxDescontoIR
            // 
            this.txtBoxDescontoIR.Enabled = false;
            this.txtBoxDescontoIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescontoIR.Location = new System.Drawing.Point(869, 557);
            this.txtBoxDescontoIR.Name = "txtBoxDescontoIR";
            this.txtBoxDescontoIR.Size = new System.Drawing.Size(251, 30);
            this.txtBoxDescontoIR.TabIndex = 20;
            // 
            // txtBoxSalarioLiquido
            // 
            this.txtBoxSalarioLiquido.Enabled = false;
            this.txtBoxSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalarioLiquido.Location = new System.Drawing.Point(869, 632);
            this.txtBoxSalarioLiquido.Name = "txtBoxSalarioLiquido";
            this.txtBoxSalarioLiquido.Size = new System.Drawing.Size(251, 30);
            this.txtBoxSalarioLiquido.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 711);
            this.Controls.Add(this.txtBoxSalarioLiquido);
            this.Controls.Add(this.txtBoxDescontoIR);
            this.Controls.Add(this.txtBoxDescontoINSS);
            this.Controls.Add(this.txtBoxSalarioFamilia);
            this.Controls.Add(this.txtBoxIR);
            this.Controls.Add(this.txtBoxINSS);
            this.Controls.Add(this.numUpDownFilhos);
            this.Controls.Add(this.mkdTxtBoxSalarioBruto);
            this.Controls.Add(this.txtBoxNomeFuncionario);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.chckBoxCasado);
            this.Controls.Add(this.gpBoxSexo);
            this.Controls.Add(this.btnCalcularDescontos);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Name = "Form1";
            this.Text = "Desconto INSS";
            this.gpBoxSexo.ResumeLayout(false);
            this.gpBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnCalcularDescontos;
        private System.Windows.Forms.GroupBox gpBoxSexo;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.RadioButton rdBtnFeminino;
        private System.Windows.Forms.CheckBox chckBoxCasado;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.TextBox txtBoxNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mkdTxtBoxSalarioBruto;
        private System.Windows.Forms.NumericUpDown numUpDownFilhos;
        private System.Windows.Forms.TextBox txtBoxINSS;
        private System.Windows.Forms.TextBox txtBoxIR;
        private System.Windows.Forms.TextBox txtBoxSalarioFamilia;
        private System.Windows.Forms.TextBox txtBoxDescontoINSS;
        private System.Windows.Forms.TextBox txtBoxDescontoIR;
        private System.Windows.Forms.TextBox txtBoxSalarioLiquido;
    }
}

