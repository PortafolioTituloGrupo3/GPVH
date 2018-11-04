using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.Enums;

namespace LB_GPVH.Modelo
{
    public class Resolucion
    {
        private int id;
        private DateTime fechaResolucion;
        public EstadoResolucion Estado { get; set; } 
        private Permiso permiso;
        private Funcionario resolvente;
        private bool? asistencia;

        public Resolucion()
        {
            id = -1;
            permiso = null;
            resolvente = null;
            Estado = EstadoResolucion.Pendiente;
            asistencia = null;
        }

        public string EstadoResolucionString
        {
            get { return MetodosEstadoReolucion.GetString(Estado); }
        }

        public bool setEstadoResolucion(string estado)
        {
            try
            {
                this.Estado = Enums.MetodosEstadoReolucion.setEstado(estado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string NombreSolicitantePermiso
        {
            get
            {
                if (permiso != null && permiso.Solicitante != null)
                    return permiso.Solicitante.NombreCompleto;
                else
                    return null;
            }
        }

        public string NombreAutorizantePermiso
        {
            get
            {
                if (permiso != null && permiso.Autorizante != null)
                    return permiso.Autorizante.NombreCompleto;
                else
                    return null;
            }
        }

        public string NombreResolvente
        {
            get
            {
                if (resolvente != null)
                    return resolvente.NombreCompleto;
                else
                    return null;
            }
        }


        public string AsistenciaString
        {
            get
            {
                if (asistencia != null)
                    return (bool)asistencia ? "Asistió" : "No Asistió";
                else
                    return null;
            }
        }

        
        public Funcionario Resolvente
        {
            get { return resolvente; }
            set { resolvente = value; }
        }


        public Permiso Permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }
        

        public DateTime FechaResolucion
        {
            get { return fechaResolucion; }
            set { fechaResolucion = value; }
        }


        public bool? Asistencia
        {
            get { return asistencia; }
            set { asistencia = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void LeerXML(XElement resolucionXML)
        {
            if (resolucionXML.Element("id") != null)
            {
                try
                {
                    this.id = int.Parse(resolucionXML.Element("id").Value);
                }
                catch { };
            }
            if (resolucionXML.Element("estado") != null)
            {
                try
                {
                    this.Estado = (EstadoResolucion)int.Parse(resolucionXML.Element("estado").Value);
                }
                catch { };
            }
            if (resolucionXML.Element("fechaResolucion") != null)
            {
                this.fechaResolucion = DateTime.Parse(resolucionXML.Element("fechaResolucion").Value);
            }
            if (resolucionXML.Element("Permiso") != null)
            {
                Permiso permiso = new Permiso();
                permiso.LeerXML(resolucionXML.Element("Permiso"));
                this.permiso = permiso;
            }
            if (resolucionXML.Element("Funcionario") != null)
            {
                Funcionario resolvente = new Funcionario();
                resolvente.LeerXML(resolucionXML.Element("Funcionario"));
                this.resolvente = resolvente;
            }
        }
    }
}
