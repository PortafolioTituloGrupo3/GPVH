namespace WF_GPVH.Formularios.Menu
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
            this.btnGestionarFuncionario = new System.Windows.Forms.Button();
            this.btnGestionarUsuario = new System.Windows.Forms.Button();
            this.btnGestionarUnidad = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarFuncionario
            // 
            this.btnGestionarFuncionario.Location = new System.Drawing.Point(80, 101);
            this.btnGestionarFuncionario.Name = "btnGestionarFuncionario";
            this.btnGestionarFuncionario.Size = new System.Drawing.Size(131, 57);
            this.btnGestionarFuncionario.TabIndex = 0;
            this.btnGestionarFuncionario.Text = "Gestionar Funcionario";
            this.btnGestionarFuncionario.UseVisualStyleBackColor = true;
            this.btnGestionarFuncionario.Click += new System.EventHandler(this.btnGestionarFuncionario_Click);
            // 
            // btnGestionarUsuario
            // 
            this.btnGestionarUsuario.Location = new System.Drawing.Point(80, 188);
            this.btnGestionarUsuario.Name = "btnGestionarUsuario";
            this.btnGestionarUsuario.Size = new System.Drawing.Size(131, 52);
            this.btnGestionarUsuario.TabIndex = 1;
            this.btnGestionarUsuario.Text = "Gestionar Usuario";
            this.btnGestionarUsuario.UseVisualStyleBackColor = true;
            this.btnGestionarUsuario.Click += new System.EventHandler(this.btnGestionarUsuario_Click);
            // 
            // btnGestionarUnidad
            // 
            this.btnGestionarUnidad.Location = new System.Drawing.Point(80, 265);
            this.btnGestionarUnidad.Name = "btnGestionarUnidad";
            this.btnGestionarUnidad.Size = new System.Drawing.Size(131, 54);
            this.btnGestionarUnidad.TabIndex = 2;
            this.btnGestionarUnidad.Text = "Gestionar Unidad";
            this.btnGestionarUnidad.UseVisualStyleBackColor = true;
            this.btnGestionarUnidad.Click += new System.EventHandler(this.btnGestionarUnidad_Click);
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(680, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form_Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGestionarUnidad);
            this.Controls.Add(this.btnGestionarUsuario);
            this.Controls.Add(this.btnGestionarFuncionario);
            this.Name = "Form_Menu_Administrador";
            this.Text = "Form_Menu_Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_Administrador_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarFuncionario;
        private System.Windows.Forms.Button btnGestionarUsuario;
        private System.Windows.Forms.Button btnGestionarUnidad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Button btnSalir;
    }
}