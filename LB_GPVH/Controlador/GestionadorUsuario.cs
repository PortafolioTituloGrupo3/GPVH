using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorUsuario
    {
        //Muestra posibles resultados de cada metodo, comprensibles para el usuario final
        public enum ResultadoGestionUsuario
        {
            CaracteresNombreInvalido,
            CaracteresClaveInvalido,
            ClaveConfirmacionInvalida,
            NombreVacio,
            ClaveVacia,
            Valido,
            Invalido
        }
        #region xml
        //Recibe un string con formato xml y lo convierte en una lista de usuario
        public List<Usuario> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> usuariosXML = doc.Root.Elements();
            //Variable de salida
            List<Usuario> usuarios = new List<Usuario>();
            //Se recorren los elementos del xml y se crean funcionarios
            foreach (var usuarioXML in usuariosXML)
            {
                Usuario usuario = new Usuario();
                //Se cargan los datos del usuario con la informacion del documento
                usuario.LeerXML(usuarioXML);
                //Se agrega el funcionario a la lista de salida
                usuarios.Add(usuario);
            }
            return usuarios;
        }
        //Recibe un string con formato xml y lo convierte en un usuario
        public Usuario DesempaquetarUsuarioXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            Usuario usuario = new Usuario();
            //Se cargan los datos del usuario con la informacion del documento
            usuario.LeerXML(doc.Root);
            return usuario;
        }
        //Devuelve el resultado de una consulta a la base de datos
        public int DesempaquetarRespuesta(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            try
            {
                return int.Parse(doc.Root.Value);
            }
            catch
            {
                return -1;
            };
        }
        #endregion

        #region webservice/sql
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = null;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                usuarios = DesempaquetarListaXml(cliente.listarUsuarios());
            }
            return usuarios;
        }
        public Usuario BuscarUsarioPorId(int id)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarUsuarioXml(cliente.buscarUsuario(id));
            }
        }
        //Agrega un nuevo usuario
        public ResultadoGestionUsuario AgregarUsuario(Usuario usuario)
        {
            ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
            if (validacion != ResultadoGestionUsuario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.insertarUsuario(usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run));
                }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUsuario.Valido;
                default:
                    return ResultadoGestionUsuario.Invalido;
            }
        }
        //Modifica un usuario especificado
        public ResultadoGestionUsuario ModificarUsuario(Usuario usuario)
        {
            ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
            if (validacion != ResultadoGestionUsuario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.modificarUsuario(usuario.Id, usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run));
                }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUsuario.Valido;
                default:
                    return ResultadoGestionUsuario.Invalido;
            }
        }
        //Elimina un usuario especificado
        public ResultadoGestionUsuario EliminarUsuario(int id)
        {
            int salida;
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    salida = DesempaquetarRespuesta(cliente.eliminarUsuario(id));
                }
            if (salida == 0)
            {
                return ResultadoGestionUsuario.Valido;
            }
            else
                return ResultadoGestionUsuario.Invalido;

        }
        #endregion

        //Retorna una lista con los parametros que se usaran al desplegar informacion en la capa vista.
        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Id");
            parametros.Add("Nombre");
            parametros.Add("Clave");
            parametros.Add("TipoToString");
            parametros.Add("PropietarioCuenta");

            return parametros;
        }
        //Asigna un funcionario al usuario especificado
        public void setFuncionarioUsuario(Usuario usuario, int run, string nombreCompleto)
        {
            if (usuario.Funcionario == null)
            {
                usuario.Funcionario = new Funcionario();
            }
            usuario.Funcionario.Run = run;
            string[] nombreSplit = nombreCompleto.Split(' ');
            usuario.Funcionario.Nombre = nombreSplit[0];
            if (nombreSplit.Length > 1)
            {
                usuario.Funcionario.ApellidoPaterno = nombreSplit[1];
            }
            if (nombreSplit.Length > 2)
            {
                usuario.Funcionario.ApellidoMaterno = nombreSplit[2];
            }
        }
        //Asigna un tipo de usuario al usuario especificado y retorna true si se logro
        public bool setTipoUsuario(Usuario usuario, string tipo)
        {
            return usuario.setTipoUsuario(tipo);
        }

        #region validaciones
        public ResultadoGestionUsuario ValidarUsuario(Usuario usuario)
        {
            if (usuario.Nombre.Length == 0)
            {
                return ResultadoGestionUsuario.NombreVacio;
            }
            else if (usuario.Clave.Length == 0)
            {
                return ResultadoGestionUsuario.ClaveVacia;
            }
            return ResultadoGestionUsuario.Valido;
        }
        public ResultadoGestionUsuario ValidarClaveConfirmacion(string clave, string claveConfirmacion)
        {
            if(clave != claveConfirmacion)
            {
                return ResultadoGestionUsuario.ClaveConfirmacionInvalida;
            }
            return ResultadoGestionUsuario.Valido;
        }
        public ResultadoGestionUsuario ValidarCaracterNombre(Usuario usuario, string nombre)
        {
            if (!usuario.ValidarNombre(nombre))
            {
                return ResultadoGestionUsuario.CaracteresNombreInvalido;
            }
            return ResultadoGestionUsuario.Valido;
        }
        public ResultadoGestionUsuario ValidarCaracterClave(Usuario usuario, string clave)
        {
            if (!usuario.ValidarClave(clave))
            {
                return ResultadoGestionUsuario.CaracteresClaveInvalido;
            }
            return ResultadoGestionUsuario.Valido;
        }
        #endregion
    }
}