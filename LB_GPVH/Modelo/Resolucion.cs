using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Resolucion()
        {
            id = -1;
            permiso = null;
            resolvente = null;
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


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
