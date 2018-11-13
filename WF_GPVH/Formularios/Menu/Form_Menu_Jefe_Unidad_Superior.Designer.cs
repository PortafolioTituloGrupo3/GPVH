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
            this.mtIdentificarDocumento = new MetroFramework.Controls.MetroTile();
            this.mtBuscarResoluciones = new MetroFramework.Controls.MetroTile();
            this.mtAntecedentes = new MetroFramework.Controls.MetroTile();
            this.mtGenerarReporte = new MetroFramework.Controls.MetroTile();
            this.mtBuscarPermisos = new MetroFramework.Controls.MetroTile();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mtSalir = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtIdentificarDocumento
            // 
            this.mtIdentificarDocumento.ActiveControl = null;
            this.mtIdentificarDocumento.Location = new System.Drawing.Point(23, 217);
            this.mtIdentificarDocumento.Name = "mtIdentificarDocumento";
            this.mtIdentificarDocumento.Size = new System.Drawing.Size(161, 60);
            this.mtIdentificarDocumento.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtIdentificarDocumento.TabIndex = 25;
            this.mtIdentificarDocumento.Text = "Identificar Documento";
            this.mtIdentificarDocumento.UseSelectable = true;
            this.mtIdentificarDocumento.UseStyleColors = true;
            // 
            // mtBuscarResoluciones
            // 
            this.mtBuscarResoluciones.ActiveControl = null;
            this.mtBuscarResoluciones.Location = new System.Drawing.Point(145, 85);
            this.mtBuscarResoluciones.Name = "mtBuscarResoluciones";
            this.mtBuscarResoluciones.Size = new System.Drawing.Size(170, 60);
            this.mtBuscarResoluciones.Style = MetroFramework.MetroColorStyle.Green;
            this.mtBuscarResoluciones.TabIndex = 24;
            this.mtBuscarResoluciones.Text = "Buscar Resoluciones";
            this.mtBuscarResoluciones.UseSelectable = true;
            this.mtBuscarResoluciones.UseStyleColors = true;
            this.mtBuscarResoluciones.Click += new System.EventHandler(this.mtBuscarResoluciones_Click);
            // 
            // mtAntecedentes
            // 
            this.mtAntecedentes.ActiveControl = null;
            this.mtAntecedentes.Location = new System.Drawing.Point(190, 217);
            this.mtAntecedentes.Name = "mtAntecedentes";
            this.mtAntecedentes.Size = new System.Drawing.Size(125, 60);
            this.mtAntecedentes.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAntecedentes.TabIndex = 23;
            this.mtAntecedentes.Text = "Ver Antecedentes";
            this.mtAntecedentes.UseSelectable = true;
            this.mtAntecedentes.UseStyleColors = true;
            this.mtAntecedentes.Click += new System.EventHandler(this.mtAntecedentes_Click);
            // 
            // mtGenerarReporte
            // 
            this.mtGenerarReporte.ActiveControl = null;
            this.mtGenerarReporte.Location = new System.Drawing.Point(23, 151);
            this.mtGenerarReporte.Name = "mtGenerarReporte";
            this.mtGenerarReporte.Size = new System.Drawing.Size(292, 60);
            this.mtGenerarReporte.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtGenerarReporte.TabIndex = 22;
            this.mtGenerarReporte.Text = "Generar reporte de permisos";
            this.mtGenerarReporte.UseSelectable = true;
            this.mtGenerarReporte.UseStyleColors = true;
            this.mtGenerarReporte.Click += new System.EventHandler(this.mtGenerarReporte_Click);
            // 
            // mtBuscarPermisos
            // 
            this.mtBuscarPermisos.ActiveControl = null;
            this.mtBuscarPermisos.Location = new System.Drawing.Point(23, 85);
            this.mtBuscarPermisos.Name = "mtBuscarPermisos";
            this.mtBuscarPermisos.Size = new System.Drawing.Size(116, 60);
            this.mtBuscarPermisos.Style = MetroFramework.MetroColorStyle.Pink;
            this.mtBuscarPermisos.TabIndex = 21;
            this.mtBuscarPermisos.Text = "Buscar Permisos";
            this.mtBuscarPermisos.UseSelectable = true;
            this.mtBuscarPermisos.UseStyleColors = true;
            this.mtBuscarPermisos.Click += new System.EventHandler(this.mtBuscarPermisos_Click);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(431, 65);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 27;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(428, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = "Usuario:";
            // 
            // mtSalir
            // 
            this.mtSalir.ActiveControl = null;
            this.mtSalir.Location = new System.Drawing.Point(652, 380);
            this.mtSalir.Name = "mtSalir";
            this.mtSalir.Size = new System.Drawing.Size(125, 47);
            this.mtSalir.TabIndex = 28;
            this.mtSalir.Text = "Salir";
            this.mtSalir.UseSelectable = true;
            this.mtSalir.Click += new System.EventHandler(this.mtSalir_Click);
            // 
            // Form_Menu_Jefe_Unidad_Superior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtSalir);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mtIdentificarDocumento);
            this.Controls.Add(this.mtBuscarResoluciones);
            this.Controls.Add(this.mtAntecedentes);
            this.Controls.Add(this.mtGenerarReporte);
            this.Controls.Add(this.mtBuscarPermisos);
            this.Name = "Form_Menu_Jefe_Unidad_Superior";
            this.Text = "Jefe de Unidad Superior";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_Jefe_Unidad_Superior_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtIdentificarDocumento;
        private MetroFramework.Controls.MetroTile mtBuscarResoluciones;
        private MetroFramework.Controls.MetroTile mtAntecedentes;
        private MetroFramework.Controls.MetroTile mtGenerarReporte;
        private MetroFramework.Controls.MetroTile mtBuscarPermisos;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private MetroFramework.Controls.MetroTile mtSalir;
    }
}