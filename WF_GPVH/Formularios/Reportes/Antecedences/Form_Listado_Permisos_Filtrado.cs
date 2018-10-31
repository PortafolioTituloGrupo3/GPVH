using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    public partial class Form_Listado_Permisos_Filtrado : MetroFramework.Forms.MetroForm
    {
        Form form_temp = null;
        public Form_Listado_Permisos_Filtrado(int run, int filtro, Form form)
        {
            InitializeComponent();
            this.loadUnidades(run, filtro);
            form_temp = form;
        }

        public void loadUnidades(int run, int filtro)
        {
            this.dgv_Permisos.DataSource = null;
            //Diccionario que contendra el <codigoProducto, nombreProducto>
            using (ServiceWSPermisos.WSPermisosClient servicePermisos = new ServiceWSPermisos.WSPermisosClient())
            {
                var listadoPermisos = servicePermisos.getPermisosByFuncionario(run, filtro);
                //Inicialisar DGV
                this.dgv_Permisos.AutoGenerateColumns = false;
                this.dgv_Permisos.AutoSize = true;
                this.dgv_Permisos.DataSource = listadoPermisos;
                if (dgv_Permisos.ColumnCount<=0) {
                    //Se agreagan las columnas de forma personalisada
                    this.addColumn(0, "Id_permiso", "ID", false, "-1", dgv_Permisos);
                    this.addColumn(0, "Tipo_permiso", "Tipo permiso", true, "SIN IDENTIFICAR", dgv_Permisos);
                    this.addColumn(0, "Fecha_inicio", "Fecha inicio", true, "-1", dgv_Permisos);
                    this.addColumn(0, "Fecha_termino", "Fecha termino", true, "-1", dgv_Permisos);
                    this.addColumn(0, "Fecha_solicitud", "Fecha solicitud", true, "-1", dgv_Permisos);
                    this.addColumn(0, "Desc_permiso", "Descripcion", true, "SIN DESRIPCION", dgv_Permisos);
                    this.addColumn(0, "Solicitante_run_sin_dv", "Solicitante", true, "-1", dgv_Permisos);
                    this.addColumn(0, "Autorizante_run_sin_dv", "Autorizante", true, "-1", dgv_Permisos);
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

        private void Form_Listado_Permisos_Filtrado_Load(object sender, EventArgs e)
        {

        }

        private void Form_Listado_Permisos_Filtrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form_temp.Enabled = true;
        }
    }
}
