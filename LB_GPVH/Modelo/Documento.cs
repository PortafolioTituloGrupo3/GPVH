using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Modelo
{
    public class Documento
    {
        int id_documento = -1;
        string nombre_documento = "documento";
        string formato_documento = "";
        DateTime fecha_creacion = DateTime.MinValue;
        string dir = "\\";
        int id_permiso = -1;
        
        public int Id_documento
        {
            get
            {
                return id_documento;
            }

            set
            {
                id_documento = value;
            }
        }
        public string Nombre_documento
        {
            get
            {
                return nombre_documento;
            }

            set
            {
                nombre_documento = value;
            }
        }
        public string Formato_documento
        {
            get
            {
                return formato_documento;
            }

            set
            {
                formato_documento = value;
            }
        }
        public DateTime Fecha_creacion
        {
            get
            {
                return fecha_creacion;
            }

            set
            {
                fecha_creacion = value;
            }
        }
        public string Dir
        {
            get
            {
                return dir;
            }

            set
            {
                dir = value;
            }
        }
        public int Id_permiso
        {
            get
            {
                return id_permiso;
            }

            set
            {
                id_permiso = value;
            }
        }
    }
}
