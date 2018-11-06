using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcroPDFLib;
using System.IO;
using LB_GPVH.Modelo;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_cargar_PDF : MetroFramework.Forms.MetroForm
    {
        Documento documentoActual;
        Form formPadre;
        public Form_cargar_PDF(Form form, Documento documento)
        {
            InitializeComponent();
            formPadre = form;
            documentoActual = documento;
            cargarPDF(documentoActual);
        }
        
        private void cargarPDF(Documento documento)
        {
            string direccionArchivo = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", documento.Dir, documento.Nombre_documento+documento.Formato_documento));
            pdfViewer.LoadFile(direccionArchivo);
        }


    }
}
