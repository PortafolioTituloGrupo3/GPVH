using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Reportes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSReportes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSReportes.svc o WSReportes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSReportes : IWSReportes
    {
        private string conString = "DATA SOURCE=localhost:1521/XE;PASSWORD=prueba;USER ID=PRUEBA";
        //Retorna la cantidad de permisos por tipo de permiso y por unidad 
        public List<FilaReportePermisos> ReportePermisos(DateTime inicio, DateTime termino)
        {
            //Creacion de datatable
            List<FilaReportePermisos> filas = new List<FilaReportePermisos>();
            string inicio_texto = inicio.ToString("yyyy-MM-dd");
            string termino_texto = termino.ToString("yyyy-MM-dd");
            
            //Coneccion y consulta
            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select  nombre_unidad AS \"Unidad\", "+ 
                                "tipo_permiso AS \"Tipo de Permiso\", "+
                                "count(*) AS \"Cantidad de permisos\" "+
                                "from sol_permiso sol join funcionario fun "+
                                "on sol.solicitante_run_sin_dv = fun.run_sin_dv join unidad uni "+
                                "on fun.unidad_id_unidad = uni.id_unidad "+
                                "where   sol.fecha_solicitud >= TO_DATE('"+ inicio_texto +"', 'YYYY-MM-DD')  AND " +
                                "        sol.fecha_solicitud <= TO_DATE('"+ termino_texto +"', 'YYYY-MM-DD') "+
                                "group by tipo_permiso, uni.nombre_unidad "+
                                "order by nombre_unidad, tipo_permiso ";
            OracleDataReader reader = cmd.ExecuteReader();
            FilaReportePermisos filaTemp;
            while (reader.Read())
            {
                //Crear fila
                filaTemp = new FilaReportePermisos();
                filaTemp.Unidad = reader.GetString(0);
                filaTemp.Tipo_permiso = reader.GetString(1);
                filaTemp.Cantidad = reader.GetInt32(2);
                //Agregar fila
                filas.Add(filaTemp);
            }
            return filas;
        }
    }
}
