﻿using LB_GPVH.Controlador;
using LB_GPVH.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    public partial class Form_M_Usuario_Modificar : MetroFramework.Forms.MetroForm
    {
        Form_M_Usuario padreTemp = null; //Formulario desde el cual se accedio
        LB_GPVH.Modelo.Usuario usuario; //Usuario a modificar
        GestionadorUsuario gestionador; //Clase controlador
        bool nombreValido, claveValida, claveConfirmacionValida, habilitarEventos;
        
        public Form_M_Usuario_Modificar(Form_M_Usuario formPadre, int id_usuario)
        {
            InitializeComponent();
            padreTemp = formPadre;
            habilitarEventos = false;
            gestionador = new GestionadorUsuario();
            usuario = gestionador.BuscarUsarioPorId(id_usuario);
            this.loadDdlTipos();
            this.loadDdlFuncionarios();
            nombreValido = true;
            claveValida = true;
            claveConfirmacionValida = true;
            this.CargarCamposUsuario();
            habilitarEventos = true;
        }

        private void loadDdlTipos()
        {
            this.ddl_tipo.DataSource = MetodosTipoUsuario.Listar();
        }
        private void loadDdlFuncionarios()
        {
            this.ddl_funcionarios.DisplayMember = "Value";
            this.ddl_funcionarios.ValueMember = "Key";
            this.ddl_funcionarios.DataSource = new BindingSource(new GestionadorFuncionario().DiccionarioFuncionariosClaveValor(false), null);
        }
        //Carga los campos con los datos actuales a modificar 
        private void CargarCamposUsuario()
        {
            this.txt_nombre.Text = usuario.Nombre;
            this.txt_clave.Text = usuario.Clave;
            this.txt_clave_confirmacion.Text = usuario.Clave;
            this.ddl_funcionarios.SelectedValue = usuario.Funcionario.Run;
            this.ddl_tipo.SelectedItem = MetodosTipoUsuario.GetString(usuario.Tipo);
        }

        #region eventos
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (nombreValido && claveValida && claveConfirmacionValida)
            {
                GestionadorUsuario.ResultadoGestionUsuario resultado = gestionador.ModificarUsuario(usuario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorUsuario.ResultadoGestionUsuario.NombreVacio:
                        MessageBox.Show("No se pudo modificar el usuario: El nombre esta vacio.");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.ClaveVacia:
                        MessageBox.Show("No se pudo modificar el usuario: La clave esta vacio");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Valido:
                        padreTemp.loadUsuarios();
                        MessageBox.Show("El usuario se modificó correctamente.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario: Existen datos inválidos.");
            }
            
            /*
            string nombre = this.txt_nombre.Text;
            string clave = this.Clave.Text;
            string tipo = this.ddl_tipo.GetItemText(this.ddl_tipo.SelectedItem);
            int run = int.Parse(this.ddl_funcionarios.SelectedValue.ToString());
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                int salida = serviceUsuarios.modifyUsuario(usuario1.Id_usuario, nombre, clave, tipo, run);
                if (salida == 0)
                {
                    padreTemp.loadUsuarios();
                    MessageBox.Show("Datos modificados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
            */
        }
        private void ddl_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(habilitarEventos)
                gestionador.setTipoUsuario(usuario, ddl_tipo.Text);
        }
        private void ddl_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (habilitarEventos)
                gestionador.setFuncionarioUsuario(usuario, int.Parse(this.ddl_funcionarios.SelectedValue.ToString()), ddl_funcionarios.Text);
        }
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre el nombre y ve si es valido
            switch (gestionador.ValidarCaracterNombre(usuario, txt_nombre.Text))
            {
                case GestionadorUsuario.ResultadoGestionUsuario.CaracteresNombreInvalido:
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
        private void txt_clave_confirmacion_Leave(object sender, EventArgs e)
        {
            //Verifica que la clave de confirmacion sea la misma que la clave de 
            switch (gestionador.ValidarClaveConfirmacion(txt_clave.Text, txt_clave_confirmacion.Text))
            {
                case GestionadorUsuario.ResultadoGestionUsuario.ClaveConfirmacionInvalida:
                    lblErrorClaveConfirmacion.Text = "La clave de confirmacion no corresponde a la clave";
                    lblErrorClaveConfirmacion.Visible = true;
                    claveConfirmacionValida = false;
                    break;
                default:
                    lblErrorClaveConfirmacion.Visible = false;
                    claveConfirmacionValida = true;
                    break;
            }
        }
        private void txt_clave_TextChanged(object sender, EventArgs e)
        {
            //Realiza validaciones sobre la clave y ve si es valida
            switch (gestionador.ValidarCaracterClave(usuario, txt_clave.Text))
            {
                case GestionadorUsuario.ResultadoGestionUsuario.CaracteresClaveInvalido:
                    lblErrorClave.Text = "La clave tiene caracteres inválidos";
                    lblErrorClave.Visible = true;
                    claveValida = false;
                    break;
                default:
                    lblErrorClave.Visible = false;
                    claveValida = true;
                    break;
            }
        }
        private void mtModificar_Click(object sender, EventArgs e)
        {
            if (nombreValido && claveValida && claveConfirmacionValida)
            {
                GestionadorUsuario.ResultadoGestionUsuario resultado = gestionador.ModificarUsuario(usuario);
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (resultado)
                {
                    case GestionadorUsuario.ResultadoGestionUsuario.NombreVacio:
                        MessageBox.Show("No se pudo modificar el usuario: El nombre esta vacio.");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.ClaveVacia:
                        MessageBox.Show("No se pudo modificar el usuario: La clave esta vacio");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado al modificar.");
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Valido:
                        padreTemp.loadUsuarios();
                        MessageBox.Show("El usuario se modificó correctamente.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario: Existen datos inválidos.");
            }
        }
        private void mtVolver_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close(); 
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close(); 
        }
        #endregion
    }
}
