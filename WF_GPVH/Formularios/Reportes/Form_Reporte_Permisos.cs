using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Reportes
{
    public partial class Form_Reporte_Permisos : Form
    {
        public Form_Reporte_Permisos()
        {
            InitializeComponent();
        }

        private void crv_ReportePermisos_Load(object sender, EventArgs e)
        {
            //Inicialmente se mostraran las solicitudes del mes
            this.CargarReporte(DateTime.Today.AddMonths(-1), DateTime.Today);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            DateTime inicio = DateTime.Parse(this.cld_fechaInicio.Text);
            DateTime termino = DateTime.Parse(this.cld_fechaTermino.Text);
            if (inicio > termino)
                MessageBox.Show("Aprende a ingresar las fechas!");
            else
                this.CargarReporte(inicio, termino);
        }

        private void CargarReporte(DateTime inicio, DateTime termino)
        {
            //Datatable
            DataTable dt_ReportePermisos = new DataTable();
            dt_ReportePermisos.Columns.Add("unidad", typeof(string));
            dt_ReportePermisos.Columns.Add("tipo_permiso", typeof(string));
            dt_ReportePermisos.Columns.Add("cantidad", typeof(Int32));

            //Agregar filas desde WS
            using (ServiceWSReportes.WSReportesClient service = new ServiceWSReportes.WSReportesClient())
            {
                var filas = service.ReportePermisos(inicio, termino);
                foreach (ServiceWSReportes.FilaReportePermisos item in filas)
                {
                    dt_ReportePermisos.Rows.Add(item.Unidad, item.Tipo_permiso, item.Cantidad);
                }
            }

            CR_Permisos reporte = new CR_Permisos();
            reporte.Database.Tables["WF_GPVH_ServiceWSReportes_FilaReportePermisos"].SetDataSource(dt_ReportePermisos);

            crv_ReportePermisos.ReportSource = null;
            crv_ReportePermisos.ReportSource = reporte;
        }
    }
}
