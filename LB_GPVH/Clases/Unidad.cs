using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Clases
{
    public class Unidad
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string direccion;
        private bool habilitado;
        private int idPadre;
        private int runJefe;

        public Unidad()
        {

        }

        public int RunJefe
        {
            get { return runJefe; }
            set { runJefe = value; }
        }

        public int IdPadre
        {
            get { return idPadre; }
            set { idPadre = value; }
        }


        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }


        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
