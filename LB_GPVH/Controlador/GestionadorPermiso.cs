using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;

namespace LB_GPVH.Controlador
{
    public class GestionadorPermiso
    {
        public enum ResultadoGestionPermiso
        {

        }

        public bool AsignarPermisos(Funcionario funcionario)
        {
            if(funcionario == null)
            {
                return false;
            }
            else
            {
                funcionario.Permisos = new SQL.PermisoSQL().BuscarPermisos(funcionario.Run);
                return true;
            }
        }


        public List<Permiso> ListarPermisos(int run)
        {
            using (ServiceWSPermisos.WSPermisosClient servicePermisos = new ServiceWSPermisos.WSPermisosClient())
            {
                List<Permiso> permisos = new List<Permiso>();
                //****Sujeto a cambios para intergracion
                var listadoPermisos = servicePermisos.getPermisosByFuncionario(run, -1);
                foreach (WS_GPVH.WebServices.Permisos.Permiso wsPermiso in listadoPermisos)
                {
                    Permiso permiso = new Permiso();
                    permiso.Id = wsPermiso.Id_permiso;
                    switch (wsPermiso.Tipo_permiso)
                    {
                        case ("Administrativo"):
                            permiso.Tipo = Enums.TipoPermiso.Administrativo;
                            break;
                        case ("Feriado Legal"):
                            permiso.Tipo = Enums.TipoPermiso.FeriadoLegal;
                            break;
                        case ("Nacimiento De Hijo"):
                            permiso.Tipo = Enums.TipoPermiso.NacimientoDeHijo;
                            break;
                        case ("Deceso de Familiar"):
                            permiso.Tipo = Enums.TipoPermiso.DecesoDeFamiliar;
                            break;
                    }
                    /**
                    switch (wsPermiso.Estado)
                    {
                        case (""):
                            permiso.Estado = Enums.EstadoPermiso.Autorizado;
                            break;
                        case (""):
                            permiso.Estado = Enums.EstadoPermiso.Autorizado;
                            break;
                        case (""):
                            permiso.Estado = Enums.EstadoPermiso.Autorizado;
                            break;
                    }
                    **/
                    permiso.Estado = Enums.EstadoPermiso.Autorizado;
                    permiso.FechaInicio = wsPermiso.Fecha_inicio;
                    permiso.FechaTermino = wsPermiso.Fecha_termino;
                    permiso.FechaSolicitud = wsPermiso.Fecha_solicitud;
                    permiso.Descripcion = wsPermiso.Desc_permiso;
                    permiso.Solicitante = new GestionadorFuncionario().BuscarFuncionario(wsPermiso.Solicitante_run_sin_dv);
                    permiso.Autorizante = new GestionadorFuncionario().BuscarFuncionario(wsPermiso.Autorizante_run_sin_dv);

                    permisos.Add(permiso);
                }
                return permisos;
            }
        }

        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Id");
            parametros.Add("TipoPermisoString");
            parametros.Add("EstadoPermisoString");
            parametros.Add("FechaInicio");
            parametros.Add("FechaTermino");
            parametros.Add("FechaSolicitud");
            parametros.Add("Descripcion");
            parametros.Add("NombreSolicitante");
            parametros.Add("NombreAutorizante");
            return parametros;
        }

    }
}
