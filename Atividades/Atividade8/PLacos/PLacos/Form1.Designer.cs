namespace PLacos
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
            this.exercícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exercício2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exercício3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exercício4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exercícioToolStripMenuItem
            // 
            this.exercícioToolStripMenuItem.Name = "exercícioToolStripMenuItem";
            this.exercícioToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.exercícioToolStripMenuItem.Text = "Exercício 1";
            this.exercícioToolStripMenuItem.Click += new System.EventHandler(this.ExercícioToolStripMenuItem_Click);
            // 
            // Exercício2ToolStripMenuItem
            // 
            this.Exercício2ToolStripMenuItem.Name = "Exercício2ToolStripMenuItem";
            this.Exercício2ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.Exercício2ToolStripMenuItem.Text = "Exercício 2";
            this.Exercício2ToolStripMenuItem.Click += new System.EventHandler(this.Exercício2ToolStripMenuItem_Click);
            // 
            // Exercício3ToolStripMenuItem
            // 
            this.Exercício3ToolStripMenuItem.Name = "Exercício3ToolStripMenuItem";
            this.Exercício3ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.Exercício3ToolStripMenuItem.Text = "Exercício 3";
            this.Exercício3ToolStripMenuItem.Click += new System.EventHandler(this.Exercício3ToolStripMenuItem_Click);
            // 
            // Exercício4ToolStripMenuItem
            // 
            this.Exercício4ToolStripMenuItem.Name = "Exercício4ToolStripMenuItem";
            this.Exercício4ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.Exercício4ToolStripMenuItem.Text = "Exercício 4";
            this.Exercício4ToolStripMenuItem.Click += new System.EventHandler(this.Exercício4ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercícioToolStripMenuItem,
            this.Exercício2ToolStripMenuItem,
            this.Exercício3ToolStripMenuItem,
            this.Exercício4ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exercícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exercício2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exercício3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exercício4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

