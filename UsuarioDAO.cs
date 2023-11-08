using ImobCESV;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ImobCESV
{
    public class UsuarioDAO
    {
        public UsuarioDAO()
        {

        }


        public void cadastrarUsuario(Usuario usuario)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();


                    string sqlQuery = "INSERT INTO usuarios" +
                        "(nome, email, senha)" +
                        "VALUES(?, ?, ?)";



                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.Add("nome", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("email", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("senha", OleDbType.VarChar, 100);


                    command.Parameters[0].Value = usuario.nome;
                    command.Parameters[1].Value = usuario.email;
                    command.Parameters[2].Value = usuario.senha;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ConsultarUsuarioPorEmail(string email)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    bool emailEncontrado = false;
                    connection.Open();
                    string sqlQuery = "SELECT * FROM usuarios WHERE email = ? ";
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.Add("email", OleDbType.LongVarChar, 100);
                    command.Parameters[0].Value = email;
                    command.Prepare();
                    OleDbDataReader reader = command.ExecuteReader();
                    emailEncontrado = reader.HasRows;
                    return emailEncontrado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Usuario logar(string email, string senha)
        {

            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM usuarios WHERE email = ? AND senha = ? ";
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.Add("email", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("senha", OleDbType.VarChar, 100);
                    command.Parameters[0].Value = email;
                    command.Parameters[1].Value = senha;

                    command.Prepare();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows) {
                        throw new Exception("Usuário não encontrado");
                    }
                    Usuario usuario = new Usuario();
                    while (reader.Read())
                    {
                        usuario.email = reader.GetString(reader.GetOrdinal("email"));
                        usuario.nome = reader.GetString(reader.GetOrdinal("nome"));
                    }
                    return usuario;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}


    