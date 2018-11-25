namespace WF_GPVH.Formularios.Menu
{
    partial class Form_Menu_Alcalde
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mtIdentificarDocumento = new MetroFramework.Controls.MetroTile();
            this.mtBuscarResoluciones = new MetroFramework.Controls.MetroTile();
            this.mtAntecedentes = new MetroFramework.Controls.MetroTile();
            this.mtGenerarReporte = new MetroFramework.Controls.MetroTile();
            this.mtBuscarPermisos = new MetroFramework.Controls.MetroTile();
            this.mtSalir = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(354, 59);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 6;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(351, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // mtIdentificarDocumento
            // 
            this.mtIdentificarDocumento.ActiveControl = null;
            this.mtIdentificarDocumento.Location = new System.Drawing.Point(61, 233);
            this.mtIdentificarDocumento.Name = "mtIdentificarDocumento";
            this.mtIdentificarDocumento.Size = new System.Drawing.Size(161, 60);
            this.mtIdentificarDocumento.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtIdentificarDocumento.TabIndex = 20;
            this.mtIdentificarDocumento.Text = "Identificar Documento";
            this.mtIdentificarDocumento.UseSelectable = true;
            this.mtIdentificarDocumento.UseStyleColors = true;
            this.mtIdentificarDocumento.Click += new System.EventHandler(this.mtIdentificarDocumento_Click);
            // 
            // mtBuscarResoluciones
            // 
            this.mtBuscarResoluciones.ActiveControl = null;
            this.mtBuscarResoluciones.Location = new System.Drawing.Point(183, 101);
            this.mtBuscarResoluciones.Name = "mtBuscarResoluciones";
            this.mtBuscarResoluciones.Size = new System.Drawing.Size(170, 60);
            this.mtBuscarResoluciones.Style = MetroFramework.MetroColorStyle.Green;
            this.mtBuscarResoluciones.TabIndex = 19;
            this.mtBuscarResoluciones.Text = "Buscar Resoluciones";
            this.mtBuscarResoluciones.UseSelectable = true;
            this.mtBuscarResoluciones.UseStyleColors = true;
            this.mtBuscarResoluciones.Click += new System.EventHandler(this.mtBuscarResoluciones_Click);
            // 
            // mtAntecedentes
            // 
            this.mtAntecedentes.ActiveControl = null;
            this.mtAntecedentes.Location = new System.Drawing.Point(228, 233);
            this.mtAntecedentes.Name = "mtAntecedentes";
            this.mtAntecedentes.Size = new System.Drawing.Size(125, 60);
            this.mtAntecedentes.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAntecedentes.TabIndex = 18;
            this.mtAntecedentes.Text = "Ver Antecedentes";
            this.mtAntecedentes.UseSelectable = true;
            this.mtAntecedentes.UseStyleColors = true;
            this.mtAntecedentes.Click += new System.EventHandler(this.mtAntecedentes_Click);
            // 
            // mtGenerarReporte
            // 
            this.mtGenerarReporte.ActiveControl = null;
            this.mtGenerarReporte.Location = new System.Drawing.Point(61, 167);
            this.mtGenerarReporte.Name = "mtGenerarReporte";
            this.mtGenerarReporte.Size = new System.Drawing.Size(292, 60);
            this.mtGenerarReporte.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtGenerarReporte.TabIndex = 17;
            this.mtGenerarReporte.Text = "Generar reporte de permisos";
            this.mtGenerarReporte.UseSelectable = true;
            this.mtGenerarReporte.UseStyleColors = true;
            this.mtGenerarReporte.Click += new System.EventHandler(this.mtGenerarReporte_Click);
            // 
            // mtBuscarPermisos
            // 
            this.mtBuscarPermisos.ActiveControl = null;
            this.mtBuscarPermisos.Location = new System.Drawing.Point(61, 101);
            this.mtBuscarPermisos.Name = "mtBuscarPermisos";
            this.mtBuscarPermisos.Size = new System.Drawing.Size(116, 60);
            this.mtBuscarPermisos.Style = MetroFramework.MetroColorStyle.Pink;
            this.mtBuscarPermisos.TabIndex = 16;
            this.mtBuscarPermisos.Text = "Buscar Permisos";
            this.mtBuscarPermisos.UseSelectable = true;
            this.mtBuscarPermisos.UseStyleColors = true;
            this.mtBuscarPermisos.Click += new System.EventHandler(this.mtBuscarPermisos_Click);
            // 
            // mtSalir
            // 
            this.mtSalir.ActiveControl = null;
            this.mtSalir.Location = new System.Drawing.Point(518, 380);
            this.mtSalir.Name = "mtSalir";
            this.mtSalir.Size = new System.Drawing.Size(125, 47);
            this.mtSalir.TabIndex = 29;
            this.mtSalir.Text = "Salir";
            this.mtSalir.UseSelectable = true;
            this.mtSalir.Click += new System.EventHandler(this.mtSalir_Click);
            // 
            // Form_Menu_Alcalde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.mtSalir);
            this.Controls.Add(this.mtIdentificarDocumento);
            this.Controls.Add(this.mtBuscarResoluciones);
            this.Controls.Add(this.mtAntecedentes);
            this.Controls.Add(this.mtGenerarReporte);
            this.Controls.Add(this.mtBuscarPermisos);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form_Menu_Alcalde";
            this.Text = "Alcalde";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_Alcalde_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private MetroFramework.Controls.MetroTile mtIdentificarDocumento;
        private MetroFramework.Controls.MetroTile mtBuscarResoluciones;
        private MetroFramework.Controls.MetroTile mtAntecedentes;
        private MetroFramework.Controls.MetroTile mtGenerarReporte;
        private MetroFramework.Controls.MetroTile mtBuscarPermisos;
        private MetroFramework.Controls.MetroTile mtSalir;
    }
}