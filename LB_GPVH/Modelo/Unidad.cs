using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            if (AuxiliarString.ContieneCaracteresInvalidos(pDescripcion,true,true,false))
            {
                return false;
            }

            descripcion = pDescripcion;
            return true;
        }

        public bool ValidarDireccion(string pDireccion)
        {
            if (AuxiliarString.ContieneCaracteresInvalidos(pDireccion, true, true,false))
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


        public void LeerXML(XElement unidadXML)
        {
            if (unidadXML.Element("id") != null)
            {
                try
                {
                    this.id = int.Parse(unidadXML.Element("id").Value);
                }
                catch { };
            }
            if (unidadXML.Element("nombre") != null)
            {
                this.nombre = unidadXML.Element("nombre").Value;
            }
            if (unidadXML.Element("descripcion") != null)
            {
                this.descripcion = unidadXML.Element("descripcion").Value;
            }
            if (unidadXML.Element("direccion") != null)
            {
                this.direccion = unidadXML.Element("direccion").Value;
            }
            if (unidadXML.Element("habilitado") != null)
            {
                try
                {
                    this.habilitado = (int.Parse(unidadXML.Element("habilitado").Value) != 0);
                }
                catch { };
            }
            if (unidadXML.Element("Unidad") != null)
            {
                Unidad unidad = new Unidad();
                unidad.LeerXML(unidadXML.Element("Unidad"));
                this.unidadPadre = unidad;
            }
            if (unidadXML.Element("Funcionario") != null)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.LeerXML(unidadXML.Element("Funcionario"));
                this.jefe = funcionario;
            }
        }
    }
}
