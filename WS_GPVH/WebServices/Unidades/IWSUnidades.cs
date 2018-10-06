using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Unidades
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSUnidades" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSUnidades
    {
        [OperationContract]
        List<Unidad> getListadoUnidades();
        [OperationContract]
        bool unidadExiste(string nombre);
        [OperationContract]
        List<Unidad> getListadoUnidadesNoHijas(int id_unidad);
        [OperationContract]
        Dictionary<int, string> getListadoUnidadesNoHijasClaveValor(int id_unidad);
        [OperationContract]
        Dictionary<int, string> getListadoUnidadesClaveValor();
        [OperationContract]
        Unidad getUnidadById(int id_unidad);
        [OperationContract]
        int addUnidad(string nombre, string descripcion, string direccion,
                        int? unidad_padre, int? jefe);
        [OperationContract]
        int modifyUnidad(int id_unidad, string nombre, string descripcion, string direccion,
                                bool habilitado_bool, int? unidad_padre, int? jefe);
        [OperationContract]
        int deleteUnidad(int id);
        [OperationContract]
        Dictionary<int, string> filterListadoUnidades(List<Unidad> listado);
    }

    [DataContract]
    public class Unidad
    {
        int id_unidad = -1;
        string nombre_unidad = "";
        string descripcion_unidad = "";
        string direccion_unidad = "";
        int habilitado = '1'; // 1 cuando esta habilitado; 0 cuando esta desabilitado
        int? unidad_id_unidad = null; //Este es el id de la unidad padre, el cual puede ser nulo
        int? funcionario_run_sin_dv= null; 
        
        [DataMember]
        public int Id_unidad
        {
            get
            {
                return id_unidad;
            }
            set
            {
                id_unidad = value;
            }
        }
        [DataMember]
        public string Nombre_unidad
        {
            get
            {
                return nombre_unidad;
            }

            set
            {
                nombre_unidad = value;
            }
        }
        [DataMember]
        public string Descripcion_unidad
        {
            get
            {
                return descripcion_unidad;
            }

            set
            {
                descripcion_unidad = value;
            }
        }
        [DataMember]
        public string Direccion_unidad
        {
            get
            {
                return direccion_unidad;
            }

            set
            {
                direccion_unidad = value;
            }
        }
        [DataMember]
        public int Habilitado
        {
            get
            {
                return habilitado;
            }

            set
            {
                habilitado = value;
            }
        }
        [DataMember]
        public int? Unidad_id_unidad
        {
            get
            {
                return unidad_id_unidad;
            }

            set
            {
                unidad_id_unidad = value;
            }
        }
        [DataMember]
        public int? Funcionario_run_sin_dv
        {
            get
            {
                return funcionario_run_sin_dv;
            }

            set
            {
                funcionario_run_sin_dv = value;
            }
        }
    }

        
    }