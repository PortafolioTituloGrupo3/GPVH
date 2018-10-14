using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_GPVH.WebServices.Funcionarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSFuncionarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSFuncionarios
    {
        [OperationContract]
        List<Funcionario> getListadoFuncionarios();
        [OperationContract]
        Dictionary<int, string> getListadoFuncionariosClaveValor();
        [OperationContract]
        Dictionary<int, string> getListadoFuncionariosNoJefesClaveValor();
        [OperationContract]
        Dictionary<int, string> getListadoFuncionariosNoJefesNoClaveValorModificar(int id_unidad);
        [OperationContract]
        Funcionario getFuncionarioByRun(int run);
        [OperationContract]
        int addFuncionario(int run, int dv, string nombre, string ap_pat,
                            string ap_mat, DateTime nacimiento, string correo,
                            string direccion, string tipo_funcionario,
                            int id_unidad);
        [OperationContract]
        int modifyFuncionario(int run, string nombre, string ap_pat,
                            string ap_mat, DateTime nacimiento, string correo,
                            string direccion, string tipo_funcionario,
                            bool habilitado_bool, int id_unidad);
        [OperationContract]
        int deleteFuncionario(int run);
    }

    [DataContract]
    public class Funcionario
    {
        int run_sin_dv = -1;
        int run_dv = -1;
        string nom_funcionario = "";
        string ap_paterno = "";
        string ap_materno = "";
        DateTime fec_nacimiento = DateTime.Now;
        string correo = "";
        string direc_funcionario = "";
        string cargo = "";
        int habilitado = 1;
        int unidad_id_unidad = 999;

        [DataMember]
        public int Run_sin_dv
        {
            get
            {
                return run_sin_dv;
            }

            set
            {
                run_sin_dv = value;
            }
        }
        [DataMember]
        public int Run_dv
        {
            get
            {
                return run_dv;
            }

            set
            {
                run_dv = value;
            }
        }
        [DataMember]
        public string Nom_funcionario
        {
            get
            {
                return nom_funcionario;
            }

            set
            {
                nom_funcionario = value;
            }
        }
        [DataMember]
        public string Ap_paterno
        {
            get
            {
                return ap_paterno;
            }

            set
            {
                ap_paterno = value;
            }
        }
        [DataMember]
        public string Ap_materno
        {
            get
            {
                return ap_materno;
            }

            set
            {
                ap_materno = value;
            }
        }
        [DataMember]
        public DateTime Fec_nacimiento
        {
            get
            {
                return fec_nacimiento;
            }

            set
            {
                fec_nacimiento = value;
            }
        }
        [DataMember]
        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }
        [DataMember]
        public string Direc_funcionario
        {
            get
            {
                return direc_funcionario;
            }

            set
            {
                direc_funcionario = value;
            }
        }
        [DataMember]
        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
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
        public int Unidad_id_unidad
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
    }
}
