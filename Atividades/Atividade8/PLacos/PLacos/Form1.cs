using System;
using System.Linq;
using System.Windows.Forms;

namespace PLacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExercicio1>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto!");
                Application.OpenForms["FormExercicio1"].Activate();
            }
            else
            {
                FormExercicio1 form1 = new FormExercicio1();
                form1.MdiParent = this;
                form1.WindowState = FormWindowState.Maximized;
                form1.Show();
            }
        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExercicio2>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto!");
                Application.OpenForms["FormExercicio2"].Activate();
            }
            else
            {
                FormExercicio2 form2 = new FormExercicio2();
                form2.MdiParent = this;
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
            }
        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExercicio3>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto!");
                Application.OpenForms["FormExercicio3"].Activate();
            }
            else
            {
                FormExercicio3 form3 = new FormExercicio3();
                form3.MdiParent = this;
                form3.WindowState = FormWindowState.Maximized;
                form3.Show();
            }
        }

        private void Exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormExercicio4>().Count() > 0)
            {
                MessageBox.Show("Formulário já está aberto!");
                Application.OpenForms["FormExercicio4"].Activate();
            }
            else
            {
                FormExercicio4 form4 = new FormExercicio4();
                form4.MdiParent = this;
                form4.WindowState = FormWindowState.Maximized;
                form4.Show();
            }
        }
    }
}
