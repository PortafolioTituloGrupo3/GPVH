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
            UnidadExiste,
            Valido
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
            if (!unidad.ValidarNombre(nombre))
            {
                return ResultadoGestionUnidad.CaracteresNombreInvalido;
            }
            return ResultadoGestionUnidad.Valido;

        }




    }
}
