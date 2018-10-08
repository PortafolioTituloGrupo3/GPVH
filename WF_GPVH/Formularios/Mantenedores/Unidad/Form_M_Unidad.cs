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
    public partial class Form_M_Unidad : Form
    {
        private GestionadorUnidad gestionador;
        private List<LB_GPVH.Modelo.Unidad> unidades;

        public Form_M_Unidad()
        {
            InitializeComponent();
            gestionador = new GestionadorUnidad();
            this.loadUnidades();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            CargarUnidadGridview(this.unidades);

            /*
            bool prueba = AuxiliarString.ContieneCaracteresInvalidos("asdf");
            if(prueba)
                MessageBox.Show("invalido");
            else
                MessageBox.Show("valido");
            */
        }

        public void loadUnidades()
        {
            unidades = gestionador.ListarUnidades();
            CargarUnidadGridview(this.unidades);

            /*
            this.dgv_Unidades.DataSource = null;
            //Diccionario que contendra el <codigoProducto, nombreProducto>
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                var listadoUnidades = serviceUnidades.getListadoUnidades();
                //Inicialisar DGV
                this.dgv_Unidades.AutoGenerateColumns = false;
                this.dgv_Unidades.AutoSize = true;
                this.dgv_Unidades.DataSource = listadoUnidades;

                if (dgv_Unidades.ColumnCount <= 0) {
                    DataTable espCol = new DataTable();
                    espCol.Columns.Add("tipoColumna", typeof(int));
                    espCol.Columns.Add("property", typeof(int));
                    espCol.Columns.Add("titulo", typeof(int));
                    espCol.Columns.Add("visible", typeof(int));
                    espCol.Columns.Add("valorPorDefecto", typeof(int));   
                }
            }
            */
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
                int id_unidad_actual =  int.Parse(this.dgv_Unidades.CurrentRow.Cells[0].Value.ToString());
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

        public void CargarUnidadGridview(List<LB_GPVH.Modelo.Unidad> unidades)
        {
            this.dgv_Unidades.AutoGenerateColumns = false;
            this.dgv_Unidades.AutoSize = true;
            this.dgv_Unidades.DataSource = unidades;
        }

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
    }
}
