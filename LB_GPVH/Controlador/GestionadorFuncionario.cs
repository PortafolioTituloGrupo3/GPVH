using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_GPVH.Modelo;
using LB_GPVH.Auxiliares;

namespace LB_GPVH.Controlador
{
    public class GestionadorFuncionario
    {
        public enum ResultadoGestionFuncionario
        {
            CaracteresNombreInvalido,
            CaracteresApellidoPaternoInvalido,
            CaracteresApellidoMaternoInvalido,
            CaracteresDireccionInvalido,
            CaracteresCorreoInvalido,
            CaracteresCargoInvalido,
            RunExiste,
            DvInvalido,
            FechaInvalida,
            NombreVacio,
            ApellidoPaternoVacio,
            ApellidoMaternoVacio,
            CorreoVacio,
            DireccionVacia,
            Valido,
            Invalido
        }

        public Funcionario BuscarFuncionarioParcial(int run)
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
                funcionario.Direccion = wsFuncionario.Direc_funcionario;
                funcionario.Cargo = wsFuncionario.Cargo;
                funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                return funcionario;

            }

        }

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
                funcionario.Direccion = wsFuncionario.Direc_funcionario;
                funcionario.Cargo = wsFuncionario.Cargo;
                funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                funcionario.Unidad = new GestionadorUnidad().BuscarPorIdParcial(wsFuncionario.Unidad_id_unidad);
                return funcionario;

            }

        }


        public List<Funcionario> ListarFuncionarios()
        {
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                //****Sujeto a cambios para intergracion
                var listadoFuncionarios = serviceFuncionarios.getListadoFuncionarios();
                foreach (WS_GPVH.WebServices.Funcionarios.Funcionario wsFuncionario in listadoFuncionarios)
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Run = wsFuncionario.Run_sin_dv;
                    funcionario.Dv = wsFuncionario.Run_dv;
                    funcionario.Nombre = wsFuncionario.Nom_funcionario;
                    funcionario.ApellidoPaterno = wsFuncionario.Ap_paterno;
                    funcionario.ApellidoMaterno = wsFuncionario.Ap_materno;
                    funcionario.Correo = wsFuncionario.Correo;
                    funcionario.Cargo = wsFuncionario.Cargo;
                    funcionario.FechaNacimiento = wsFuncionario.Fec_nacimiento;
                    funcionario.Habilitado = (wsFuncionario.Habilitado == 0) ? false : true;
                    funcionario.Unidad = new GestionadorUnidad().BuscarPorIdParcial(wsFuncionario.Unidad_id_unidad);
                    funcionarios.Add(funcionario);
                }
                //****
                return funcionarios;
            }
        }

        public ResultadoGestionFuncionario AgregarFuncionario(Funcionario funcionario)
        {
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
                if (validacion != ResultadoGestionFuncionario.Valido)
                {
                    return validacion;
                }
                int? unidad;
                if (funcionario.Unidad == null)
                    unidad = null;
                else
                    unidad = funcionario.Unidad.Id;
                int codigoRetorno = serviceFuncionarios.addFuncionario(funcionario.Run, funcionario.Dv, funcionario.Nombre, funcionario.ApellidoPaterno, funcionario.ApellidoMaterno, funcionario.FechaNacimiento,
                                                                    funcionario.Correo, funcionario.Direccion, funcionario.Cargo, funcionario.Unidad.Id);
                switch (codigoRetorno)
                {
                    case 0:
                        return ResultadoGestionFuncionario.Valido;
                    default:
                        return ResultadoGestionFuncionario.Invalido;
                }
            }
            /*
            int run = int.Parse(this.txt_run.Text);
            int dv = int.Parse(this.txt_dv.Text);
            string nombre = this.txt_nombre.Text;
            string ap_pat = this.txt_ap_pat.Text;
            string ap_mat = this.txt_ap_mat.Text;
            DateTime nacimiento = DateTime.Parse(this.cld_nacimiento.Text);
            string correo = this.txt_correo.Text;
            string direccion = this.txt_direccion.Text;
            bool habilitado = this.chk_habilitado.Checked;
            string tipo = this.ddl_tipo.GetItemText(this.ddl_tipo.SelectedItem);
            int unidad = int.Parse(this.ddl_unidad.SelectedValue.ToString());
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                int salida = serviceFuncionarios.addFuncionario(run, dv, nombre, ap_pat, ap_mat, nacimiento,
                                                                    correo, direccion, tipo, unidad);
                if (salida == 0)
                {
                    padreTemp.loadFuncionarios();
                    MessageBox.Show("Datos agregados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
            */
        }

        public ResultadoGestionFuncionario ModificarFuncionario(Funcionario funcionario)
        {
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                ResultadoGestionFuncionario validacion = this.ValidarFuncionario(funcionario);
                if (validacion != ResultadoGestionFuncionario.Valido)
                {
                    return validacion;
                }
                int? unidad;
                if (funcionario.Unidad == null)
                    unidad = null;
                else
                    unidad = funcionario.Unidad.Id;
                int codigoRetorno = serviceFuncionarios.modifyFuncionario(funcionario.Run, funcionario.Nombre, funcionario.ApellidoPaterno, funcionario.ApellidoMaterno, funcionario.FechaNacimiento,
                                                                    funcionario.Correo, funcionario.Direccion, funcionario.Cargo, funcionario.Habilitado, funcionario.Unidad.Id);
                switch (codigoRetorno)
                {
                    case 0:
                        return ResultadoGestionFuncionario.Valido;
                    default:
                        return ResultadoGestionFuncionario.Invalido;
                }
            }
        }


        public ResultadoGestionFuncionario ValidarFuncionario(Funcionario funcionario)
        {
            if (funcionario.Nombre.Length == 0)
            {
                return ResultadoGestionFuncionario.NombreVacio;
            }
            else if (funcionario.Run == -1 || funcionario.Dv == -1)
            {
                return ResultadoGestionFuncionario.ApellidoPaternoVacio;
            }
            else if (funcionario.ApellidoPaterno.Length == 0)
            {
                return ResultadoGestionFuncionario.ApellidoPaternoVacio;
            }
            else if (funcionario.ApellidoMaterno.Length == 0)
            {
                return ResultadoGestionFuncionario.ApellidoMaternoVacio;
            }
            else if (funcionario.Direccion.Length == 0)
            {
                return ResultadoGestionFuncionario.DireccionVacia;
            }
            return ResultadoGestionFuncionario.Valido;
        }


        public Dictionary<int, string> DiccionarioFuncionariosNoJefes()
        {
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {

                Dictionary<int, string> listaFinal = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                Dictionary<int, string> lista = serviceFuncionarios.getListadoFuncionariosNoJefesClaveValor();
                listaFinal.Add(-1, "");
                foreach (var unidad in lista)
                {
                    listaFinal.Add(unidad.Key, unidad.Value);
                }
                return listaFinal;
            }
        }


        public List<String> ListarNombresParametros()
        {
            List<String> parametros = new List<string>();
            parametros.Add("Run");
            parametros.Add("Dv");
            parametros.Add("Nombre");
            parametros.Add("ApellidoPaterno");
            parametros.Add("ApellidoMaterno");
            parametros.Add("FechaNacimiento");
            parametros.Add("Correo");
            parametros.Add("Direccion");
            parametros.Add("Tipo");
            parametros.Add("Habilitado");
            parametros.Add("NombreUnidad");

            return parametros;
        }

        

        public void setUnidadFuncionario(Funcionario funcionario, int idUnidad, string nombreUnidad)
        {
            if (funcionario.Unidad == null)
            {
                funcionario.Unidad = new Unidad();
            }
            funcionario.Unidad.Id = idUnidad;
            funcionario.Unidad.Nombre = nombreUnidad;
        }

        public ResultadoGestionFuncionario ValidarRun(Funcionario funcionario, int run, int dv)
        {
            if(funcionario.Modulo11(run, dv))
            {
                return ResultadoGestionFuncionario.Valido;
            }
            else
            {
                return ResultadoGestionFuncionario.DvInvalido;
            }
        }

        public bool ControlarCaracterRun(char caracter)
        {
            if (!AuxiliarString.EsNumerico(caracter) && caracter != 8)
                return true;
            else
                return false;
        }

        public bool ControlarCaracterDV(char caracter)
        {
            if (!AuxiliarString.EsNumerico(caracter) && caracter != 8 && caracter != 'k' && caracter != 'K')
                return true;
            else
                return false;
        }

        public ResultadoGestionFuncionario ValidarCaracterNombreFuncionario(Funcionario funcionario, string nombre)
        {
            if (!funcionario.ValidarNombre(nombre))
            {
                return ResultadoGestionFuncionario.CaracteresNombreInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterApellidoPaternoFuncionario(Funcionario funcionario, string apellidoPaterno)
        {
            if (!funcionario.ValidarApellidoPaterno(apellidoPaterno))
            {
                return ResultadoGestionFuncionario.CaracteresApellidoPaternoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterApellidoMaternoFuncionario(Funcionario funcionario, string apellidoMaterno)
        {
            if (!funcionario.ValidarApellidoMaterno(apellidoMaterno))
            {
                return ResultadoGestionFuncionario.CaracteresApellidoMaternoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterCorreo(Funcionario funcionario, string correo)
        {
            if (!funcionario.ValidarCorreo(correo))
            {
                return ResultadoGestionFuncionario.CaracteresCorreoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterDireccion(Funcionario funcionario, string direccion)
        {
            if (!funcionario.ValidarDireccion(direccion))
            {
                return ResultadoGestionFuncionario.CaracteresDireccionInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }

        public ResultadoGestionFuncionario ValidarCaracterCargo(Funcionario funcionario, string cargo)
        {
            if (!funcionario.ValidarCargo(cargo))
            {
                return ResultadoGestionFuncionario.CaracteresCargoInvalido;
            }
            return ResultadoGestionFuncionario.Valido;
        }


        public ResultadoGestionFuncionario ValidarFechaNacimientoFuncionario(Funcionario funcionario, DateTime fechaNacimiento)
        {
            if (!funcionario.ValidaFechaNacimiento(fechaNacimiento))
            {
                return ResultadoGestionFuncionario.FechaInvalida;
            }
            return ResultadoGestionFuncionario.Valido;
        }

    }
}
