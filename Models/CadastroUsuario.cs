using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;
using System.Reflection.Metadata;
using System.Data;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PIETAPA4MaxwellAraujo.Models
{
     public class CadastroUsuario
    {
        private const string DadosConexao = "Database = PIETAPA4; Data Source=localhost; User Id=root;";

        public void testeConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Console.WriteLine("Consegui logar!");

            Conexao.Close();
        
        }

    public void Inserir(Cadastro cadastro)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
              Conexao.Open();
            string Query = "INSERT INTO cadastro (Nome, Email, LoginAcesso, Senha) VALUES (@Nome, @Email, @LoginAcesso, @Senha)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome", cadastro.Nome);
            Comando.Parameters.AddWithValue("@Email", cadastro.Email);
            Comando.Parameters.AddWithValue("@LoginAcesso", cadastro.LoginAcesso);
            Comando.Parameters.AddWithValue("@Senha", cadastro.Senha);
          
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
