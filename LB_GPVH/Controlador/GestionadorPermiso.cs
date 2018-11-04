using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LB_GPVH.Modelo;
using LB_GPVH.wsIntegracionAppEscritorio;

namespace LB_GPVH.Controlador
{
    public class GestionadorPermiso
    {
        public enum ResultadoGestionPermiso
        {

        }

        public List<Permiso> DesempaquetarListaXml(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            IEnumerable<XElement> permisosXML = doc.Root.Elements();
            List<Permiso> permisos = new List<Permiso>();
            foreach (var permisoXML in permisosXML)
            {
                Permiso permiso = new Permiso();
                permiso.LeerXML(permisoXML);
                permisos.Add(permiso);
            }
            return permisos;
        }

        public bool AsignarPermisos(Funcionario funcionario)
        {
            if(funcionario == null)
            {
                return false;
            }
            else
            {
                if (ParametrosGlobales.usarIntegracion)
                {
                    using (WebServiceAppEscritorioClient cliente = new WebServiceAppEscritorioClient())
                    {
                        funcionario.Permisos = DesempaquetarListaXml(cliente.buscarPermisos(funcionario.Run));
                    }
                }
                else
                {
                    funcionario.Permisos = new SQL.PermisoSQL().BuscarPermisos(funcionario.Run);
                }
                return true;
            }
        }

        public Permiso BuscarPermiso(int id)
        {
            return new SQL.PermisoSQL().BuscarPermiso(id);
        }

        public Permiso BuscarPermisoFull(int id)
        {
            return new SQL.PermisoSQL().BuscarPermisoFull(id);
        }

        public Permiso BuscarPermisoParcial(int id)
        {
            return new SQL.PermisoSQL().BuscarPermisoParcial(id);
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
