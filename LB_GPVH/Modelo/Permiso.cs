using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.Enums;


namespace LB_GPVH.Modelo
{
    public class Permiso
    {
        private int id;
        public TipoPermiso Tipo { get; set; }
        public EstadoPermiso Estado { get; set; }
        private DateTime fechaInicio;
        private DateTime fechaTermino;
        private DateTime fechaSolicitud;
        private string descripcion;
        private Funcionario solicitante;
        private Funcionario autorizante;


        public Permiso()
        {
            id = -1;
            descripcion = "";
            solicitante = null;
            autorizante = null;
        }



        public string TipoPermisoString
        {
            get
            {
                return MetodosTipoPermiso.GetString(Tipo);
            }
        }

        public string EstadoPermisoString
        {
            get
            {
                return MetodosEstadoPermiso.GetString(Estado);
            }
        }

        public bool setTipoPermiso(string tipo)
        {
            try
            {
                this.Tipo = Enums.MetodosTipoPermiso.setTipo(tipo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool setEstadoPermiso(string estado)
        {
            try
            {
                this.Estado = Enums.MetodosEstadoPermiso.setEstado(estado);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string NombreAutorizante
        {
            get {
                if (autorizante != null)
                    return autorizante.NombreCompleto;
                else
                    return null;
            }
        }

        public string NombreSolicitante
        {
            get {
                if (solicitante != null)
                    return solicitante.NombreCompleto;
                else
                    return null;
            }
        }

        public Funcionario Autorizante
        {
            get { return autorizante; }
            set { autorizante = value; }
        }


        public Funcionario Solicitante
        {
            get { return solicitante; }
            set { solicitante = value; }
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public DateTime FechaSolicitud
        {
            get { return fechaSolicitud; }
            set { fechaSolicitud = value; }
        }

        public DateTime FechaTermino
        {
            get { return fechaTermino; }
            set { fechaTermino = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public void LeerXML(XElement permisoXML)
        {
            if (permisoXML.Element("id") != null)
            {
                try
                {
                    this.id = int.Parse(permisoXML.Element("id").Value);
                }
                catch { };
            }
            if (permisoXML.Element("tipo") != null)
            {
                this.setTipoPermiso(permisoXML.Element("tipo").Value);
            }
            if (permisoXML.Element("estado") != null)
            {
                try
                {
                    this.Estado = (EstadoPermiso)int.Parse(permisoXML.Element("estado").Value);
                }
                catch { };
            }
            if (permisoXML.Element("fechaInicio") != null)
            {
                this.fechaInicio = DateTime.Parse(permisoXML.Element("fechaInicio").Value);
            }
            if (permisoXML.Element("fechaTermino") != null)
            {
                this.fechaTermino = DateTime.Parse(permisoXML.Element("fechaTermino").Value);
            }
            if (permisoXML.Element("fechaSolicitud") != null)
            {
                this.fechaSolicitud = DateTime.Parse(permisoXML.Element("fechaSolicitud").Value);
            }
            if (permisoXML.Element("Solicitante") != null)
            {
                Funcionario solicitante = new Funcionario();
                solicitante.LeerXML(permisoXML.Element("Solicitante").Element("Funcionario"));
                this.solicitante = solicitante;
            }
            if (permisoXML.Element("Autorizante") != null)
            {
                Funcionario autorizante = new Funcionario();
                autorizante.LeerXML(permisoXML.Element("Autorizante").Element("Funcionario"));
                this.autorizante = autorizante;
            }
        }

        

    }
}
