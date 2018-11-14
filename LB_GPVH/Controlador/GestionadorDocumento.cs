using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorDocumento
    {
        public List<Documento> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> documentosXML = doc.Root.Elements();
            List<Documento> documentos = new List<Documento>();
            foreach (var documentoXML in documentosXML)
            {
                Documento documento = new Documento();
                documento.LeerXML(documentoXML);
                documentos.Add(documento);
            }
            return documentos;
        }

        

        public Documento Documento(int id)
        {
            Documento documento = new Documento();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                //string xml = cliente.getReportePermisos();
                //XDocument doc = XDocument.Parse(xml);
                //IEnumerable<XElement> reporteXML = doc.Root.Elements();
                //foreach (var filaTemp in reporteXML)
                //{
                    //ReportePermisoFila fila = new ReportePermisoFila();
                    //fila.LeerXML(filaTemp);
                    //filas.Add(fila);
                //}
            }
            /**
             * 
            */
            return documento;
        }



        public List<Documento> getDocumentosByPermiso(int id_permiso)
        {
            List<Documento> documentos= new List<Documento>();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getDocumentosByPermiso(id_permiso);
                XDocument doc = XDocument.Parse(xml);
                IEnumerable<XElement> documentosXML = doc.Root.Elements();
                foreach (var documentoXML in documentosXML)
                {
                    Documento documento = new Documento();
                    documento.LeerXML(documentoXML);
                    documentos.Add(documento);
                }
            }
            return documentos;
        }

        public Documento getDocumentoById(int id_documento)
        {
            Documento documento = new Documento();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getDocumentoById(id_documento);
                XDocument doc = XDocument.Parse(xml);
                documento.LeerXML(doc.Root);
            }
            return documento;
        }


    }
}
