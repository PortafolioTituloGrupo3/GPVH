using LB_GPVH.Controlador;
using LB_GPVH.Enums;
using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LB_GPVH.Controlador.GestionadorResolucion;

namespace WF_GPVH.Formularios.Resoluciones
{
    public partial class Form_BuscarResolucion : MetroFramework.Forms.MetroForm
    {
        List<Resolucion> resoluciones;
        List<Resolucion> resolucionesGridView;
        GestionadorResolucion gestionador;
        Form mainForm;
        Form formAnterior;
        Sesion sesion;


        public Form_BuscarResolucion(Login.Form_Login pMainForm, Form pFormAnterior, Sesion pSesion)
        {
            InitializeComponent();
            mainForm = pMainForm;
            this.formAnterior = pFormAnterior;
            sesion = pSesion;
            txbMes.Text = DateTime.Now.Month.ToString();
            txbAnno.Text = DateTime.Now.Year.ToString();
            gestionador = new GestionadorResolucion();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            loadResoluciones();
            loadDdlUnidades();
        }

        public void loadResoluciones()
        {
            if (sesion.Usuario.Tipo == LB_GPVH.Enums.TipoUsuario.JefeUnidadSuperior)
                resoluciones = gestionador.BuscarResoluciones(int.Parse(txbMes.Text), int.Parse(txbAnno.Text), sesion.Usuario.Funcionario.Unidad.Id);
            else
            {
                resoluciones = gestionador.BuscarResoluciones(int.Parse(txbMes.Text), int.Parse(txbAnno.Text));
                mgResoluciones.Columns[0].Visible = false;
                mgResoluciones.Columns[1].Visible = false;
            }
            CargarPermisosGridView(this.resoluciones);
        }

        private void loadDdlUnidades()
        {
            this.cmbUnidad.DisplayMember = "Value";
            this.cmbUnidad.ValueMember = "Key";
            if (sesion.Usuario.Tipo == LB_GPVH.Enums.TipoUsuario.JefeUnidadSuperior)
                this.cmbUnidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadConHijas(sesion.Usuario.Funcionario.Unidad.Id, true), null);
            else
                this.cmbUnidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(true), null);
            this.cmbUnidad.SelectedIndex = 0;
        }


        public void CargarPermisosGridView(List<Resolucion> resoluciones)
        {
            this.mgResoluciones.AutoGenerateColumns = false;
            this.mgResoluciones.AutoSize = true;
            IEnumerable<Resolucion> resolucionesFiltradas;
            if (cmbUnidad.SelectedIndex > 0)
            {
                resolucionesFiltradas = resoluciones.Where(s => s.Permiso.Solicitante.Unidad.Id == int.Parse(cmbUnidad.SelectedValue.ToString()));
            }
            else
            {
                resolucionesFiltradas = resoluciones;
            }

            if (!rbVerTodos.Checked)
            {
                EstadoResolucion Estado;
                if (rbVerSoloValidados.Checked)
                {
                    Estado = EstadoResolucion.Validado;
                }
                else if (rbVerSoloPendientes.Checked)
                {
                    Estado = EstadoResolucion.Pendiente;
                }
                else
                {
                    Estado = EstadoResolucion.Invalidado;
                }
                resolucionesFiltradas = resolucionesFiltradas.Where(s => s.Estado == Estado);
            }
            resolucionesGridView = resolucionesFiltradas.ToList();
            mgResoluciones.DataSource = resolucionesGridView;
        }


        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "Id", false, "-1", mgResoluciones);
            this.addColumn(0, nombrePropiedades[1], "Fecha Resolucion", true, "FECHA RESOLUCION NO ENCONTRADA", mgResoluciones);
            this.addColumn(0, nombrePropiedades[2], "Estado", true, "ESTADO DESCONOCIDO", mgResoluciones);
            this.addColumn(0, nombrePropiedades[3], "Sistema Asistencia", true, "ASISTENCIA DESCONOCIDA", mgResoluciones);
            this.addColumn(0, nombrePropiedades[4], "Solicitante Permiso", true, "SOLICITANTE DESCONOCIDO", mgResoluciones);
            this.addColumn(0, nombrePropiedades[5], "Autorizante Permiso", true, "AUTORIZANTE DESCONOCIDO", mgResoluciones);
            this.addColumn(0, nombrePropiedades[6], "Resolvente", true, "---", mgResoluciones);
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


        private void btnMesInc_Click(object sender, EventArgs e)
        {
            txbMes.Text = setMes(txbMes.Text, 1);
        }

        private string setMes(string strMes, int inc)
        {
            int mes;
            try
            {
                mes = int.Parse(strMes);
            }
            catch
            {
                return DateTime.Now.Month.ToString();
            }
            mes += inc;
            while(mes > 12)
            {
                mes -= 12;
            }
            while (mes < 1)
            {
                mes += 12;
            }
            return mes.ToString();
        }

        private string setAnno(string strAnno, int inc)
        {
            int anno;
            try
            {
                anno = int.Parse(strAnno);
            }
            catch
            {
                return DateTime.Today.Year.ToString();
            }
            anno += inc;
            return anno.ToString();
        }

        private void btnMesDec_Click(object sender, EventArgs e)
        {
            txbMes.Text = setMes(txbMes.Text, -1);
        }

        private void btnAnnoInc_Click(object sender, EventArgs e)
        {
            txbAnno.Text = setAnno(txbAnno.Text, 1);
        }

        private void btnAnnoDec_Click(object sender, EventArgs e)
        {
            txbAnno.Text = setAnno(txbAnno.Text, -1);
        }

        private void txbMes_TextChanged(object sender, EventArgs e)
        {
            txbMes.Text = setMes(txbMes.Text, 0);
        }

        private void txbAnno_TextChanged(object sender, EventArgs e)
        {
            txbAnno.Text = setAnno(txbAnno.Text, 0);
        }

        private void mtBuscar_Click(object sender, EventArgs e)
        {
            loadResoluciones();
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPermisosGridView(this.resoluciones);
        }

        private void rbVerTodos_CheckedChanged(object sender, EventArgs e)
        {
            CargarPermisosGridView(this.resoluciones);
        }

        private void rbVerSoloValidados_CheckedChanged(object sender, EventArgs e)
        {
            CargarPermisosGridView(this.resoluciones);
        }

        private void rbVerSoloInvalidados_CheckedChanged(object sender, EventArgs e)
        {
            CargarPermisosGridView(this.resoluciones);
        }

        private void rbVerSoloPendientes_CheckedChanged(object sender, EventArgs e)
        {
            CargarPermisosGridView(this.resoluciones);
        }

        private void Form_BuscarResolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }

        private void mgResoluciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ResultadoGestionResolucion resultado = gestionador.ValidarResolucion(resoluciones[e.RowIndex].Id, sesion.Usuario.Funcionario.Run);
                switch(resultado)
                {
                    case ResultadoGestionResolucion.Error:
                        MessageBox.Show("Ocurrio un error inesperado al momento de validar.");
                        break;
                    case ResultadoGestionResolucion.idResolucionNoExiste:
                        MessageBox.Show("No se pudo encontrar la resolucion dentro del sistema.");
                        break;
                    case ResultadoGestionResolucion.ResolventeNoValido:
                        MessageBox.Show("No tiene permiso para validar o invalidar dicha resolucion.");
                        break;
                    case ResultadoGestionResolucion.valido:
                        loadResoluciones();
                        break;
                }
            }
            if (e.ColumnIndex == 1)
            {
                ResultadoGestionResolucion resultado = gestionador.InvalidarResolucion(resoluciones[e.RowIndex].Id, sesion.Usuario.Funcionario.Run);
                switch (resultado)
                {
                    case ResultadoGestionResolucion.Error:
                        MessageBox.Show("Ocurrio un error inesperado al momento de validar.");
                        break;
                    case ResultadoGestionResolucion.idResolucionNoExiste:
                        MessageBox.Show("No se pudo encontrar la resolucion dentro del sistema.");
                        break;
                    case ResultadoGestionResolucion.ResolventeNoValido:
                        MessageBox.Show("No tiene permiso para validar o invalidar dicha resolucion.");
                        break;
                    case ResultadoGestionResolucion.valido:
                        loadResoluciones();
                        break;
                }
            }
        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Visible = true;
            this.Dispose();
        }
    }
}
