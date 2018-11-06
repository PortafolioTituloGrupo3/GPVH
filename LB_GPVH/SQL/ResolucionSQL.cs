using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;
using Oracle.ManagedDataAccess.Client;
using LB_GPVH.Enums;
using LB_GPVH.Controlador;

namespace LB_GPVH.SQL
{
    class ResolucionSQL
    {
        public List<Resolucion> BuscarResolucioness( int mes, int anno, int idUnidad)
        {
            List<Resolucion> resoluciones = new List<Resolucion>();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select r.id_resolucion, r.fec_resolucion,r.estado_resolucion, r.permiso_id_permiso, r.resolvente_run_sin_dv " +
                "FROM resolucion r " +
                "JOIN sol_permiso s on r.permiso_id_permiso = s.id_permiso " +
                "JOIN funcionario f ON f.run_sin_dv = s.solicitante_run_sin_dv " +
                "JOIN unidad u on u.id_unidad = f.unidad_id_unidad " +
                "LEFT JOIN unidad pa on pa.id_unidad = u.unidad_padre_id_unidad " +
                "WHERE extract(MONTH FROM s.fecha_termino) = (" + mes + " - 1) AND extract(YEAR FROM s.fecha_termino) = " + anno + " AND (f.unidad_id_unidad = " + idUnidad + " OR u.unidad_padre_id_unidad = " + idUnidad + " OR pa.unidad_padre_id_unidad = " + idUnidad + ")";
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Resolucion resolucion = new Resolucion();
                resolucion.Id = reader.GetInt32(0);
                resolucion.FechaResolucion = reader.GetDateTime(2);
                resolucion.Estado = (parseNullableInt(reader.GetValue(3).ToString()) == null) ? (EstadoResolucion)2 : (EstadoResolucion)reader.GetInt32(3);
                if (parseNullableInt(reader.GetValue(4).ToString()) != null)
                    resolucion.Permiso = new GestionadorPermiso().BuscarPermisoFull(reader.GetInt32(4));
                if (parseNullableInt(reader.GetValue(5).ToString()) != null)
                    resolucion.Resolvente = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(5));
                resoluciones.Add(resolucion);
            }
            con.Close();
            return resoluciones;
        }

        public List<Resolucion> BuscarResolucioness(int mes, int anno)
        {
            List<Resolucion> resoluciones = new List<Resolucion>();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select r.id_resolucion, r.fec_resolucion,r.estado_resolucion, r.permiso_id_permiso, r.resolvente_run_sin_dv " +
                "FROM resolucion r " +
                "JOIN sol_permiso s on r.permiso_id_permiso = s.id_permiso " +
                "WHERE extract(MONTH FROM s.fecha_termino) = (" + mes + " - 1) AND extract(YEAR FROM s.fecha_termino) = " + anno;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Resolucion resolucion = new Resolucion();
                resolucion.Id = reader.GetInt32(0);
                resolucion.FechaResolucion = reader.GetDateTime(1);
                resolucion.Estado = (parseNullableInt(reader.GetValue(2).ToString()) == null) ? (EstadoResolucion)2 : (EstadoResolucion)reader.GetInt32(2);
                if (parseNullableInt(reader.GetValue(3).ToString()) != null)
                    resolucion.Permiso = new GestionadorPermiso().BuscarPermisoFull(reader.GetInt32(3));
                if (parseNullableInt(reader.GetValue(4).ToString()) != null)
                    resolucion.Resolvente = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(4));
                resoluciones.Add(resolucion);
            }
            con.Close();
            return resoluciones;
        }




        //Metodo para obtener entero o nulo
        private int? parseNullableInt(string valor)
        {
            int salida;
            if (int.TryParse(valor, out salida)) return salida;
            return null;
        }


    }
}
