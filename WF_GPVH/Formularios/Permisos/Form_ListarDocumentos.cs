using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Modelo;
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_ListarDocumentos : MetroFramework.Forms.MetroForm
    {
        private List<Documento> documentos = new List<Documento>(); //Listado de documentos
        private GestionadorDocumento gestionador = new GestionadorDocumento(); //Clase controlador
        int permisoActual=-1; //Id del permiso seleccionado
        public Form_ListarDocumentos(Form pFormPadre, int permiso)
        {
            InitializeComponent();
            permisoActual = permiso;
            this.CargarDocumentosGridView();
        }

        private void CargarDocumentosGridView()
        {
            documentos = gestionador.getDocumentosByPermiso(permisoActual);
            this.mgDocumentos.AutoGenerateColumns = false;
            this.mgDocumentos.AutoSize = true;
            this.mgDocumentos.DataSource = this.documentos;

            if (mgDocumentos.ColumnCount <= 1)
            {
                //Se agreagan las columnas de forma personalisada
                this.addColumn(0, "Id_documento", "ID", true, "-1", mgDocumentos);
                this.addColumn(0, "Nombre_documento", "Nombre documento", true, "1", mgDocumentos);
                this.addColumn(0, "Fecha_creacion", "Fecha", true, "9", mgDocumentos);
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
                case 3: //Si es 2 sera una columna de ComboBox
                    column = new DataGridViewLinkColumn();
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

        private void mgDocumentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                new Form_cargar_PDF(this, documentos[e.RowIndex]).Show();
                this.Visible = false;
            }
        }
    }
}
