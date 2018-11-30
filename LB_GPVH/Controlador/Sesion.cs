using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Enums;
using LB_GPVH.wsIntegracionAppEscritorio;
using System.Xml.Linq;

namespace LB_GPVH.Controlador
{
    public class Sesion
    {
        public Usuario Usuario { get; set; }

        public Sesion()
        {
        }
        //Comprueba la autenticidad de un usuario
        public bool AutenticarUsuario(string nombre, string clave)
        {
            if(ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    string xml = cliente.autenticarUsuario(nombre,clave);
                    XDocument doc = XDocument.Parse(xml);
                    Usuario = new Usuario();
                    Usuario.LeerXML(doc.Root);
                    return Usuario != null && Usuario.Id != -1;
                }
                    
            }
            else
            {
                Usuario = new SQL.UsuarioSQL().autenticarUsuario(nombre, clave);
                return Usuario != null;
            }
            
        }

        public TipoUsuario TipoUsuario
        {
            get { return Usuario.Tipo; }
        }
    }
}
