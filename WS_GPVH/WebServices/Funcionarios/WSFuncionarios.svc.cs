using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Funcionarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSFuncionarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSFuncionarios.svc o WSFuncionarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSFuncionarios : IWSFuncionarios
    {
        private string conString = "DATA SOURCE=localhost:1521/XE;PASSWORD=prueba;USER ID=PRUEBA";
        public List<Funcionario> getListadoFuncionarios()
        {
            List<Funcionario> ListadoFuncionario = new List<Funcionario>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from funcionario";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se crea un objeto unidad vacio
                Funcionario funcionarioTemp = new Funcionario();
                //Se agregan los datos al objeto unidad
                funcionarioTemp.Run_sin_dv = reader.GetInt32(0);
                funcionarioTemp.Run_dv = reader.GetInt32(1);
                funcionarioTemp.Nom_funcionario = reader.GetString(2);
                funcionarioTemp.Ap_paterno = reader.GetString(3);
                funcionarioTemp.Ap_materno = reader.GetString(4);
                funcionarioTemp.Fec_nacimiento = reader.GetDateTime(5);
                funcionarioTemp.Correo = reader.GetString(6);
                funcionarioTemp.Direc_funcionario = reader.GetString(7);
                funcionarioTemp.Cargo = reader.GetString(8);
                funcionarioTemp.Habilitado = reader.GetInt32(9);
                funcionarioTemp.Unidad_id_unidad = reader.GetInt32(10);
                //Se agrega la unidad
                ListadoFuncionario.Add(funcionarioTemp);
            }
            return ListadoFuncionario;
        }

        public Funcionario getFuncionarioByRun(int run)
        {
            Funcionario funcionario = new Funcionario();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from funcionario where run_sin_dv = " + run;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se agregan los datos al objeto unidad
                funcionario.Run_sin_dv = reader.GetInt32(0);
                funcionario.Run_dv = reader.GetInt32(1);
                funcionario.Nom_funcionario= reader.GetString(2);
                funcionario.Ap_paterno = reader.GetString(3);
                funcionario.Ap_materno = reader.GetString(4);
                funcionario.Fec_nacimiento = reader.GetDateTime(5);
                funcionario.Correo = reader.GetString(6);
                funcionario.Direc_funcionario= reader.GetString(7);
                funcionario.Cargo = reader.GetString(8);
                funcionario.Habilitado = reader.GetInt32(9);
                funcionario.Unidad_id_unidad = reader.GetInt32(10);
            }
            con.Close();
            return funcionario;
        }
        public Dictionary<int, string> getListadoFuncionariosClaveValor()
        {
            Dictionary<int, string> listado = new Dictionary<int, string>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select RUN_SIN_DV, " +
                                    "NOM_FUNCIONARIO || ' ' || AP_PATERNO || ' ' || AP_PATERNO as NOMBRE " +
                               "from funcionario";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listado.Add(reader.GetInt32(0), reader.GetString(1));
            }
            return listado;
        }
        public Dictionary<int, string> getListadoFuncionariosNoJefesClaveValor()
        {
            Dictionary<int, string> listado = new Dictionary<int, string>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =  "Select RUN_SIN_DV, "+
                                    "NOM_FUNCIONARIO || ' ' || AP_PATERNO || ' ' || AP_PATERNO as NOMBRE "+
                               "from funcionario F "+
                               "where NOT EXISTS(SELECT 1 "+
                                                "FROM unidad "+
                                                "WHERE jefe_unidad_run_sin_dv = F.run_sin_dv)";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listado.Add(reader.GetInt32(0), reader.GetString(1));
            }
            return listado;
        }
        public Dictionary<int, string> getListadoFuncionariosNoJefesNoClaveValorModificar(int id_unidad)
        {
            Dictionary<int, string> listado = new Dictionary<int, string>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select RUN_SIN_DV, " +
                                    "NOM_FUNCIONARIO || ' ' || AP_PATERNO || ' ' || AP_PATERNO as NOMBRE " +
                               "from funcionario F " +
                               "where NOT EXISTS(SELECT 1 " +
                                                "FROM unidad " +
                                                "WHERE jefe_unidad_run_sin_dv = F.run_sin_dv) or "+
                                      "EXISTS(SELECT 1 " +
                                                "FROM unidad " +
                                                "WHERE jefe_unidad_run_sin_dv = F.run_sin_dv and id_unidad = "+id_unidad+")";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listado.Add(reader.GetInt32(0), reader.GetString(1));
            }
            return listado;
        }
        
        public int addFuncionario(int run, int dv, string nombre, string ap_pat,
                            string ap_mat, DateTime nacimiento, string correo,
                            string direccion, string tipo_funcionario,
                            int id_unidad)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_CREAR_FUNCIONARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_RUN_SIN_DV", OracleDbType.Int32, run, ParameterDirection.Input);
            cmd.Parameters.Add("P_RUN_DV", OracleDbType.Int32, dv, ParameterDirection.Input);
            cmd.Parameters.Add("P_NOM_FUNCIONARIO", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_AP_PATERNO", OracleDbType.Varchar2, ap_pat, ParameterDirection.Input);
            cmd.Parameters.Add("P_AP_MATERNO", OracleDbType.Varchar2, ap_mat, ParameterDirection.Input);
            cmd.Parameters.Add("P_FEC_NACIMIENTO", OracleDbType.Date, nacimiento, ParameterDirection.Input);
            cmd.Parameters.Add("P_CORREO", OracleDbType.Varchar2, correo, ParameterDirection.Input);
            cmd.Parameters.Add("P_DIREC_FUNCIONARIO", OracleDbType.Varchar2, direccion, ParameterDirection.Input);
            cmd.Parameters.Add("P_CARGO", OracleDbType.Varchar2, tipo_funcionario, ParameterDirection.Input);
            cmd.Parameters.Add("P_UNIDAD_ID_UNIDAD", OracleDbType.Int32, id_unidad, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int modifyFuncionario(int run, string nombre, string ap_pat,
                            string ap_mat, DateTime nacimiento, string correo,
                            string direccion, string tipo_funcionario,
                            bool habilitado_bool, int id_unidad)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_MODIFICAR_FUNCIONARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_RUN_SIN_DV", OracleDbType.Int32, run, ParameterDirection.Input);
            cmd.Parameters.Add("P_NOM_FUNCIONARIO", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_AP_PATERNO", OracleDbType.Varchar2, ap_pat, ParameterDirection.Input);
            cmd.Parameters.Add("P_AP_MATERNO", OracleDbType.Varchar2, ap_mat, ParameterDirection.Input);
            cmd.Parameters.Add("P_FEC_NACIMIENTO", OracleDbType.Date, nacimiento, ParameterDirection.Input);
            cmd.Parameters.Add("P_CORREO", OracleDbType.Varchar2, correo, ParameterDirection.Input);
            cmd.Parameters.Add("P_DIREC_FUNCIONARIO", OracleDbType.Varchar2, direccion, ParameterDirection.Input);
            cmd.Parameters.Add("P_CARGO", OracleDbType.Varchar2, tipo_funcionario, ParameterDirection.Input);
            cmd.Parameters.Add("P_UNIDAD_ID_UNIDAD", OracleDbType.Int32, id_unidad, ParameterDirection.Input);
            int habilitado;
            habilitado = habilitado_bool ? 1: 0;
            cmd.Parameters.Add("P_HABILITADO", OracleDbType.Int32, habilitado, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int deleteFuncionario(int run)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_ELIMINAR_FUNCIONARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_RUN_SIN_DV", OracleDbType.Int32, run, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
    }
}
