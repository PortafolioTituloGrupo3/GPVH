using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Clases
{
    public class Funcionario
    {
        private int run;
        private int dv;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private string correo;
        private string direccion;
        private string tipo;

        public Funcionario()
        {

        }


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }


        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Dv
        {
            get { return dv; }
            set { dv = value; }
        }


        public int Run
        {
            get { return run; }
            set { run = value; }
        }


    }
}
