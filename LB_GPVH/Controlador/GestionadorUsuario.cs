using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Usuario> ListarUsuarios()
        {
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                List<Usuario> usuarios = new List<Usuario>();
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
                return usuarios;
            }
        }

        public Usuario BuscarUsarioPorId(int id)
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






        public ResultadoGestionUsuario AgregarUsuario(Usuario usuario)
        {
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
                if (validacion != ResultadoGestionUsuario.Valido)
                {
                    return validacion;
                }
                int codigoRetorno = serviceUsuarios.addUsuario(usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run);
                switch (codigoRetorno)
                {
                    case 0:
                        return ResultadoGestionUsuario.Valido;
                    default:
                        return ResultadoGestionUsuario.Invalido;
                }
            }
        }

        public ResultadoGestionUsuario ModificarUsuario(Usuario usuario)
        {
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                ResultadoGestionUsuario validacion = this.ValidarUsuario(usuario);
                if (validacion != ResultadoGestionUsuario.Valido)
                {
                    return validacion;
                }
                int codigoRetorno = serviceUsuarios.modifyUsuario(usuario.Id, usuario.Nombre, usuario.Clave, usuario.TipoToString, usuario.Funcionario.Run);
                switch (codigoRetorno)
                {
                    case 0:
                        return ResultadoGestionUsuario.Valido;
                    default:
                        return ResultadoGestionUsuario.Invalido;
                }
            }
        }

        public ResultadoGestionUsuario EliminarUsuario(int id)
        {
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                int salida = serviceUsuarios.deleteUsuario(id);

                if (salida == 0)
                {
                    return ResultadoGestionUsuario.Valido;
                }
                else
                    return ResultadoGestionUsuario.Invalido;
            }

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
            if(clave == claveConfirmacion)
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