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

namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    public partial class Form_Listado_Permisos_Filtrado : MetroFramework.Forms.MetroForm
    {
        GestionadorPermiso gestionador = new GestionadorPermiso(); //Clase controlador
        Form form_temp = null; //Formulario de donde se accedio

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
            List<LB_GPVH.Modelo.Permiso> listadoPermisos = gestionador.ListarPermisos(run);
            //Inicialisar DGV
            this.dgv_Permisos.AutoGenerateColumns = false;
            this.dgv_Permisos.AutoSize = true;
            this.dgv_Permisos.DataSource = listadoPermisos;
            if (dgv_Permisos.ColumnCount<=0) {
                //Se agreagan las columnas de forma personalisada
                this.addColumn(0, "id", "ID", false, "-1", dgv_Permisos);
                this.addColumn(0, "TipoPermisoString", "Tipo permiso", true, "SIN IDENTIFICAR", dgv_Permisos);
                this.addColumn(0, "FechaInicio", "Fecha inicio", true, "-1", dgv_Permisos);
                this.addColumn(0, "FechaTermino", "Fecha termino", true, "-1", dgv_Permisos);
                this.addColumn(0, "FechaSolicitud", "Fecha solicitud", true, "-1", dgv_Permisos);
                this.addColumn(0, "Descripcion", "Descripcion", true, "SIN DESRIPCION", dgv_Permisos);
                this.addColumn(0, "NombreSolicitante", "Solicitante", true, "Sin solicitante", dgv_Permisos);
                this.addColumn(0, "NombreAutorizante", "Autorizante", true, "Sin autorizante", dgv_Permisos);
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
        
        private void Form_Listado_Permisos_Filtrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form_temp.Enabled = true;
        }
    }
}
