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

namespace WF_GPVH.Formularios.Reportes
{
    public partial class Form_Ver_Permiso : MetroFramework.Forms.MetroForm
    {
        public Form_Ver_Permiso(Permiso permiso, Form padre)
        {
            InitializeComponent();

            GenerarReporte(permiso);
        }

        private void GenerarReporte(Permiso permiso)
        {
            DataTable dt_ReportePermiso = new DataTable();
            dt_ReportePermiso.Columns.Add("Codigo", typeof(Int32));
            dt_ReportePermiso.Columns.Add("Solicitante", typeof(string));
            dt_ReportePermiso.Columns.Add("Autorizante", typeof(string));
            dt_ReportePermiso.Columns.Add("Estado", typeof(string));
            dt_ReportePermiso.Columns.Add("FechaInicio", typeof(DateTime));
            dt_ReportePermiso.Columns.Add("FechaTermino", typeof(DateTime));
            dt_ReportePermiso.Columns.Add("FechaSolicitud", typeof(DateTime));
            dt_ReportePermiso.Columns.Add("TipoPermiso", typeof(string));
            dt_ReportePermiso.Columns.Add("Descripcion", typeof(string));

            dt_ReportePermiso.Rows.Add(
                permiso.Id,
                (permiso.NombreSolicitante != null) ? permiso.NombreSolicitante : "N/A",
                (permiso.NombreAutorizante != null) ? permiso.NombreAutorizante : "N/A",
                permiso.EstadoPermisoString,
                permiso.FechaInicio,
                permiso.FechaTermino,
                permiso.FechaSolicitud,
                permiso.TipoPermisoString,
                permiso.Descripcion
                );

            CR_Permiso reporte = new CR_Permiso();
            reporte.Database.Tables["Permiso"].SetDataSource(dt_ReportePermiso);
            crv_permiso.ReportSource = null;
            crv_permiso.ReportSource = reporte;
        }
    }
}
