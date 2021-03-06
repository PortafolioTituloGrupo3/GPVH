﻿namespace WF_GPVH.Formularios.Menu
{
    partial class Form_Menu_Administrador
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.mtGestionarFuncionarios = new MetroFramework.Controls.MetroTile();
            this.mtGestionarUsuarios = new MetroFramework.Controls.MetroTile();
            this.mtGestionarUnidades = new MetroFramework.Controls.MetroTile();
            this.mtSalir = new MetroFramework.Controls.MetroTile();
            this.mtBuscarPermisos = new MetroFramework.Controls.MetroTile();
            this.mtGenerarReporte = new MetroFramework.Controls.MetroTile();
            this.mtAntecedentes = new MetroFramework.Controls.MetroTile();
            this.mtBuscarResoluciones = new MetroFramework.Controls.MetroTile();
            this.mtGenerarArchivoPermiso = new MetroFramework.Controls.MetroTile();
            this.mtIdentificarDocumento = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(468, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(471, 53);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 4;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // mtGestionarFuncionarios
            // 
            this.mtGestionarFuncionarios.ActiveControl = null;
            this.mtGestionarFuncionarios.Location = new System.Drawing.Point(23, 94);
            this.mtGestionarFuncionarios.Name = "mtGestionarFuncionarios";
            this.mtGestionarFuncionarios.Size = new System.Drawing.Size(161, 60);
            this.mtGestionarFuncionarios.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtGestionarFuncionarios.TabIndex = 6;
            this.mtGestionarFuncionarios.Text = "Gestionar Funcionarios";
            this.mtGestionarFuncionarios.UseSelectable = true;
            this.mtGestionarFuncionarios.UseStyleColors = true;
            this.mtGestionarFuncionarios.Click += new System.EventHandler(this.mtGestionarFuncionarios_Click);
            // 
            // mtGestionarUsuarios
            // 
            this.mtGestionarUsuarios.ActiveControl = null;
            this.mtGestionarUsuarios.Location = new System.Drawing.Point(190, 94);
            this.mtGestionarUsuarios.Name = "mtGestionarUsuarios";
            this.mtGestionarUsuarios.Size = new System.Drawing.Size(161, 60);
            this.mtGestionarUsuarios.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtGestionarUsuarios.TabIndex = 7;
            this.mtGestionarUsuarios.Text = "Gestionar Usuarios";
            this.mtGestionarUsuarios.UseSelectable = true;
            this.mtGestionarUsuarios.UseStyleColors = true;
            this.mtGestionarUsuarios.Click += new System.EventHandler(this.mtGestionarUsuarios_Click);
            // 
            // mtGestionarUnidades
            // 
            this.mtGestionarUnidades.ActiveControl = null;
            this.mtGestionarUnidades.Location = new System.Drawing.Point(357, 94);
            this.mtGestionarUnidades.Name = "mtGestionarUnidades";
            this.mtGestionarUnidades.Size = new System.Drawing.Size(179, 60);
            this.mtGestionarUnidades.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtGestionarUnidades.TabIndex = 8;
            this.mtGestionarUnidades.Text = "Gestionar Unidades";
            this.mtGestionarUnidades.UseSelectable = true;
            this.mtGestionarUnidades.UseStyleColors = true;
            this.mtGestionarUnidades.Click += new System.EventHandler(this.mtGestionarUnidades_Click);
            // 
            // mtSalir
            // 
            this.mtSalir.ActiveControl = null;
            this.mtSalir.Location = new System.Drawing.Point(682, 346);
            this.mtSalir.Name = "mtSalir";
            this.mtSalir.Size = new System.Drawing.Size(106, 43);
            this.mtSalir.TabIndex = 9;
            this.mtSalir.Text = "Salir";
            this.mtSalir.UseSelectable = true;
            this.mtSalir.Click += new System.EventHandler(this.mtSalir_Click);
            // 
            // mtBuscarPermisos
            // 
            this.mtBuscarPermisos.ActiveControl = null;
            this.mtBuscarPermisos.Location = new System.Drawing.Point(23, 160);
            this.mtBuscarPermisos.Name = "mtBuscarPermisos";
            this.mtBuscarPermisos.Size = new System.Drawing.Size(135, 60);
            this.mtBuscarPermisos.Style = MetroFramework.MetroColorStyle.Pink;
            this.mtBuscarPermisos.TabIndex = 10;
            this.mtBuscarPermisos.Text = "Buscar Permisos";
            this.mtBuscarPermisos.UseSelectable = true;
            this.mtBuscarPermisos.UseStyleColors = true;
            this.mtBuscarPermisos.Click += new System.EventHandler(this.mtBuscarPermisos_Click);
            // 
            // mtGenerarReporte
            // 
            this.mtGenerarReporte.ActiveControl = null;
            this.mtGenerarReporte.Location = new System.Drawing.Point(164, 160);
            this.mtGenerarReporte.Name = "mtGenerarReporte";
            this.mtGenerarReporte.Size = new System.Drawing.Size(215, 60);
            this.mtGenerarReporte.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtGenerarReporte.TabIndex = 11;
            this.mtGenerarReporte.Text = "Generar reporte de permisos";
            this.mtGenerarReporte.UseSelectable = true;
            this.mtGenerarReporte.UseStyleColors = true;
            this.mtGenerarReporte.Click += new System.EventHandler(this.mtGenerarReporte_Click);
            // 
            // mtAntecedentes
            // 
            this.mtAntecedentes.ActiveControl = null;
            this.mtAntecedentes.Location = new System.Drawing.Point(411, 226);
            this.mtAntecedentes.Name = "mtAntecedentes";
            this.mtAntecedentes.Size = new System.Drawing.Size(125, 60);
            this.mtAntecedentes.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtAntecedentes.TabIndex = 12;
            this.mtAntecedentes.Text = "Ver Antecedentes";
            this.mtAntecedentes.UseSelectable = true;
            this.mtAntecedentes.UseStyleColors = true;
            this.mtAntecedentes.Click += new System.EventHandler(this.mtAntecedentes_Click);
            // 
            // mtBuscarResoluciones
            // 
            this.mtBuscarResoluciones.ActiveControl = null;
            this.mtBuscarResoluciones.Location = new System.Drawing.Point(385, 160);
            this.mtBuscarResoluciones.Name = "mtBuscarResoluciones";
            this.mtBuscarResoluciones.Size = new System.Drawing.Size(151, 60);
            this.mtBuscarResoluciones.Style = MetroFramework.MetroColorStyle.Green;
            this.mtBuscarResoluciones.TabIndex = 13;
            this.mtBuscarResoluciones.Text = "Buscar Resoluciones";
            this.mtBuscarResoluciones.UseSelectable = true;
            this.mtBuscarResoluciones.UseStyleColors = true;
            this.mtBuscarResoluciones.Click += new System.EventHandler(this.mtBuscarResoluciones_Click);
            // 
            // mtGenerarArchivoPermiso
            // 
            this.mtGenerarArchivoPermiso.ActiveControl = null;
            this.mtGenerarArchivoPermiso.Location = new System.Drawing.Point(190, 226);
            this.mtGenerarArchivoPermiso.Name = "mtGenerarArchivoPermiso";
            this.mtGenerarArchivoPermiso.Size = new System.Drawing.Size(215, 60);
            this.mtGenerarArchivoPermiso.Style = MetroFramework.MetroColorStyle.Red;
            this.mtGenerarArchivoPermiso.TabIndex = 14;
            this.mtGenerarArchivoPermiso.Text = "Generar Archivo de Permiso";
            this.mtGenerarArchivoPermiso.UseSelectable = true;
            this.mtGenerarArchivoPermiso.UseStyleColors = true;
            this.mtGenerarArchivoPermiso.Click += new System.EventHandler(this.mtGenerarArchivoPermiso_Click);
            // 
            // mtIdentificarDocumento
            // 
            this.mtIdentificarDocumento.ActiveControl = null;
            this.mtIdentificarDocumento.Location = new System.Drawing.Point(23, 226);
            this.mtIdentificarDocumento.Name = "mtIdentificarDocumento";
            this.mtIdentificarDocumento.Size = new System.Drawing.Size(161, 60);
            this.mtIdentificarDocumento.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtIdentificarDocumento.TabIndex = 15;
            this.mtIdentificarDocumento.Text = "Identificar Documento";
            this.mtIdentificarDocumento.UseSelectable = true;
            this.mtIdentificarDocumento.UseStyleColors = true;
            this.mtIdentificarDocumento.Click += new System.EventHandler(this.mtIdentificarDocumento_Click);
            // 
            // Form_Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtIdentificarDocumento);
            this.Controls.Add(this.mtGenerarArchivoPermiso);
            this.Controls.Add(this.mtBuscarResoluciones);
            this.Controls.Add(this.mtAntecedentes);
            this.Controls.Add(this.mtGenerarReporte);
            this.Controls.Add(this.mtBuscarPermisos);
            this.Controls.Add(this.mtSalir);
            this.Controls.Add(this.mtGestionarUnidades);
            this.Controls.Add(this.mtGestionarUsuarios);
            this.Controls.Add(this.mtGestionarFuncionarios);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form_Menu_Administrador";
            this.Text = "Administracion de Permisos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_Administrador_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFuncionario;
        private MetroFramework.Controls.MetroTile mtGestionarFuncionarios;
        private MetroFramework.Controls.MetroTile mtGestionarUsuarios;
        private MetroFramework.Controls.MetroTile mtGestionarUnidades;
        private MetroFramework.Controls.MetroTile mtSalir;
        private MetroFramework.Controls.MetroTile mtBuscarPermisos;
        private MetroFramework.Controls.MetroTile mtGenerarReporte;
        private MetroFramework.Controls.MetroTile mtAntecedentes;
        private MetroFramework.Controls.MetroTile mtBuscarResoluciones;
        private MetroFramework.Controls.MetroTile mtGenerarArchivoPermiso;
        private MetroFramework.Controls.MetroTile mtIdentificarDocumento;
    }
}