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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.txtContraseña = new ReaLTaiizor.Controls.AloneTextBox();
            this.txtUsuario = new ReaLTaiizor.Controls.AloneTextBox();
            this.lblUsuario = new ReaLTaiizor.Controls.DungeonLabel();
            this.lblContraseña = new ReaLTaiizor.Controls.DungeonLabel();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.btnLogIn = new ReaLTaiizor.Controls.Button();
            this.linkLblOlCon = new ReaLTaiizor.Controls.FoxLinkLabel();
            this.foxLinkLabel2 = new ReaLTaiizor.Controls.FoxLinkLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.hopeGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(87, 39);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.EnabledCalc = true;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtContraseña.Location = new System.Drawing.Point(36, 218);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MultiLine = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.Size = new System.Drawing.Size(161, 29);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "aloneTextBox1";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.EnabledCalc = true;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtUsuario.Location = new System.Drawing.Point(36, 147);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MultiLine = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(161, 29);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "aloneTextBox2";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblUsuario.Location = new System.Drawing.Point(33, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.dungeonLabel1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblContraseña.Location = new System.Drawing.Point(33, 198);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(74, 17);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.dungeonLabel2_Click);
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.dungeonLabel1);
            this.hopeGroupBox1.Controls.Add(this.dungeonLabel3);
            this.hopeGroupBox1.Controls.Add(this.foxLinkLabel2);
            this.hopeGroupBox1.Controls.Add(this.linkLblOlCon);
            this.hopeGroupBox1.Controls.Add(this.uiAvatar1);
            this.hopeGroupBox1.Controls.Add(this.btnLogIn);
            this.hopeGroupBox1.Controls.Add(this.txtUsuario);
            this.hopeGroupBox1.Controls.Add(this.lblContraseña);
            this.hopeGroupBox1.Controls.Add(this.txtContraseña);
            this.hopeGroupBox1.Controls.Add(this.lblUsuario);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(24, 12);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(235, 426);
            this.hopeGroupBox1.TabIndex = 6;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "Por favor ingrese:";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.LavenderBlush;
            this.hopeGroupBox1.Enter += new System.EventHandler(this.hopeGroupBox1_Enter);
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
            this.btnLogIn.Location = new System.Drawing.Point(36, 302);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogIn.Size = new System.Drawing.Size(161, 40);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Iniciar sesión";
            this.btnLogIn.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // linkLblOlCon
            // 
            this.linkLblOlCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblOlCon.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.linkLblOlCon.EnabledCalc = true;
            this.linkLblOlCon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOlCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.linkLblOlCon.Location = new System.Drawing.Point(36, 253);
            this.linkLblOlCon.Name = "linkLblOlCon";
            this.linkLblOlCon.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(229)))));
            this.linkLblOlCon.Size = new System.Drawing.Size(111, 17);
            this.linkLblOlCon.TabIndex = 9;
            this.linkLblOlCon.Text = "Olvidé mi contraseña";
            // 
            // foxLinkLabel2
            // 
            this.foxLinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxLinkLabel2.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.foxLinkLabel2.EnabledCalc = true;
            this.foxLinkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foxLinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.foxLinkLabel2.Location = new System.Drawing.Point(87, 392);
            this.foxLinkLabel2.Name = "foxLinkLabel2";
            this.foxLinkLabel2.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(229)))));
            this.foxLinkLabel2.Size = new System.Drawing.Size(60, 19);
            this.foxLinkLabel2.TabIndex = 10;
            this.foxLinkLabel2.Text = "Registrate";
            this.foxLinkLabel2.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.foxLinkLabel2_Click);
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(60, 372);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(118, 17);
            this.dungeonLabel3.TabIndex = 11;
            this.dungeonLabel3.Text = "¿No tienes cuenta?";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(68, 15);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(94, 21);
            this.dungeonLabel1.TabIndex = 12;
            this.dungeonLabel1.Text = "Inicia sesión";
            this.dungeonLabel1.Click += new System.EventHandler(this.dungeonLabel1_Click_1);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.hopeGroupBox1);
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.hopeGroupBox1.ResumeLayout(false);
            this.hopeGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private ReaLTaiizor.Controls.AloneTextBox txtContraseña;
        private ReaLTaiizor.Controls.AloneTextBox txtUsuario;
        private ReaLTaiizor.Controls.DungeonLabel lblUsuario;
        private ReaLTaiizor.Controls.DungeonLabel lblContraseña;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.FoxLinkLabel linkLblOlCon;
        private ReaLTaiizor.Controls.Button btnLogIn;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.FoxLinkLabel foxLinkLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
    }
}