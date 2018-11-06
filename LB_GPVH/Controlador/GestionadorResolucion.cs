using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorResolucion
    {
        public List<Resolucion> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> resolucionesXML = doc.Root.Elements();
            List<Resolucion> resoluciones = new List<Resolucion>();
            foreach (var resolucionXML in resolucionesXML)
            {
                Resolucion resolucion = new Resolucion();
                resolucion.LeerXML(resolucionXML);
                resoluciones.Add(resolucion);
            }
            return resoluciones;
        }

        public List<Resolucion> BuscarResoluciones(int mes,int anno)
        {
            if(ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarListaXml(cliente.buscarResoluciones(mes, anno));
                }
            }
            else
            {
                return new SQL.ResolucionSQL().BuscarResolucioness(mes, anno);
            }
            
        }

        public List<Resolucion> BuscarResoluciones(int mes, int anno, int idUnidad)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarListaXml(cliente.buscarResolucionesUnidadesSubHijas(mes, anno,idUnidad));
                }
            }
            else
            {
                return new SQL.ResolucionSQL().BuscarResolucioness(mes, anno, idUnidad);
            }
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
