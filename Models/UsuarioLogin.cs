using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PIETAPA4MaxwellAraujo.Models
{
     public class UsuarioLogin
    {
        private const string DadosConexao = "Database=PIETAPA4; Data Source=localhost; User Id=root;";


        public LoginAcesso ValidarLogin(LoginAcesso loginAcesso)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM LoginAcesso WHERE login=@Login AND Senha=@Senha";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Login", loginAcesso.login);
            Comando.Parameters.AddWithValue("@Senha", loginAcesso.senha);
            MySqlDataReader Reader = Comando.ExecuteReader();

            LoginAcesso LoginAcessoEncontrado = new LoginAcesso();

            if(Reader.Read())
            {
                LoginAcessoEncontrado.id = Reader.GetInt32("Id");
                
               
                if(!Reader.IsDBNull(Reader.GetOrdinal("login")))                    
                    LoginAcessoEncontrado.login = Reader.GetString("login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("senha")))                    
                    LoginAcessoEncontrado.senha = Reader.GetString("senha");
            }
            Conexao.Close();
            return LoginAcessoEncontrado;
        }

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();
        }
    }
}