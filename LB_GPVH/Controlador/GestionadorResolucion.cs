using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;
using LB_GPVH.wsSistemaAsistencia;


namespace LB_GPVH.Controlador
{
    public class GestionadorResolucion
    {
        //Muestra posibles resultados de cada metodo, comprensibles para el usuario final
        public enum ResultadoGestionResolucion
        {
            idResolucionNoExiste,
            ResolventeNoValido,
            Error,
            valido
        }
        //Recibe un string con formato xml y lo convierte en una lista de resolucion
        public List<Resolucion> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> resolucionesXML = doc.Root.Elements();
            //Variable de salida
            List<Resolucion> resoluciones = new List<Resolucion>();
            //Se recorren los elementos del xml y se crean funcionarios
            foreach (var resolucionXML in resolucionesXML)
            {
                Resolucion resolucion = new Resolucion();
                //Se cargan los datos del funcionario con la informacion del documento
                resolucion.LeerXML(resolucionXML);
                //Se agrega el funcionario a la lista de salida
                resoluciones.Add(resolucion);
            }
            return resoluciones;
        }
        //Retorna unas lista con la informacion de la asistencia
        public List<Tuple<int, DateTime>> LeerXmlAsistencia(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> asistenciasXML = doc.Root.Elements();
            //Variable de salida
            List<Tuple<int, DateTime>> asistencias = new List<Tuple<int, DateTime>>();
            //Se recorren los elementos del xml y agregan tuplas a la lista
            foreach (var asistenciaXML in asistenciasXML)
            {
                int run = -1;
                DateTime? fecha = null;
                if (asistenciaXML.Element("runFuncionario") != null)
                {
                    try
                    {
                        run = int.Parse(asistenciaXML.Element("runFuncionario").Value);
                    }
                    catch { };
                }
                if (asistenciaXML.Element("fechAsistencia") != null)
                {
                    fecha = DateTime.Parse(asistenciaXML.Element("fechAsistencia").Value);
                }
                if (run != -1 && fecha != null)
                {
                    asistencias.Add(new Tuple<int, DateTime>(run, (DateTime)fecha));
                }
            }
            return asistencias;
        }
        //Retorna un listado con las resuluciones de un mes en especifico
        public List<Resolucion> BuscarResoluciones(int mes,int anno)
        {
            List<Resolucion> resoluciones = null;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                resoluciones = DesempaquetarListaXml(cliente.buscarResoluciones(mes, anno));
            }
            DeterminarAsistenciaPermiso(resoluciones);
            return resoluciones;
        }
        //Retorna un listado con las resuluciones de un mes y unidad en especifico
        public List<Resolucion> BuscarResoluciones(int mes, int anno, int idUnidad)
        {
            List<Resolucion> resoluciones = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    resoluciones = DesempaquetarListaXml(cliente.buscarResolucionesUnidadesSubHijas(mes, anno,idUnidad));
                }
            }
            else
            {
                resoluciones = new SQL.ResolucionSQL().BuscarResolucioness(mes, anno, idUnidad);
            }
            DeterminarAsistenciaPermiso(resoluciones);
            
            return resoluciones;
        }
        
        private List<Resolucion> DeterminarAsistenciaPermiso(List<Resolucion> resoluciones)
        {
            if (resoluciones.Count > 0)
            {
                DateTime? fechaMinima = null, fechaMaxima = null;
                foreach (var resolucion in resoluciones)
                {
                    if (fechaMinima == null || fechaMinima > resolucion.Permiso.FechaInicio)
                    {
                        fechaMinima = resolucion.Permiso.FechaInicio;
                    }
                    if (fechaMaxima == null || fechaMaxima < resolucion.Permiso.FechaTermino)
                    {
                        fechaMaxima = resolucion.Permiso.FechaTermino;
                    }
                }
                List<Tuple<int, DateTime>> listaAsistencia;
                //webservice goes here
                using (WebServiceSistemaAsistenciaClient cliente = new WebServiceSistemaAsistenciaClient())
                {
                    listaAsistencia = LeerXmlAsistencia(cliente.listarAsistencias((DateTime)fechaMinima, (DateTime)fechaMaxima));
                }
                resoluciones = resoluciones.OrderBy(r => r.Permiso.Solicitante.Run).ToList(); // Se ordenan los permisos por run para poder realizar una comparacion paralela de los funcionarios en cuanto a permisos y asistencias.
                int asistenciaIndex = -1, runActual = -1;
                DateTime fechaAsistencia = DateTime.Now;
                foreach (var resolucion in resoluciones)
                {
                    bool asisencia = false;
                    while(runActual < resolucion.Permiso.Solicitante.Run)  //La lista de asistencia actua como cursor: Dado que se encuentra ordenada por run y fecha, se busca el proximo run. Si el proximo run es mayor al run del permiso, se pasa al proximo run de solicitante.
                    {
                        asistenciaIndex++;
                        if(asistenciaIndex >= listaAsistencia.Count)
                            break;
                        runActual = listaAsistencia[asistenciaIndex].Item1;
                        fechaAsistencia = listaAsistencia[asistenciaIndex].Item2;
                    }
                    while(runActual == resolucion.Permiso.Solicitante.Run)
                    {
                        //Se verifica si es que la asistencia pertenece al periodo del permiso en cuestion.
                        if (fechaAsistencia.Date >= resolucion.Permiso.FechaInicio.Date && fechaAsistencia.Date <= resolucion.Permiso.FechaTermino.Date)
                            asisencia = true;
                        asistenciaIndex++;
                        if (asistenciaIndex >= listaAsistencia.Count)
                            break;
                        runActual = listaAsistencia[asistenciaIndex].Item1;
                        fechaAsistencia = listaAsistencia[asistenciaIndex].Item2;
                    }
                    resolucion.Asistencia = asisencia;
                }
            }
            return resoluciones;
        }
        //Valida una resoluciones y registra al funcionario que lo hizo
        public ResultadoGestionResolucion ValidarResolucion(int idResolucion, int runResolvente)
        {
            int resultado;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                resultado = DesempaquetarRespuesta(cliente.validarResolucion(idResolucion, runResolvente));
            }
            switch(resultado)
            {
                case 0:
                    return ResultadoGestionResolucion.valido;
                case 140101:
                    return ResultadoGestionResolucion.idResolucionNoExiste;
                case 140102:
                    return ResultadoGestionResolucion.ResolventeNoValido;
                default:
                    return ResultadoGestionResolucion.Error;
            }
        }
        //Invalida una resoluciones y registra al funcionario que lo hizo
        public ResultadoGestionResolucion InvalidarResolucion(int idResolucion, int runResolvente)
        {
            int resultado;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                resultado = DesempaquetarRespuesta(cliente.invalidarResolucion(idResolucion, runResolvente));
            }
            switch (resultado)
            {
                case 0:
                    return ResultadoGestionResolucion.valido;
                case 140201:
                    return ResultadoGestionResolucion.idResolucionNoExiste;
                case 140202:
                    return ResultadoGestionResolucion.ResolventeNoValido;
                default:
                    return ResultadoGestionResolucion.Error;
            }
        }
        //Devuelve el resultado de una consulta a la base de datos
        public int DesempaquetarRespuesta(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            try
            {
                return int.Parse(doc.Root.Value);
            }
            catch
            {
                return -1;
            };
        }
        //Retorna una lista con los parametros que se usaran al desplegar informacion en la capa vista.
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
