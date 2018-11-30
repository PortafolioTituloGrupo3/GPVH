using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_GPVH.Modelo
{
    public class Documento
    {
        int id_documento = -1;
        string nombre_documento = "documento";
        string formato_documento = "";
        DateTime fecha_creacion = DateTime.MinValue;
        string pdfBinario = ""; //Archivo codificado a Base64
        string dirTemp = ""; //Direccion temporal del documento real a crear
        int id_permiso = -1;

        #region propiedades
        public int Id_documento
        {
            get
            {
                return id_documento;
            }

            set
            {
                id_documento = value;
            }
        }
        public string Nombre_documento
        {
            get
            {
                return nombre_documento;
            }

            set
            {
                nombre_documento = value;
            }
        }
        public string Formato_documento
        {
            get
            {
                return formato_documento;
            }

            set
            {
                formato_documento = value;
            }
        }
        public DateTime Fecha_creacion
        {
            get
            {
                return fecha_creacion;
            }

            set
            {
                fecha_creacion = value;
            }
        }
        public string PdfBinario
        {
            get
            {
                return pdfBinario;
            }

            set
            {
                pdfBinario = value;
            }
        }
        public int Id_permiso
        {
            get
            {
                return id_permiso;
            }

            set
            {
                id_permiso = value;
            }
        }
        public string DirTemp
        {
            get
            {
                return dirTemp;
            }

            set
            {
                dirTemp = value;
            }
        }
        #endregion

        //Carga la propiedades mediante un documento
        public void LeerXML(XElement documentoXML)
        {
            if (documentoXML.Element("id_documento") != null)
            {
                try
                {
                    this.id_documento = int.Parse(documentoXML.Element("id_documento").Value);
                }
                catch { };
            }
            if (documentoXML.Element("nombre_documento") != null)
            {
                try
                {
                    this.nombre_documento = documentoXML.Element("nombre_documento").Value;
                }
                catch { };
            }
            if (documentoXML.Element("formato_documento") != null)
            {
                try
                {
                    this.formato_documento = documentoXML.Element("formato_documento").Value;
                }
                catch { };
            }
            if (documentoXML.Element("fecha_creacion") != null)
            {
                try
                {
                    this.fecha_creacion = DateTime.Parse(documentoXML.Element("fecha_creacion").Value);
                }
                catch { };
            }
            if (documentoXML.Element("pdfBinario") != null)
            {
                try
                {
                    this.pdfBinario = documentoXML.Element("pdfBinario").Value;
                }
                catch { };
            }
        }

        //Crea un archivo PDF temporal usando la propiedad pdfBinario
        public void Base64aPdf()
        {
            this.dirTemp = Path.GetTempFileName() + Guid.NewGuid().ToString() + ".pdf";
            File.WriteAllBytes(dirTemp, Convert.FromBase64String(this.pdfBinario));
        }
    }
}
