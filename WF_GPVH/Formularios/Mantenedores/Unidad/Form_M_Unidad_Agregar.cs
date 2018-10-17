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
    public partial class Form_M_Unidad_Agregar : MetroFramework.Forms.MetroForm
    {
        Form_M_Unidad padreTemp = null;
        GestionadorUnidad gestionador = null;
        LB_GPVH.Modelo.Unidad unidad;
        bool nombreValido, direccionValida, descripcionValida;


        public Form_M_Unidad_Agregar(Form_M_Unidad formPadre)
        {
            InitializeComponent();
            padreTemp = formPadre;
            gestionador = new GestionadorUnidad();
            unidad = new LB_GPVH.Modelo.Unidad();
            nombreValido = true;
            direccionValida = true;
            descripcionValida = true;


            this.ddl_padre.DisplayMember = "Value";
            this.ddl_padre.ValueMember = "Key";
            this.ddl_padre.DataSource = new BindingSource(gestionador.DiccionarioUnidadClaveValor(true), null);

            this.ddl_jefe.DisplayMember = "Value";
            this.ddl_jefe.ValueMember = "Key";
            this.ddl_jefe.DataSource = new BindingSource(new GestionadorFuncionario().DiccionarioFuncionariosNoJefes(), null);

            /*
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceUnidades.getListadoUnidadesClaveValor();
                this.ddl_padre.DisplayMember = "Value";
                this.ddl_padre.ValueMember = "Key";
                this.ddl_padre.DataSource = new BindingSource(salida, null);
            }
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosNoJefesClaveValor();
                this.ddl_jefe.DisplayMember = "Value";
                this.ddl_jefe.ValueMember = "Key";
                this.ddl_jefe.DataSource = new BindingSource(salida, null);
            }
            */
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

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
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

        private void ddl_padre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddl_padre.SelectedIndex != 0)
                gestionador.SetPadre(unidad, int.Parse(this.ddl_padre.SelectedValue.ToString()), ddl_padre.Text);
            else
                gestionador.EliminarPadre(unidad);
        }

        private void mtAgregar_Click(object sender, EventArgs e)
        {
            if (direccionValida && nombreValido && descripcionValida)
            {
                GestionadorUnidad.ResultadoGestionUnidad resultado = gestionador.AgregarUnidad(unidad);
                switch (resultado)
                {
                    case GestionadorUnidad.ResultadoGestionUnidad.DescripcionVacia:
                        MessageBox.Show("No se pudo ingresar la unidad: La descripcion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.DireccionVacia:
                        MessageBox.Show("No se pudo ingresar la unidad: La direccion esta vacia.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.NombreVacio:
                        MessageBox.Show("No se pudo ingresar la unidad: El nombre esta vacio.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al ingresar.");
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Valido:
                        padreTemp.loadUnidades();
                        MessageBox.Show("La unidad se ingreso correctamente.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pudo ingresar la unidad: Existen datos inválidos.");
            }
        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close();
        }

        private void ddl_jefe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddl_jefe.SelectedIndex != 0)
                gestionador.SetJefe(unidad, int.Parse(this.ddl_jefe.SelectedValue.ToString()), ddl_jefe.Text);
            else
                gestionador.EliminarJefe(unidad);
        }

        private void Form_M_Unidad_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            padreTemp.Dispose();
        }
    }
}
