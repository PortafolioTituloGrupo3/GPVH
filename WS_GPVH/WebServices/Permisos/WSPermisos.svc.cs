using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Permisos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSPermisos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSPermisos.svc o WSPermisos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPermisos : IWSPermisos
    {
        private string conString = "DATA SOURCE=localhost:1521/XE;PASSWORD=prueba;USER ID=PRUEBA";
        /**
         * En esta funcion se debe indicar cual sera la condicion siendo:
         * -1 = todos los permisos
         * 0 = permisos no resueltos
         * 1 = permisos aprobados
         * 2 = permisos rechazados
         * */
        public List<Permiso> getPermisosByFuncionario(int run, int condicion)
        {
            List<Permiso> permisos = new List<Permiso>();
            Permiso permisoTemp = new Permiso();
            //Coneccion y consulta
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            string comando_txt = "select * " +
                                "from sol_permiso " +
                                "where solicitante_run_sin_dv = " + run;
            switch (condicion)
            {
                case 0: //Mostrar mermisos no resueltos
                    comando_txt += "and estado = " + condicion;
                    break;
                case 1: //Mostrar mermisos autorizados
                    comando_txt += "and estado = " + condicion;
                    break;
                case 2: //Mostrar mermisos rechazados
                    comando_txt += "and estado = " + condicion;
                    break;
                default:
                    break;
            }
            cmd.CommandText = comando_txt;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Crear fila
                permisoTemp = new Permiso();
                int estado_num = reader.GetInt32(2);
                switch (estado_num)
                {
                    case 0:
                        permisoTemp.Estado = "No resuelto";
                        break;
                    case 1:
                        permisoTemp.Estado = "Autorizado";
                        break;
                    case 2:
                        permisoTemp.Estado = "Rechazado";
                        break;
                }
                permisoTemp.Id_permiso= reader.GetInt32(0);
                permisoTemp.Tipo_permiso = reader.GetString(1);
                permisoTemp.Fecha_inicio= reader.GetDateTime(3);
                permisoTemp.Fecha_termino = reader.GetDateTime(4);
                permisoTemp.Fecha_solicitud = reader.GetDateTime(5);
                permisoTemp.Desc_permiso = reader.GetString(6);
                permisoTemp.Solicitante_run_sin_dv = reader.GetInt32(7);
                try
                {
                    permisoTemp.Autorizante_run_sin_dv = reader.GetInt32(8);
                }catch(Exception ex)
                {
                    permisoTemp.Autorizante_run_sin_dv = -1;
                }
                
                //Agregar permiso
                permisos.Add(permisoTemp);
            }
            return permisos;
        }
    }
}
