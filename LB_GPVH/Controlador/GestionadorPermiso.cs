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
