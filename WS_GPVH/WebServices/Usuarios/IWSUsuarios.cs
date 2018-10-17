using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_GPVH
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSUsuarios
    {

        [OperationContract]
        List<Usuario> getListadoUsuarios();
        [OperationContract]
        Usuario getUsuarioById(int id);
        [OperationContract]
        int addUsuario(string nombre, string clave, string tipo, int run);
        [OperationContract]
        int modifyUsuario(int id, string nombre, string clave,
                                string tipo, int run);
        [OperationContract]
        int deleteUsuario(int id);
        [OperationContract]
        Usuario autenticarUsuario(string nombre, string clave);
        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Usuario
    {
        int id_usuario= -1;
        string nombre_usuario= "";
        string clave = "";
        string tipo_usuario = "";
        int? funcionario_run_sin_dv = null;
        [DataMember]
        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }
        [DataMember]
        public string Nombre_usuario
        {
            get
            {
                return nombre_usuario;
            }

            set
            {
                nombre_usuario = value;
            }
        }
        [DataMember]
        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }
        [DataMember]
        public string Tipo_usuario
        {
            get
            {
                return tipo_usuario;
            }

            set
            {
                tipo_usuario = value;
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
