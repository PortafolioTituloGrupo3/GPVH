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

namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    public partial class Form_M_Usuario : MetroFramework.Forms.MetroForm
    {
        private GestionadorUsuario gestionador; //Clase controlador
        private List<LB_GPVH.Modelo.Usuario> usuarios; //Lista completa de usuarios desde la base de datos
        private Form mainForm; //Formulario principal

        public Form_M_Usuario(Form pMainForm)
        {
            InitializeComponent();
            mainForm = pMainForm;
            gestionador = new GestionadorUsuario();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            this.loadUsuarios();

            this.dgv_Usuarios.Columns[2].Visible = false;
        }

        public Form_M_Usuario()
        {
        }

        public void loadUsuarios()
        {
            usuarios = gestionador.ListarUsuarios();
            CargarUsuariosGridView(this.usuarios);
        }
        //Funcion para agregar manualmente una columna a un gridview especificado
        private void addColumn(int tipoColumna, string property, string titulo, bool visible,
                                            string valorPorDefecto, DataGridView dgv)
        {
            DataGridViewColumn column;
            switch (tipoColumna)
            {
                case 0: //Si es 0 sera una columna de TextBox
                    column = new DataGridViewTextBoxColumn();
                    break;
                case 1: //Si es 1 sera una columna de CheckBox
                    column = new DataGridViewCheckBoxColumn();
                    break;
                case 2: //Si es 2 sera una columna de ComboBox
                    column = new DataGridViewComboBoxColumn();
                    break;
                default: //En cualquier otro caso, sera una columna generica
                    column = new DataGridViewColumn();
                    break;
            }
            column.DataPropertyName = property;
            column.Name = titulo;
            column.Visible = visible;
            column.DefaultCellStyle.NullValue = valorPorDefecto;
            dgv.Columns.Add(column);
        }
        public void CargarUsuariosGridView(List<LB_GPVH.Modelo.Usuario> usuarios)
        {
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.AutoSize = true;
            this.dgv_Usuarios.DataSource = usuarios;
        }
        //Funcion que carga las columnas a mostrar del gridview, segun la lista a mostrar
        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "ID", false, "-1", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[1], "Nombre", true, "UNIDAD SIN NOMBRE", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[2], "Clave", true, "SIN CLAVE", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[3], "Tipo", true, "SIN TIPO", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[4], "RUN funcionario", true, "SIN FUNCIONARIO", dgv_Usuarios);
        }

        #region eventos
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Se abre un formulario para ingresar los datos
            Form_M_Usuario_Agregar popUpAgregar = new Form_M_Usuario_Agregar(this);
            popUpAgregar.Show();
            this.Enabled = false;
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //Se obtiene el id del usuario en la fila seleccionada.
                Form_M_Usuario_Modificar popUpEditar = new Form_M_Usuario_Modificar(this, usuarios[dgv_Usuarios.CurrentRow.Index].Id);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (gestionador.EliminarUsuario(usuarios[this.dgv_Usuarios.CurrentRow.Index].Id)) // Se entrega el id del usuario seleccionado al gestionador para que este proceda a eliminar tal cuenta de usuario.
                {
                    case GestionadorUsuario.ResultadoGestionUsuario.Valido:
                        MessageBox.Show("Funcionario eliminado con exito!");
                        loadUsuarios();
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado durante la eliminacion.");
                        break;
                }
            }
        }
        private void mtAgregar_Click(object sender, EventArgs e)
        {
            //Se abre un formulario para ingresar los datos
            Form_M_Usuario_Agregar popUpAgregar = new Form_M_Usuario_Agregar(this);
            popUpAgregar.Show();
            this.Enabled = false;
        }
        private void mtEditar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //Se obtiene el id de la unidad en la fila seleccionada.
                Form_M_Usuario_Modificar popUpEditar = new Form_M_Usuario_Modificar(this, usuarios[dgv_Usuarios.CurrentRow.Index].Id);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }
        private void mtEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (gestionador.EliminarUsuario(usuarios[this.dgv_Usuarios.CurrentRow.Index].Id)) // Se entrega el id del usuario seleccionado al gestionador para que este proceda a eliminar tal cuenta de usuario.
                {
                    case GestionadorUsuario.ResultadoGestionUsuario.Valido:
                        MessageBox.Show("Funcionario eliminado con exito!");
                        loadUsuarios();
                        break;
                    case GestionadorUsuario.ResultadoGestionUsuario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado durante la eliminacion.");
                        break;
                }
            }
        }
        #endregion
    }
}
