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
        private GestionadorUsuario gestionador;
        private List<LB_GPVH.Modelo.Usuario> usuarios;
        private Form mainForm;
        private Form anterior;
        private bool changingSize;

        public Form_M_Usuario(Form pMainForm, Form pAnterior)
        {
            changingSize = true;
            InitializeComponent();
            mainForm = pMainForm;
            anterior = pAnterior;
            GridViewLimits();
            gestionador = new GestionadorUsuario();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            this.loadUsuarios();

            this.dgv_Usuarios.Columns[2].Visible = false;
            changingSize = false;

            if (anterior.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public void loadUsuarios()
        {
            usuarios = gestionador.ListarUsuarios();
            CargarUsuariosGridView(this.usuarios);


            /*
            this.dgv_Usuarios.DataSource = null;
            //Diccionario que contendra el <codigoProducto, nombreProducto>
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                var listadoUsuarios = serviceUsuarios.getListadoUsuarios();
                //Inicialisar DGV
                this.dgv_Usuarios.AutoGenerateColumns = false;
                this.dgv_Usuarios.AutoSize = true;
                this.dgv_Usuarios.DataSource = listadoUsuarios;
                if (dgv_Usuarios.ColumnCount <= 0)
                {
                    //Se agreagan las columnas de forma personalisada
                    this.addColumn(0, "Id_usuario", "ID", false, "-1", dgv_Usuarios);
                    this.addColumn(0, "Nombre_usuario", "Nombre", true, "UNIDAD SIN NOMBRE", dgv_Usuarios);
                    this.addColumn(0, "Clave", "Clave", true, "SIN CLAVE", dgv_Usuarios);
                    this.addColumn(0, "Tipo_usuario", "Tipo", true, "SIN TIPO", dgv_Usuarios);
                    this.addColumn(0, "Funcionario_run_sin_dv", "RUN funcionario", true, "SIN FUNCIONARIO", dgv_Usuarios);
                }
            }
            */
        }

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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Form_M_Usuario_Agregar popUpAgregar = new Form_M_Usuario_Agregar(mainForm,this);
            popUpAgregar.Show();
            this.Visible = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //int id_usuario_actual = int.Parse(this.dgv_Usuarios.CurrentRow.Cells[0].Value.ToString());
                Form_M_Usuario_Modificar popUpEditar = new Form_M_Usuario_Modificar(mainForm,this, usuarios[dgv_Usuarios.CurrentRow.Index].Id);
                popUpEditar.Show();
                this.Visible = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
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


        public void CargarUsuariosGridView(List<LB_GPVH.Modelo.Usuario> usuarios)
        {
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.AutoSize = true;
            this.dgv_Usuarios.DataSource = usuarios;
        }

        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "ID", false, "-1", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[1], "Nombre", true, "UNIDAD SIN NOMBRE", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[2], "Clave", true, "SIN CLAVE", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[3], "Tipo", true, "SIN TIPO", dgv_Usuarios);
            this.addColumn(0, nombrePropiedades[4], "RUN funcionario", true, "SIN FUNCIONARIO", dgv_Usuarios);
        }

        private void mtAgregar_Click(object sender, EventArgs e)
        {
            Form_M_Usuario_Agregar popUpAgregar = new Form_M_Usuario_Agregar(mainForm,this);
            popUpAgregar.Show();
            this.Visible = false;
        }

        private void mtEditar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //int id_usuario_actual = int.Parse(this.dgv_Usuarios.CurrentRow.Cells[0].Value.ToString());
                Form_M_Usuario_Modificar popUpEditar = new Form_M_Usuario_Modificar(mainForm,this, usuarios[dgv_Usuarios.CurrentRow.Index].Id);
                popUpEditar.Show();
                this.Visible = false;
            }
        }

        private void mtEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Usuarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
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

        private void mtVolver_Click(object sender, EventArgs e)
        {
            anterior.Visible = true;
            this.Dispose();
        }

        private void Form_M_Usuario_SizeChanged(object sender, EventArgs e)
        {
            if (!changingSize)
            {
                changingSize = true;
                GridViewLimits();
                changingSize = false;
            }
        }

        private void GridViewLimits()
        {
            dgv_Usuarios.MaximumSize = new Size(this.Size.Width - 50, this.Size.Height - 150);
            dgv_Usuarios.Size = dgv_Usuarios.MaximumSize;
            dgv_Usuarios.Refresh();
        }
    }
}
