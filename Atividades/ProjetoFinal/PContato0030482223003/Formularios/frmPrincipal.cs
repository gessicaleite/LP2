using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PContato0030482223003.Formularios
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // aqui a conexão vai depender da sua máquina da escola ou particular 
                conexao = new SqlConnection("Data Source=NOTEBOK-AUTOMAT;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContato objContato = new frmContato();
            objContato.MdiParent = this; //PARA APARECER NO "PAI"
            objContato.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objContato.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade objCidade= new frmCidade();
            objCidade.MdiParent = this; //PARA APARECER NO "PAI"
            objCidade.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objCidade.Show();
        }
    }
}
