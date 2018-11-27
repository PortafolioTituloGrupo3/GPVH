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
using LB_GPVH.Enums;
using WF_GPVH.Formularios.Reportes;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_BuscarPermiso : MetroFramework.Forms.MetroForm
    {
        Funcionario funcionario;
        IEnumerable<Permiso> permisosGridView;
        GestionadorPermiso gestionador;
        Form formPadre;
        Form mainForm;
        bool changingSize;
        
        public Form_BuscarPermiso(Form pMainForm,Form pFormPadre, Funcionario pFuncionario)
        {
            changingSize = true;
            InitializeComponent();
            GridViewLimits();
            funcionario = pFuncionario;
            mainForm = pMainForm;
            formPadre = pFormPadre;
            gestionador = new GestionadorPermiso();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            loadPermisos();
            changingSize = false;

            if(formPadre.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public void loadPermisos()
        {
            gestionador.AsignarPermisos(funcionario);
            CargarPermisosGridView(this.funcionario.Permisos);
        }

        public void CargarPermisosGridView(List<Permiso> permisos)
        {
            this.mgPermisos.AutoGenerateColumns = false;
            this.mgPermisos.AutoSize = true;
            IEnumerable<Permiso> permisosFiltrados;
            if (chkBuscarEntreFechas.Checked)
            {
                permisosFiltrados = permisos.Where(s => s.FechaInicio >= mdtFechaInicio.Value && s.FechaTermino <= mdtFechaTermino.Value);
            }
            else
            {
                permisosFiltrados = permisos;
            }
            
            if (!rbVerTodos.Checked) 
            {
                EstadoPermiso Estado;
                if(rbVerSoloAutorizados.Checked)
                {
                    Estado = EstadoPermiso.Autorizado;
                }
                else if (rbVerSoloPendientes.Checked)
                {
                    Estado = EstadoPermiso.Pendiente;
                }
                else
                {
                    Estado = EstadoPermiso.Rechazado;
                }
                permisosFiltrados = permisosFiltrados.Where(s => s.Estado == Estado);
            }
            permisosGridView = permisosFiltrados.ToList();
            mgPermisos.DataSource = permisosGridView;
        }

        public void CargarUsuariosGridView(List<Permiso> permisos)
        {
            this.mgPermisos.AutoGenerateColumns = false;
            this.mgPermisos.AutoSize = true;
            this.mgPermisos.DataSource = permisos;
        }

        private void chkBuscarEntreFechas_CheckedChanged(object sender, EventArgs e)
        {
            mpBusquedaEntreFechas.Visible = chkBuscarEntreFechas.Checked;
            this.CargarPermisosGridView(funcionario.Permisos);
        }

        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "ID", false, "-1", mgPermisos);
            this.addColumn(0, nombrePropiedades[1], "Tipo de Permiso", true, "TIPO NO ENCONTRADO", mgPermisos);
            this.addColumn(0, nombrePropiedades[2], "Estado", true, "ESTADO DESCONOCIDO", mgPermisos);
            this.addColumn(0, nombrePropiedades[3], "Fecha Inicio", true, "FECHA INICIO DESCONOCIDA", mgPermisos);
            this.addColumn(0, nombrePropiedades[4], "Fecha Termino", true, "FECHA INICIO DESCONOCIDA", mgPermisos);
            this.addColumn(0, nombrePropiedades[5], "Fecha Solicitud", false, "FECHA INICIO DESCONOCIDA", mgPermisos);
            this.addColumn(0, nombrePropiedades[6], "Descripcion", true, "DESCRIPCION DESCONOCIDA", mgPermisos);
            this.addColumn(0, nombrePropiedades[7], "Solicitante", true, "SOLICITANTE DESCONOCIDO", mgPermisos);
            this.addColumn(0, nombrePropiedades[8], "Autorizante", true, "---", mgPermisos);
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

        private void mdtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            this.CargarPermisosGridView(funcionario.Permisos);
        }

        private void mdtFechaTermino_ValueChanged(object sender, EventArgs e)
        {
            this.CargarPermisosGridView(funcionario.Permisos);
        }

        private void rbVerTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVerTodos.Checked)
                this.CargarPermisosGridView(funcionario.Permisos);
        }

        private void rbVerSoloAutorizados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerSoloAutorizados.Checked)
                this.CargarPermisosGridView(funcionario.Permisos);
        }

        private void rbVerSoloRechazados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerSoloRechazados.Checked)
                this.CargarPermisosGridView(funcionario.Permisos);
        }

        private void rbVerSoloPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerSoloPendientes.Checked)
                this.CargarPermisosGridView(funcionario.Permisos);
        }
        

        private void mgPermisos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                new Form_ListarDocumentos(mainForm ,this, funcionario.Permisos[e.RowIndex].Id).Show();
                this.Visible = false;
            }
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                this.Enabled = false;
                new Form_Ver_Permiso(funcionario.Permisos[e.RowIndex], mainForm, this).Show();
            }
        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            formPadre.Visible = true;
            this.Dispose();
        }

        private void GridViewLimits()
        {
            mgPermisos.MaximumSize = new Size(this.Size.Width-50, this.Size.Height - 300);
            mgPermisos.Size = mgPermisos.MaximumSize;
            mgPermisos.Refresh();
        }

        private void Form_BuscarPermiso_SizeChanged(object sender, EventArgs e)
        {
            if(!changingSize)
            {
                changingSize = true;
                GridViewLimits();
                changingSize = false;
            }
        }
    }
}
