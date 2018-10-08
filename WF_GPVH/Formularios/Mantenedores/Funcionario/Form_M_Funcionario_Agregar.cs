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
    public partial class Form_M_Funcionario_Agregar : Form
    {
        Form_M_Funcionario padreTemp = null;
        GestionadorFuncionario gestionador;
        LB_GPVH.Modelo.Funcionario funcionario;
        bool nombreValido, apellidoPaternoValido, apellidoMaternoValido, direccionValida, correoValido, runValido, fechaNacimientoValida;


        public Form_M_Funcionario_Agregar(Form_M_Funcionario formPadre)
        {
            InitializeComponent();
            padreTemp = formPadre;
            gestionador = new GestionadorFuncionario();
            funcionario = new LB_GPVH.Modelo.Funcionario();

            this.loadDdlTipos();
            this.loadDdlUnidades();
            nombreValido = true;
            apellidoPaternoValido = true;
            apellidoMaternoValido = true;
            direccionValida = true;
            correoValido = true;
            fechaNacimientoValida = false;
            runValido = false;

        }

        private void loadDdlUnidades()
        {
            this.ddl_unidad.DisplayMember = "Value";
            this.ddl_unidad.ValueMember = "Key";
            this.ddl_unidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(false), null);
            this.ddl_unidad.SelectedIndex = 0;
        }
        private void loadDdlTipos()
        {
            this.ddl_tipo.Items.Add("Administrador");
            this.ddl_tipo.Items.Add("Jefe Unidad Superior");
            this.ddl_tipo.Items.Add("Jefe Unidad Interna");
            this.ddl_tipo.Items.Add("Alcalde");
            this.ddl_tipo.Items.Add("Funcionario");
            this.ddl_tipo.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Dispose();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && correoValido && apellidoPaternoValido && apellidoMaternoValido && fechaNacimientoValida && runValido)
            {
                GestionadorFuncionario.ResultadoGestionFuncionario resultado = gestionador.AgregarFuncionario(funcionario);
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
                        MessageBox.Show("La unidad se ingreso correctamente.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pudo ingresar la unidad: Existen datos inválidos.");
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
                int salida = serviceFuncionarios.addFuncionario(run, dv,nombre, ap_pat, ap_mat, nacimiento,
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

        private void Form_M_Funcionario_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            padreTemp.Close();
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

        private void validarRun()
        {
            switch (gestionador.ValidarRun(funcionario, int.Parse(txt_run.Text), int.Parse(txt_dv.Text)))
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

        private void ddl_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestionador.setUnidadFuncionario(funcionario, int.Parse(this.ddl_unidad.SelectedValue.ToString()), ddl_unidad.Text);
        }

        private void ddl_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestionador.setTipoFuncionario(funcionario, ddl_unidad.Text);
        }

        private void cld_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
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
                    lblErrorApellidoPaterno.Text = "El apellido materno tiene caracteres inválidos";
                    lblErrorApellidoPaterno.Visible = true;
                    apellidoPaternoValido = false;
                    break;
                default:
                    lblErrorApellidoPaterno.Visible = false;
                    apellidoPaternoValido = true;
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
    }
}
