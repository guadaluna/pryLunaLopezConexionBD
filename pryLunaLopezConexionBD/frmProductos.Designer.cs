namespace pryLunaLopezConexionBD
{
    partial class frmProductos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpAgregarProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new ReaLTaiizor.Controls.AloneButton();
            this.cmbCategoria = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtPrecio = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtDescripcion = new ReaLTaiizor.Controls.DungeonTextBox();
            this.dungeonNumeric1 = new ReaLTaiizor.Controls.DungeonNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpBuscar.SuspendLayout();
            this.grpAgregarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(196, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(643, 360);
            this.dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 126);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(17, 176);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 223);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoría";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.cmbProducto);
            this.grpBuscar.Controls.Add(this.btnEliminar);
            this.grpBuscar.Controls.Add(this.btnVerTodos);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(845, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(152, 360);
            this.grpBuscar.TabIndex = 20;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar y eliminar producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(27, 40);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(100, 21);
            this.cmbProducto.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(27, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(27, 125);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(100, 23);
            this.btnVerTodos.TabIndex = 17;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(27, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpAgregarProducto
            // 
            this.grpAgregarProducto.Controls.Add(this.dungeonNumeric1);
            this.grpAgregarProducto.Controls.Add(this.txtPrecio);
            this.grpAgregarProducto.Controls.Add(this.txtNombre);
            this.grpAgregarProducto.Controls.Add(this.txtDescripcion);
            this.grpAgregarProducto.Controls.Add(this.btnAgregar);
            this.grpAgregarProducto.Controls.Add(this.label1);
            this.grpAgregarProducto.Controls.Add(this.cmbCategoria);
            this.grpAgregarProducto.Controls.Add(this.label2);
            this.grpAgregarProducto.Controls.Add(this.lblCategoria);
            this.grpAgregarProducto.Controls.Add(this.lblPrecio);
            this.grpAgregarProducto.Controls.Add(this.lblStock);
            this.grpAgregarProducto.Location = new System.Drawing.Point(10, 12);
            this.grpAgregarProducto.Name = "grpAgregarProducto";
            this.grpAgregarProducto.Size = new System.Drawing.Size(180, 360);
            this.grpAgregarProducto.TabIndex = 21;
            this.grpAgregarProducto.TabStop = false;
            this.grpAgregarProducto.Text = "Agregar producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.EnabledCalc = true;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnAgregar.Location = new System.Drawing.Point(20, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 29);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnAgregar_Click);
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
            this.cmbCategoria.Location = new System.Drawing.Point(20, 243);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(128, 26);
            this.cmbCategoria.StartIndex = 0;
            this.cmbCategoria.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNombre.EdgeColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(20, 39);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(128, 28);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPrecio.EdgeColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(20, 142);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = false;
            this.txtPrecio.Size = new System.Drawing.Size(128, 28);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDescripcion.EdgeColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(20, 91);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.Size = new System.Drawing.Size(128, 28);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // dungeonNumeric1
            // 
            this.dungeonNumeric1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonNumeric1.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonNumeric1.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.dungeonNumeric1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonNumeric1.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dungeonNumeric1.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dungeonNumeric1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dungeonNumeric1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dungeonNumeric1.Location = new System.Drawing.Point(20, 192);
            this.dungeonNumeric1.Maximum = ((long)(100));
            this.dungeonNumeric1.Minimum = ((long)(0));
            this.dungeonNumeric1.MinimumSize = new System.Drawing.Size(62, 28);
            this.dungeonNumeric1.Name = "dungeonNumeric1";
            this.dungeonNumeric1.Size = new System.Drawing.Size(93, 28);
            this.dungeonNumeric1.TabIndex = 25;
            this.dungeonNumeric1.Text = "dungeonNumeric1";
            this.dungeonNumeric1.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.dungeonNumeric1.Value = ((long)(0));
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1011, 381);
            this.Controls.Add(this.grpAgregarProducto);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpAgregarProducto.ResumeLayout(false);
            this.grpAgregarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpAgregarProducto;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCategoria;
        private ReaLTaiizor.Controls.AloneButton btnAgregar;
        private ReaLTaiizor.Controls.DungeonTextBox txtNombre;
        private ReaLTaiizor.Controls.DungeonNumeric dungeonNumeric1;
        private ReaLTaiizor.Controls.DungeonTextBox txtPrecio;
        private ReaLTaiizor.Controls.DungeonTextBox txtDescripcion;
    }
}