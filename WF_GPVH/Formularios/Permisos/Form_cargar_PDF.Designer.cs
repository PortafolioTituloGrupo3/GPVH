namespace WF_GPVH.Formularios.Permisos
{
    partial class Form_cargar_PDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cargar_PDF));
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(12, 63);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(728, 499);
            this.pdfViewer.TabIndex = 0;
            // 
            // Form_cargar_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 575);
            this.Controls.Add(this.pdfViewer);
            this.Name = "Form_cargar_PDF";
            this.Text = "Form_cargar_PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfViewer;
    }
}