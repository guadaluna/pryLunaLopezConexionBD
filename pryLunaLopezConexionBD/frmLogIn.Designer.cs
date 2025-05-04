namespace pryLunaLopezConexionBD
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panelIniciarSesion = new System.Windows.Forms.Panel();
            this.picVerContraseña = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.imgCandado = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.lblIniciaSesion = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblPregunta = new ReaLTaiizor.Controls.DungeonLabel();
            this.linkLblRegistro = new ReaLTaiizor.Controls.FoxLinkLabel();
            this.lblUsuario = new ReaLTaiizor.Controls.DungeonLabel();
            this.linkLblOlCon = new ReaLTaiizor.Controls.FoxLinkLabel();
            this.btnLogIn = new ReaLTaiizor.Controls.Button();
            this.lblContraseña = new ReaLTaiizor.Controls.DungeonLabel();
            this.panelIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIniciarSesion
            // 
            this.panelIniciarSesion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelIniciarSesion.Controls.Add(this.picVerContraseña);
            this.panelIniciarSesion.Controls.Add(this.txtContraseña);
            this.panelIniciarSesion.Controls.Add(this.txtUsuario);
            this.panelIniciarSesion.Controls.Add(this.imgUsuario);
            this.panelIniciarSesion.Controls.Add(this.imgCandado);
            this.panelIniciarSesion.Controls.Add(this.imgUser);
            this.panelIniciarSesion.Controls.Add(this.lblIniciaSesion);
            this.panelIniciarSesion.Controls.Add(this.lblPregunta);
            this.panelIniciarSesion.Controls.Add(this.linkLblRegistro);
            this.panelIniciarSesion.Controls.Add(this.lblUsuario);
            this.panelIniciarSesion.Controls.Add(this.linkLblOlCon);
            this.panelIniciarSesion.Controls.Add(this.btnLogIn);
            this.panelIniciarSesion.Controls.Add(this.lblContraseña);
            this.panelIniciarSesion.Location = new System.Drawing.Point(50, 50);
            this.panelIniciarSesion.Name = "panelIniciarSesion";
            this.panelIniciarSesion.Size = new System.Drawing.Size(578, 463);
            this.panelIniciarSesion.TabIndex = 3;
            // 
            // picVerContraseña
            // 
            this.picVerContraseña.BackColor = System.Drawing.Color.White;
            this.picVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVerContraseña.Image = global::pryLunaLopezConexionBD.Properties.Resources.icons8_closed_eye_15;
            this.picVerContraseña.Location = new System.Drawing.Point(339, 250);
            this.picVerContraseña.Name = "picVerContraseña";
            this.picVerContraseña.Size = new System.Drawing.Size(24, 16);
            this.picVerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVerContraseña.TabIndex = 18;
            this.picVerContraseña.TabStop = false;
            this.picVerContraseña.Click += new System.EventHandler(this.picVerContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(204, 248);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(161, 20);
            this.txtContraseña.TabIndex = 17;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(204, 191);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgUsuario.Image")));
            this.imgUsuario.Location = new System.Drawing.Point(239, 61);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(90, 81);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 15;
            this.imgUsuario.TabStop = false;
            // 
            // imgCandado
            // 
            this.imgCandado.Image = ((System.Drawing.Image)(resources.GetObject("imgCandado.Image")));
            this.imgCandado.Location = new System.Drawing.Point(178, 248);
            this.imgCandado.Name = "imgCandado";
            this.imgCandado.Size = new System.Drawing.Size(20, 20);
            this.imgCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCandado.TabIndex = 14;
            this.imgCandado.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(178, 191);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(20, 20);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 13;
            this.imgUser.TabStop = false;
            // 
            // lblIniciaSesion
            // 
            this.lblIniciaSesion.AutoSize = true;
            this.lblIniciaSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciaSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciaSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblIniciaSesion.Location = new System.Drawing.Point(238, 37);
            this.lblIniciaSesion.Name = "lblIniciaSesion";
            this.lblIniciaSesion.Size = new System.Drawing.Size(94, 21);
            this.lblIniciaSesion.TabIndex = 12;
            this.lblIniciaSesion.Text = "Inicia sesión";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblPregunta.Location = new System.Drawing.Point(225, 402);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(118, 17);
            this.lblPregunta.TabIndex = 11;
            this.lblPregunta.Text = "¿No tienes cuenta?";
            // 
            // linkLblRegistro
            // 
            this.linkLblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblRegistro.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.linkLblRegistro.EnabledCalc = true;
            this.linkLblRegistro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkLblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.linkLblRegistro.Location = new System.Drawing.Point(252, 422);
            this.linkLblRegistro.Name = "linkLblRegistro";
            this.linkLblRegistro.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(229)))));
            this.linkLblRegistro.Size = new System.Drawing.Size(60, 19);
            this.linkLblRegistro.TabIndex = 10;
            this.linkLblRegistro.Text = "Registrate";
            this.linkLblRegistro.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.foxLinkLabel2_Click_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblUsuario.Location = new System.Drawing.Point(201, 171);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // linkLblOlCon
            // 
            this.linkLblOlCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblOlCon.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.linkLblOlCon.EnabledCalc = true;
            this.linkLblOlCon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOlCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.linkLblOlCon.Location = new System.Drawing.Point(204, 283);
            this.linkLblOlCon.Name = "linkLblOlCon";
            this.linkLblOlCon.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(229)))));
            this.linkLblOlCon.Size = new System.Drawing.Size(111, 17);
            this.linkLblOlCon.TabIndex = 9;
            this.linkLblOlCon.Text = "Olvidé mi contraseña";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogIn.Image = null;
            this.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogIn.Location = new System.Drawing.Point(204, 332);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogIn.Size = new System.Drawing.Size(161, 40);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Iniciar sesión";
            this.btnLogIn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblContraseña.Location = new System.Drawing.Point(201, 228);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(74, 17);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panelIniciarSesion);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicia sesión";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.panelIniciarSesion.ResumeLayout(false);
            this.panelIniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgCandado;
        private System.Windows.Forms.PictureBox imgUser;
        private ReaLTaiizor.Controls.DungeonLabel lblIniciaSesion;
        private ReaLTaiizor.Controls.DungeonLabel lblPregunta;
        private ReaLTaiizor.Controls.FoxLinkLabel linkLblRegistro;
        private ReaLTaiizor.Controls.DungeonLabel lblUsuario;
        private ReaLTaiizor.Controls.FoxLinkLabel linkLblOlCon;
        private ReaLTaiizor.Controls.Button btnLogIn;
        private ReaLTaiizor.Controls.DungeonLabel lblContraseña;
        private System.Windows.Forms.PictureBox picVerContraseña;
    }
}