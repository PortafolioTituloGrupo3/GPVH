using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_GPVH.Modelo
{
    public class ReportePermisoFila
    {
        string unidad = "";
        string tipo_permiso = "";
        int cantidad = -1;

        #region propiedades 
        public string Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }
        public string Tipo_permiso
        {
            get
            {
                return tipo_permiso;
            }

            set
            {
                tipo_permiso = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
        #endregion

        //Carga la propiedades mediante un documento
        public void LeerXML(XElement reportePermisoXML)
        {
            if (reportePermisoXML.Element("unidad") != null)
            {
                try
                {
                    this.unidad = reportePermisoXML.Element("unidad").Value;
                }
                catch { };
            }
            if (reportePermisoXML.Element("tipo_permiso") != null)
            {
                this.tipo_permiso = reportePermisoXML.Element("tipo_permiso").Value;
            }
            if (reportePermisoXML.Element("cantidad") != null)
            {
                this.cantidad = int.Parse(reportePermisoXML.Element("cantidad").Value);
            }
        }
    }
}
