using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Auxiliares;

namespace LB_GPVH.Modelo
{
    public class Unidad
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string direccion;
        private bool habilitado;
        private Unidad unidadPadre;
        private Funcionario jefe;
        private List<Funcionario> funcionarios;


        public Unidad()
        {
            UnidadPadre = null;
            Jefe = null;
            funcionarios = null;
            nombre = "";
            descripcion = "";
            direccion = "";
            habilitado = true;
        }

        public List<Funcionario> Funcionarios
        {
            get {
                if(funcionarios == null)
                {
                    funcionarios = new List<Funcionario>();
                }
                return funcionarios; }
            set { funcionarios = value; }
        }

        public Funcionario Jefe
        {
            get { return jefe; }
            set { jefe = value; }
        }

        public Unidad UnidadPadre
        {
            get { return unidadPadre; }
            set { unidadPadre = value; }
        }

        public String NombrePadre
        {
            get {
                if (unidadPadre == null)
                    return null;
                else
                    return unidadPadre.Nombre; }
        }

        public String NombreJefe
        {
            get {
                if (jefe == null)
                    return null;
                else
                    return jefe.NombreCompleto; }
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

        public bool ValidarNombre(string pNombre)
        {
            if(!AuxiliarString.ContieneCaracteresAlfabeto(pNombre,true))
            {
                return false;
            }

            nombre = pNombre;
            return true;
        }

        public bool ValidarDescripcion(string pDescripcion)
        {
            if (AuxiliarString.ContieneCaracteresInvalidos(pDescripcion))
            {
                return false;
            }

            descripcion = pDescripcion;
            return true;
        }

        public bool ValidarDireccion(string pDireccion)
        {
            if (AuxiliarString.ContieneCaracteresInvalidos(pDireccion))
            {
                return false;
            }

            direccion = pDireccion;
            return true;
        }
        


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        


    }
}
