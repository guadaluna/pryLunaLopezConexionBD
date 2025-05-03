namespace pryLunaLopezConexionBD
{
    partial class ucContactos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpAgregarContacto = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new ReaLTaiizor.Controls.AloneButton();
            this.cmbCategoria = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtCorreo = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtTelefono = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtApellido = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.grpBuscar.SuspendLayout();
            this.grpAgregarContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnVerProductos);
            this.grpBuscar.Controls.Add(this.cmbId);
            this.grpBuscar.Controls.Add(this.btnEliminar);
            this.grpBuscar.Controls.Add(this.btnVerTodos);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(852, 20);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(152, 360);
            this.grpBuscar.TabIndex = 22;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar y eliminar contacto";
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(26, 169);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(100, 23);
            this.btnVerProductos.TabIndex = 18;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(27, 40);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(100, 21);
            this.cmbId.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(27, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(27, 125);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(100, 23);
            this.btnVerTodos.TabIndex = 17;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(27, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grpAgregarContacto
            // 
            this.grpAgregarContacto.Controls.Add(this.btnAgregar);
            this.grpAgregarContacto.Controls.Add(this.cmbCategoria);
            this.grpAgregarContacto.Controls.Add(this.txtCorreo);
            this.grpAgregarContacto.Controls.Add(this.txtTelefono);
            this.grpAgregarContacto.Controls.Add(this.txtApellido);
            this.grpAgregarContacto.Controls.Add(this.txtNombre);
            this.grpAgregarContacto.Controls.Add(this.lblNombre);
            this.grpAgregarContacto.Controls.Add(this.lblApellido);
            this.grpAgregarContacto.Controls.Add(this.lblTelefono);
            this.grpAgregarContacto.Controls.Add(this.lblCorreo);
            this.grpAgregarContacto.Controls.Add(this.lblCategoria);
            this.grpAgregarContacto.Location = new System.Drawing.Point(19, 20);
            this.grpAgregarContacto.Name = "grpAgregarContacto";
            this.grpAgregarContacto.Size = new System.Drawing.Size(184, 360);
            this.grpAgregarContacto.TabIndex = 21;
            this.grpAgregarContacto.TabStop = false;
            this.grpAgregarContacto.Text = "Agregar contacto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.EnabledCalc = true;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnAgregar.Location = new System.Drawing.Point(20, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 29);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbCategoria.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbCategoria.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbCategoria.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbCategoria.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbCategoria.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbCategoria.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbCategoria.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbCategoria.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbCategoria.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.DropDownHeight = 100;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.ItemHeight = 20;
            this.cmbCategoria.Location = new System.Drawing.Point(20, 256);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(128, 26);
            this.cmbCategoria.StartIndex = 0;
            this.cmbCategoria.TabIndex = 27;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCorreo.EdgeColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(20, 202);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.Size = new System.Drawing.Size(128, 28);
            this.txtCorreo.TabIndex = 26;
            this.txtCorreo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtTelefono.EdgeColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(20, 143);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.Size = new System.Drawing.Size(128, 28);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtApellido.EdgeColor = System.Drawing.Color.White;
            this.txtApellido.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(20, 91);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = false;
            this.txtApellido.Size = new System.Drawing.Size(128, 28);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNombre.EdgeColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(20, 44);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(128, 28);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 127);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(17, 186);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 240);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoría";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(209, 20);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(637, 360);
            this.dgvContactos.TabIndex = 20;
            // 
            // ucContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpAgregarContacto);
            this.Controls.Add(this.dgvContactos);
            this.Name = "ucContactos";
            this.Size = new System.Drawing.Size(1080, 496);
            this.grpBuscar.ResumeLayout(false);
            this.grpAgregarContacto.ResumeLayout(false);
            this.grpAgregarContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpAgregarContacto;
        private ReaLTaiizor.Controls.AloneButton btnAgregar;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCategoria;
        private ReaLTaiizor.Controls.DungeonTextBox txtCorreo;
        private ReaLTaiizor.Controls.DungeonTextBox txtTelefono;
        private ReaLTaiizor.Controls.DungeonTextBox txtApellido;
        private ReaLTaiizor.Controls.DungeonTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dgvContactos;
    }
}
