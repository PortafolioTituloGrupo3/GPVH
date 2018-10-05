using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;

namespace LB_GPVH.Controlador
{
    public class GestionadorFuncionario
    {


        public Funcionario BuscarFuncionario(int run)
        {
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                var wsFuncionario = serviceFuncionarios.getFuncionarioByRun(run);
                Funcionario funcionario = new Funcionario();
                funcionario.Run = wsFuncionario.Run_sin_dv;
                funcionario.Dv = wsFuncionario.Run_dv;
                funcionario.Nombre = wsFuncionario.Nom_funcionario;
                funcionario.ApellidoPaterno = wsFuncionario.Ap_paterno;
                funcionario.ApellidoMaterno = wsFuncionario.Ap_materno;
                funcionario.Correo = wsFuncionario.Correo;
                funcionario.Tipo = wsFuncionario.Tipo_funcionario;
                funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                return funcionario;

            }

        }



        public Dictionary<int, string> DiccionarioFuncionariosNoJefes()
        { 
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> diccionario = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                diccionario = serviceFuncionarios.getListadoFuncionariosNoJefesClaveValor();
                return diccionario;
            }
        }


    }
}
