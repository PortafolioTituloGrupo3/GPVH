﻿using LB_GPVH.Modelo;
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

        public void LeerXmlAsistencia(XElement permisoXML, List<Tuple<int, DateTime>> listaAsistencia)
        {
            int run = -1;
            DateTime? fecha = null;
            if (permisoXML.Element("run") != null)
            {
                try
                {
                    run = int.Parse(permisoXML.Element("run").Value);
                }
                catch { };
            }
            if (permisoXML.Element("fechaInicio") != null)
            {
                fecha = DateTime.Parse(permisoXML.Element("fechaInicio").Value);
            }
            if (run != -1 && fecha != null)
            {
                listaAsistencia.Add(new Tuple<int, DateTime>(run, (DateTime)fecha));
            }
        }

        public List<Resolucion> BuscarResoluciones(int mes,int anno)
        {
            List<Resolucion> resoluciones = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    resoluciones = DesempaquetarListaXml(cliente.buscarResoluciones(mes, anno));
                }
            }
            else
            {
                resoluciones = new SQL.ResolucionSQL().BuscarResolucioness(mes, anno);
            }
            DeterminarAsistenciaPermiso(resoluciones);
            return resoluciones;
        }

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
                //webservice goes here
                List<Tuple<int,DateTime>> listaAsistencia = new List<Tuple<int, DateTime>>();
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
