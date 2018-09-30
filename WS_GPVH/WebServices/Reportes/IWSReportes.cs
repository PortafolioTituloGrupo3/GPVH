
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Reportes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSReportes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSReportes
    {
        [OperationContract]
        List<FilaReportePermisos> ReportePermisos(DateTime inicio, DateTime termino);

    }

    [DataContract]
    public class FilaReportePermisos
    {
        string unidad = "";
        string tipo_permiso = ""; 
        int cantidad = -1;

        [DataMember]
        public string Unidad
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }
        [DataMember]
        public string Tipo_permiso
        {
            get
            {
                return tipo_permiso;
            }

            set
            {
                tipo_permiso = value;
            }
        }
        [DataMember]
        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}
