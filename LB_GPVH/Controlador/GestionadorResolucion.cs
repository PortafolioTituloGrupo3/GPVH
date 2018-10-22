using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Controlador
{
    public class GestionadorResolucion
    {
        public List<Resolucion> BuscarResoluciones(int mes,int anno)
        {
            return new SQL.ResolucionSQL().BuscarResolucioness(mes, anno);
        }

        public List<Resolucion> BuscarResoluciones(int mes, int anno, int idUnidad)
        {
            return new SQL.ResolucionSQL().BuscarResolucioness(mes, anno,idUnidad);
        }


        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Id");
            parametros.Add("FechaResolucion");
            parametros.Add("EstadoResolucionString");
            parametros.Add("AsistenciaString");
            parametros.Add("NombreSolicitantePermiso");
            parametros.Add("NombreAutorizantePermiso");
            parametros.Add("NombreResolvente");
            return parametros;
        }



    }
}
