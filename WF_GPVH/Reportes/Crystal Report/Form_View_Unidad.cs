using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Reportes.Crystal_Report
{
    public partial class Form_View_Unidad : Form
    {
        public Form_View_Unidad()
        {
            InitializeComponent();
        }

        private void Form_View_Unidad_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            //Datatable
            DataTable test = new DataTable();
            test.Columns.Add("id", typeof(Int32));
            test.Columns.Add("nombre", typeof(string));
            test.Columns.Add("descripcion", typeof(string));

            //Test filas
            test.Rows.Add(1, "pechotes", "cosas");

            //Reporte_Unidades reporte = new Reporte_Unidades();
            //reporte.Database.Tables["Unidad"].SetDataSource(test);
            nepecio reporte = new nepecio();
            reporte.Database.Tables["Unidad"].SetDataSource(test);


            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
