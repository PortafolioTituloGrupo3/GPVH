using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Enums;
using LB_GPVH.Auxiliares;
using System.Xml.Linq;

namespace LB_GPVH.Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string clave;
        public TipoUsuario Tipo { get; set; }
        private Funcionario funcionario;

        public Usuario()
        {
            id = -1;
            nombre = "";
            clave = "";
            funcionario = null;
        }


        public Funcionario Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
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

        public bool setTipoUsuario(string tipo)
        {
            try
            {
                this.Tipo = Enums.MetodosTipoUsuario.setTipo(tipo);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public string TipoToString
        {
            get
            {
                return Enums.MetodosTipoUsuario.GetString(this.Tipo);
            }
        }

        public string PropietarioCuenta
        {
            get
            {
                if(funcionario == null)
                {
                    return null;
                }
                else
                {
                    return funcionario.NombreCompleto;
                }
            }
        }


        public bool ValidarNombre(string pNombre)
        {
            if (AuxiliarString.ContieneCaracteresInvalidos(pNombre, false, false, false))
            {
                return false;
            }

            this.nombre = pNombre;
            return true;
        }

        public bool ValidarClave(string pClave)
        {
            if (AuxiliarString.ContieneCaracteresInvalidos(pClave, false, false, true))
            {
                return false;
            }

            this.clave = pClave;
            return true;
        }

        public void LeerXML(XElement usuarioXML)
        {
            if (usuarioXML.Element("id") != null)
            {
                try
                {
                    this.id = int.Parse(usuarioXML.Element("id").Value);
                }
                catch { };
            }
            if (usuarioXML.Element("nombre") != null)
            {
                this.nombre = usuarioXML.Element("nombre").Value;
            }
            if (usuarioXML.Element("clave") != null)
            {
                this.clave = usuarioXML.Element("clave").Value;
            }
            if (usuarioXML.Element("tipoUsuario") != null)
            {
                this.setTipoUsuario(usuarioXML.Element("tipoUsuario").Value);
            }
            if (usuarioXML.Element("Funcionario") != null)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.LeerXML(usuarioXML.Element("Funcionario"));
                this.funcionario = funcionario;
            }
        }

    }
}
