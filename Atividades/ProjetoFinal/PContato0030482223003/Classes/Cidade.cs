using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PContato0030482223003.Classes
{
    class Cidade
    {
        private int ID_Cidade;
        private string NomeCidade;
        private string UF;

        public int ID_Cidade1 { get => ID_Cidade; set => ID_Cidade = value; }
        public string NomeCidade1 { get => NomeCidade; set => NomeCidade = value; }
        public string UF1
        {
            get => UF; set => UF = value;


        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE", Form1.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }
        public int Salvar()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES (@nome_cidade, @uf_cidade)", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade",
               SqlDbType.VarChar)); ;
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade",
               SqlDbType.VarChar));
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Alterar()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE TBCIDADE SET nome_cidade = 
               @nome_cidade, uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", 
               Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_cidade",
               SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade",
               SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade",
               SqlDbType.Char));
                mycommand.Parameters["@id_cidade"].Value = idcidade;
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM TBCIDADE WHERE 
               id_cidade = @id_cidade", Form1.conexao); 


                mycommand.Parameters.Add(new SqlParameter("@id_cidade",
               SqlDbType.Int));
                mycommand.Parameters["@id_cidade"].Value =
               Convert.ToInt16(idcidade);
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

    }
