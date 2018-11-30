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

namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    public partial class Form_M_Funcionario_Modificar : MetroFramework.Forms.MetroForm
    {
        Form_M_Funcionario padreTemp = null;  //Formulario desde el cual se accedio
        GestionadorFuncionario gestionador; //Clase controlador
        LB_GPVH.Modelo.Funcionario funcionario; //Funcionario a modificar
        bool nombreValido, apellidoPaternoValido, apellidoMaternoValido, direccionValida, correoValido, fechaNacimientoValida, cargoValido;
        Form mainForm; //Formulario principal

        
        public Form_M_Funcionario_Modificar(Form pMainForm,Form_M_Funcionario formPadre, int run)
        {
            InitializeComponent();
            mainForm = pMainForm;
            padreTemp = formPadre;
            gestionador = new GestionadorFuncionario();
            funcionario = gestionador.BuscarFuncionario(run);
            this.loadDdlUnidades(funcionario.Unidad.Id);
            nombreValido = true;
            apellidoPaternoValido = true;
            apellidoMaternoValido = true;
            direccionValida = true;
            correoValido = true;
            fechaNacimientoValida = false;
            CargarCamposUnidad();
            
        }

        //Cargar datos de unidades en ComboBox
        private void loadDdlUnidades(int id_unidad)
        {
            this.ddl_unidad.DisplayMember = "Value";
            this.ddl_unidad.ValueMember = "Key";
            this.ddl_unidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(false), null);
            this.ddl_unidad.SelectedIndex = id_unidad;
        }
        //Carga los campos con los datos actuales a modificar
        private void CargarCamposUnidad()
        {
            this.txt_run.Text = funcionario.Run.ToString();
            this.txt_nombre.Text = funcionario.Nombre;
            this.txt_ap_pat.Text = funcionario.ApellidoPaterno;
            this.txt_ap_mat.Text = funcionario.ApellidoMaterno;
            this.cld_nacimiento.Value = funcionario.FechaNacimiento;
            this.txt_correo.Text = funcionario.Correo;
            this.txt_direccion.Text = funcionario.Direccion;
            this.chk_habilitado.Checked = funcionario.Habilitado;
            this.txt_cargo.Text = funcionario.Cargo;
        }

        #region eventos
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && correoValido && apellidoPaternoValido && apellidoMaternoValido && fechaNacimientoValida && cargoValido)
            {
                GestionadorFuncionario.ResultadoGestionFuncionario resultado = gestionador.ModificarFuncionario(funcionario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoPaternoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El apellido paterno esta vacio.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoMaternoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El apellido materno esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.CorreoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El correo esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.DireccionVacia:
                        MessageBox.Show("No se pudo modificar el funcionario: La direccion esta vacia.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.NombreVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El nombre esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Valido:
                        padreTemp.loadFuncionarios();
                        MessageBox.Show("El funcionario se modificó correctamente.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pudo modificar el funcionario: Existen datos inválidos.");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Visible = true;
            this.Dispose();
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
        private void Form_M_Funcionario_Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Close();
        }
        private void mtModificar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && correoValido && apellidoPaternoValido && apellidoMaternoValido && fechaNacimientoValida && cargoValido)
            {
                GestionadorFuncionario.ResultadoGestionFuncionario resultado = gestionador.ModificarFuncionario(funcionario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoPaternoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El apellido paterno esta vacio.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.ApellidoMaternoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El apellido materno esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.CorreoVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El correo esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.DireccionVacia:
                        MessageBox.Show("No se pudo modificar el funcionario: La direccion esta vacia.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.NombreVacio:
                        MessageBox.Show("No se pudo modificar el funcionario: El nombre esta vacio");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Valido:
                        padreTemp.loadFuncionarios();
                        MessageBox.Show("El funcionario se modificó correctamente.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pudo modificar el funcionario: Existen datos inválidos.");
            }
        }
        private void mtVolver_Click(object sender, EventArgs e)
        {
            padreTemp.Visible = true;
            this.Dispose();
        }
        private void txt_correo_Leave(object sender, EventArgs e)
        {
            //Recibe el resultado de la transaccion y muestra un mensaje al usuario
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
        private void ddl_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestionador.setUnidadFuncionario(funcionario, int.Parse(this.ddl_unidad.SelectedValue.ToString()), ddl_unidad.Text);
        }
        #endregion

    }
}
