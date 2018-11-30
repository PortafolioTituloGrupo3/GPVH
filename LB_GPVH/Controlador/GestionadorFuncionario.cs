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
        //Muestra posibles resultados de cada metodo, comprensibles para el usuario final
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

        #region xml
        //Recibe un string con formato xml y lo convierte en una lista de funcionario
        public List<Funcionario> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> funcionariosXML = doc.Root.Elements();
            //Variable de salida
            List<Funcionario> funcionarios = new List<Funcionario>();
            //Se recorren los elementos del xml y se crean funcionarios
            foreach (var funcionarioXML in funcionariosXML)
            {
                Funcionario funcionario = new Funcionario();
                //Se cargan los datos del funcionario con la informacion del documento
                funcionario.LeerXML(funcionarioXML);
                //Se agrega el funcionario a la lista de salida
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }
        //Recibe un string con formato xml y lo convierte en un objeto "Funcionario"
        public Funcionario DesempaquetarFuncionarioXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Variable de salida
            Funcionario funcionario = new Funcionario();
            //Se cargan los datos del funcionario con la informacion del documento
            funcionario.LeerXML(doc.Root);
            return funcionario;
        }
        //Recibe un string con formato xml y lo convierte en un diccionario con clave y valor
        public Dictionary<int, string> DesempaquetarDiccionarioXml(string xml)
        {
            //Se llama a la funcion DesempaquetarListaXml para retornar un listado,
            //el que se recorrera para cargar la informacion del diccionario
            List<Funcionario> funcionarios = DesempaquetarListaXml(xml);
            //Variable de salida
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            foreach (var funcionario in funcionarios)
            {
                diccionario.Add(funcionario.Run, funcionario.NombreCompleto);
            }
            return diccionario;
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

        //Retorna solo la informacion del funcionario (excluyendo relaciones y llaves foraneas) por su run
        public Funcionario BuscarFuncionarioParcial(int run)
        {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarFuncionarioXml(cliente.buscarFuncionarioParcial(run));
                }   
        }
        //Retorna a un funcionario por su run
        public Funcionario BuscarFuncionario(int run)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarFuncionarioXml(cliente.buscarFuncionario(run));
            }
        }
        //Retorna un listado de funcionario
        public List<Funcionario> ListarFuncionarios()
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarListaXml(cliente.listarFuncionarios());
            }
        }
        //Retorna un listado de funcionario por unidad
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
        //Agrega un nuevo funcionario
        public ResultadoGestionFuncionario AgregarFuncionario(Funcionario funcionario)
        {
            ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
            if (validacion != ResultadoGestionFuncionario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                //Se pasa la informacion para la insercion de datos y se retorna un numero que indique el resultado
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
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionFuncionario.Valido;
                default:
                    return ResultadoGestionFuncionario.Invalido;
            }
        }
        //Modifica un funcionario
        public ResultadoGestionFuncionario ModificarFuncionario(Funcionario funcionario)
        {
            ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
            if (validacion != ResultadoGestionFuncionario.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                //Se pasa la informacion para la modificacion de datos y se retorna un numero que indique el resultado
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
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionFuncionario.Valido;
                default:
                    return ResultadoGestionFuncionario.Invalido;
            }
        }
        //Elimina un funcionario
        public ResultadoGestionFuncionario EliminarFuncionario(int run)
        {
            int salida;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                //Se pasa la informacion eliminar los datos y se retorna un numero que indique el resultado
                salida = DesempaquetarRespuesta(cliente.eliminarFuncionario(run));
            }
            if (salida == 0)
            {
                return ResultadoGestionFuncionario.Valido;
            }
            else
                return ResultadoGestionFuncionario.Invalido;
        }
        //Valida los datos ingresados para agregar o modificar
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
        //Retorna un diccionario de los funcionarios no jefes
        public Dictionary<int, string> DiccionarioFuncionariosNoJefes()
        {
            Dictionary<int, string> lista;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                lista =  DesempaquetarDiccionarioXml(cliente.listarFuncionariosNoJefesClaveValor());
            }
            Dictionary<int, string> listaFinal = new Dictionary<int, string>();
            listaFinal.Add(-1, "");
            foreach (var unidad in lista)
            {
                listaFinal.Add(unidad.Key, unidad.Value);
            }
            return listaFinal;
        }
        //Retorna un diccionario de funcionarios
        public Dictionary<int, string> DiccionarioFuncionariosClaveValor(bool primeraFilaVacia)
        {
            Dictionary<int, string> lista = null;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                lista = DesempaquetarDiccionarioXml(cliente.listarFuncionariosClaveValor());
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
        //Retorna una lista con los parametros que se usaran al desplegar informacion en la capa vista.
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
        //Cambia la unidad de un funcionario
        public void setUnidadFuncionario(Funcionario funcionario, int idUnidad, string nombreUnidad)
        {
            if (funcionario.Unidad == null)
            {
                funcionario.Unidad = new Unidad();
            }
            funcionario.Unidad.Id = idUnidad;
            funcionario.Unidad.Nombre = nombreUnidad;
        }
        #region validacionDeDatos
        //Valida el run con la funcion modulo11
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
        #endregion
    }
}
