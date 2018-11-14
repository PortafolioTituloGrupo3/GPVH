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
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_cargar_PDF : MetroFramework.Forms.MetroForm
    {
        Documento documentoActual;
        GestionadorDocumento gestionador = new GestionadorDocumento();
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
            documento.Base64aPdf();
            pdfViewer.LoadFile(documento.DirTemp);

        }
    }
}

