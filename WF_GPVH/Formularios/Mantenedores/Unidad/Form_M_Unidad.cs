using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    public partial class Form_M_Unidad : Form
    {
        public Form_M_Unidad()
        {
            InitializeComponent();
            this.loadUnidades();
        }

        public void loadUnidades()
        {
            this.dgv_Unidades.DataSource = null;
            //Diccionario que contendra el <codigoProducto, nombreProducto>
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                var listadoUnidades = serviceUnidades.getListadoUnidades();
                //Inicialisar DGV
                this.dgv_Unidades.AutoGenerateColumns = false;
                this.dgv_Unidades.AutoSize = true;
                this.dgv_Unidades.DataSource = listadoUnidades;
                if (dgv_Unidades.ColumnCount<=0) {
                    //Se agreagan las columnas de forma personalisada
                    this.addColumn(0, "Id_unidad", "ID", false, "-1", dgv_Unidades);
                    this.addColumn(0, "Nombre_unidad", "Nombre", true, "UNIDAD SIN NOMBRE", dgv_Unidades);
                    this.addColumn(0, "Descripcion_unidad", "Descripcion", true, "SIN DESRIPCION", dgv_Unidades);
                    this.addColumn(0, "Direccion_unidad", "Direccion", true, "SIN DIRECCION", dgv_Unidades);
                    this.addColumn(1, "Habilitado", "Habilitado", true, "1", dgv_Unidades);
                    this.addColumn(0, "Unidad_id_unidad", "Unidad padre", true, "---", dgv_Unidades);
                    this.addColumn(0, "Funcionario_run_sin_dv", "Jefe unidad", true, "SIN JEFE", dgv_Unidades);
                }
            }
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
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Unidades.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                int id_unidad_actual = int.Parse(this.dgv_Unidades.CurrentRow.Cells[0].Value.ToString());
                Form_M_Unidad_Modificar popUpEditar = new Form_M_Unidad_Modificar(this, id_unidad_actual);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Form_M_Unidad_Agregar popUpAgregar = new Form_M_Unidad_Agregar(this);
            popUpAgregar.Show();
            this.Enabled = false;
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Unidades.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                int id_unidad_actual = int.Parse(this.dgv_Unidades.CurrentRow.Cells[0].Value.ToString());
                using(ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
                {
                    int salida = serviceUnidades.deleteUnidad(id_unidad_actual);
                    if (salida == 0)
                    {
                        MessageBox.Show("Datos eliminados con exito!");
                    }
                    else
                        MessageBox.Show("ERROR NRO: " + salida);
                }
            }
        }
    }
}
