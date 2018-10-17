using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Enums;


namespace LB_GPVH.Controlador
{
    public class Sesion
    {
        public Usuario Usuario { get; set; }
        public Funcionario Funcionario { get; set; }

        public Sesion()
        {

        }

        public bool AutenticarUsuario(string nombre, string clave)
        {
            Usuario = new SQL.UsuarioSQL().autenticarUsuario(nombre, clave);
            return Usuario != null;
        }
        

        public TipoUsuario TipoUsuario
        {
            get { return Usuario.Tipo; }
        }
    }
}
