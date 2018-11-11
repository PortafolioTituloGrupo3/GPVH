using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;
using LB_GPVH.Auxiliares;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorFuncionario
    {
        public enum ResultadoGestionFuncionario
        {
            CaracteresNombreInvalido,
            CaracteresApellidoPaternoInvalido,
            CaracteresApellidoMaternoInvalido,
            CaracteresDireccionInvalido,
            CaracteresCorreoInvalido,
            CaracteresCargoInvalido,
            RunExiste,
            DvInvalido,
            CorreoInvalido,
            FechaInvalida,
            NombreVacio,
            ApellidoPaternoVacio,
            ApellidoMaternoVacio,
            CorreoVacio,
            DireccionVacia,
            Valido,
            Invalido
        }

        public List<Funcionario> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> funcionariosXML = doc.Root.Elements();
            List<Funcionario> funcionarios = new List<Funcionario>();
            foreach (var funcionarioXML in funcionariosXML)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.LeerXML(funcionarioXML);
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }

        public Funcionario DesempaquetarFuncionarioXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            Funcionario funcionario = new Funcionario();
            funcionario.LeerXML(doc.Root);
            return funcionario;
        }

        public Dictionary<int, string> DesempaquetarDiccionarioXml(string xml)
        {
            List<Funcionario> funcionarios = DesempaquetarListaXml(xml);
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            foreach (var funcionario in funcionarios)
            {
                diccionario.Add(funcionario.Run, funcionario.NombreCompleto);
            }
            return diccionario;
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

        public Funcionario BuscarFuncionarioParcial(int run)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarFuncionarioXml(cliente.buscarFuncionarioParcial(run));
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    var wsFuncionario = serviceFuncionarios.getFuncionarioByRun(run);
                    Funcionario funcionario = new Funcionario();
                    funcionario.Run = wsFuncionario.Run_sin_dv;
                    funcionario.Dv = wsFuncionario.Run_dv;
                    funcionario.Nombre = wsFuncionario.Nom_funcionario;
                    funcionario.ApellidoPaterno = wsFuncionario.Ap_paterno;
                    funcionario.ApellidoMaterno = wsFuncionario.Ap_materno;
                    funcionario.Correo = wsFuncionario.Correo;
                    funcionario.Direccion = wsFuncionario.Direc_funcionario;
                    funcionario.Cargo = wsFuncionario.Cargo;
                    funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                    funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                    return funcionario;
                }
            }

            
            
        }

        public Funcionario BuscarFuncionario(int run)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarFuncionarioXml(cliente.buscarFuncionario(run));
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    var wsFuncionario = serviceFuncionarios.getFuncionarioByRun(run);
                    Funcionario funcionario = new Funcionario();
                    funcionario.Run = wsFuncionario.Run_sin_dv;
                    funcionario.Dv = wsFuncionario.Run_dv;
                    funcionario.Nombre = wsFuncionario.Nom_funcionario;
                    funcionario.ApellidoPaterno = wsFuncionario.Ap_paterno;
                    funcionario.ApellidoMaterno = wsFuncionario.Ap_materno;
                    funcionario.Correo = wsFuncionario.Correo;
                    funcionario.Direccion = wsFuncionario.Direc_funcionario;
                    funcionario.Cargo = wsFuncionario.Cargo;
                    funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                    funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                    funcionario.Unidad = new GestionadorUnidad().BuscarPorIdParcial(wsFuncionario.Unidad_id_unidad);
                    return funcionario;
                }
            }
        }


        public List<Funcionario> ListarFuncionarios()
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarListaXml(cliente.listarFuncionarios());
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    List<Funcionario> funcionarios = new List<Funcionario>();
                    var listadoFuncionarios = serviceFuncionarios.getListadoFuncionarios();
                    foreach (WS_GPVH.WebServices.Funcionarios.Funcionario wsFuncionario in listadoFuncionarios)
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionario.Run = wsFuncionario.Run_sin_dv;
                        funcionario.Dv = wsFuncionario.Run_dv;
                        funcionario.Nombre = wsFuncionario.Nom_funcionario;
                        funcionario.ApellidoPaterno = wsFuncionario.Ap_paterno;
                        funcionario.ApellidoMaterno = wsFuncionario.Ap_materno;
                        funcionario.Correo = wsFuncionario.Correo;
                        funcionario.Direccion = wsFuncionario.Direc_funcionario;
                        funcionario.Cargo = wsFuncionario.Cargo;
                        funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                        funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                        funcionario.Unidad = new GestionadorUnidad().BuscarPorIdParcial(wsFuncionario.Unidad_id_unidad);
                        funcionarios.Add(funcionario);
                    }
                    //****
                    return funcionarios;
                }
            }
        }

        public List<Funcionario> ListarFuncionariosDeUnidad(int idUnidad)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarListaXml(cliente.listarFuncionariosDeUnidad(idUnidad));
                }
            }
            else
            {
                return new SQL.FuncionarioSQL().getListadoFuncionariosHijosUnidad(idUnidad);
            }
        }



        public ResultadoGestionFuncionario AgregarFuncionario(Funcionario funcionario)
        {
            ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
            if (validacion != ResultadoGestionFuncionario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.insertarFuncionario(
                        funcionario.Run,
                        funcionario.Dv,
                        funcionario.Nombre,
                        funcionario.ApellidoPaterno,
                        funcionario.ApellidoMaterno,
                        funcionario.FechaNacimiento,
                        funcionario.Correo,
                        funcionario.Direccion,
                        funcionario.Cargo, 
                        funcionario.Unidad.Id));
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    
                    codigoRetorno = serviceFuncionarios.addFuncionario(funcionario.Run, funcionario.Dv, funcionario.Nombre, funcionario.ApellidoPaterno, funcionario.ApellidoMaterno, funcionario.FechaNacimiento,
                                                                        funcionario.Correo, funcionario.Direccion, funcionario.Cargo, funcionario.Unidad.Id);
                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionFuncionario.Valido;
                default:
                    return ResultadoGestionFuncionario.Invalido;
            }
        }

        public ResultadoGestionFuncionario ModificarFuncionario(Funcionario funcionario)
        {
            ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
            if (validacion != ResultadoGestionFuncionario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    codigoRetorno = DesempaquetarRespuesta(cliente.modificarFuncionario(
                        funcionario.Run,
                        funcionario.Dv,
                        funcionario.Nombre,
                        funcionario.ApellidoPaterno,
                        funcionario.ApellidoMaterno,
                        funcionario.FechaNacimiento,
                        funcionario.Correo,
                        funcionario.Direccion,
                        funcionario.Cargo,
                        funcionario.Habilitado,
                        funcionario.Unidad.Id));
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    codigoRetorno = serviceFuncionarios.modifyFuncionario(funcionario.Run, funcionario.Nombre, funcionario.ApellidoPaterno, funcionario.ApellidoMaterno, funcionario.FechaNacimiento,
                                                                        funcionario.Correo, funcionario.Direccion, funcionario.Cargo, funcionario.Habilitado, funcionario.Unidad.Id);
                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionFuncionario.Valido;
                default:
                    return ResultadoGestionFuncionario.Invalido;
            }
        }

        public ResultadoGestionFuncionario EliminarFuncionario(int run)
        {
            int salida;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    salida = DesempaquetarRespuesta(cliente.eliminarFuncionario(run));
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionario = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    salida = serviceFuncionario.deleteFuncionario(run);
                }
            }
            if (salida == 0)
            {
                return ResultadoGestionFuncionario.Valido;
            }
            else
                return ResultadoGestionFuncionario.Invalido;
        }


        public ResultadoGestionFuncionario ValidarFuncionario(Funcionario funcionario)
        {
            if (funcionario.Nombre.Length == 0)
            {
                return ResultadoGestionFuncionario.NombreVacio;
            }
            else if (funcionario.Run == -1 || funcionario.Dv == -1)
            {
                return ResultadoGestionFuncionario.ApellidoPaternoVacio;
            }
            else if (funcionario.ApellidoPaterno.Length == 0)
            {
                return ResultadoGestionFuncionario.ApellidoPaternoVacio;
            }
            else if (funcionario.ApellidoMaterno.Length == 0)
            {
                return ResultadoGestionFuncionario.ApellidoMaternoVacio;
            }
            else if (funcionario.Direccion.Length == 0)
            {
                return ResultadoGestionFuncionario.DireccionVacia;
            }
            return ResultadoGestionFuncionario.Valido;
        }


        public Dictionary<int, string> DiccionarioFuncionariosNoJefes()
        {
            Dictionary<int, string> lista;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    lista =  DesempaquetarDiccionarioXml(cliente.listarFuncionariosNoJefesClaveValor());
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    lista = serviceFuncionarios.getListadoFuncionariosNoJefesClaveValor();
                }
            }
            Dictionary<int, string> listaFinal = new Dictionary<int, string>();
            listaFinal.Add(-1, "");
            foreach (var unidad in lista)
            {
                listaFinal.Add(unidad.Key, unidad.Value);
            }
            return listaFinal;
        }

        public Dictionary<int, string> DiccionarioFuncionariosClaveValor(bool primeraFilaVacia)
        {
            Dictionary<int, string> lista = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    lista = DesempaquetarDiccionarioXml(cliente.listarFuncionariosClaveValor());
                }
            }
            else
            {
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    lista = serviceFuncionarios.getListadoFuncionariosClaveValor();
                }
            }
            if (primeraFilaVacia)
            {
                Dictionary<int, string> listaFinal = new Dictionary<int, string>();
                listaFinal.Add(-1, "");
                foreach (var unidad in lista)
                {
                    listaFinal.Add(unidad.Key, unidad.Value);
                }
                return listaFinal;
            }
            else
            {
                return lista;
            }
        }


        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Run");
            parametros.Add("Dv");
            parametros.Add("Nombre");
            parametros.Add("ApellidoPaterno");
            parametros.Add("ApellidoMaterno");
            parametros.Add("FechaNacimiento");
            parametros.Add("Correo");
            parametros.Add("Direccion");
            parametros.Add("Cargo");
            parametros.Add("Habilitado");
            parametros.Add("NombreUnidad");

            return parametros;
        }

        

        public void setUnidadFuncionario(Funcionario funcionario, int idUnidad, string nombreUnidad)
        {
            if (funcionario.Unidad == null)
            {
                funcionario.Unidad = new Unidad();
            }
            funcionario.Unidad.Id = idUnidad;
            funcionario.Unidad.Nombre = nombreUnidad;
        }

        public ResultadoGestionFuncionario ValidarRun(Funcionario funcionario, int run, int dv)
        {
            if(funcionario.Modulo11(run, dv))
            {
                return ResultadoGestionFuncionario.Valido;
            }
            else
            {
                return ResultadoGestionFuncionario.DvInvalido;
            }
        }

        public ResultadoGestionFuncionario ValidarFormatoCorreo(Funcionario funcionario, string correo)
        {
            if (funcionario.ValidarFormatoCorreo(correo))
            {
                return ResultadoGestionFuncionario.Valido;
            }
            else
            {
                return ResultadoGestionFuncionario.CorreoInvalido;
            }
        }


        public bool ControlarCaracterRun(char caracter)
        {
            if (!AuxiliarString.EsNumerico(caracter) && caracter != 8)
                return true;
            else
                return false;
        }

        public bool ControlarCaracterDV(char caracter)
        {
            if (!AuxiliarString.EsNumerico(caracter) && caracter != 8 && caracter != 'k' && caracter != 'K')
                return true;
            else
                return false;
        }

        public ResultadoGestionFuncionario ValidarCaracterNombreFuncionario(Funcionario funcionario, string nombre)
        {
            if (!funcionario.ValidarNombre(nombre))
            {
                return ResultadoGestionFuncionario.CaracteresNombreInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterApellidoPaternoFuncionario(Funcionario funcionario, string apellidoPaterno)
        {
            if (!funcionario.ValidarApellidoPaterno(apellidoPaterno))
            {
                return ResultadoGestionFuncionario.CaracteresApellidoPaternoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterApellidoMaternoFuncionario(Funcionario funcionario, string apellidoMaterno)
        {
            if (!funcionario.ValidarApellidoMaterno(apellidoMaterno))
            {
                return ResultadoGestionFuncionario.CaracteresApellidoMaternoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterCorreo(Funcionario funcionario, string correo)
        {
            if (!funcionario.ValidarCaracteresCorreo(correo))
            {
                return ResultadoGestionFuncionario.CaracteresCorreoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterDireccion(Funcionario funcionario, string direccion)
        {
            if (!funcionario.ValidarDireccion(direccion))
            {
                return ResultadoGestionFuncionario.CaracteresDireccionInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterCargo(Funcionario funcionario, string cargo)
        {
            if (!funcionario.ValidarCargo(cargo))
            {
                return ResultadoGestionFuncionario.CaracteresCargoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }


        public ResultadoGestionFuncionario ValidarFechaNacimientoFuncionario(Funcionario funcionario, DateTime fechaNacimiento)
        {
            if (!funcionario.ValidaFechaNacimiento(fechaNacimiento))
            {
                return ResultadoGestionFuncionario.FechaInvalida;
            }
            return ResultadoGestionFuncionario.Valido;
        }

    }
}
