namespace pryLunaLopezConexionBD
{
    partial class ucProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.btnModificar = new ReaLTaiizor.Controls.AloneButton();
            this.btnEliminar = new ReaLTaiizor.Controls.AloneButton();
            this.numStock = new ReaLTaiizor.Controls.DungeonNumeric();
            this.txtPrecio = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtNombre = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtDescripcion = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnAgregar = new ReaLTaiizor.Controls.AloneButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbCategoria = new ReaLTaiizor.Controls.DungeonComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.dgvProductos = new Sunny.UI.UIDataGridView();
            this.txtBuscar = new ReaLTaiizor.Controls.DungeonTextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new ReaLTaiizor.Controls.AloneButton();
            this.btnLimpiar = new ReaLTaiizor.Controls.AloneButton();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.btnLimpiar);
            this.grpProducto.Controls.Add(this.btnModificar);
            this.grpProducto.Controls.Add(this.btnEliminar);
            this.grpProducto.Controls.Add(this.numStock);
            this.grpProducto.Controls.Add(this.txtPrecio);
            this.grpProducto.Controls.Add(this.txtNombre);
            this.grpProducto.Controls.Add(this.txtDescripcion);
            this.grpProducto.Controls.Add(this.btnAgregar);
            this.grpProducto.Controls.Add(this.lblNombre);
            this.grpProducto.Controls.Add(this.cmbCategoria);
            this.grpProducto.Controls.Add(this.lblDescripcion);
            this.grpProducto.Controls.Add(this.lblCategoria);
            this.grpProducto.Controls.Add(this.lblPrecio);
            this.grpProducto.Controls.Add(this.lblStock);
            this.grpProducto.Location = new System.Drawing.Point(46, 82);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(180, 445);
            this.grpProducto.TabIndex = 24;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.EnabledCalc = true;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnModificar.Location = new System.Drawing.Point(20, 367);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 29);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Editar";
            this.btnModificar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.EnabledCalc = true;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnEliminar.Location = new System.Drawing.Point(20, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 29);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnEliminar_Click);
            // 
            // numStock
            // 
            this.numStock.BackColor = System.Drawing.Color.Transparent;
            this.numStock.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.numStock.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.numStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.numStock.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.numStock.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.numStock.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numStock.Location = new System.Drawing.Point(20, 202);
            this.numStock.Maximum = ((long)(100));
            this.numStock.Minimum = ((long)(0));
            this.numStock.MinimumSize = new System.Drawing.Size(62, 28);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(93, 28);
            this.numStock.TabIndex = 25;
            this.numStock.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.numStock.Value = ((long)(0));
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPrecio.EdgeColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(20, 148);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = false;
            this.txtPrecio.Size = new System.Drawing.Size(128, 28);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNombre.EdgeColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(20, 43);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(128, 28);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDescripcion.EdgeColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(20, 95);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.Size = new System.Drawing.Size(128, 28);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
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
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
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
            this.cmbCategoria.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 79);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 240);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 132);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(17, 186);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock";
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(232, 82);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.SelectedIndex = -1;
            this.dgvProductos.Size = new System.Drawing.Size(643, 445);
            this.dgvProductos.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProductos.TabIndex = 25;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEndEdit);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBuscar.EdgeColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(334, 41);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.Size = new System.Drawing.Size(128, 28);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(229, 48);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(99, 13);
            this.lblBusqueda.TabIndex = 26;
            this.lblBusqueda.Text = "Buscar por nombre:";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos.EnabledCalc = true;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnMostrarTodos.Location = new System.Drawing.Point(747, 534);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(128, 29);
            this.btnMostrarTodos.TabIndex = 28;
            this.btnMostrarTodos.Text = "MostrarTodos";
            this.btnMostrarTodos.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnMostrarTodos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.EnabledCalc = true;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnLimpiar.Location = new System.Drawing.Point(20, 402);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 29);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnLimpiar_Click);
            // 
            // ucProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.grpProducto);
            this.Name = "ucProductos";
            this.Size = new System.Drawing.Size(930, 595);
            this.Load += new System.EventHandler(this.ucProductos_Load);
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProducto;
        private ReaLTaiizor.Controls.DungeonNumeric numStock;
        private ReaLTaiizor.Controls.DungeonTextBox txtPrecio;
        private ReaLTaiizor.Controls.DungeonTextBox txtNombre;
        private ReaLTaiizor.Controls.DungeonTextBox txtDescripcion;
        private ReaLTaiizor.Controls.AloneButton btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private ReaLTaiizor.Controls.AloneButton btnModificar;
        private ReaLTaiizor.Controls.AloneButton btnEliminar;
        private Sunny.UI.UIDataGridView dgvProductos;
        private ReaLTaiizor.Controls.DungeonTextBox txtBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private ReaLTaiizor.Controls.AloneButton btnMostrarTodos;
        private ReaLTaiizor.Controls.AloneButton btnLimpiar;
    }
}
