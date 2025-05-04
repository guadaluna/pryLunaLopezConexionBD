namespace pryLunaLopezConexionBD
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pOpciones = new System.Windows.Forms.Panel();
            this.btnContactos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pUcProductos = new System.Windows.Forms.Panel();
            this.lblInventario = new ReaLTaiizor.Controls.BigLabel();
            this.picInventario = new System.Windows.Forms.PictureBox();
            this.pOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pOpciones
            // 
            this.pOpciones.BackColor = System.Drawing.Color.SteelBlue;
            this.pOpciones.Controls.Add(this.picInventario);
            this.pOpciones.Controls.Add(this.lblInventario);
            this.pOpciones.Controls.Add(this.btnContactos);
            this.pOpciones.Controls.Add(this.btnCerrarSesion);
            this.pOpciones.Controls.Add(this.btnProductos);
            this.pOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOpciones.Location = new System.Drawing.Point(0, 0);
            this.pOpciones.Name = "pOpciones";
            this.pOpciones.Size = new System.Drawing.Size(232, 709);
            this.pOpciones.TabIndex = 0;
            // 
            // btnContactos
            // 
            this.btnContactos.FlatAppearance.BorderSize = 0;
            this.btnContactos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactos.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.ForeColor = System.Drawing.Color.Azure;
            this.btnContactos.Image = ((System.Drawing.Image)(resources.GetObject("btnContactos.Image")));
            this.btnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.Location = new System.Drawing.Point(3, 209);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContactos.Size = new System.Drawing.Size(226, 51);
            this.btnContactos.TabIndex = 3;
            this.btnContactos.Text = "           Contactos";
            this.btnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(21, 656);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 41);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Azure;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(3, 152);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(226, 51);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "           Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pUcProductos
            // 
            this.pUcProductos.Location = new System.Drawing.Point(250, 12);
            this.pUcProductos.Name = "pUcProductos";
            this.pUcProductos.Size = new System.Drawing.Size(906, 685);
            this.pUcProductos.TabIndex = 3;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Transparent;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblInventario.ForeColor = System.Drawing.Color.LightCyan;
            this.lblInventario.Location = new System.Drawing.Point(13, 12);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(205, 46);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "!Bienvenido¡";
            // 
            // picInventario
            // 
            this.picInventario.Image = ((System.Drawing.Image)(resources.GetObject("picInventario.Image")));
            this.picInventario.InitialImage = ((System.Drawing.Image)(resources.GetObject("picInventario.InitialImage")));
            this.picInventario.Location = new System.Drawing.Point(64, 61);
            this.picInventario.Name = "picInventario";
            this.picInventario.Size = new System.Drawing.Size(89, 72);
            this.picInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInventario.TabIndex = 5;
            this.picInventario.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryLunaLopezConexionBD.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 709);
            this.Controls.Add(this.pUcProductos);
            this.Controls.Add(this.pOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Gestor de inventario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pOpciones.ResumeLayout(false);
            this.pOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOpciones;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Panel pUcProductos;
        private ReaLTaiizor.Controls.BigLabel lblInventario;
        private System.Windows.Forms.PictureBox picInventario;
    }
}