using System;
using System.Data;
using System.Net;
using Npgsql;

namespace Suporte
{
    class DAL
    {

        public string Hostname { get; set; }
        public string Setor { get; set; }
        public string Predio { get; set; }
        public string Solicitacao { get; set; }
        public int Ramal { get; set; }
        public string Descricao { get; set; }
        public string IP { get; set; }
        public int Codigo { get; set; }
        public string Observacao { get; set; }
        public string Ativo { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        static readonly string serverName = "127.0.0.1";                                          //localhost
        static readonly string port = "5432";                                                            //porta default
        static readonly string userName = "postgres";                                               //host do administrador
        static readonly string password = "12345";                                             //Senha do administrador
        static readonly string databaseName = "postgres";                                       //host do banco de dados
        NpgsqlConnection pgsqlConnection = null;
        readonly string connString = null;

        public DAL()
        {
            connString = String.Format("Server={0};Port={1}; UserID={2}; Password={3};Database={4};",
                serverName, port, userName, password, databaseName);
        }
        internal void AtualizaChamado(string Observacao, int Codigo)
        {
            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    string finaliz = "finalizado";
                    pgsqlConnection.Open();
                    string cmdAtualiza = String.Format("Update suporte Set Observacao = '" + Observacao + "' , status = '" + finaliz + "', fechamento = '" + DateTime.Now +
                            "', Ativo = '0' Where id_chamado = " + Codigo) ;

                    using NpgsqlCommand pgsqlcommand = new(cmdAtualiza, pgsqlConnection);
                    pgsqlcommand.ExecuteNonQuery();
                    pgsqlConnection.Close();
                }
            }
            catch (NpgsqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                pgsqlConnection.Close();
            }
        }
        public DataTable GetTodosRegistros()
        {
            DataTable dt = new();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from suporte where ativo = 1 order by id_chamado ";

                    using NpgsqlDataAdapter Adpt = new(cmdSeleciona, pgsqlConnection);
                    Adpt.Fill(dt);
                }
            }
            catch (NpgsqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }


        public DataTable GetRegistrosInativos()
        {
            DataTable dt = new();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    pgsqlConnection.Open();
                    string cmdSeleciona = "Select * from suporte where ativo = 0 order by id_chamado ";

                    using NpgsqlDataAdapter Adpt = new(cmdSeleciona, pgsqlConnection);
                    Adpt.Fill(dt);
                }
            }
            catch (NpgsqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                pgsqlConnection.Close();
            }
            return dt;
        }

        internal void InserirRegistros(string Hostname, string Setor, string Predio, string Solicitacao, int Ramal, string Descricao, string IP)
        {
            try
            {
                using NpgsqlConnection pgsqlConnection = new(connString);
                //Abra a conexão com o PgSQL                  
                pgsqlConnection.Open();
                string cmdInserir = String.Format("Insert into suporte(Host, Usuario, Setor, Predio, Solicitacao, Ramal, Descricao, abertura, IP,status, Ativo) " +
                    "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','Aberto','1')", Hostname, System.Security.Principal.WindowsIdentity.GetCurrent().Name, Setor, Predio, Solicitacao, Ramal, Descricao, DateTime.Now, IP);
                using NpgsqlCommand pgsqlcommand = new(cmdInserir, pgsqlConnection);
                pgsqlcommand.ExecuteNonQuery();
                pgsqlConnection.Close();
            }
            catch (NpgsqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }

    }
}
    

