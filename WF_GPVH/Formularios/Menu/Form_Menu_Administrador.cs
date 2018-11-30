using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Menu
{
    public partial class Form_Menu_Administrador : MetroFramework.Forms.MetroForm
    {
        Login.Form_Login mainForm; //Formulario principal
        Sesion sesion;
        
        public Form_Menu_Administrador(Login.Form_Login pMainForm, Sesion pSesion)
        {
            mainForm = pMainForm;
            sesion = pSesion;
            InitializeComponent();
            lblUsuario.Text = "Usuario: "+sesion.Usuario.Nombre;
            lblFuncionario.Text = "Funcionario: " + sesion.Usuario.Funcionario.NombreCompleto;
        }

        #region eventos
        private void Form_Menu_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }
        private void mtGestionarFuncionarios_Click(object sender, EventArgs e)
        {
            new Mantenedores.Funcionario.Form_M_Funcionario(mainForm,this).Show();
            this.Hide();
        }
        private void mtGestionarUsuarios_Click(object sender, EventArgs e)
        {
            new Mantenedores.Usuario.Form_M_Usuario(mainForm).Show();
        }
        private void mtGestionarUnidades_Click(object sender, EventArgs e)
        {
            new Mantenedores.Unidad.Form_M_Unidad(mainForm,this).Show();
        }
        private void mtSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Dispose();
        }
        private void mtBuscarPermisos_Click(object sender, EventArgs e)
        {
            new Permisos.Form_SeleccionFuncionarioPermisos(mainForm,this,sesion).Show();
        }
        private void mtGenerarReporte_Click(object sender, EventArgs e)
        {
            new Reportes.Form_Reporte_Permisos().Show();
        }
        private void mtAntecedentes_Click(object sender, EventArgs e)
        {
            new Reportes.Antecedences.Form_Listado_Funcionarios().Show();
        }
        private void mtBuscarResoluciones_Click(object sender, EventArgs e)
        {
            new Resoluciones.Form_BuscarResolucion(mainForm, this, sesion).Show();
            this.Hide();
        }
        private void mtGenerarArchivoPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument doc = new GestionadorPermiso().ObtenerArchivoPermisosAnuales(); //Gernera un documento
                SaveFileDialog save = new SaveFileDialog(); //Se crea un objeto para guardar el archivo
                save.FileName = "Archivo_Permisos_Anual.xml";
                save.Filter = "XML-File | *.xml";
                //Se muestra una ventana para elegir destino. Si se acepta, se guardara el documento
                if (save.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(save.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void mtIdentificarDocumento_Click(object sender, EventArgs e)
        {
            new Permisos.Form_ValidarDocumento(mainForm, this, sesion).Show();
        }
        #endregion
    }
}
