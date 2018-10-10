namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    partial class Form_Listado_Permisos_Filtrado
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
            this.dgv_Permisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Permisos
            // 
            this.dgv_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Permisos.Location = new System.Drawing.Point(12, 12);
            this.dgv_Permisos.Name = "dgv_Permisos";
            this.dgv_Permisos.Size = new System.Drawing.Size(649, 273);
            this.dgv_Permisos.TabIndex = 1;
            // 
            // Form_Listado_Permisos_Filtrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 297);
            this.Controls.Add(this.dgv_Permisos);
            this.Name = "Form_Listado_Permisos_Filtrado";
            this.Text = "Form_M_Unidad";
            this.Load += new System.EventHandler(this.Form_Listado_Permisos_Filtrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Permisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Permisos;
    }
}