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

        public List<Usuario> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> usuariosXML = doc.Root.Elements();
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var usuarioXML in usuariosXML)
            {
                Usuario usuario = new Usuario();
                usuario.LeerXML(usuarioXML);
                usuarios.Add(usuario);
            }
            return usuarios;
        }


        public Usuario DesempaquetarUsuarioXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            Usuario usuario = new Usuario();
            usuario.LeerXML(doc.Root);
            return usuario;
        }

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



        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    usuarios = DesempaquetarListaXml(cliente.listarUsuarios());
                }
            }
            else
            {
                using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
                {
                    usuarios = new List<Usuario>();
                    //****Sujeto a cambios para intergracion
                    var listadoUsuarios = serviceUsuarios.getListadoUsuarios();
                    foreach (var wsUsuario in listadoUsuarios)
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = wsUsuario.Id_usuario;
                        usuario.Clave = wsUsuario.Clave;
                        usuario.Nombre = wsUsuario.Nombre_usuario;
                        usuario.Tipo = Enums.MetodosTipoUsuario.setTipo(wsUsuario.Tipo_usuario);
                        usuario.Funcionario = new GestionadorFuncionario().BuscarFuncionarioParcial((int)wsUsuario.Funcionario_run_sin_dv);
                        usuarios.Add(usuario);
                    }
                    //****
                    
                }
            }
            return usuarios;
        }

        public Usuario BuscarUsarioPorId(int id)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarUsuarioXml(cliente.buscarUsuario(id));
                }
            }
            else
            {
                using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
                {
                    Usuario usuario = new Usuario();
                    //****Sujeto a cambios para intergracion
                    var wsUsuario = serviceUsuarios.getUsuarioById(id);
                    usuario.Id = wsUsuario.Id_usuario;
                    usuario.Clave = wsUsuario.Clave;
                    usuario.Nombre = wsUsuario.Nombre_usuario;
                    usuario.Tipo = Enums.MetodosTipoUsuario.setTipo(wsUsuario.Tipo_usuario);
                    usuario.Funcionario = new GestionadorFuncionario().BuscarFuncionarioParcial((int)wsUsuario.Funcionario_run_sin_dv);
                    //****
                    return usuario;
                }
            }
        }






        public ResultadoGestionUsuario AgregarUsuario(Usuario usuario)
        {
            ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
            if (validacion != ResultadoGestionUsuario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.insertarUsuario(usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run));
                }
            }
            else
            {
                using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
                {
                    codigoRetorno = serviceUsuarios.addUsuario(usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run);
                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUsuario.Valido;
                default:
                    return ResultadoGestionUsuario.Invalido;
            }
        }

        public ResultadoGestionUsuario ModificarUsuario(Usuario usuario)
        {
            ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
            if (validacion != ResultadoGestionUsuario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.modificarUsuario(usuario.Id, usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run));
                }
            }
            else
            {
                using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
                {
                    codigoRetorno = serviceUsuarios.modifyUsuario(usuario.Id, usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run);

                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUsuario.Valido;
                default:
                    return ResultadoGestionUsuario.Invalido;
            }
        }

        public ResultadoGestionUsuario EliminarUsuario(int id)
        {
            int salida;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    salida = DesempaquetarRespuesta(cliente.eliminarUsuario(id));
                }
            }
            else
            {
                using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
                {
                    salida = serviceUsuarios.deleteUsuario(id);
                }
            }
            if (salida == 0)
            {
                return ResultadoGestionUsuario.Valido;
            }
            else
                return ResultadoGestionUsuario.Invalido;

        }



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

        public bool setTipoUsuario(Usuario usuario, string tipo)
        {
            return usuario.setTipoUsuario(tipo);
        }

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
    }
}