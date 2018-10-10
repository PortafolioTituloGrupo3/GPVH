using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Permisos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSPermisos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPermisos
    {
        [OperationContract]
        List<Permiso> getPermisosByFuncionario(int run, int condicion);
    }

    [DataContract]
    public class Permiso
    {
        int id_permiso = -1;
        string tipo_permiso = "";
        string estado = "";
        DateTime fecha_inicio = DateTime.MinValue;
        DateTime fecha_termino = DateTime.MaxValue;
        DateTime fecha_solicitud = DateTime.MinValue;
        string desc_permiso = "";
        int solicitante_run_sin_dv = -1;
        int autorizante_run_sin_dv = -1;

        [DataMember]
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
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
        [DataMember]
        public DateTime Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }

            set
            {
                fecha_inicio = value;
            }
        }
        [DataMember]
        public DateTime Fecha_termino
        {
            get
            {
                return fecha_termino;
            }

            set
            {
                fecha_termino = value;
            }
        }
        [DataMember]
        public DateTime Fecha_solicitud
        {
            get
            {
                return fecha_solicitud;
            }

            set
            {
                fecha_solicitud = value;
            }
        }
        [DataMember]
        public string Desc_permiso
        {
            get
            {
                return desc_permiso;
            }

            set
            {
                desc_permiso = value;
            }
        }
        [DataMember]
        public int Solicitante_run_sin_dv
        {
            get
            {
                return solicitante_run_sin_dv;
            }

            set
            {
                solicitante_run_sin_dv = value;
            }
        }
        [DataMember]
        public int Autorizante_run_sin_dv
        {
            get
            {
                return autorizante_run_sin_dv;
            }

            set
            {
                autorizante_run_sin_dv = value;
            }
        }
    }

}
