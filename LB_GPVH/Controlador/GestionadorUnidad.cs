using LB_GPVH.Modelo;
using LB_GPVH.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorUnidad
    {
        //Muestra posibles resultados de cada metodo, comprensibles para el usuario final
        public enum ResultadoGestionUnidad
        {
            CaracteresNombreInvalido,
            CaracteresDescripcionInvalido,
            CaracteresDireccionInvalido,
            UnidadExiste,
            NombreVacio,
            DescripcionVacia,
            DireccionVacia,
            Valido,
            Invalido
        }
        public GestionadorUnidad()
        {
            
        }

        #region xml
        //Recibe un string con formato xml y lo convierte en una lista de unidad
        public List<Unidad> DesempaquetarListaXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            //Se pasan lo elementos del documento
            IEnumerable<XElement> unidadesXML = doc.Root.Elements();
            //Variable de salida
            List<Unidad> unidades = new List<Unidad>();
            //Se recorren los elementos del xml y se crean unidades
            foreach (var unidadXML in unidadesXML)
            {
                Unidad unidad = new Unidad();
                //Se cargan los datos de la unidad con la informacion del documento
                unidad.LeerXML(unidadXML);
                //Se agrega la unidad a la lista de salida
                unidades.Add(unidad);
            }
            return unidades;
        }
        //Recibe un string con formato xml y lo convierte en un diccionario con clave y valor
        public Dictionary<int, string> DesempaquetarDiccionarioXml(string xml)
        {
            //Se llama a la funcion DesempaquetarListaXml para retornar un listado,
            //el que se recorrera para cargar la informacion del diccionario
            List<Unidad> unidades = DesempaquetarListaXml(xml);
            //Variable de salida
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            foreach (var unidad in unidades)
            {
                diccionario.Add(unidad.Id, unidad.Nombre);
            }
            return diccionario;
        }
        //Recibe un string con formato xml y lo convierte en una unidad
        public Unidad DesempaquetarUnidadXml(string xml)
        {
            //Se crea la representacion de un documento xml
            XDocument doc = XDocument.Parse(xml);
            Unidad unidad = new Unidad();
            //Se cargan los datos de la unidad con la informacion del documento
            unidad.LeerXML(doc.Root);
            return unidad;
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
        public List<Unidad> ListarUnidades()
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarListaXml(cliente.listarUnidades());
            }
        }
        //Agrega un nueva unidad
        public ResultadoGestionUnidad AgregarUnidad(Unidad unidad)
        {
            ResultadoGestionUnidad validacion = this.ValidarUnidad(unidad);
            if (validacion != ResultadoGestionUnidad.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            int idPadre;
            if (unidad.UnidadPadre == null)
                idPadre = -1;
            else
                idPadre = unidad.UnidadPadre.Id;
            int runJefe;
            if (unidad.Jefe == null)
                runJefe = -1;
            else
                runJefe = unidad.Jefe.Run;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                codigoRetorno = DesempaquetarRespuesta(cliente.insertarUnidad(
                    unidad.Nombre,
                    unidad.Descripcion,
                    unidad.Direccion,
                    idPadre,
                    runJefe));
            }
            
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUnidad.Valido;
                default:
                    return ResultadoGestionUnidad.Invalido;
            }
        }
        //Modifica una unidad especificada
        public ResultadoGestionUnidad ModificarUnidad(Unidad unidad)
        {
            ResultadoGestionUnidad validacion = this.ValidarUnidad(unidad);
            if (validacion != ResultadoGestionUnidad.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            int idPadre;
            if (unidad.UnidadPadre == null)
                idPadre = -1;
            else
                idPadre = unidad.UnidadPadre.Id;
            int runJefe;
            if (unidad.Jefe == null)
                runJefe = -1;
            else
                runJefe = unidad.Jefe.Run;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                codigoRetorno = DesempaquetarRespuesta(cliente.modificarUnidad(
                    unidad.Id,
                    unidad.Nombre,
                    unidad.Descripcion,
                    unidad.Direccion,
                    unidad.Habilitado,
                    idPadre,
                    runJefe));
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUnidad.Valido;
                default:
                    return ResultadoGestionUnidad.Invalido;
            }
        }
        //Elimina un  unidad especificada
        public ResultadoGestionUnidad EliminarUnidad(int id)
        {
            int salida;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                salida = DesempaquetarRespuesta(cliente.eliminarUnidad(id));
            }
            if (salida == 0)
            {
                return ResultadoGestionUnidad.Valido;
            }
            else
                return ResultadoGestionUnidad.Invalido;
        }
        //Retorna un diccionario de funcionarios
        public Dictionary<int, string> DiccionarioUnidadClaveValor(bool primeraFilaVacia)
        {
            Dictionary<int, string> lista = null;
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                lista = DesempaquetarDiccionarioXml(cliente.listadoUnidadClaveValor());
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
        
        /// <summary>
        /// Busca la unidad cuyo id es entregado, incluyendo sus unidades hijas.
        /// </summary>
        /// <param name="primeraFilaVacia">Agregar un espacio en blanco para la primera fila del diccionario</param>
        /// <returns></returns>
        public Dictionary<int, string> DiccionarioUnidadConHijas(int idUnidad,bool primeraFilaVacia)
        {
            Dictionary<int, string> lista = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    lista = DesempaquetarDiccionarioXml(cliente.listadoUnidadesHijasClaveValor(idUnidad));
                }
            }
            else
            {
                lista = new UnidadSQL().getListadoUnidadesHijasClaveValor(idUnidad);
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
        //Retorna solo la informacion de la unidad (excluyendo relaciones y llaves foraneas) por su id
        public Unidad BuscarPorIdParcial(int id)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarUnidadXml(cliente.buscarUnidadPorIdParcial(id));
            }
        }
        //Comprueba si existe el nombre de la unidad ingresada
        public bool NombreUnidadExiste(string nombre)
        {
            using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
            {
                return DesempaquetarRespuesta(cliente.nombreUnidadExiste(nombre)) != 0;
            }
        }
        #endregion
        
        ///<summary>
        ///Busca las unidades que no tengan parentesco con la unidad cuyo id es el parametro.
        ///</summary>
        ///<return>
        ///Devuelve un diccionario conteniendo los id y nombres de las unidades no descendientes y desiguales al id de la unidad(ver parametro).
        ///</return>
        ///<param nombre="id">
        ///El id de la unidad del cual se quiere excluir los descendientes y si misma.
        ///</param>
        ///<remarks>
        ///Realiza una busqueda recursiva para encontrar todas los id de unidades hijas descendientes. En el peor caso, la complejidad es N^2, y en el mejor caso es N.
        ///
        ///</remarks>
        public Dictionary<int, string> DiccionarioUnidadNoHijaClaveValor(int id)
        {
            List<Unidad> unidadesTotales = this.ListarUnidades();
            List<int> idHijas = new List<int>();
            Dictionary<int, string> lista = new Dictionary<int, string>();
            idHijas.Add(id);
            ObtenerIdHijas(unidadesTotales, idHijas, id);
            lista.Add(-1, "");
            foreach (Unidad unidad in unidadesTotales)
            {
                if (idHijas.Where(s => s == unidad.Id).Count() == 0)
                {
                    lista.Add(unidad.Id, unidad.Nombre);
                }
            }

            return lista;
        }
        //Asigna los id de las unidades ijas a la lista ingresada por parametro
        public void ObtenerIdHijas(List<Unidad> unidadesTotales, List<int> idHijas, int idUnidad)
        {
            foreach (Unidad unidad in unidadesTotales)
            {
                if (unidad.UnidadPadre != null)
                {
                    if (unidad.UnidadPadre.Id == idUnidad)
                    {
                        idHijas.Add(unidad.Id);
                        ObtenerIdHijas(unidadesTotales, idHijas, unidad.Id);
                    }
                }
            }
        }
        //Retorna una lista con los parametros que se usaran al desplegar informacion en la capa vista.
        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Id");
            parametros.Add("Nombre");
            parametros.Add("Descripcion");
            parametros.Add("Direccion");
            parametros.Add("Habilitado");
            parametros.Add("NombrePadre");
            parametros.Add("NombreJefe");
            return parametros;
        }
        //Define la unidad padre de una unidad
        public void SetPadre(Unidad unidad, int id, string nombre)
        {
            if (unidad.UnidadPadre == null)
            {
                unidad.UnidadPadre = new Unidad();
            }
            unidad.UnidadPadre.Nombre = nombre;
            unidad.UnidadPadre.Id = id;
        }
        //Deja a la unidad ingresada sin unidad padre
        public void EliminarPadre(Unidad unidad)
        {
            unidad.UnidadPadre = null;
        }
        //Define el jefe de una unidad
        public void SetJefe(Unidad unidad, int run, string nombreCompleto)
        {
            if (unidad.Jefe == null)
            {
                unidad.Jefe = new Funcionario();
            }
            unidad.Jefe.Run = run;
            string[] nombreSplit = nombreCompleto.Split(' ');
            unidad.Jefe.Nombre = nombreSplit[0];
            if (nombreSplit.Length > 1)
            {
                unidad.Jefe.ApellidoPaterno = nombreSplit[1];
            }
            if (nombreSplit.Length > 2)
            {
                unidad.Jefe.ApellidoMaterno = nombreSplit[2];
            }
        }
        //Deja a la unidad ingresada sin jefe
        public void EliminarJefe(Unidad unidad)
        {
            unidad.Jefe = null;
        }
        #region validacionDeDatos
        public ResultadoGestionUnidad ValidarUnidad(Unidad unidad)
        {
            if (unidad.Nombre.Length == 0)
            {
                return ResultadoGestionUnidad.NombreVacio;
            }
            else if (unidad.Descripcion.Length == 0)
            {
                return ResultadoGestionUnidad.DescripcionVacia;
            }
            else if (unidad.Direccion.Length == 0)
            {
                return ResultadoGestionUnidad.DireccionVacia;
            }
            return ResultadoGestionUnidad.Valido;
        }
        public ResultadoGestionUnidad ValidarCaracterNombreUnidad(Unidad unidad, string nombre)
        {
            if(!unidad.ValidarNombre(nombre))
            {
                return ResultadoGestionUnidad.CaracteresNombreInvalido;
            }
            return ResultadoGestionUnidad.Valido;
        }
        public ResultadoGestionUnidad ValidarNombreUnidad(Unidad unidad, string nombre)
        {

            if(NombreUnidadExiste(nombre))
            {
                return ResultadoGestionUnidad.UnidadExiste;
            }
            if (!unidad.ValidarNombre(nombre))
            {
                return ResultadoGestionUnidad.CaracteresNombreInvalido;
            }
            return ResultadoGestionUnidad.Valido;
        }
        public ResultadoGestionUnidad ValidarDescripcion(Unidad unidad, string descripcion)
        {
            if (!unidad.ValidarDescripcion(descripcion))
            {
                return ResultadoGestionUnidad.CaracteresDescripcionInvalido;
            }
            return ResultadoGestionUnidad.Valido;
        }
        public ResultadoGestionUnidad ValidarDireccion(Unidad unidad, string direccion)
        {
            if (!unidad.ValidarDireccion(direccion))
            {
                return ResultadoGestionUnidad.CaracteresDireccionInvalido;
            }
            return ResultadoGestionUnidad.Valido;
        }
        #endregion
    }
}
