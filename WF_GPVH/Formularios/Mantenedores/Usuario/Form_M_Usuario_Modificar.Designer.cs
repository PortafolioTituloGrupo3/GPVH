﻿namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    partial class Form_M_Usuario_Modificar
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
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.Clave = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.ddl_funcionarios = new MetroFramework.Controls.MetroComboBox();
            this.ddl_tipo = new MetroFramework.Controls.MetroComboBox();
            this.txt_clave = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorClaveConfirmacion = new MetroFramework.Controls.MetroLabel();
            this.lblClaveConfirmacion = new MetroFramework.Controls.MetroLabel();
            this.txt_clave_confirmacion = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorClave = new MetroFramework.Controls.MetroLabel();
            this.lblErrorNombre = new MetroFramework.Controls.MetroLabel();
            this.mtModificar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(26, 93);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(41, 19);
            this.Clave.TabIndex = 22;
            this.Clave.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // ddl_funcionarios
            // 
            this.ddl_funcionarios.FormattingEnabled = true;
            this.ddl_funcionarios.ItemHeight = 23;
            this.ddl_funcionarios.Location = new System.Drawing.Point(144, 185);
            this.ddl_funcionarios.Name = "ddl_funcionarios";
            this.ddl_funcionarios.Size = new System.Drawing.Size(192, 29);
            this.ddl_funcionarios.TabIndex = 19;
            this.ddl_funcionarios.UseSelectable = true;
            this.ddl_funcionarios.SelectedIndexChanged += new System.EventHandler(this.ddl_funcionarios_SelectedIndexChanged);
            // 
            // ddl_tipo
            // 
            this.ddl_tipo.FormattingEnabled = true;
            this.ddl_tipo.ItemHeight = 23;
            this.ddl_tipo.Location = new System.Drawing.Point(144, 150);
            this.ddl_tipo.Name = "ddl_tipo";
            this.ddl_tipo.Size = new System.Drawing.Size(192, 29);
            this.ddl_tipo.TabIndex = 18;
            this.ddl_tipo.UseSelectable = true;
            this.ddl_tipo.SelectedIndexChanged += new System.EventHandler(this.ddl_tipo_SelectedIndexChanged);
            // 
            // txt_clave
            // 
            // 
            // 
            // 
            this.txt_clave.CustomButton.Image = null;
            this.txt_clave.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txt_clave.CustomButton.Name = "";
            this.txt_clave.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_clave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_clave.CustomButton.TabIndex = 1;
            this.txt_clave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_clave.CustomButton.UseSelectable = true;
            this.txt_clave.CustomButton.Visible = false;
            this.txt_clave.Lines = new string[0];
            this.txt_clave.Location = new System.Drawing.Point(144, 93);
            this.txt_clave.MaxLength = 32767;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '●';
            this.txt_clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_clave.SelectedText = "";
            this.txt_clave.SelectionLength = 0;
            this.txt_clave.SelectionStart = 0;
            this.txt_clave.ShortcutsEnabled = true;
            this.txt_clave.Size = new System.Drawing.Size(192, 20);
            this.txt_clave.TabIndex = 16;
            this.txt_clave.UseSelectable = true;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_clave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_clave.TextChanged += new System.EventHandler(this.txt_clave_TextChanged);
            // 
            // txt_nombre
            // 
            // 
            // 
            // 
            this.txt_nombre.CustomButton.Image = null;
            this.txt_nombre.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txt_nombre.CustomButton.Name = "";
            this.txt_nombre.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre.CustomButton.TabIndex = 1;
            this.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.CustomButton.UseSelectable = true;
            this.txt_nombre.CustomButton.Visible = false;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(144, 63);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(192, 20);
            this.txt_nombre.TabIndex = 14;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lblErrorClaveConfirmacion
            // 
            this.lblErrorClaveConfirmacion.AutoSize = true;
            this.lblErrorClaveConfirmacion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClaveConfirmacion.Location = new System.Drawing.Point(342, 122);
            this.lblErrorClaveConfirmacion.Name = "lblErrorClaveConfirmacion";
            this.lblErrorClaveConfirmacion.Size = new System.Drawing.Size(138, 19);
            this.lblErrorClaveConfirmacion.TabIndex = 49;
            this.lblErrorClaveConfirmacion.Text = "Clave mal confirmada";
            this.lblErrorClaveConfirmacion.UseCustomForeColor = true;
            this.lblErrorClaveConfirmacion.Visible = false;
            // 
            // lblClaveConfirmacion
            // 
            this.lblClaveConfirmacion.AutoSize = true;
            this.lblClaveConfirmacion.Location = new System.Drawing.Point(6, 122);
            this.lblClaveConfirmacion.Name = "lblClaveConfirmacion";
            this.lblClaveConfirmacion.Size = new System.Drawing.Size(132, 19);
            this.lblClaveConfirmacion.TabIndex = 48;
            this.lblClaveConfirmacion.Text = "Clave (Confirmacion)";
            // 
            // txt_clave_confirmacion
            // 
            // 
            // 
            // 
            this.txt_clave_confirmacion.CustomButton.Image = null;
            this.txt_clave_confirmacion.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txt_clave_confirmacion.CustomButton.Name = "";
            this.txt_clave_confirmacion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txt_clave_confirmacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_clave_confirmacion.CustomButton.TabIndex = 1;
            this.txt_clave_confirmacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_clave_confirmacion.CustomButton.UseSelectable = true;
            this.txt_clave_confirmacion.CustomButton.Visible = false;
            this.txt_clave_confirmacion.Lines = new string[0];
            this.txt_clave_confirmacion.Location = new System.Drawing.Point(144, 122);
            this.txt_clave_confirmacion.MaxLength = 32767;
            this.txt_clave_confirmacion.Name = "txt_clave_confirmacion";
            this.txt_clave_confirmacion.PasswordChar = '●';
            this.txt_clave_confirmacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_clave_confirmacion.SelectedText = "";
            this.txt_clave_confirmacion.SelectionLength = 0;
            this.txt_clave_confirmacion.SelectionStart = 0;
            this.txt_clave_confirmacion.ShortcutsEnabled = true;
            this.txt_clave_confirmacion.Size = new System.Drawing.Size(192, 20);
            this.txt_clave_confirmacion.TabIndex = 47;
            this.txt_clave_confirmacion.UseSelectable = true;
            this.txt_clave_confirmacion.UseSystemPasswordChar = true;
            this.txt_clave_confirmacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_clave_confirmacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_clave_confirmacion.Leave += new System.EventHandler(this.txt_clave_confirmacion_Leave);
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClave.Location = new System.Drawing.Point(342, 93);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(138, 19);
            this.lblErrorClave.TabIndex = 46;
            this.lblErrorClave.Text = "Clave Usuario Invalido";
            this.lblErrorClave.UseCustomForeColor = true;
            this.lblErrorClave.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(342, 63);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(156, 19);
            this.lblErrorNombre.TabIndex = 45;
            this.lblErrorNombre.Text = "Nombre Usuario Invalido";
            this.lblErrorNombre.UseCustomForeColor = true;
            this.lblErrorNombre.Visible = false;
            // 
            // mtModificar
            // 
            this.mtModificar.ActiveControl = null;
            this.mtModificar.Location = new System.Drawing.Point(26, 253);
            this.mtModificar.Name = "mtModificar";
            this.mtModificar.Size = new System.Drawing.Size(120, 65);
            this.mtModificar.TabIndex = 50;
            this.mtModificar.Text = "Modificar";
            this.mtModificar.UseSelectable = true;
            this.mtModificar.Click += new System.EventHandler(this.mtModificar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(243, 253);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(120, 65);
            this.mtVolver.TabIndex = 51;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_M_Usuario_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 412);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtModificar);
            this.Controls.Add(this.lblErrorClaveConfirmacion);
            this.Controls.Add(this.lblClaveConfirmacion);
            this.Controls.Add(this.txt_clave_confirmacion);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_funcionarios);
            this.Controls.Add(this.ddl_tipo);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form_M_Usuario_Modificar";
            this.Text = "Form_M_Usuario_Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel Clave;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroComboBox ddl_funcionarios;
        private MetroFramework.Controls.MetroComboBox ddl_tipo;
        private MetroFramework.Controls.MetroTextBox txt_clave;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroLabel lblErrorClaveConfirmacion;
        private MetroFramework.Controls.MetroLabel lblClaveConfirmacion;
        private MetroFramework.Controls.MetroTextBox txt_clave_confirmacion;
        private MetroFramework.Controls.MetroLabel lblErrorClave;
        private MetroFramework.Controls.MetroLabel lblErrorNombre;
        private MetroFramework.Controls.MetroTile mtModificar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}