using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Enums;


namespace LB_GPVH.Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string clave;
        public TipoUsuario Tipo { get; set; }
        private int runFuncionario;

        public Usuario()
        {

        }


        public int RunFuncionario
        {
            get { return runFuncionario; }
            set { runFuncionario = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
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
