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
        public List<Unidad> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> unidadesXML = doc.Root.Elements();
            List<Unidad> unidades = new List<Unidad>();
            foreach (var unidadXML in unidadesXML)
            {
                Unidad unidad = new Unidad();
                unidad.LeerXML(unidadXML);
                unidades.Add(unidad);
            }
            return unidades;
        }

        public Dictionary<int, string> DesempaquetarDiccionarioXml(string xml)
        {
            List<Unidad> unidades = DesempaquetarListaXml(xml);
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            foreach (var unidad in unidades)
            {
                diccionario.Add(unidad.Id, unidad.Nombre);
            }
            return diccionario;
        }

        public Unidad DesempaquetarUnidadXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            Unidad unidad = new Unidad();
            unidad.LeerXML(doc.Root);
            return unidad;
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
        #endregion

        #region webservice/sql
        public List<Unidad> ListarUnidades()
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarListaXml(cliente.listarUnidades());
                }
            }
            else
            {
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    List<Unidad> unidades = new List<Unidad>();
                    var listadoUnidades = serviceUnidades.getListadoUnidades();
                    foreach (WS_GPVH.WebServices.Unidades.Unidad wsUnidad in listadoUnidades)
                    {
                        Unidad unidad = new Unidad();
                        unidad.Id = wsUnidad.Id_unidad;
                        unidad.Nombre = wsUnidad.Nombre_unidad;
                        unidad.Descripcion = wsUnidad.Descripcion_unidad;
                        unidad.Direccion = wsUnidad.Direccion_unidad;
                        unidad.Habilitado = (wsUnidad.Habilitado == 0) ? false : true;
                        if (wsUnidad.Funcionario_run_sin_dv != null)
                        {
                            unidad.Jefe = new GestionadorFuncionario().BuscarFuncionarioParcial((int)wsUnidad.Funcionario_run_sin_dv);
                        }
                        if (wsUnidad.Unidad_id_unidad != null)
                        {
                            unidad.UnidadPadre = new GestionadorUnidad().BuscarPorIdParcial((int)wsUnidad.Unidad_id_unidad);
                        }
                        unidades.Add(unidad);
                    }
                    return unidades;
                }
            }
        }

        public ResultadoGestionUnidad AgregarUnidad(Unidad unidad)
        {
            ResultadoGestionUnidad validacion = this.ValidarUnidad(unidad);
            if (validacion != ResultadoGestionUnidad.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
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
            }
            else
            {
                int? padre;
                if (unidad.UnidadPadre == null)
                    padre = null;
                else
                    padre = unidad.UnidadPadre.Id;
                int? jefe;
                if (unidad.Jefe == null)
                    jefe = null;
                else
                    jefe = unidad.Jefe.Run;
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    codigoRetorno = serviceUnidades.addUnidad(unidad.Nombre, unidad.Descripcion, unidad.Direccion, padre, jefe);
                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUnidad.Valido;
                default:
                    return ResultadoGestionUnidad.Invalido;
            }
        }

        public ResultadoGestionUnidad ModificarUnidad(Unidad unidad)
        {
            ResultadoGestionUnidad validacion = this.ValidarUnidad(unidad);
            if (validacion != ResultadoGestionUnidad.Valido)
            {
                return validacion;
            }
            int codigoRetorno;
            if (ParametrosGlobales.usarIntegracion)
            {
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
            }
            else
            {
                int? padre;
                if (unidad.UnidadPadre == null)
                    padre = null;
                else
                    padre = unidad.UnidadPadre.Id;
                int? jefe;
                if (unidad.Jefe == null)
                    jefe = null;
                else
                    jefe = unidad.Jefe.Run;
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    codigoRetorno = serviceUnidades.modifyUnidad(unidad.Id, unidad.Nombre, unidad.Descripcion, unidad.Direccion, unidad.Habilitado, padre, jefe);
                }
            }
            switch (codigoRetorno)
            {
                case 0:
                    return ResultadoGestionUnidad.Valido;
                default:
                    return ResultadoGestionUnidad.Invalido;
            }
        }

        public ResultadoGestionUnidad EliminarUnidad(int id)
        {
            int salida;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    salida = DesempaquetarRespuesta(cliente.eliminarUnidad(id));
                }
            }
            else
            {
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    salida = serviceUnidades.deleteUnidad(id);
                }
            }
            if (salida == 0)
            {
                return ResultadoGestionUnidad.Valido;
            }
            else
                return ResultadoGestionUnidad.Invalido;
        }

        public Dictionary<int, string> DiccionarioUnidadClaveValor(bool primeraFilaVacia)
        {
            Dictionary<int, string> lista = null;
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    lista = DesempaquetarDiccionarioXml(cliente.listadoUnidadClaveValor());
                }
            }
            else
            {
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    lista = serviceUnidades.getListadoUnidadesClaveValor();
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
        

        public Unidad BuscarPorIdParcial(int id)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarUnidadXml(cliente.buscarUnidadPorIdParcial(id));
                }
            }
            else
            {
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    var wsUnidad = serviceUnidades.getUnidadById(id);
                    Unidad unidad = new Unidad();
                    unidad.Id = wsUnidad.Id_unidad;
                    unidad.Nombre = wsUnidad.Nombre_unidad;
                    unidad.Descripcion = wsUnidad.Descripcion_unidad;
                    unidad.Direccion = wsUnidad.Direccion_unidad;
                    unidad.Habilitado = (wsUnidad.Habilitado == 0) ? false : true;
                    return unidad;
                }
            }
        }

        public bool NombreUnidadExiste(string nombre)
        {
            if (ParametrosGlobales.usarIntegracion)
            {
                using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                {
                    return DesempaquetarRespuesta(cliente.nombreUnidadExiste(nombre)) != 0;
                }
            }
            else
            {
                using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    return serviceUnidades.unidadExiste(nombre);
                }
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

        public void SetPadre(Unidad unidad, int id, string nombre)
        {
            if (unidad.UnidadPadre == null)
            {
                unidad.UnidadPadre = new Unidad();
            }
            unidad.UnidadPadre.Nombre = nombre;
            unidad.UnidadPadre.Id = id;
        }

        public void EliminarPadre(Unidad unidad)
        {
            unidad.UnidadPadre = null;
        }

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

        public void EliminarJefe(Unidad unidad)
        {
            unidad.Jefe = null;
        }

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
        
    }
}
