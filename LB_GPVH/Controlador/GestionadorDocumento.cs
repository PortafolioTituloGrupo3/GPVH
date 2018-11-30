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
        //Recibe un string con formato xml y lo convierte en una lista de documento
        public List<Documento> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> documentosXML = doc.Root.Elements();
            //Variable de salida
            List<Documento> documentos = new List<Documento>();
            //Se recorren los elementos del xml y se crean funcionarios
            foreach (var documentoXML in documentosXML)
            {
                Documento documento = new Documento();
                //Se cargan los datos del funcionario con la informacion del documento
                documento.LeerXML(documentoXML);
                //Se agrega el funcionario a la lista de salida
                documentos.Add(documento);
            }
            return documentos;
        }
        //Obtiene un listado de documentos segun el permiso recibido
        public List<Documento> getDocumentosByPermiso(int id_permiso)
        {
            List<Documento> documentos= new List<Documento>();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getDocumentosByPermiso(id_permiso);
                //Se crea la representacion de un documento xml
                XDocument doc = XDocument.Parse(xml);
                //Se pasan lo elementos del documento
                IEnumerable<XElement> documentosXML = doc.Root.Elements();
                //Se recorren los elementos del xml y se crean objetos de tipo documento
                foreach (var documentoXML in documentosXML)
                {
                    Documento documento = new Documento();
                    //Se cargan los datos del funcionario con la informacion del documento
                    documento.LeerXML(documentoXML);
                    //Se agrega el funcionario a la lista de salida
                    documentos.Add(documento);
                }
            }
            return documentos;
        }
        //Obtiene un documento segun el id ingresado
        public Documento getDocumentoById(int id_documento)
        {
            Documento documento = new Documento();
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                string xml = cliente.getDocumentoById(id_documento);
                //Se crea la representacion de un documento xml
                XDocument doc = XDocument.Parse(xml);
                //Se cargan los datos del funcionario con la informacion del documento
                documento.LeerXML(doc.Root);
            }
            return documento;
        }


    }
}
