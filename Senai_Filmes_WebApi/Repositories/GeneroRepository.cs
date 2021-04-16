using Senai_Filmes_WebApi.Domains;
using Senai_Filmes_WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Filmes_WebApi.Repositories
{
    /// <summary>
    /// classe responsavel pelo repositorio dos generos
    /// </summary>
    public class GeneroRepository : IGenerosRepository
    {
        //private string stringConexao = "Data Souce = DESKTOP-5GTFAN8; initial catalog= Filmes; user Id = sa; pwd = buck0315";
        private string stringConexao = "Data Source=DESKTOP-5GTFAN8; initial catalog=Filmes; user Id=sa; pwd=buck0315; integrated security=true";
        public void AtualizarIdCorpo(GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain NovoGenero)
        {   //declara a conexão con passando a string de conexão como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string QueryInsert = "INSERT INTO Generos(Nome) VALUES ('"+ NovoGenero.NomeGenero +"')";

                //declara o slqcommand cmd passando a query que será executada e a conexão como parametro
                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    //abre a conexão com o banco de dados
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {   
            List<GeneroDomain> listGeneros = new List<GeneroDomain>();
            //Declara a SqlConnection con passando a string de conexão como parametro
            using (SqlConnection con = new SqlConnection(stringConexao))
            {   //declara a instrução a ser executada
                string querySelectAll = "SELECT idGenero, Nome FROM Generos";

                //Abre a conexão com BDD
                con.Open();

                //declara sqlDataReader rdr para percorrer a tabela do bdd
                SqlDataReader rdr;

                //declara o sqlcommand cmd  passando a query que será executada e a conexão como parametros
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //enquanto houver registros para ser lidos no rdr, o laço se repete
                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //atribui a propriedade idGenero o valor da primeira coluna da tabela do banco de dados
                            IdGenero = Convert.ToInt32(rdr[0]),
                            //atribui a propriedade NomeGenero o valor da segunda coluna da tabela do banco de dados
                            NomeGenero = rdr[1].ToString()


                        };
                        //adiciona o objeto criado a lista de generos
                        listGeneros.Add(genero);
                    }
                }
            }

            //retorna a lista de generos
            return (listGeneros);
        }
        
    }
}
