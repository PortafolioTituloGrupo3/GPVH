using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Unidades
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSUnidades" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSUnidades.svc o WSUnidades.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSUnidades : IWSUnidades
    {
        private string conString = "DATA SOURCE=localhost:1521/XE;PASSWORD=prueba;USER ID=PRUEBA";
        public List<Unidad> getListadoUnidades()
        {
            List<Unidad> ListadoUnidades = new List<Unidad>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from unidad";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se crea un objeto unidad vacio
                Unidad unidadTemp = new Unidad();
                //Se agregan los datos al objeto unidad
                unidadTemp.Id_unidad = reader.GetInt32(0);
                unidadTemp.Nombre_unidad = reader.GetString(1);
                unidadTemp.Descripcion_unidad = reader.GetString(2);
                unidadTemp.Direccion_unidad = reader.GetString(3);
                unidadTemp.Habilitado = int.Parse(reader.GetValue(4).ToString());
                unidadTemp.Unidad_id_unidad = this.parseNullableInt(reader.GetValue(5).ToString());
                unidadTemp.Funcionario_run_sin_dv = this.parseNullableInt(reader.GetValue(6).ToString());
                //Se agrega la unidad
                ListadoUnidades.Add(unidadTemp);
            }
            return ListadoUnidades;
        }
        public List<Unidad> getListadoUnidadesNoHijas(int id_unidad)
        {
            List<Unidad> ListadoUnidades = new List<Unidad>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from unidad where (UNIDAD_PADRE_ID_UNIDAD != " + id_unidad +
                            " or unidad_padre_id_unidad is null) and id_unidad != " + id_unidad;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se crea un objeto unidad vacio
                Unidad unidadTemp = new Unidad();
                //Se agregan los datos al objeto unidad
                unidadTemp.Id_unidad = reader.GetInt32(0);
                unidadTemp.Nombre_unidad = reader.GetString(1);
                unidadTemp.Descripcion_unidad = reader.GetString(2);
                unidadTemp.Direccion_unidad = reader.GetString(3);
                unidadTemp.Habilitado = int.Parse(reader.GetValue(4).ToString());
                unidadTemp.Unidad_id_unidad = this.parseNullableInt(reader.GetValue(5).ToString());
                unidadTemp.Funcionario_run_sin_dv = this.parseNullableInt(reader.GetValue(6).ToString());
                //Se agrega la unidad
                ListadoUnidades.Add(unidadTemp);
            }
            return ListadoUnidades;
        }
        public Dictionary<int, string> getListadoUnidadesNoHijasClaveValor(int id_unidad) //Obtiene los datos filtrados, entregando solo una clave y el valor
        {
            return this.filterListadoUnidades(getListadoUnidadesNoHijas(id_unidad));
        }
        public Dictionary<int, string> getListadoUnidadesClaveValor() //Obtiene los datos filtrados, entregando solo una clave y el valor
        {
            Dictionary<int, string> ListadoUnidades = new Dictionary<int, string>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select id_unidad, nombre_unidad from unidad";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se agregan los datos al diccionario
                ListadoUnidades.Add(reader.GetInt32(0), reader.GetString(1));
            }
            return ListadoUnidades;
        }
        public Unidad getUnidadById(int id_unidad)
        {
            Unidad unidad = new Unidad();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from unidad where id_unidad = "+id_unidad;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se agregan los datos al objeto unidad
                unidad.Id_unidad = reader.GetInt32(0);
                unidad.Nombre_unidad = reader.GetString(1);
                unidad.Descripcion_unidad = reader.GetString(2);
                unidad.Direccion_unidad = reader.GetString(3);
                unidad.Habilitado = int.Parse(reader.GetValue(4).ToString());
                unidad.Unidad_id_unidad = this.parseNullableInt(reader.GetValue(5).ToString());
                unidad.Funcionario_run_sin_dv = this.parseNullableInt(reader.GetValue(6).ToString());
            }
            return unidad;
        }
        
        public int addUnidad(string nombre, string descripcion, string direccion, 
                            int? unidad_padre, int? jefe)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_CREAR_UNIDAD";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_NOMBRE_UNIDAD", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_DESCRIPCION_UNIDAD", OracleDbType.Varchar2, descripcion, ParameterDirection.Input);
            cmd.Parameters.Add("P_DIRECCION_UNIDAD", OracleDbType.Varchar2, direccion, ParameterDirection.Input);
            cmd.Parameters.Add("P_UNIDAD_PADRE", OracleDbType.Int32, unidad_padre, ParameterDirection.Input);
            cmd.Parameters.Add("P_JEFE_UNIDAD", OracleDbType.Int32, jefe, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int modifyUnidad(int id_unidad, string nombre, string descripcion, string direccion,
                                bool habilitado_bool, int? unidad_padre, int? jefe)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_MODIFICAR_UNIDAD";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_ID_UNIDAD", OracleDbType.Int32, id_unidad, ParameterDirection.Input);
            cmd.Parameters.Add("P_NOMBRE_UNIDAD", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
            cmd.Parameters.Add("P_DESCRIPCION_UNIDAD", OracleDbType.Varchar2, descripcion, ParameterDirection.Input);
            cmd.Parameters.Add("P_DIRECCION_UNIDAD", OracleDbType.Varchar2, direccion, ParameterDirection.Input);
            int habilitado;
            habilitado = habilitado_bool ? 1: 0;
            cmd.Parameters.Add("P_HABILITADO", OracleDbType.Int32, habilitado, ParameterDirection.Input);
            cmd.Parameters.Add("P_UNIDAD_PADRE", OracleDbType.Int32, unidad_padre, ParameterDirection.Input);
            cmd.Parameters.Add("P_JEFE_UNIDAD", OracleDbType.Int32, jefe, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public int deleteUnidad(int id)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "prueba.PR_ELIMINAR_UNIDAD";
            cmd.BindByName = true;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //ENTRADAS
            cmd.Parameters.Add("P_ID_UNIDAD", OracleDbType.Int32, id, ParameterDirection.Input);
            //SALIDA
            cmd.Parameters.Add("P_RETURN_VALUE", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int salida = int.Parse(cmd.Parameters["P_RETURN_VALUE"].Value.ToString());
            return salida;
        }
        public Dictionary<int, string> filterListadoUnidades(List<Unidad> listado)
        {
            Dictionary<int, string> listadoFiltrado = new Dictionary<int, string>();
            foreach(Unidad item in listado)
            {
                listadoFiltrado.Add(item.Id_unidad, item.Nombre_unidad);
            }
            return listadoFiltrado;
        }

        //Metodo para obtener entero o nulo
        private int? parseNullableInt(string valor)
        {
            int salida;
            if (int.TryParse(valor, out salida)) return salida;
            return null;
        }

        public bool unidadExiste(string nombre)
        {
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from unidad where UPPER(nombre_unidad) = UPPER('" + nombre + "')";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;
        }
    }

}
