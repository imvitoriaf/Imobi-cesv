using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace ImobCESV
{
    public class ImovelDAO
    {
        private object referencia;

        public ImovelDAO()
        {

        }

        internal static Imovel pesquisar(string referencia)
        {
            throw new NotImplementedException();
        }

        public void cadastrarImovel(Imovel imovel)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();


                    string sqlQuery = "INSERT INTO imoveis" +
                        "(titulo, atividade, endereco, cep, bairro, cidade, numero, tipoimovel, finalidade, descricao," +
                        " quarto, banheiro, suite, garagem, area, valor, tratar, telefone, agua," +
                        "lavanderia, alarme, academia, camera, churrasqueira, cerca, esgoto, gas, playground, piscina," +
                        "portaria, quintal, quadra, sauna, wifi, referencia)" +
                        "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?," +
                        " ?)";



                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.Add("titulo", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("atividade", OleDbType.VarChar, 10);
                    command.Parameters.Add("endereco", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("cep", OleDbType.Integer, 8);
                    command.Parameters.Add("bairro", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("cidade", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("numero", OleDbType.Integer, 100);
                    command.Parameters.Add("tipoimovel", OleDbType.VarChar, 20);
                    command.Parameters.Add("finalidade", OleDbType.VarChar, 20);
                    command.Parameters.Add("descricao", OleDbType.LongVarChar, 400);
                    command.Parameters.Add("quartos", OleDbType.Integer, 10);
                    command.Parameters.Add("banheiro", OleDbType.Integer, 10);
                    command.Parameters.Add("suite", OleDbType.Integer, 10);
                    command.Parameters.Add("garagem", OleDbType.Integer, 10);
                    command.Parameters.Add("areatotal", OleDbType.VarChar, 300);
                    command.Parameters.Add("valor", OleDbType.VarChar, 255);
                    command.Parameters.Add("tratar", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("telefone", OleDbType.VarChar, 255);
                    command.Parameters.Add("agua", OleDbType.Boolean, 8);
                    command.Parameters.Add("lavanderia", OleDbType.Boolean, 8);
                    command.Parameters.Add("alarme", OleDbType.Boolean, 8);
                    command.Parameters.Add("academia", OleDbType.Boolean, 8);
                    command.Parameters.Add("camera", OleDbType.Boolean, 8);
                    command.Parameters.Add("churrasqueira", OleDbType.Boolean, 8);
                    command.Parameters.Add("cerca", OleDbType.Boolean, 8);
                    command.Parameters.Add("esgoto", OleDbType.Boolean, 8);
                    command.Parameters.Add("gas", OleDbType.Boolean, 8);
                    command.Parameters.Add("playground", OleDbType.Boolean, 8);
                    command.Parameters.Add("piscina", OleDbType.Boolean, 8);
                    command.Parameters.Add("portaria", OleDbType.Boolean, 8);
                    command.Parameters.Add("quintal", OleDbType.Boolean, 8);
                    command.Parameters.Add("quadra", OleDbType.Boolean, 8);
                    command.Parameters.Add("sauna", OleDbType.Boolean, 8);
                    command.Parameters.Add("wifi", OleDbType.Boolean, 8);
                    command.Parameters.Add("referencia", OleDbType.VarChar, 255);



                    command.Parameters[0].Value = imovel.titulo;
                    command.Parameters[1].Value = imovel.ativo;
                    command.Parameters[2].Value = imovel.endereco;
                    command.Parameters[3].Value = int.Parse(imovel.cep);
                    command.Parameters[4].Value = imovel.bairro;
                    command.Parameters[5].Value = imovel.cidade;
                    command.Parameters[6].Value = imovel.numero;
                    command.Parameters[7].Value = imovel.tipoimovel;
                    command.Parameters[8].Value = imovel.finalidade;
                    command.Parameters[9].Value = imovel.descricao;
                    command.Parameters[10].Value = imovel.quartos;
                    command.Parameters[11].Value = imovel.banheiro;
                    command.Parameters[12].Value = imovel.suite;
                    command.Parameters[13].Value = imovel.garagem;
                    command.Parameters[14].Value = imovel.areatotal;
                    command.Parameters[15].Value = imovel.valor;
                    command.Parameters[16].Value = imovel.tratar;
                    command.Parameters[17].Value = imovel.telefone;
                    command.Parameters[18].Value = imovel.agua;
                    command.Parameters[19].Value = imovel.lavanderia;
                    command.Parameters[20].Value = imovel.alarme;
                    command.Parameters[21].Value = imovel.academia;
                    command.Parameters[22].Value = imovel.camera;
                    command.Parameters[23].Value = imovel.churrasqueira;
                    command.Parameters[24].Value = imovel.cerca;
                    command.Parameters[25].Value = imovel.esgoto;
                    command.Parameters[26].Value = imovel.gas;
                    command.Parameters[27].Value = imovel.playground;
                    command.Parameters[28].Value = imovel.piscina;
                    command.Parameters[29].Value = imovel.portaria;
                    command.Parameters[30].Value = imovel.quintal;
                    command.Parameters[31].Value = imovel.quadra;
                    command.Parameters[32].Value = imovel.sauna;
                    command.Parameters[33].Value = imovel.wifi;
                    command.Parameters[34].Value = imovel.referencia;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        internal void cadastrarUsuario(Usuario objusuario)
        {
            throw new NotImplementedException();
        }

        public Imovel ConsultarImovelPorReferencia(string referencia)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM imoveis WHERE referencia = ? ";
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.Add("referencia", OleDbType.VarChar, 255);
                    command.Parameters[0].Value = referencia;
                    command.Prepare();
                    OleDbDataReader reader = command.ExecuteReader();
                    Imovel imovel = null;
                    while (reader.Read())
                    {
                        string referenciaBanco = reader.GetString(reader.GetOrdinal("referencia"));
                        string titulo = reader.GetString(reader.GetOrdinal("titulo"));
                        string atividade = reader.GetString(reader.GetOrdinal("atividade"));
                        string endereco = reader.GetString(reader.GetOrdinal("endereco"));
                        int cep = reader.GetInt32(reader.GetOrdinal("cep"));
                        string bairro = reader.GetString(reader.GetOrdinal("bairro"));
                        string cidade = reader.GetString(reader.GetOrdinal("cidade"));
                        int numero = reader.GetInt32(reader.GetOrdinal("numero"));
                        string tipoimovel = reader.GetString(reader.GetOrdinal("tipoimovel"));
                        string finalidade = reader.GetString(reader.GetOrdinal("finalidade"));
                        string descricao = reader.GetString(reader.GetOrdinal("descricao"));
                        int quartos = reader.GetInt32(reader.GetOrdinal("quarto"));
                        int banheiro = reader.GetInt32(reader.GetOrdinal("banheiro"));
                        int suite = reader.GetInt32(reader.GetOrdinal("suite"));
                        int garagem = reader.GetInt32(reader.GetOrdinal("garagem"));
                        string areatotal = reader.GetString(reader.GetOrdinal("area"));
                        string valor = reader.GetString(reader.GetOrdinal("valor"));
                        string tratar = reader.GetString(reader.GetOrdinal("tratar"));
                        string telefone = reader.GetString(reader.GetOrdinal("telefone"));
                        bool agua = reader.GetBoolean(reader.GetOrdinal("agua"));
                        bool lavanderia = reader.GetBoolean(reader.GetOrdinal("lavanderia"));
                        bool alarme = reader.GetBoolean(reader.GetOrdinal("alarme"));
                        bool academia = reader.GetBoolean(reader.GetOrdinal("academia"));
                        bool camera = reader.GetBoolean(reader.GetOrdinal("camera"));
                        bool churrasqueira = reader.GetBoolean(reader.GetOrdinal("churrasqueira"));
                        bool cerca = reader.GetBoolean(reader.GetOrdinal("cerca"));
                        bool esgoto = reader.GetBoolean(reader.GetOrdinal("esgoto"));
                        bool gas = reader.GetBoolean(reader.GetOrdinal("gas"));
                        bool playground = reader.GetBoolean(reader.GetOrdinal("playground"));
                        bool piscina = reader.GetBoolean(reader.GetOrdinal("piscina"));
                        bool portaria = reader.GetBoolean(reader.GetOrdinal("portaria"));
                        bool quintal = reader.GetBoolean(reader.GetOrdinal("quintal"));
                        bool quadra = reader.GetBoolean(reader.GetOrdinal("quadra"));
                        bool sauna = reader.GetBoolean(reader.GetOrdinal("sauna"));
                        bool wifi = reader.GetBoolean(reader.GetOrdinal("wifi"));
                        imovel = new Imovel(bairro, endereco, cidade, cep.ToString(), numero.ToString(), referencia, titulo,
                            atividade, descricao, quartos, finalidade, tipoimovel, banheiro, suite, garagem, areatotal, valor, 
                            tratar, telefone, agua, lavanderia, alarme, academia, camera, churrasqueira, cerca, esgoto, playground, 
                            gas, piscina, portaria, quintal, quadra, sauna, wifi);
                        break;
                    }

                    return imovel;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void EditarCampos(Imovel imovel)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "UPDATE imoveis " +
                        "SET titulo = ?, atividade = ?, endereco = ?, " +
                        "cep = ?, bairro = ?, cidade = ?,numero = ?, tipoimovel = ?, " +
                        "finalidade = ?, descricao = ?, quarto = ?, banheiro = ?, suite = ?, " +
                        "garagem = ?, area = ?, valor = ?, tratar = ?, telefone = ?, agua = ?, " +
                        "lavanderia = ?, alarme = ?, academia = ?, camera = ?, churrasqueira = ?, " +
                        "cerca = ?, esgoto = ?, gas  = ?, playground = ?, piscina = ?, portaria = ?, " +
                        "quintal = ?, quadra = ?, sauna = ?, wifi = ? WHERE referencia = ?";
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                    
                    command.Parameters.Add("titulo", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("atividade", OleDbType.VarChar, 10);
                    command.Parameters.Add("endereco", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("cep", OleDbType.Integer, 8);
                    command.Parameters.Add("bairro", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("cidade", OleDbType.LongVarChar, 50);
                    command.Parameters.Add("numero", OleDbType.Integer, 100);
                    command.Parameters.Add("tipoimovel", OleDbType.VarChar, 20);
                    command.Parameters.Add("finalidade", OleDbType.VarChar, 20);
                    command.Parameters.Add("descricao", OleDbType.LongVarChar, 400);
                    command.Parameters.Add("quartos", OleDbType.Integer, 10);
                    command.Parameters.Add("banheiro", OleDbType.Integer, 10);
                    command.Parameters.Add("suite", OleDbType.Integer, 10);
                    command.Parameters.Add("garagem", OleDbType.Integer, 10);
                    command.Parameters.Add("areatotal", OleDbType.VarChar, 300);
                    command.Parameters.Add("valor", OleDbType.VarChar, 255);
                    command.Parameters.Add("tratar", OleDbType.LongVarChar, 100);
                    command.Parameters.Add("telefone", OleDbType.VarChar, 255);
                    command.Parameters.Add("agua", OleDbType.Boolean, 8);
                    command.Parameters.Add("lavanderia", OleDbType.Boolean, 8);
                    command.Parameters.Add("alarme", OleDbType.Boolean, 8);
                    command.Parameters.Add("academia", OleDbType.Boolean, 8);
                    command.Parameters.Add("camera", OleDbType.Boolean, 8);
                    command.Parameters.Add("churrasqueira", OleDbType.Boolean, 8);
                    command.Parameters.Add("cerca", OleDbType.Boolean, 8);
                    command.Parameters.Add("esgoto", OleDbType.Boolean, 8);
                    command.Parameters.Add("gas", OleDbType.Boolean, 8);
                    command.Parameters.Add("playground", OleDbType.Boolean, 8);
                    command.Parameters.Add("piscina", OleDbType.Boolean, 8);
                    command.Parameters.Add("portaria", OleDbType.Boolean, 8);
                    command.Parameters.Add("quintal", OleDbType.Boolean, 8);
                    command.Parameters.Add("quadra", OleDbType.Boolean, 8);
                    command.Parameters.Add("sauna", OleDbType.Boolean, 8);
                    command.Parameters.Add("wifi", OleDbType.Boolean, 8);
                    command.Parameters.Add("referencia", OleDbType.VarChar, 255);



                    
                    command.Parameters[0].Value = imovel.titulo;
                    command.Parameters[1].Value = imovel.ativo;
                    command.Parameters[2].Value = imovel.endereco;
                    command.Parameters[3].Value = int.Parse(imovel.cep);
                    command.Parameters[4].Value = imovel.bairro;
                    command.Parameters[5].Value = imovel.cidade;
                    command.Parameters[6].Value = imovel.numero;
                    command.Parameters[7].Value = imovel.tipoimovel;
                    command.Parameters[8].Value = imovel.finalidade;
                    command.Parameters[9].Value = imovel.descricao;
                    command.Parameters[10].Value = imovel.quartos;
                    command.Parameters[11].Value = imovel.banheiro;
                    command.Parameters[12].Value = imovel.suite;
                    command.Parameters[13].Value = imovel.garagem;
                    command.Parameters[14].Value = imovel.areatotal;
                    command.Parameters[15].Value = imovel.valor;
                    command.Parameters[16].Value = imovel.tratar;
                    command.Parameters[17].Value = imovel.telefone;
                    command.Parameters[18].Value = imovel.agua;
                    command.Parameters[19].Value = imovel.lavanderia;
                    command.Parameters[20].Value = imovel.alarme;
                    command.Parameters[21].Value = imovel.academia;
                    command.Parameters[22].Value = imovel.camera;
                    command.Parameters[23].Value = imovel.churrasqueira;
                    command.Parameters[24].Value = imovel.cerca;
                    command.Parameters[25].Value = imovel.esgoto;
                    command.Parameters[26].Value = imovel.gas;
                    command.Parameters[27].Value = imovel.playground;
                    command.Parameters[28].Value = imovel.piscina;
                    command.Parameters[29].Value = imovel.portaria;
                    command.Parameters[30].Value = imovel.quintal;
                    command.Parameters[31].Value = imovel.quadra;
                    command.Parameters[32].Value = imovel.sauna;
                    command.Parameters[33].Value = imovel.wifi;
                    command.Parameters[34].Value = imovel.referencia;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void excluirImovel(string referencia)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionManager.getConexao()))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM imoveis WHERE referencia = ?";
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                    command.Parameters.Add("referencia", OleDbType.VarChar, 255);

                    command.Parameters[0].Value = referencia;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
