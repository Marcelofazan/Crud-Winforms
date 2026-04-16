using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace SampleCRUD.DAO
{
    class PessoaDAO
    {
        private Helpers.dbs db;
        private MySqlConnection con;
        public PessoaDAO()
        {

        }

        public void InserirDados(String RazaoSocial, String NomeFantasia, String Cnpj, String InscrEstadual, String InscrMunicipal, DateTime DataCadastro, String Email, String Celular, String Usuario, String Senha, String IeDestinatario)
        {
            con = new MySqlConnection();
            db = new Helpers.dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO Pessoa (RazaoSocial, NomeFantasia, Cnpj, InscrEstadual, InscrMunicipal, DataCadastro, Email, Celular, Usuario, Senha, IeDestinatario) VALUES";
            query += "(?RazaoSocial, ?NomeFantasia, ?Cnpj, ?InscrEstadual, ?InscrMunicipal, ?DataCadastro, ?Email, ?Celular, Usuario, Senha, IeDestinatario)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?RazaoSocial", RazaoSocial);
                cmd.Parameters.AddWithValue("?NomeFantasia", NomeFantasia);
                cmd.Parameters.AddWithValue("?Cnpj", Cnpj);
                cmd.Parameters.AddWithValue("?InscrEstadual", InscrEstadual);
                cmd.Parameters.AddWithValue("?InscrMunicipal", InscrMunicipal);
                cmd.Parameters.AddWithValue("?DataCadastro", DataCadastro);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Celular", Celular);
                cmd.Parameters.AddWithValue("?Usuario", Usuario);
                cmd.Parameters.AddWithValue("?Senha", Senha);
                cmd.Parameters.AddWithValue("?IeDestinatario", IeDestinatario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(String RazaoSocial, String NomeFantasia, String Cnpj, String InscrEstadual, String InscrMunicipal, DateTime DataCadastro, String Email, String Celular, String Usuario, String Senha, String IeDestinatario, Int32 Id)
        {
            con = new MySqlConnection();
            db = new Helpers.dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE Pessoa SET RazaoSocial = ?RazaoSocial, NomeFantasia = ?NomeFantasia, Cnpj = ?Cnpj, InscrEstadual = ?InscrEstadual, InscrMunicipal = ?InscrMunicipal, DataCadastro = ?DataCadastro, Email = ?Email, Celular = ?Celular, Usuario = ?Usuario, Senha = ?Senha, IeDestinatario = ?IeDestinatario ";
            query += " WHERE Id = ?Id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?RazaoSocial", RazaoSocial);
                cmd.Parameters.AddWithValue("?NomeFantasia", NomeFantasia);
                cmd.Parameters.AddWithValue("?Cnpj", Cnpj);
                cmd.Parameters.AddWithValue("?InscrEstadual", InscrEstadual);
                cmd.Parameters.AddWithValue("?InscrMunicipal", InscrMunicipal);
                cmd.Parameters.AddWithValue("?DataCadastro", DataCadastro);
                cmd.Parameters.AddWithValue("?Email", Email);
                cmd.Parameters.AddWithValue("?Celular", Celular);
                cmd.Parameters.AddWithValue("?Usuario", Usuario);
                cmd.Parameters.AddWithValue("?Senha", Senha);
                cmd.Parameters.AddWithValue("?IeDestinatario", IeDestinatario);
                cmd.Parameters.AddWithValue("?Id", Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDados(String RazaoSocial, Int32 Id)
        {
            con = new MySqlConnection();
            db = new Helpers.dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM Pessoa ";
            query += "WHERE RazaoSocial = ?RazaoSocial AND Id = ?Id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?RazaoSocial", RazaoSocial);
                cmd.Parameters.AddWithValue("?Id", Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}