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
using LB_GPVH.Modelo;
using LB_GPVH.Auxiliares;

namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    public partial class Form_M_Unidad : MetroFramework.Forms.MetroForm
    {
        private GestionadorUnidad gestionador; //Clase controlador
        private List<LB_GPVH.Modelo.Unidad> unidades; //Lista completa de unidades desde la base de datos
        private Form mainForm; //Formulario principal
        private Form anterior; //Formulario desde el cual se accedio

        public Form_M_Unidad(Form pMainForm, Form pAnterior)
        {
            InitializeComponent();
            mainForm = pMainForm;
            anterior = pAnterior;

            gestionador = new GestionadorUnidad();
            this.loadUnidades();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            CargarUnidadGridview(this.unidades);
        }

        public void loadUnidades()
        {
            unidades = gestionador.ListarUnidades();
            CargarUnidadGridview(this.unidades);
        }

        //Funcion que agregara columnas con los parametros ingresados
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
        public void CargarUnidadGridview(List<LB_GPVH.Modelo.Unidad> unidades)
        {
            this.dgv_Unidades.AutoGenerateColumns = false;
            this.dgv_Unidades.AutoSize = true;
            this.dgv_Unidades.DataSource = unidades;
        }
        //Funcion que carga las columnas a mostrar del gridview, segun la lista a mostrar
        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "ID", false, "-1", dgv_Unidades);
            this.addColumn(0, nombrePropiedades[1], "Nombre", true, "UNIDAD SIN NOMBRE", dgv_Unidades);
            this.addColumn(0, nombrePropiedades[2], "Descripcion", true, "SIN DESRIPCION", dgv_Unidades);
            this.addColumn(0, nombrePropiedades[3], "Direccion", true, "SIN DIRECCION", dgv_Unidades);
            this.addColumn(1, nombrePropiedades[4], "Habilitado", true, "1", dgv_Unidades);
            this.addColumn(0, nombrePropiedades[5], "Unidad padre", true, "---", dgv_Unidades);
            this.addColumn(0, nombrePropiedades[6], "Jefe unidad", true, "SIN JEFE", dgv_Unidades);
        }

        #region eventos
        private void mtAgregar_Click(object sender, EventArgs e)
        {
            //Se abre un formulario para ingresar los datos
            Form_M_Unidad_Agregar popUpAgregar = new Form_M_Unidad_Agregar(mainForm,this);
            popUpAgregar.Show();
            this.Enabled = false;
        }
        private void mtEditar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Unidades.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                //Se obtiene el id de la unidad en la fila seleccionada.
                int id_unidad_actual = int.Parse(this.dgv_Unidades.CurrentRow.Cells[0].Value.ToString());
                //Se abre un formulario para ingresar los datos
                Form_M_Unidad_Modificar popUpEditar = new Form_M_Unidad_Modificar(this, id_unidad_actual);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }
        private void mtEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Unidades.CurrentRow == null)
                MessageBox.Show("Primero debe seleccionar una fila!");
            else
            {
                //Recibe el resultado de la transaccion y muestra un mensaje al usuario
                switch (gestionador.EliminarUnidad(unidades[this.dgv_Unidades.CurrentRow.Index].Id)) // Se entrega el id de la unidad seleccionada al gestionador para que este proceda a eliminar tal unidad.
                {
                    case GestionadorUnidad.ResultadoGestionUnidad.Valido:
                        MessageBox.Show("Datos eliminados con exito!");
                        loadUnidades();
                        break;
                    case GestionadorUnidad.ResultadoGestionUnidad.Invalido:
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
        #endregion 
    }
}
