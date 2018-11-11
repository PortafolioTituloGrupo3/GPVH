namespace WF_GPVH.Formularios.Menu
{
    partial class Form_Menu_Jefe_Unidad_Superior
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtBuscarPermisos = new MetroFramework.Controls.MetroTile();
            this.mtBuscarResoluciones = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(663, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 47);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtBuscarPermisos
            // 
            this.mtBuscarPermisos.ActiveControl = null;
            this.mtBuscarPermisos.Location = new System.Drawing.Point(48, 103);
            this.mtBuscarPermisos.Name = "mtBuscarPermisos";
            this.mtBuscarPermisos.Size = new System.Drawing.Size(161, 60);
            this.mtBuscarPermisos.TabIndex = 11;
            this.mtBuscarPermisos.Text = "Buscar Permisos";
            this.mtBuscarPermisos.UseSelectable = true;
            this.mtBuscarPermisos.Click += new System.EventHandler(this.mtBuscarPermisos_Click);
            // 
            // mtBuscarResoluciones
            // 
            this.mtBuscarResoluciones.ActiveControl = null;
            this.mtBuscarResoluciones.Location = new System.Drawing.Point(48, 169);
            this.mtBuscarResoluciones.Name = "mtBuscarResoluciones";
            this.mtBuscarResoluciones.Size = new System.Drawing.Size(161, 60);
            this.mtBuscarResoluciones.TabIndex = 14;
            this.mtBuscarResoluciones.Text = "Buscar Resoluciones";
            this.mtBuscarResoluciones.UseSelectable = true;
            this.mtBuscarResoluciones.Click += new System.EventHandler(this.mtBuscarResoluciones_Click);
            // 
            // Form_Menu_Jefe_Unidad_Superior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtBuscarResoluciones);
            this.Controls.Add(this.mtBuscarPermisos);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form_Menu_Jefe_Unidad_Superior";
            this.Text = "Form_Menu_Jefe_Unidad_Superior";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_Jefe_Unidad_Superior_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private MetroFramework.Controls.MetroTile mtBuscarPermisos;
        private MetroFramework.Controls.MetroTile mtBuscarResoluciones;
    }
}