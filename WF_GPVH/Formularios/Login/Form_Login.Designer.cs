namespace WF_GPVH.Formularios.Login
{
    partial class Form_Login
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
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblClave = new MetroFramework.Controls.MetroLabel();
            this.lblBienvenida = new MetroFramework.Controls.MetroLabel();
            this.txbNombre = new MetroFramework.Controls.MetroTextBox();
            this.txbClave = new MetroFramework.Controls.MetroTextBox();
            this.mtIniciarSesion = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(47, 199);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(65, 229);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(109, 19);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave de usuario:";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(46, 70);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(176, 19);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Sistema Gestion de Permisos";
            // 
            // txbNombre
            // 
            // 
            // 
            // 
            this.txbNombre.CustomButton.Image = null;
            this.txbNombre.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txbNombre.CustomButton.Name = "";
            this.txbNombre.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombre.CustomButton.TabIndex = 1;
            this.txbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombre.CustomButton.UseSelectable = true;
            this.txbNombre.CustomButton.Visible = false;
            this.txbNombre.Lines = new string[0];
            this.txbNombre.Location = new System.Drawing.Point(219, 198);
            this.txbNombre.MaxLength = 32767;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.ShortcutsEnabled = true;
            this.txbNombre.Size = new System.Drawing.Size(121, 20);
            this.txbNombre.TabIndex = 0;
            this.txbNombre.UseSelectable = true;
            this.txbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbClave
            // 
            // 
            // 
            // 
            this.txbClave.CustomButton.Image = null;
            this.txbClave.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.txbClave.CustomButton.Name = "";
            this.txbClave.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txbClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbClave.CustomButton.TabIndex = 1;
            this.txbClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbClave.CustomButton.UseSelectable = true;
            this.txbClave.CustomButton.Visible = false;
            this.txbClave.Lines = new string[0];
            this.txbClave.Location = new System.Drawing.Point(219, 228);
            this.txbClave.MaxLength = 32767;
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '*';
            this.txbClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbClave.SelectedText = "";
            this.txbClave.SelectionLength = 0;
            this.txbClave.SelectionStart = 0;
            this.txbClave.ShortcutsEnabled = true;
            this.txbClave.Size = new System.Drawing.Size(121, 20);
            this.txbClave.TabIndex = 5;
            this.txbClave.UseSelectable = true;
            this.txbClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClave_KeyPress);
            // 
            // mtIniciarSesion
            // 
            this.mtIniciarSesion.ActiveControl = null;
            this.mtIniciarSesion.Location = new System.Drawing.Point(291, 267);
            this.mtIniciarSesion.Name = "mtIniciarSesion";
            this.mtIniciarSesion.Size = new System.Drawing.Size(133, 62);
            this.mtIniciarSesion.TabIndex = 6;
            this.mtIniciarSesion.Text = "Iniciar Sesión";
            this.mtIniciarSesion.UseSelectable = true;
            this.mtIniciarSesion.Click += new System.EventHandler(this.mtIniciarSesion_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 414);
            this.Controls.Add(this.mtIniciarSesion);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblClave;
        private MetroFramework.Controls.MetroLabel lblBienvenida;
        private MetroFramework.Controls.MetroTextBox txbNombre;
        private MetroFramework.Controls.MetroTextBox txbClave;
        private MetroFramework.Controls.MetroTile mtIniciarSesion;
    }
}