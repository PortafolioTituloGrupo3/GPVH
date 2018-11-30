using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Controlador;
using LB_GPVH.Auxiliares;

namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    public partial class Form_M_Funcionario_Agregar : MetroFramework.Forms.MetroForm
    {
        Form_M_Funcionario padreTemp = null; //Formulario desde el cual se accedio
        GestionadorFuncionario gestionador; //Clase controlador
        LB_GPVH.Modelo.Funcionario funcionario; //Funcionario a agregar
        bool nombreValido, apellidoPaternoValido, apellidoMaternoValido, direccionValida, correoValido, runValido, fechaNacimientoValida, cargoValido;
        private Form mainForm; //Formulario principal

        public Form_M_Funcionario_Agregar(Form pMainForm,Form_M_Funcionario formPadre)
        {
            InitializeComponent();
            this.mainForm = pMainForm;
            padreTemp = formPadre;
            gestionador = new GestionadorFuncionario();
            funcionario = new LB_GPVH.Modelo.Funcionario();
            
            this.loadDdlUnidades();
            nombreValido = true;
            apellidoPaternoValido = true;
            apellidoMaternoValido = true;
            direccionValida = true;
            correoValido = true;
            cargoValido = true;
            fechaNacimientoValida = false;
            runValido = false;
            gestionador.ValidarFechaNacimientoFuncionario(funcionario, cld_nacimiento.Value);
        }

        private void loadDdlUnidades()
        {
            this.ddl_unidad.DisplayMember = "Value";
            this.ddl_unidad.ValueMember = "Key";
            this.ddl_unidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(false), null);
            this.ddl_unidad.SelectedIndex = 0;
        }

        #region eventos
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Visible = true;
            this.Dispose();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && correoValido && apellidoPaternoValido && apellidoMaternoValido && fechaNacimientoValida && runValido && cargoValido)
            {
                GestionadorFuncionario.ResultadoGestionFuncionario resultado = gestionador.AgregarFuncionario(funcionario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoPaternoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El apellido paterno esta vacio.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoMaternoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El apellido materno esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.CorreoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El correo esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.DireccionVacia:
                        MessageBox.Show("No se pudo ingresar el funcionario: La direccion esta vacia.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.NombreVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El nombre esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al ingresar.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Valido:
                        padreTemp.loadFuncionarios();
                        MessageBox.Show("El funcionario se ingreso correctamente.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el funcionario: Existen datos inválidos.");
            }
        }
        private void Form_M_Funcionario_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Close();
        }
        private void txt_run_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = gestionador.ControlarCaracterRun(e.KeyChar);
        }
        private void txt_run_TextChanged(object sender, EventArgs e)
        {
            if (txt_run.Text.Length == 0)
            {
                lblErrorRun.Visible = false;
            }
        }
        private void txt_dv_TextChanged(object sender, EventArgs e)
        {
            if (txt_run.Text.Length == 0)
            {
                lblErrorRun.Visible = false;
            }
        }
        private void txt_dv_Leave(object sender, EventArgs e)
        {
            if (txt_run.Text.Length > 0 && txt_dv.Text.Length > 0)
            {
                validarRun();
            }
        }
        private void txt_run_Leave(object sender, EventArgs e)
        {
            if(txt_run.Text.Length > 0 && txt_dv.Text.Length > 0)
            {
                validarRun();
            }
        }
        private void ddl_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestionador.setUnidadFuncionario(funcionario, int.Parse(this.ddl_unidad.SelectedValue.ToString()), ddl_unidad.Text);
        }
        private void cld_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre la fecha de nacimiento y ve si es valida
            switch (gestionador.ValidarFechaNacimientoFuncionario(funcionario, cld_nacimiento.Value))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.FechaInvalida:
                    lblErrorFechaNacimiento.Text = "La fecha de nacimiento es invalida: El funcionario debe ser mayor a 18 años.";
                    lblErrorFechaNacimiento.Visible = true;
                    fechaNacimientoValida = false;
                    break;
                default:
                    lblErrorFechaNacimiento.Visible = false;
                    fechaNacimientoValida = true;
                    break;
            }
        }
        private void mtVolver_Click(object sender, EventArgs e)
        {
            padreTemp.Visible = true;
            this.Dispose();
        }
        private void mtAgregar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && correoValido && apellidoPaternoValido && apellidoMaternoValido && fechaNacimientoValida && runValido && cargoValido)
            {
                GestionadorFuncionario.ResultadoGestionFuncionario resultado = gestionador.AgregarFuncionario(funcionario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoPaternoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El apellido paterno esta vacio.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoMaternoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El apellido materno esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.CorreoVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El correo esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.DireccionVacia:
                        MessageBox.Show("No se pudo ingresar el funcionario: La direccion esta vacia.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.NombreVacio:
                        MessageBox.Show("No se pudo ingresar el funcionario: El nombre esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al ingresar.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Valido:
                        padreTemp.loadFuncionarios();
                        MessageBox.Show("El funcionario se ingreso correctamente.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el funcionario: Existen datos inválidos.");
            }
        }
        private void txt_correo_Leave(object sender, EventArgs e)
        {
            switch (gestionador.ValidarFormatoCorreo(funcionario, txt_correo.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CorreoInvalido:
                    lblErrorCorreo.Text = "El formato del correo no es válidos";
                    lblErrorCorreo.Visible = true;
                    correoValido = false;
                    break;
                default:
                    lblErrorCorreo.Visible = false;
                    correoValido = true;
                    break;
            }
        }
        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el cargo y ve si es valido
            switch (gestionador.ValidarCaracterCargo(funcionario, txt_cargo.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresCargoInvalido:
                    lblErrorCargo.Text = "El cargo tiene caracteres inválidos";
                    lblErrorCargo.Visible = true;
                    cargoValido = false;
                    break;
                default:
                    lblErrorCargo.Visible = false;
                    cargoValido = true;
                    break;
            }
        }
        private void txt_dv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = gestionador.ControlarCaracterDV(e.KeyChar);
        }
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
            switch (gestionador.ValidarCaracterNombreFuncionario(funcionario, txt_nombre.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresNombreInvalido:
                    lblErrorNombre.Text = "El nombre tiene caracteres inválidos";
                    lblErrorNombre.Visible = true;
                    nombreValido = false;
                    break;
                default:
                    lblErrorNombre.Visible = false;
                    nombreValido = true;
                    break;
            }
        }
        private void txt_ap_pat_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el apellido paterno y ve si es valido
            switch (gestionador.ValidarCaracterApellidoPaternoFuncionario(funcionario, txt_ap_pat.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresApellidoPaternoInvalido:
                    lblErrorApellidoPaterno.Text = "El apellido paterno tiene caracteres inválidos";
                    lblErrorApellidoPaterno.Visible = true;
                    apellidoPaternoValido = false;
                    break;
                default:
                    lblErrorApellidoPaterno.Visible = false;
                    apellidoPaternoValido = true;
                    break;
            }
        }
        private void txt_ap_mat_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el apellido materno y ve si es valido
            switch (gestionador.ValidarCaracterApellidoMaternoFuncionario(funcionario, txt_ap_mat.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresApellidoMaternoInvalido:
                    lblErrorApellidoMaterno.Text = "El apellido materno tiene caracteres inválidos";
                    lblErrorApellidoMaterno.Visible = true;
                    apellidoMaternoValido = false;
                    break;
                default:
                    lblErrorApellidoMaterno.Visible = false;
                    apellidoMaternoValido = true;
                    break;
            }
        }
        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre la direccion y ve si es valida
            switch (gestionador.ValidarCaracterDireccion(funcionario, txt_direccion.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresDireccionInvalido:
                    lblErrorDireccion.Text = "La dirección tiene caracteres inválidos";
                    lblErrorDireccion.Visible = true;
                    direccionValida = false;
                    break;
                default:
                    lblErrorDireccion.Visible = false;
                    direccionValida = true;
                    break;
            }
        }
        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el correo y ve si es valido
            switch (gestionador.ValidarCaracterCorreo(funcionario, txt_correo.Text))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.CaracteresCorreoInvalido:
                    lblErrorCorreo.Text = "El correo tiene caracteres inválidos";
                    lblErrorCorreo.Visible = true;
                    correoValido = false;
                    break;
                default:
                    lblErrorCorreo.Visible = false;
                    correoValido = true;
                    break;
            }
        }
        #endregion

        private void validarRun()
        {
            int numeroDV = (AuxiliarString.EsNumerico(txt_dv.Text)) ? int.Parse(txt_dv.Text) : 10;

            switch (gestionador.ValidarRun(funcionario, int.Parse(txt_run.Text), numeroDV))
            {
                case GestionadorFuncionario.ResultadoGestionFuncionario.DvInvalido:
                    lblErrorRun.Text = "El digito verificador no es valido";
                    lblErrorRun.Visible = true;
                    runValido = false;
                    break;
                default:
                    lblErrorRun.Visible = false;
                    runValido = true;
                    break;
            }
        }
    }
}
