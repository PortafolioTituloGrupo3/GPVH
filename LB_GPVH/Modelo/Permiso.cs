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
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
