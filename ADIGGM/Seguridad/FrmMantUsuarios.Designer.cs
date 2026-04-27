namespace ADIGGM.Seguridad
{
    partial class FrmMantUsuarios
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantUsuarios));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CambiarPass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdPerfil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRPerfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm1 = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarUsuariotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restablecerContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tR_UsuariosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter();
            this.tR_PerfilesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_PerfilesTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPerfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(465, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(425, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(505, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(365, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 458);
            this.pnlFooter.Size = new System.Drawing.Size(545, 23);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnAgregar.TabIndex = 126;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombreUsuario,
            this.nombreApellido,
            this.password,
            this.email,
            this.bloqueado,
            this.CambiarPass,
            this.IdPerfil,
            this.Division});
            this.dgvUsuarios.ContextMenuStrip = this.cmsOpciones;
            this.dgvUsuarios.DataSource = this.tRUsuariosBindingSource;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 120);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(545, 297);
            this.dgvUsuarios.TabIndex = 127;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseDown);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "IdUsuario";
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nombreUsuario.DataPropertyName = "NombreUsuario";
            this.nombreUsuario.HeaderText = "Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            this.nombreUsuario.Width = 71;
            // 
            // nombreApellido
            // 
            this.nombreApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreApellido.DataPropertyName = "NombreApellido";
            this.nombreApellido.HeaderText = "Nombre";
            this.nombreApellido.Name = "nombreApellido";
            this.nombreApellido.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // bloqueado
            // 
            this.bloqueado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bloqueado.DataPropertyName = "Bloqueado";
            this.bloqueado.HeaderText = "Bloqueado";
            this.bloqueado.Name = "bloqueado";
            this.bloqueado.ReadOnly = true;
            this.bloqueado.Width = 73;
            // 
            // CambiarPass
            // 
            this.CambiarPass.DataPropertyName = "CambiarPass";
            this.CambiarPass.HeaderText = "CambiarPass";
            this.CambiarPass.Name = "CambiarPass";
            this.CambiarPass.ReadOnly = true;
            this.CambiarPass.Visible = false;
            // 
            // IdPerfil
            // 
            this.IdPerfil.DataPropertyName = "IdPerfil";
            this.IdPerfil.DataSource = this.tRPerfilesBindingSource;
            this.IdPerfil.DisplayMember = "NombrePerfil";
            this.IdPerfil.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdPerfil.HeaderText = "Perfil";
            this.IdPerfil.Name = "IdPerfil";
            this.IdPerfil.ReadOnly = true;
            this.IdPerfil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdPerfil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdPerfil.ValueMember = "IdPerfil";
            // 
            // tRPerfilesBindingSource
            // 
            this.tRPerfilesBindingSource.DataMember = "TR_Perfiles";
            this.tRPerfilesBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // dsTransporteAdiggm1
            // 
            this.dsTransporteAdiggm1.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Division
            // 
            this.Division.DataPropertyName = "Division";
            this.Division.HeaderText = "Division";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            this.Division.Visible = false;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuariotoolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.bloquearUsuarioToolStripMenuItem,
            this.desbloquearUsuarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.restablecerContraseñaToolStripMenuItem});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(198, 126);
            // 
            // agregarUsuariotoolStripMenuItem
            // 
            this.agregarUsuariotoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarUsuariotoolStripMenuItem.Image")));
            this.agregarUsuariotoolStripMenuItem.Name = "agregarUsuariotoolStripMenuItem";
            this.agregarUsuariotoolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agregarUsuariotoolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuariotoolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariotoolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarUsuarioToolStripMenuItem.Image")));
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // bloquearUsuarioToolStripMenuItem
            // 
            this.bloquearUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloquearUsuarioToolStripMenuItem.Image")));
            this.bloquearUsuarioToolStripMenuItem.Name = "bloquearUsuarioToolStripMenuItem";
            this.bloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bloquearUsuarioToolStripMenuItem.Text = "Bloquear Usuario";
            this.bloquearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.bloquearUsuarioToolStripMenuItem_Click);
            // 
            // desbloquearUsuarioToolStripMenuItem
            // 
            this.desbloquearUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("desbloquearUsuarioToolStripMenuItem.Image")));
            this.desbloquearUsuarioToolStripMenuItem.Name = "desbloquearUsuarioToolStripMenuItem";
            this.desbloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.desbloquearUsuarioToolStripMenuItem.Text = "Desbloquear Usuario";
            this.desbloquearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.desbloquearUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // restablecerContraseñaToolStripMenuItem
            // 
            this.restablecerContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restablecerContraseñaToolStripMenuItem.Image")));
            this.restablecerContraseñaToolStripMenuItem.Name = "restablecerContraseñaToolStripMenuItem";
            this.restablecerContraseñaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.restablecerContraseñaToolStripMenuItem.Text = "Restablecer Contraseña";
            this.restablecerContraseñaToolStripMenuItem.Click += new System.EventHandler(this.restablecerContraseñaToolStripMenuItem_Click);
            // 
            // tRUsuariosBindingSource
            // 
            this.tRUsuariosBindingSource.DataMember = "TR_Usuarios";
            this.tRUsuariosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnRestablecer);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 41);
            this.panel1.TabIndex = 128;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(183, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 36);
            this.btnEditar.TabIndex = 128;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.Transparent;
            this.btnRestablecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecer.Image")));
            this.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecer.Location = new System.Drawing.Point(363, 2);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(179, 36);
            this.btnRestablecer.TabIndex = 127;
            this.btnRestablecer.Text = "&Restablecer Contraseña";
            this.btnRestablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 85);
            this.panel2.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 131;
            this.label1.Text = "Buscar Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(124, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 21);
            this.txtUser.TabIndex = 129;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(365, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 36);
            this.btnBuscar.TabIndex = 128;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(456, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 36);
            this.btnLimpiar.TabIndex = 127;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tR_UsuariosTableAdapter
            // 
            this.tR_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_PerfilesTableAdapter
            // 
            this.tR_PerfilesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMantUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(545, 481);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMantUsuarios";
            this.Load += new System.EventHandler(this.FrmMantUsuarios_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvUsuarios, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPerfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRUsuariosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter tR_UsuariosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariotoolStripMenuItem;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolStripMenuItem desbloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm1;
        private System.Windows.Forms.BindingSource tRPerfilesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_PerfilesTableAdapter tR_PerfilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloqueado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CambiarPass;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
    }
}
