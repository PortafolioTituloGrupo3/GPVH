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

namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    public partial class Form_M_Unidad_Modificar : MetroFramework.Forms.MetroForm
    {
        Form_M_Unidad padreTemp = null;
        Form mainForm;
        LB_GPVH.Modelo.Unidad unidad;
        GestionadorUnidad gestionador;
        bool nombreValido, direccionValida, descripcionValida, inicializando;
        string nombreOriginal;

        public Form_M_Unidad_Modificar(Form pMainForm, Form_M_Unidad formPadre, LB_GPVH.Modelo.Unidad pUnidad)
        {
            inicializando = true;
            InitializeComponent();
            mainForm = pMainForm;
            padreTemp = formPadre;
            gestionador = new GestionadorUnidad();
            nombreOriginal = pUnidad.Nombre;
            nombreValido = true;
            direccionValida = true;
            descripcionValida = true;


            this.ddl_padre.DisplayMember = "Value";
            this.ddl_padre.ValueMember = "Key";
            this.ddl_padre.DataSource = new BindingSource(gestionador.DiccionarioUnidadNoHijaClaveValor(pUnidad.Id).OrderBy(p => p.Value), null);

            this.ddl_jefe.DisplayMember = "Value";
            this.ddl_jefe.ValueMember = "Key";
            Dictionary<int, string> posiblesJefes = new GestionadorFuncionario().DiccionarioFuncionariosNoJefes();
            if (pUnidad.Jefe != null)
                posiblesJefes.Add(pUnidad.Jefe.Run, pUnidad.Jefe.NombreCompleto);
            this.ddl_jefe.DataSource = new BindingSource(posiblesJefes.OrderBy(p => p.Value), null);
            unidad = pUnidad;
            this.cargarCamposUnidad();
            inicializando = false;
            gestionador.SetPadre(unidad, int.Parse(this.ddl_padre.SelectedValue.ToString()), ddl_padre.Text);

            /*
            ServiceWSUnidades.Unidad unidadTemp;
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                unidadTemp = serviceUnidades.getUnidadById(unidad.Id);
                

                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceUnidades.getListadoUnidadesNoHijasClaveValor(id);
                this.ddl_padre.DisplayMember = "Value";
                this.ddl_padre.ValueMember = "Key";
                this.ddl_padre.DataSource = new BindingSource(salida, null);
                if (unidadTemp.Unidad_id_unidad != null)
                    this.ddl_padre.SelectedValue = unidadTemp.Unidad_id_unidad;
            }
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosNoJefesNoClaveValorModificar(this.unidad.Id);
                this.ddl_jefe.DisplayMember = "Value";
                this.ddl_jefe.ValueMember = "Key";
                this.ddl_jefe.DataSource = new BindingSource(salida, null);
                if (unidadTemp.Funcionario_run_sin_dv != null)
                    this.ddl_padre.SelectedValue = unidadTemp.Funcionario_run_sin_dv;
            }*/
        }
        

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && descripcionValida)
            {
                GestionadorUnidad.ResultadoGestionUnidad resultado = gestionador.ModificarUnidad(unidad);
                switch (resultado)
                {
                    case GestionadorUnidad.ResultadoGestionUnidad.DescripcionVacia:
                        MessageBox.Show("No se pudo modificar la unidad: La descripcion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.DireccionVacia:
                        MessageBox.Show("No se pudo modificar la unidad: La direccion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.NombreVacio:
                        MessageBox.Show("No se pudo modificar la unidad: El nombre esta vacio.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Valido:
                        padreTemp.loadUnidades();
                        MessageBox.Show("La unidad se modifico correctamente.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pudo modificar la unidad: Existen datos inválidos.");
            }

            /*
            string nombre = this.txt_nombre.Text;
            string descripcion = this.txt_descripcion.Text;
            string direccion = this.txt_direccion.Text;
            bool habilitado = this.chk_habilitado.Checked;
            int? padre;
            if (this.ddl_padre.SelectedValue == null)
                padre = null;
            else
                padre = int.Parse(this.ddl_padre.SelectedValue.ToString());
            int? jefe;
            if (this.ddl_jefe.SelectedValue == null)
                jefe = null;
            else
                jefe = int.Parse(this.ddl_jefe.SelectedValue.ToString());
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                int salida = serviceUnidades.modifyUnidad(this.unidad.Id, nombre, descripcion,
                                            direccion, habilitado, padre, jefe);
                if (salida == 0)
                {
                    padreTemp.loadUnidades();
                    MessageBox.Show("Datos modificados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
            */
        }

        private void cargarCamposUnidad()
        {
            this.txt_nombre.Text = unidad.Nombre; //unidadTemp.Nombre_unidad;
            this.txt_descripcion.Text = unidad.Descripcion; //unidadTemp.Descripcion_unidad;
            this.txt_direccion.Text = unidad.Direccion; //unidadTemp.Direccion_unidad;

            if (unidad.Habilitado)
                this.chk_habilitado.Checked = true;
            else
                this.chk_habilitado.Checked = false;
            if (unidad.UnidadPadre != null)
                this.ddl_padre.SelectedIndex = ddl_padre.FindString(unidad.UnidadPadre.Nombre);
            if (unidad.Jefe != null)
                this.ddl_jefe.SelectedValue = unidad.Jefe.Run;
        }

        private void ddl_jefe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicializando)
            {
                if (this.ddl_jefe.SelectedIndex > 0)
                    gestionador.SetJefe(unidad, int.Parse(this.ddl_jefe.SelectedValue.ToString()), ddl_jefe.Text);
                else
                    gestionador.EliminarJefe(unidad);
            }
        }

        private void ddl_padre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicializando)
            {
                if (this.ddl_padre.SelectedIndex > 0)
                    gestionador.SetPadre(unidad, int.Parse(this.ddl_padre.SelectedValue.ToString()), ddl_padre.Text);
                else
                    gestionador.EliminarPadre(unidad);
            }
        }

        private void chk_habilitado_CheckedChanged(object sender, EventArgs e)
        {
            unidad.Habilitado = this.chk_habilitado.Checked;
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre la direccion y ve si es valido
            switch (gestionador.ValidarDireccion(unidad, txt_direccion.Text))
            {
                case GestionadorUnidad.ResultadoGestionUnidad.CaracteresDireccionInvalido:
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

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre la descripcion y ve si es valido
            switch (gestionador.ValidarDescripcion(unidad, txt_descripcion.Text))
            {
                case GestionadorUnidad.ResultadoGestionUnidad.CaracteresDescripcionInvalido:
                    lblErrorDescripcion.Text = "La descripción tiene caracteres inválidos";
                    lblErrorDescripcion.Visible = true;
                    descripcionValida = false;
                    break;
                default:
                    lblErrorDescripcion.Visible = false;
                    descripcionValida = true;
                    break;
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
            if (unidad.Nombre != nombreOriginal)
            {
                switch (gestionador.ValidarNombreUnidad(unidad, txt_nombre.Text))
                {
                    case GestionadorUnidad.ResultadoGestionUnidad.UnidadExiste:
                        lblErrorNombre.Text = "El nombre de la unidad ya existe";
                        lblErrorNombre.Visible = true;
                        nombreValido = false;
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.CaracteresNombreInvalido:
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
        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            padreTemp.loadUnidades();
            padreTemp.Visible = true;
            this.Dispose();
        }

        private void mtAgregar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && descripcionValida)
            {
                GestionadorUnidad.ResultadoGestionUnidad resultado = gestionador.ModificarUnidad(unidad);
                switch (resultado)
                {
                    case GestionadorUnidad.ResultadoGestionUnidad.DescripcionVacia:
                        MessageBox.Show("No se pudo modificar la unidad: La descripcion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.DireccionVacia:
                        MessageBox.Show("No se pudo modificar la unidad: La direccion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.NombreVacio:
                        MessageBox.Show("No se pudo modificar la unidad: El nombre esta vacio.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Valido:
                        padreTemp.loadUnidades();
                        MessageBox.Show("La unidad se modifico correctamente.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se pudo modificar la unidad: Existen datos inválidos.");
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
            switch (gestionador.ValidarCaracterNombreUnidad(unidad, txt_nombre.Text))
            {
                case GestionadorUnidad.ResultadoGestionUnidad.CaracteresNombreInvalido:
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

        private void Form_M_Unidad_Modificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Close();
        }
    }
}
