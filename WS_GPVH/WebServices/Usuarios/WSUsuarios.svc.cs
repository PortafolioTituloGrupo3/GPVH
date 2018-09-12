using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace WS_GPVH
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSUsuarios" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSUsuarios.svc o WSUsuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSUsuarios : IWSUsuarios
    {
        public string conString = "DATA SOURCE=localhost:1521/XE;PASSWORD=prueba;USER ID=PRUEBA";
        public List<Usuario> getListadoUsuarios() {
            List<Usuario> ListadoUsuarios= new List<Usuario>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from usuario";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se crea un objeto unidad vacio
                Usuario usuarioTemp = new Usuario();
                //Se agregan los datos al objeto unidad
                usuarioTemp.Id_usuario = reader.GetInt32(0);
                usuarioTemp.Nombre_usuario = reader.GetString(1);
                usuarioTemp.Clave = reader.GetString(2);
                usuarioTemp.Tipo_usuario = reader.GetString(3);
                usuarioTemp.Funcionario_run_sin_dv = reader.GetInt32(4);
                //Se agrega la unidad
                ListadoUsuarios.Add(usuarioTemp);
            }
            return ListadoUsuarios;
        }
        public Usuario getUsuarioById(int id)
        {
            Usuario usuario = new Usuario();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from usuario where id_usuario = " + id;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se agregan los datos al objeto unidad
                usuario.Id_usuario = reader.GetInt32(0);
                usuario.Nombre_usuario= reader.GetString(1);
                usuario.Clave= reader.GetString(2);
                usuario.Tipo_usuario= reader.GetString(3);
                usuario.Funcionario_run_sin_dv = reader.GetInt32(4);
            }
            return usuario;
        }

        public int addUsuario(string nombre, string clave, string tipo, int run)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_CREAR_USUARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_NOMBRE_USUARIO", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_CLAVE", OracleDbType.Varchar2, clave, ParameterDirection.Input);
            cmd.Parameters.Add("P_TIPO_USUARIO", OracleDbType.Varchar2, tipo, ParameterDirection.Input);
            cmd.Parameters.Add("P_FUNCIONARIO_RUN_SIN_DV", OracleDbType.Int32, run, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int modifyUsuario(int id, string nombre, string clave,
                                string tipo, int run)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_MODIFICAR_USUARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_ID_USUARIO", OracleDbType.Int32, id, ParameterDirection.Input);
            cmd.Parameters.Add("P_NOMBRE_USUARIO", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_CLAVE", OracleDbType.Varchar2, clave, ParameterDirection.Input);
            cmd.Parameters.Add("P_TIPO_USUARIO", OracleDbType.Varchar2, tipo, ParameterDirection.Input);
            cmd.Parameters.Add("P_FUNCIONARIO_RUN_SIN_DV", OracleDbType.Int32, run, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int deleteUsuario(int id)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_ELIMINAR_USUARIO";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_ID_USUARIO", OracleDbType.Int32, id, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }

    }
}
