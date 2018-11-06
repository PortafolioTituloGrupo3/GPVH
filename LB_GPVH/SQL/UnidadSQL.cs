using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.SQL
{
    class UnidadSQL
    {



        /// <summary>
        /// Busca la unidad cuyo id es entregado, incluyendo sus unidades hijas.
        /// </summary>
        /// <remarks>
        /// Solo puede obtener hasta 3 niveles de profunidad
        /// </remarks>
        /// <param name="idUnidad"></param>
        /// <returns></returns>
        public Dictionary<int, string> getListadoUnidadesHijasClaveValor(int idUnidad) //Obtiene una unidad y sus unidades hijas
        {
            Dictionary<int, string> ListadoUnidades = new Dictionary<int, string>();
            //Creacion de comando Oracle
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select u.id_unidad, u.nombre_unidad " +
                "from unidad u left " +
                "join unidad pa on u.unidad_padre_id_unidad = pa.id_unidad " +
                "where u.id_unidad = "+idUnidad+ " or u.unidad_padre_id_unidad = " + idUnidad + " or pa.unidad_padre_id_unidad = "+idUnidad;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Se agregan los datos al diccionario
                ListadoUnidades.Add(reader.GetInt32(0), reader.GetString(1));
            }
            con.Close();
            return ListadoUnidades;
        }
    }
}
