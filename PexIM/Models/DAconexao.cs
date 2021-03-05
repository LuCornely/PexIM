using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PexIM.Models
{
    public class DAconexao
    {
        public Usuarios GetLogin(string connectinString, Usuarios usuario)
        {
            if (usuario != null)
            {
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectinString))
                    {
                        OracleCommand command = new OracleCommand();
                        command.CommandText = "SELECT * FROM ADMUSER WHERE LOGIN = :login and SENHA = :senha";
                        command.Parameters.Add(":login", OracleDbType.NVarchar2).Value = usuario.Login;
                        command.Parameters.Add(":senha", OracleDbType.NVarchar2).Value = usuario.Senha;



                        command.Connection = connection;
                        connection.Open();

                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            //usuario.Logado = true;
                            //usuario.CodUsuario = reader["CODADMUSER"].ToString();
                            string DataAtualizacao = reader["DATAATUALIZACAO"].ToString();
                            //usuario.Grupo = reader["GRUPO"].ToString();
                            usuario.Nome = reader["NOME"].ToString();
                            //usuario.Filtro = "";
                            usuario.Login = usuario.Login;

                            if (DataAtualizacao == "" || Convert.ToDateTime(DataAtualizacao) < DateTime.Now.AddMonths(-3))
                            {
                                //usuario.TrocarSenha = true;
                                return usuario;
                            }

                            //if (usuario.Grupo == "Consulta")
                            {
                                var queryCoordenador = string.Format("SELECT * FROM VW_WF_WORKFLOW_APPROVER WHERE idlogin = '{0}' AND active = 1", usuario.Login);

                                //usuario.Filtro = GetFiltro(connectinString, queryCoordenador);
                            }

                            //if (usuario.Grupo == "Representante")
                            {
                                //usuario.Filtro = reader["MAQU"].ToString();
                            }

                            //if (usuario.Grupo == "Cliente")
                            {
                                //usuario.Filtro = usuario.Login;
                            }
                        }
                    }
                }

                catch (Exception e)
                {

                }
            }
            return usuario;
        }
    }
}
