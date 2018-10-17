using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return MetodosTipoPermiso.GetString(Tipo);
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

    }
}
