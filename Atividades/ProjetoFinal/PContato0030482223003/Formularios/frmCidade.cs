using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PContato0030482223003;

namespace PContato0030482223003.Formularios
{
    public partial class frmCidade : Form
    {


        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }


        private void frmCidade_Load(object sender, EventArgs e)
        {


            {
                try
                {
                    Cidade Cid = new Cidade();
                    dsCidade.Tables.Add(Cid.Listar());
                    bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    dgvCidade.DataSource = bnCidade;
                    //bnCidade.BindingSource = bnCidade;
                    txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                    txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                    cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
