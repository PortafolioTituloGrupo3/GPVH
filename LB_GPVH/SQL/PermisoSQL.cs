using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Enums;
using LB_GPVH.Modelo;
using Oracle.ManagedDataAccess.Client;
using LB_GPVH.Controlador;

/// <summary>
/// Esta clase es temporal y su uso es exclusivo de la fase de desarrollo del proyecto. Su desaparicion deberia producirse despues de la fase de intergracion
/// </summary>
namespace LB_GPVH.SQL
{
    public class PermisoSQL
    {
        public List<Permiso> BuscarPermisos(int run)
        {
            List<Permiso> permisos = new List<Permiso>();
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select id_permiso, tipo_permiso, estado, fecha_inicio, fecha_termino, fecha_solicitud, desc_permiso, solicitante_run_sin_dv, autorizante_run_sin_dv from sol_permiso where solicitante_run_sin_dv = "+run;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Permiso permiso = new Permiso();
                permiso.Id = reader.GetInt32(0);
                permiso.Tipo = MetodosTipoPermiso.setTipo(reader.GetString(1));
                permiso.Estado = (parseNullableInt(reader.GetValue(2).ToString()) == null) ? (EstadoPermiso)2 : (EstadoPermiso)reader.GetInt32(2);
                permiso.FechaInicio = reader.GetDateTime(3);
                permiso.FechaTermino = reader.GetDateTime(4);
                permiso.FechaSolicitud = reader.GetDateTime(5);
                permiso.Descripcion = reader.GetString(6);
                if (parseNullableInt(reader.GetValue(7).ToString()) != null)
                    permiso.Solicitante = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(7));
                if (parseNullableInt(reader.GetValue(8).ToString()) != null)
                    permiso.Autorizante = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(8));
                permisos.Add(permiso);
            }
            con.Close();
            return permisos;
        }


        public Permiso BuscarPermisoFull(int id)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT id_permiso, tipo_permiso, estado, fecha_inicio, fecha_termino, fecha_solicitud, desc_permiso, solicitante_run_sin_dv, autorizante_run_sin_dv FROM sol_permiso WHERE id_permiso = " + id;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Permiso permiso = new Permiso();
                permiso.Id = reader.GetInt32(0);
                permiso.Tipo = MetodosTipoPermiso.setTipo(reader.GetString(1));
                permiso.Estado = (parseNullableInt(reader.GetValue(2).ToString()) == null) ? (EstadoPermiso)2 : (EstadoPermiso)reader.GetInt32(2);
                permiso.FechaInicio = reader.GetDateTime(3);
                permiso.FechaTermino = reader.GetDateTime(4);
                permiso.FechaSolicitud = reader.GetDateTime(5);
                permiso.Descripcion = reader.GetString(6);
                if (parseNullableInt(reader.GetValue(7).ToString()) != null)
                    permiso.Solicitante = new GestionadorFuncionario().BuscarFuncionario(reader.GetInt32(7));
                if (parseNullableInt(reader.GetValue(8).ToString()) != null)
                    permiso.Autorizante = new GestionadorFuncionario().BuscarFuncionario(reader.GetInt32(8));
                con.Close();
                return permiso;
            }
            con.Close();
            return null;
        }

        public Permiso BuscarPermiso(int id)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT id_permiso, tipo_permiso, estado, fecha_inicio, fecha_termino, fecha_solicitud, desc_permiso, solicitante_run_sin_dv, autorizante_run_sin_dv FROM sol_permiso WHERE id_permiso = " + id;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Permiso permiso = new Permiso();
                permiso.Id = reader.GetInt32(0);
                permiso.Tipo = MetodosTipoPermiso.setTipo(reader.GetString(1));
                permiso.Estado = (parseNullableInt(reader.GetValue(2).ToString()) == null) ? (EstadoPermiso)2 : (EstadoPermiso)reader.GetInt32(2);
                permiso.FechaInicio = reader.GetDateTime(3);
                permiso.FechaTermino = reader.GetDateTime(4);
                permiso.FechaSolicitud = reader.GetDateTime(5);
                permiso.Descripcion = reader.GetString(6);
                if (parseNullableInt(reader.GetValue(7).ToString()) != null)
                    permiso.Solicitante = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(7));
                if (parseNullableInt(reader.GetValue(8).ToString()) != null)
                    permiso.Autorizante = new GestionadorFuncionario().BuscarFuncionarioParcial(reader.GetInt32(8));
                con.Close();
                return permiso;
            }
            con.Close();
            return null;
        }

        public Permiso BuscarPermisoParcial(int id)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConexionSQL.conexionString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT id_permiso, tipo_permiso, estado, fecha_inicio, fecha_termino, fecha_solicitud, desc_permiso, solicitante_run_sin_dv, autorizante_run_sin_dv FROM sol_permiso WHERE id_permiso = " + id;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Permiso permiso = new Permiso();
                permiso.Id = reader.GetInt32(0);
                permiso.Tipo = MetodosTipoPermiso.setTipo(reader.GetString(1));
                permiso.Estado = (parseNullableInt(reader.GetValue(2).ToString()) == null) ? (EstadoPermiso)2 : (EstadoPermiso)reader.GetInt32(2);
                permiso.FechaInicio = reader.GetDateTime(3);
                permiso.FechaTermino = reader.GetDateTime(4);
                permiso.FechaSolicitud = reader.GetDateTime(5);
                permiso.Descripcion = reader.GetString(6);
                con.Close();
                return permiso;
            }
            con.Close();
            return null;
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
