using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Unidad> ListarUnidades()
        {
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                List<Unidad> unidades = new List<Unidad>();
                //****Sujeto a cambios para intergracion
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
                        unidad.Jefe = new GestionadorFuncionario().BuscarFuncionario((int)wsUnidad.Funcionario_run_sin_dv);
                    }
                    if (wsUnidad.Unidad_id_unidad != null)
                    {
                        unidad.UnidadPadre = new GestionadorUnidad().BuscarPorIdParcial((int)wsUnidad.Unidad_id_unidad);
                    }
                    unidades.Add(unidad);
                }
                //****
                return unidades;
            }
        }

        public void setPadre(Unidad unidad, int id, string nombre)
        {
            if(unidad.UnidadPadre == null)
            {
                unidad.UnidadPadre = new Unidad();
            }
            unidad.UnidadPadre.Nombre = nombre;
            unidad.UnidadPadre.Id = id;
        }

        public void setJefe(Unidad unidad, int run, string nombreCompleto)
        {
            if (unidad.Jefe == null)
            {
                unidad.Jefe = new Funcionario();
            }
            unidad.Jefe.Run = run;
            string[] nombreSplit = nombreCompleto.Split(' ');
            unidad.Jefe.Nombre = nombreSplit[0];
            if(nombreSplit.Length > 1)
            {
                unidad.Jefe.ApellidoPaterno = nombreSplit[1];
            }
            if (nombreSplit.Length > 2)
            {
                unidad.Jefe.ApellidoMaterno = nombreSplit[2];
            }
        }

        public ResultadoGestionUnidad AgregarUnidad(Unidad unidad)
        {
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                ResultadoGestionUnidad validacion = this.validarUnidad(unidad);
                if(validacion != ResultadoGestionUnidad.Valido)
                {
                    return validacion;
                }
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
                int codigoRetorno = serviceUnidades.addUnidad(unidad.Nombre, unidad.Descripcion, unidad.Direccion, padre, jefe);
                switch(codigoRetorno)
                {
                    case 0:
                        return ResultadoGestionUnidad.Valido;
                    default:
                        return ResultadoGestionUnidad.Invalido;
                }
            }
        }


        public ResultadoGestionUnidad validarUnidad(Unidad unidad)
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


        public Dictionary<int, string> DiccionarioUnidadClaveValor()
        {
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                Dictionary<int, string> lista = new Dictionary<int, string>();
                lista = serviceUnidades.getListadoUnidadesClaveValor();
                return lista;
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

        public Unidad BuscarPorIdParcial(int id)
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

        public bool nombreUnidadExiste(string nombre)
        {
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                return serviceUnidades.unidadExiste(nombre);
            }
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

            if(nombreUnidadExiste(nombre))
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
