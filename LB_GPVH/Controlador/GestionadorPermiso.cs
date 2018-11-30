using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.Modelo;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorPermiso
    {
        //Recibe un string con formato xml y lo convierte en una lista de permiso
        public List<Permiso> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> permisosXML = doc.Root.Elements();
            //Variable de salida
            List<Permiso> permisos = new List<Permiso>();
            //Se recorren los elementos del xml y se crean permisos
            foreach (var permisoXML in permisosXML)
            {
                Permiso permiso = new Permiso();
                //Se cargan los datos del permiso con la informacion del documento
                permiso.LeerXML(permisoXML);
                //Se agrega el permiso a la lista de salida
                permisos.Add(permiso);
            }
            return permisos;
        }
        //Recibe un string con formato xml y lo convierte en un objeto "permiso"
        public Permiso DesempaquetarPermisoXml(string xml)
        {

            XDocument doc = XDocument.Parse(xml);
            Permiso permiso = new Permiso();
            permiso.LeerXML(doc.Root);
            return permiso;
        }
        //Cargo los permisos en el objeto funcionario
        public bool AsignarPermisos(Funcionario funcionario)
        {
            if(funcionario == null)
            {
                return false;
            }
            else
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    funcionario.Permisos = DesempaquetarListaXml(cliente.buscarPermisos(funcionario.Run));
                }
                return true;
            }
        }
        //Retorna los permisos anuales con un objeto XDocument
        public XDocument ObtenerArchivoPermisosAnuales()
        {
            try
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    XDocument doc = XDocument.Parse(cliente.buscarPermisosAnuales());
                    return doc;
                }
            }
            catch (System.Xml.XmlException xmlE)
            {
                throw new Exception("Ocurrio un problema al transoformar los permisos al formato xml: " + xmlE.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un problema al generar el archivo xml: "+ex.Message);
            }
        }
        
        public Permiso BuscarPermiso(int id)
        {
            return new SQL.PermisoSQL().BuscarPermiso(id);
        }

        public Permiso BuscarPermisoFull(int id)
        {
            return new SQL.PermisoSQL().BuscarPermisoFull(id);
        }

        public Permiso BuscarPermisoParcial(int id)
        {
            return new SQL.PermisoSQL().BuscarPermisoParcial(id);
        }
        
        //Retorna un listado de permiso
        public List<Permiso> ListarPermisos(int run)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarListaXml(cliente.buscarPermisos(run));
            }
        }
        //Retorna un permiso segun su id
        public Permiso ValidarDocumento(int codigo)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarPermisoXml(cliente.buscarPermisoPorId(codigo));
            }
        }
        //Retorna un reporte de antecedentes
        public Antecedentes ReporteAntecedentes(int run)
        {
            Antecedentes antecedentes = new Antecedentes();
            List<object> filas = new List<object>();
            using(WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getAntecedentes(run);
                //Se crea la representacion de un documento xml
                XDocument doc = XDocument.Parse(xml);
                //Se cargan los datos del permiso con la informacion del documento
                antecedentes.LeerXML(doc.Root);
            }
            return antecedentes;
        }
        //Retorna un reporte de permisos segun un rango de fechas ingresado
        public List<ReportePermisoFila> ReportePermisos(DateTime inicio, DateTime termino)
        {
            List<ReportePermisoFila> filas = new List<ReportePermisoFila>();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getReportePermisos(inicio, termino);
                //Se crea la representacion de un documento xml
                XDocument doc = XDocument.Parse(xml);
                IEnumerable<XElement> reporteXML = doc.Root.Elements();
                foreach (var filaTemp in reporteXML)
                {
                    ReportePermisoFila fila = new ReportePermisoFila();
                    //Se cargan los datos del permiso con la informacion del documento
                    fila.LeerXML(filaTemp);
                    //Se agrega a las filas
                    filas.Add(fila);
                }
            }
            return filas;
        }
        //Retorna una lista con los parametros que se usaran al desplegar informacion en la capa vista.
        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Id");
            parametros.Add("TipoPermisoString");
            parametros.Add("EstadoPermisoString");
            parametros.Add("FechaInicio");
            parametros.Add("FechaTermino");
            parametros.Add("FechaSolicitud");
            parametros.Add("Descripcion");
            parametros.Add("NombreSolicitante");
            parametros.Add("NombreAutorizante");
            return parametros;
        }
        public bool ControlarCaracterCodigo(string codigo)
        {
            return Auxiliares.AuxiliarString.EsNumerico(codigo);
        }
        
    }
}
