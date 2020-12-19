namespace LosMariquenios
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.losMarisqueñiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBajaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarBajaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageModificarProducto = new System.Windows.Forms.TabPage();
            this.buttonModificarProductoBuscarProducto = new System.Windows.Forms.Button();
            this.numericUpDownModificarProductoCodigoBarras = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownModificarProductoExistencia = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.numericUpDownModificarProductoPrecioPublico = new System.Windows.Forms.NumericUpDown();
            this.label93 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.checkBoxModificarProductoActivoInactivo = new System.Windows.Forms.CheckBox();
            this.textBoxModificarProductoDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxModificarProductoNombreProducto = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.buttonModificarProductoModificar = new System.Windows.Forms.Button();
            this.label64 = new System.Windows.Forms.Label();
            this.tabPageModificarEmpleado = new System.Windows.Forms.TabPage();
            this.comboBoxModificarEmpleadoTiposDeUsuario = new System.Windows.Forms.ComboBox();
            this.buttonModificarEmpleadoBuscarEmpleado = new System.Windows.Forms.Button();
            this.checkBoxModificarEmpleadoActivoInactivo = new System.Windows.Forms.CheckBox();
            this.textBoxModificarEmpleadoContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxModificarEmpleadoRFC = new System.Windows.Forms.TextBox();
            this.textBoxModificarEmpleadoTelefono = new System.Windows.Forms.TextBox();
            this.textBoxModificarEmpleadoCorreo = new System.Windows.Forms.TextBox();
            this.textBoxModificarEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.buttonModificarEmpleadoModificar = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.tabPageBuscarCliente = new System.Windows.Forms.TabPage();
            this.label88 = new System.Windows.Forms.Label();
            this.textBoxBuscarClienteRFC = new System.Windows.Forms.TextBox();
            this.dataGridViewBuscarClienteClientes = new System.Windows.Forms.DataGridView();
            this.RFCCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscarClienteBuscar = new System.Windows.Forms.Button();
            this.label74 = new System.Windows.Forms.Label();
            this.tabPageBuscarVenta = new System.Windows.Forms.TabPage();
            this.numericUpDownBusquedaVentasFolioVenta = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.buttonBusquedaVentasBuscar = new System.Windows.Forms.Button();
            this.dataGridViewBusquedaVentasVentas = new System.Windows.Forms.DataGridView();
            this.folioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCEmpleadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductosVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label65 = new System.Windows.Forms.Label();
            this.tabPageBuscarBaja = new System.Windows.Forms.TabPage();
            this.numericUpDownBusquedaBajasFolioBaja = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewBusquedaBajasBajas = new System.Windows.Forms.DataGridView();
            this.folioBajaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFCEmpleadoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioBajaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoSaliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label98 = new System.Windows.Forms.Label();
            this.buttonBusquedaBajasBuscar = new System.Windows.Forms.Button();
            this.label99 = new System.Windows.Forms.Label();
            this.tabPageBuscarProducto = new System.Windows.Forms.TabPage();
            this.numericUpDownBusquedaProductosCodigoBarras = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewBusquedaProductosProductos = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label71 = new System.Windows.Forms.Label();
            this.buttonBusquedaProductosBuscar = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.tabPageBuscarEmpleado = new System.Windows.Forms.TabPage();
            this.dataGridViewBusquedaEmpleadosEmpleados = new System.Windows.Forms.DataGridView();
            this.RFCEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeUsuarioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label67 = new System.Windows.Forms.Label();
            this.buttonBusquedaEmpleadosBuscar = new System.Windows.Forms.Button();
            this.textBoxBusquedaEmpleadosRFC = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.tabPageRegistrarCliente = new System.Windows.Forms.TabPage();
            this.radioButtonRegistroClienteModificacion = new System.Windows.Forms.RadioButton();
            this.buttonRegistroClienteBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxRegistroClienteRFC = new System.Windows.Forms.TextBox();
            this.textBoxRegistroClienteCorreo = new System.Windows.Forms.TextBox();
            this.textBoxRegistroClienteDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxRegistroClienteNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.buttonRegistroClienteRegistrarModificar = new System.Windows.Forms.Button();
            this.buttonRegistroClienteRegresar = new System.Windows.Forms.Button();
            this.label78 = new System.Windows.Forms.Label();
            this.tabPageRegistrarVenta = new System.Windows.Forms.TabPage();
            this.labelRegistroVentaFolio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRegistroVentaFecha = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRegistroVentaCodigoBarras = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.labelRegistroVentaCliente = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.labelRegistrarVentaDatoCambio = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.labelRegistrarVentaDatoTotal = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.labelRegistrarVentaDatoIva = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.labelRegistrarVentaDatoSubtotal = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.labelRegistrarVentaDatoCantidadDeArticulos = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.numericUpDownRegistrarVentaRecibido = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrarVentaRegistrarVenta = new System.Windows.Forms.Button();
            this.buttonRegistrarVentaCancelarVenta = new System.Windows.Forms.Button();
            this.buttonRegistrarVentaBuscarCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxRegistrarVentaRFCCliente = new System.Windows.Forms.TextBox();
            this.buttonRegistrarVentaRegistrarCliente = new System.Windows.Forms.Button();
            this.dataGridViewRegistrarVentaProductos = new System.Windows.Forms.DataGridView();
            this.codigoProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonRegistrarVentaRegistrarCodigoBarras = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageRegistrarBajaProducto = new System.Windows.Forms.TabPage();
            this.buttonRegistroBajaCancelar = new System.Windows.Forms.Button();
            this.labelRegistroBajaFolio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRegistroBajaFecha = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.numericUpDownRegistroDeBajaCodigoBarras = new System.Windows.Forms.NumericUpDown();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.textBoxRegistroDeBajaMotivo = new System.Windows.Forms.TextBox();
            this.numericUpDownRegistroDeBajaCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewRegistroDeBajaBajas = new System.Windows.Forms.DataGridView();
            this.codigoBarrasProductoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoBajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoBajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioProductoBajas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label94 = new System.Windows.Forms.Label();
            this.buttonRegistroDeBajaRegistrarProducto = new System.Windows.Forms.Button();
            this.buttonRegistroDeBajaRegistrarBaja = new System.Windows.Forms.Button();
            this.label95 = new System.Windows.Forms.Label();
            this.tabPageRegistrarProducto = new System.Windows.Forms.TabPage();
            this.numericUpDownRegistroDeProductoCodigoBarras = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRegistroDeProductoExistencia = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.numericUpDownRegistroDeProductoPrecioPublico = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxRegistroDeProductoDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxRegistroDeProductoNombreProducto = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonRegistroDeProductoRegistrarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageRegistrarEmpleado = new System.Windows.Forms.TabPage();
            this.comboBoxRegistroDeEmpleadoTipoUsuario = new System.Windows.Forms.ComboBox();
            this.textBoxRegistroDeEmpleadoContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxRegistroDeEmpleadoRFC = new System.Windows.Forms.TextBox();
            this.textBoxRegistroDeEmpleadoTelefono = new System.Windows.Forms.TextBox();
            this.textBoxRegistroDeEmpleadoCorreo = new System.Windows.Forms.TextBox();
            this.textBoxRegistroDeEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegistroDeEmpleadoRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBienvenida = new System.Windows.Forms.TabPage();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label114 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRegistrarVentaFactura = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.tabPageModificarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoPrecioPublico)).BeginInit();
            this.tabPageModificarEmpleado.SuspendLayout();
            this.tabPageBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarClienteClientes)).BeginInit();
            this.tabPageBuscarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaVentasFolioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaVentasVentas)).BeginInit();
            this.tabPageBuscarBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaBajasFolioBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaBajasBajas)).BeginInit();
            this.tabPageBuscarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaProductosCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaProductosProductos)).BeginInit();
            this.tabPageBuscarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaEmpleadosEmpleados)).BeginInit();
            this.tabPageRegistrarCliente.SuspendLayout();
            this.tabPageRegistrarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroVentaCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistrarVentaRecibido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrarVentaProductos)).BeginInit();
            this.tabPageRegistrarBajaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeBajaCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeBajaCantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroDeBajaBajas)).BeginInit();
            this.tabPageRegistrarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoPrecioPublico)).BeginInit();
            this.tabPageRegistrarEmpleado.SuspendLayout();
            this.tabPageBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losMarisqueñiosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(966, 31);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // losMarisqueñiosToolStripMenuItem
            // 
            this.losMarisqueñiosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.losMarisqueñiosToolStripMenuItem.Name = "losMarisqueñiosToolStripMenuItem";
            this.losMarisqueñiosToolStripMenuItem.Size = new System.Drawing.Size(159, 27);
            this.losMarisqueñiosToolStripMenuItem.Text = " Los Marisqueños ";
            this.losMarisqueñiosToolStripMenuItem.Click += new System.EventHandler(this.losMarisqueñiosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.usuariosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.registrarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.buscarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar Empleados";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.modificarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Empleado";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem,
            this.buscarProductosToolStripMenuItem,
            this.modificarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.registrarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // buscarProductosToolStripMenuItem
            // 
            this.buscarProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.buscarProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarProductosToolStripMenuItem.Name = "buscarProductosToolStripMenuItem";
            this.buscarProductosToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.buscarProductosToolStripMenuItem.Text = "Buscar Productos";
            this.buscarProductosToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.modificarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.registrarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.registrarClienteToolStripMenuItem.Text = "Registrar / Modificar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.buscarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarBajaDeProductoToolStripMenuItem,
            this.buscarBajaDeProductoToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.almacenToolStripMenuItem.Text = "Baja";
            // 
            // registrarBajaDeProductoToolStripMenuItem
            // 
            this.registrarBajaDeProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.registrarBajaDeProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarBajaDeProductoToolStripMenuItem.Name = "registrarBajaDeProductoToolStripMenuItem";
            this.registrarBajaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.registrarBajaDeProductoToolStripMenuItem.Text = "Registrar baja de producto";
            this.registrarBajaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarBajaDeProductoToolStripMenuItem_Click);
            // 
            // buscarBajaDeProductoToolStripMenuItem
            // 
            this.buscarBajaDeProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.buscarBajaDeProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarBajaDeProductoToolStripMenuItem.Name = "buscarBajaDeProductoToolStripMenuItem";
            this.buscarBajaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.buscarBajaDeProductoToolStripMenuItem.Text = "Buscar baja de producto";
            this.buscarBajaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarBajaDeProductoToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.buscarVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.registrarVentaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // buscarVentaToolStripMenuItem
            // 
            this.buscarVentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.buscarVentaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarVentaToolStripMenuItem.Name = "buscarVentaToolStripMenuItem";
            this.buscarVentaToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.buscarVentaToolStripMenuItem.Text = "Buscar Venta";
            this.buscarVentaToolStripMenuItem.Click += new System.EventHandler(this.buscarVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // tabPageModificarProducto
            // 
            this.tabPageModificarProducto.BackColor = System.Drawing.Color.White;
            this.tabPageModificarProducto.Controls.Add(this.buttonModificarProductoBuscarProducto);
            this.tabPageModificarProducto.Controls.Add(this.numericUpDownModificarProductoCodigoBarras);
            this.tabPageModificarProducto.Controls.Add(this.numericUpDownModificarProductoExistencia);
            this.tabPageModificarProducto.Controls.Add(this.label66);
            this.tabPageModificarProducto.Controls.Add(this.numericUpDownModificarProductoPrecioPublico);
            this.tabPageModificarProducto.Controls.Add(this.label93);
            this.tabPageModificarProducto.Controls.Add(this.label113);
            this.tabPageModificarProducto.Controls.Add(this.checkBoxModificarProductoActivoInactivo);
            this.tabPageModificarProducto.Controls.Add(this.textBoxModificarProductoDescripcion);
            this.tabPageModificarProducto.Controls.Add(this.textBoxModificarProductoNombreProducto);
            this.tabPageModificarProducto.Controls.Add(this.label59);
            this.tabPageModificarProducto.Controls.Add(this.label63);
            this.tabPageModificarProducto.Controls.Add(this.buttonModificarProductoModificar);
            this.tabPageModificarProducto.Controls.Add(this.label64);
            this.tabPageModificarProducto.Location = new System.Drawing.Point(4, 5);
            this.tabPageModificarProducto.Name = "tabPageModificarProducto";
            this.tabPageModificarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificarProducto.Size = new System.Drawing.Size(954, 562);
            this.tabPageModificarProducto.TabIndex = 12;
            this.tabPageModificarProducto.Text = "ModProd";
            // 
            // buttonModificarProductoBuscarProducto
            // 
            this.buttonModificarProductoBuscarProducto.BackColor = System.Drawing.Color.White;
            this.buttonModificarProductoBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonModificarProductoBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarProductoBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProductoBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonModificarProductoBuscarProducto.Location = new System.Drawing.Point(534, 110);
            this.buttonModificarProductoBuscarProducto.Name = "buttonModificarProductoBuscarProducto";
            this.buttonModificarProductoBuscarProducto.Size = new System.Drawing.Size(206, 36);
            this.buttonModificarProductoBuscarProducto.TabIndex = 127;
            this.buttonModificarProductoBuscarProducto.Text = "Buscar Producto";
            this.buttonModificarProductoBuscarProducto.UseVisualStyleBackColor = false;
            this.buttonModificarProductoBuscarProducto.Click += new System.EventHandler(this.buttonModificarProductoBuscarProducto_Click);
            // 
            // numericUpDownModificarProductoCodigoBarras
            // 
            this.numericUpDownModificarProductoCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownModificarProductoCodigoBarras.Location = new System.Drawing.Point(249, 112);
            this.numericUpDownModificarProductoCodigoBarras.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownModificarProductoCodigoBarras.Name = "numericUpDownModificarProductoCodigoBarras";
            this.numericUpDownModificarProductoCodigoBarras.Size = new System.Drawing.Size(269, 29);
            this.numericUpDownModificarProductoCodigoBarras.TabIndex = 126;
            // 
            // numericUpDownModificarProductoExistencia
            // 
            this.numericUpDownModificarProductoExistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownModificarProductoExistencia.Location = new System.Drawing.Point(248, 403);
            this.numericUpDownModificarProductoExistencia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownModificarProductoExistencia.Name = "numericUpDownModificarProductoExistencia";
            this.numericUpDownModificarProductoExistencia.Size = new System.Drawing.Size(150, 29);
            this.numericUpDownModificarProductoExistencia.TabIndex = 122;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(33, 403);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(80, 21);
            this.label66.TabIndex = 125;
            this.label66.Text = "Existencia:";
            // 
            // numericUpDownModificarProductoPrecioPublico
            // 
            this.numericUpDownModificarProductoPrecioPublico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownModificarProductoPrecioPublico.Location = new System.Drawing.Point(248, 354);
            this.numericUpDownModificarProductoPrecioPublico.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownModificarProductoPrecioPublico.Name = "numericUpDownModificarProductoPrecioPublico";
            this.numericUpDownModificarProductoPrecioPublico.Size = new System.Drawing.Size(150, 29);
            this.numericUpDownModificarProductoPrecioPublico.TabIndex = 121;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(34, 116);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(129, 21);
            this.label93.TabIndex = 124;
            this.label93.Text = "Código de barras";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(33, 357);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(120, 21);
            this.label113.TabIndex = 123;
            this.label113.Text = "Precio a público";
            // 
            // checkBoxModificarProductoActivoInactivo
            // 
            this.checkBoxModificarProductoActivoInactivo.AutoSize = true;
            this.checkBoxModificarProductoActivoInactivo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.checkBoxModificarProductoActivoInactivo.Location = new System.Drawing.Point(836, 112);
            this.checkBoxModificarProductoActivoInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxModificarProductoActivoInactivo.Name = "checkBoxModificarProductoActivoInactivo";
            this.checkBoxModificarProductoActivoInactivo.Size = new System.Drawing.Size(87, 32);
            this.checkBoxModificarProductoActivoInactivo.TabIndex = 120;
            this.checkBoxModificarProductoActivoInactivo.Text = "Activo";
            this.checkBoxModificarProductoActivoInactivo.UseVisualStyleBackColor = true;
            // 
            // textBoxModificarProductoDescripcion
            // 
            this.textBoxModificarProductoDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarProductoDescripcion.Location = new System.Drawing.Point(247, 210);
            this.textBoxModificarProductoDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarProductoDescripcion.MaxLength = 255;
            this.textBoxModificarProductoDescripcion.Multiline = true;
            this.textBoxModificarProductoDescripcion.Name = "textBoxModificarProductoDescripcion";
            this.textBoxModificarProductoDescripcion.Size = new System.Drawing.Size(675, 129);
            this.textBoxModificarProductoDescripcion.TabIndex = 111;
            // 
            // textBoxModificarProductoNombreProducto
            // 
            this.textBoxModificarProductoNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarProductoNombreProducto.Location = new System.Drawing.Point(248, 165);
            this.textBoxModificarProductoNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarProductoNombreProducto.MaxLength = 50;
            this.textBoxModificarProductoNombreProducto.Name = "textBoxModificarProductoNombreProducto";
            this.textBoxModificarProductoNombreProducto.Size = new System.Drawing.Size(675, 29);
            this.textBoxModificarProductoNombreProducto.TabIndex = 105;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(30, 213);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(91, 21);
            this.label59.TabIndex = 110;
            this.label59.Text = "Descripcion";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(33, 168);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(156, 21);
            this.label63.TabIndex = 104;
            this.label63.Text = "Nombre de Producto";
            // 
            // buttonModificarProductoModificar
            // 
            this.buttonModificarProductoModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonModificarProductoModificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonModificarProductoModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarProductoModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProductoModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificarProductoModificar.Location = new System.Drawing.Point(361, 485);
            this.buttonModificarProductoModificar.Name = "buttonModificarProductoModificar";
            this.buttonModificarProductoModificar.Size = new System.Drawing.Size(241, 51);
            this.buttonModificarProductoModificar.TabIndex = 103;
            this.buttonModificarProductoModificar.Text = "Modificar Producto";
            this.buttonModificarProductoModificar.UseVisualStyleBackColor = false;
            this.buttonModificarProductoModificar.Click += new System.EventHandler(this.buttonModificarProductoModificar_Click);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.White;
            this.label64.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label64.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label64.Location = new System.Drawing.Point(271, 19);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(422, 47);
            this.label64.TabIndex = 101;
            this.label64.Text = "Modificacion de producto";
            // 
            // tabPageModificarEmpleado
            // 
            this.tabPageModificarEmpleado.BackColor = System.Drawing.Color.White;
            this.tabPageModificarEmpleado.Controls.Add(this.comboBoxModificarEmpleadoTiposDeUsuario);
            this.tabPageModificarEmpleado.Controls.Add(this.buttonModificarEmpleadoBuscarEmpleado);
            this.tabPageModificarEmpleado.Controls.Add(this.checkBoxModificarEmpleadoActivoInactivo);
            this.tabPageModificarEmpleado.Controls.Add(this.textBoxModificarEmpleadoContrasenia);
            this.tabPageModificarEmpleado.Controls.Add(this.textBoxModificarEmpleadoRFC);
            this.tabPageModificarEmpleado.Controls.Add(this.textBoxModificarEmpleadoTelefono);
            this.tabPageModificarEmpleado.Controls.Add(this.textBoxModificarEmpleadoCorreo);
            this.tabPageModificarEmpleado.Controls.Add(this.textBoxModificarEmpleadoNombre);
            this.tabPageModificarEmpleado.Controls.Add(this.label38);
            this.tabPageModificarEmpleado.Controls.Add(this.label39);
            this.tabPageModificarEmpleado.Controls.Add(this.label41);
            this.tabPageModificarEmpleado.Controls.Add(this.label47);
            this.tabPageModificarEmpleado.Controls.Add(this.label48);
            this.tabPageModificarEmpleado.Controls.Add(this.label50);
            this.tabPageModificarEmpleado.Controls.Add(this.buttonModificarEmpleadoModificar);
            this.tabPageModificarEmpleado.Controls.Add(this.label51);
            this.tabPageModificarEmpleado.Location = new System.Drawing.Point(4, 5);
            this.tabPageModificarEmpleado.Name = "tabPageModificarEmpleado";
            this.tabPageModificarEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificarEmpleado.Size = new System.Drawing.Size(954, 562);
            this.tabPageModificarEmpleado.TabIndex = 10;
            this.tabPageModificarEmpleado.Text = "ModEmp";
            // 
            // comboBoxModificarEmpleadoTiposDeUsuario
            // 
            this.comboBoxModificarEmpleadoTiposDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModificarEmpleadoTiposDeUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModificarEmpleadoTiposDeUsuario.FormattingEnabled = true;
            this.comboBoxModificarEmpleadoTiposDeUsuario.Items.AddRange(new object[] {
            "Almacen",
            "Ventas",
            "Administracion"});
            this.comboBoxModificarEmpleadoTiposDeUsuario.Location = new System.Drawing.Point(247, 270);
            this.comboBoxModificarEmpleadoTiposDeUsuario.Name = "comboBoxModificarEmpleadoTiposDeUsuario";
            this.comboBoxModificarEmpleadoTiposDeUsuario.Size = new System.Drawing.Size(441, 31);
            this.comboBoxModificarEmpleadoTiposDeUsuario.TabIndex = 118;
            // 
            // buttonModificarEmpleadoBuscarEmpleado
            // 
            this.buttonModificarEmpleadoBuscarEmpleado.BackColor = System.Drawing.Color.White;
            this.buttonModificarEmpleadoBuscarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonModificarEmpleadoBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarEmpleadoBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEmpleadoBuscarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonModificarEmpleadoBuscarEmpleado.Location = new System.Drawing.Point(515, 90);
            this.buttonModificarEmpleadoBuscarEmpleado.Name = "buttonModificarEmpleadoBuscarEmpleado";
            this.buttonModificarEmpleadoBuscarEmpleado.Size = new System.Drawing.Size(206, 36);
            this.buttonModificarEmpleadoBuscarEmpleado.TabIndex = 117;
            this.buttonModificarEmpleadoBuscarEmpleado.Text = "Buscar Empleado";
            this.buttonModificarEmpleadoBuscarEmpleado.UseVisualStyleBackColor = false;
            this.buttonModificarEmpleadoBuscarEmpleado.Click += new System.EventHandler(this.buttonModificarEmpleadoBuscarEmpleado_Click);
            // 
            // checkBoxModificarEmpleadoActivoInactivo
            // 
            this.checkBoxModificarEmpleadoActivoInactivo.AutoSize = true;
            this.checkBoxModificarEmpleadoActivoInactivo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.checkBoxModificarEmpleadoActivoInactivo.Location = new System.Drawing.Point(840, 90);
            this.checkBoxModificarEmpleadoActivoInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxModificarEmpleadoActivoInactivo.Name = "checkBoxModificarEmpleadoActivoInactivo";
            this.checkBoxModificarEmpleadoActivoInactivo.Size = new System.Drawing.Size(87, 32);
            this.checkBoxModificarEmpleadoActivoInactivo.TabIndex = 1;
            this.checkBoxModificarEmpleadoActivoInactivo.Text = "Activo";
            this.checkBoxModificarEmpleadoActivoInactivo.UseVisualStyleBackColor = true;
            // 
            // textBoxModificarEmpleadoContrasenia
            // 
            this.textBoxModificarEmpleadoContrasenia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarEmpleadoContrasenia.Location = new System.Drawing.Point(247, 321);
            this.textBoxModificarEmpleadoContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarEmpleadoContrasenia.Name = "textBoxModificarEmpleadoContrasenia";
            this.textBoxModificarEmpleadoContrasenia.Size = new System.Drawing.Size(441, 30);
            this.textBoxModificarEmpleadoContrasenia.TabIndex = 13;
            this.textBoxModificarEmpleadoContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModificarEmpleadoRFC
            // 
            this.textBoxModificarEmpleadoRFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarEmpleadoRFC.Location = new System.Drawing.Point(247, 94);
            this.textBoxModificarEmpleadoRFC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarEmpleadoRFC.MaxLength = 13;
            this.textBoxModificarEmpleadoRFC.Name = "textBoxModificarEmpleadoRFC";
            this.textBoxModificarEmpleadoRFC.Size = new System.Drawing.Size(254, 30);
            this.textBoxModificarEmpleadoRFC.TabIndex = 12;
            this.textBoxModificarEmpleadoRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModificarEmpleadoTelefono
            // 
            this.textBoxModificarEmpleadoTelefono.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarEmpleadoTelefono.Location = new System.Drawing.Point(247, 226);
            this.textBoxModificarEmpleadoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarEmpleadoTelefono.Name = "textBoxModificarEmpleadoTelefono";
            this.textBoxModificarEmpleadoTelefono.Size = new System.Drawing.Size(441, 30);
            this.textBoxModificarEmpleadoTelefono.TabIndex = 5;
            this.textBoxModificarEmpleadoTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModificarEmpleadoCorreo
            // 
            this.textBoxModificarEmpleadoCorreo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarEmpleadoCorreo.Location = new System.Drawing.Point(247, 182);
            this.textBoxModificarEmpleadoCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarEmpleadoCorreo.Name = "textBoxModificarEmpleadoCorreo";
            this.textBoxModificarEmpleadoCorreo.Size = new System.Drawing.Size(680, 30);
            this.textBoxModificarEmpleadoCorreo.TabIndex = 4;
            // 
            // textBoxModificarEmpleadoNombre
            // 
            this.textBoxModificarEmpleadoNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModificarEmpleadoNombre.Location = new System.Drawing.Point(247, 137);
            this.textBoxModificarEmpleadoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModificarEmpleadoNombre.Name = "textBoxModificarEmpleadoNombre";
            this.textBoxModificarEmpleadoNombre.Size = new System.Drawing.Size(680, 30);
            this.textBoxModificarEmpleadoNombre.TabIndex = 2;
            this.textBoxModificarEmpleadoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(32, 325);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(89, 21);
            this.label38.TabIndex = 116;
            this.label38.Text = "Contraseña";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(32, 98);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(111, 21);
            this.label39.TabIndex = 114;
            this.label39.Text = "RFC Empleado";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(31, 275);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(117, 21);
            this.label41.TabIndex = 112;
            this.label41.Text = "Tipo de usuario";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(30, 230);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 21);
            this.label47.TabIndex = 100;
            this.label47.Text = "Teléfono";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(31, 186);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(58, 21);
            this.label48.TabIndex = 98;
            this.label48.Text = "Correo";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(31, 141);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(85, 21);
            this.label50.TabIndex = 94;
            this.label50.Text = "Nombre(s)";
            // 
            // buttonModificarEmpleadoModificar
            // 
            this.buttonModificarEmpleadoModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonModificarEmpleadoModificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonModificarEmpleadoModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarEmpleadoModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEmpleadoModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificarEmpleadoModificar.Location = new System.Drawing.Point(372, 430);
            this.buttonModificarEmpleadoModificar.Name = "buttonModificarEmpleadoModificar";
            this.buttonModificarEmpleadoModificar.Size = new System.Drawing.Size(241, 51);
            this.buttonModificarEmpleadoModificar.TabIndex = 14;
            this.buttonModificarEmpleadoModificar.Text = "Modificar Empleado";
            this.buttonModificarEmpleadoModificar.UseVisualStyleBackColor = false;
            this.buttonModificarEmpleadoModificar.Click += new System.EventHandler(this.buttonModificarEmpleadoModificar_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.White;
            this.label51.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label51.Location = new System.Drawing.Point(321, 19);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(433, 47);
            this.label51.TabIndex = 91;
            this.label51.Text = "Modificacion de empleado";
            // 
            // tabPageBuscarCliente
            // 
            this.tabPageBuscarCliente.BackColor = System.Drawing.Color.White;
            this.tabPageBuscarCliente.Controls.Add(this.label88);
            this.tabPageBuscarCliente.Controls.Add(this.textBoxBuscarClienteRFC);
            this.tabPageBuscarCliente.Controls.Add(this.dataGridViewBuscarClienteClientes);
            this.tabPageBuscarCliente.Controls.Add(this.buttonBuscarClienteBuscar);
            this.tabPageBuscarCliente.Controls.Add(this.label74);
            this.tabPageBuscarCliente.Location = new System.Drawing.Point(4, 5);
            this.tabPageBuscarCliente.Name = "tabPageBuscarCliente";
            this.tabPageBuscarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarCliente.Size = new System.Drawing.Size(954, 562);
            this.tabPageBuscarCliente.TabIndex = 9;
            this.tabPageBuscarCliente.Text = "BusCliente";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(466, 20);
            this.label88.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(48, 25);
            this.label88.TabIndex = 89;
            this.label88.Text = "RFC:";
            // 
            // textBoxBuscarClienteRFC
            // 
            this.textBoxBuscarClienteRFC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarClienteRFC.Location = new System.Drawing.Point(518, 17);
            this.textBoxBuscarClienteRFC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarClienteRFC.MaxLength = 13;
            this.textBoxBuscarClienteRFC.Multiline = true;
            this.textBoxBuscarClienteRFC.Name = "textBoxBuscarClienteRFC";
            this.textBoxBuscarClienteRFC.Size = new System.Drawing.Size(259, 33);
            this.textBoxBuscarClienteRFC.TabIndex = 88;
            this.textBoxBuscarClienteRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewBuscarClienteClientes
            // 
            this.dataGridViewBuscarClienteClientes.AllowUserToAddRows = false;
            this.dataGridViewBuscarClienteClientes.AllowUserToOrderColumns = true;
            this.dataGridViewBuscarClienteClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBuscarClienteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarClienteClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFCCliente,
            this.nombreCliente,
            this.domicilioCliente,
            this.correoCliente});
            this.dataGridViewBuscarClienteClientes.Location = new System.Drawing.Point(5, 60);
            this.dataGridViewBuscarClienteClientes.Name = "dataGridViewBuscarClienteClientes";
            this.dataGridViewBuscarClienteClientes.RowHeadersWidth = 51;
            this.dataGridViewBuscarClienteClientes.Size = new System.Drawing.Size(942, 486);
            this.dataGridViewBuscarClienteClientes.TabIndex = 83;
            // 
            // RFCCliente
            // 
            this.RFCCliente.HeaderText = "RFC";
            this.RFCCliente.MinimumWidth = 6;
            this.RFCCliente.Name = "RFCCliente";
            this.RFCCliente.Width = 125;
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCliente.HeaderText = "Nombre";
            this.nombreCliente.MinimumWidth = 6;
            this.nombreCliente.Name = "nombreCliente";
            // 
            // domicilioCliente
            // 
            this.domicilioCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.domicilioCliente.HeaderText = "Domicilio";
            this.domicilioCliente.MinimumWidth = 6;
            this.domicilioCliente.Name = "domicilioCliente";
            // 
            // correoCliente
            // 
            this.correoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoCliente.HeaderText = "Correo";
            this.correoCliente.MinimumWidth = 6;
            this.correoCliente.Name = "correoCliente";
            // 
            // buttonBuscarClienteBuscar
            // 
            this.buttonBuscarClienteBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonBuscarClienteBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBuscarClienteBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarClienteBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarClienteBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarClienteBuscar.Location = new System.Drawing.Point(792, 17);
            this.buttonBuscarClienteBuscar.Name = "buttonBuscarClienteBuscar";
            this.buttonBuscarClienteBuscar.Size = new System.Drawing.Size(155, 33);
            this.buttonBuscarClienteBuscar.TabIndex = 81;
            this.buttonBuscarClienteBuscar.Text = "Buscar";
            this.buttonBuscarClienteBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscarClienteBuscar.Click += new System.EventHandler(this.buttonBuscarClienteBuscar_Click);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.White;
            this.label74.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label74.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label74.Location = new System.Drawing.Point(6, 3);
            this.label74.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(237, 47);
            this.label74.TabIndex = 79;
            this.label74.Text = "Buscar Cliente";
            // 
            // tabPageBuscarVenta
            // 
            this.tabPageBuscarVenta.BackColor = System.Drawing.Color.White;
            this.tabPageBuscarVenta.Controls.Add(this.numericUpDownBusquedaVentasFolioVenta);
            this.tabPageBuscarVenta.Controls.Add(this.label62);
            this.tabPageBuscarVenta.Controls.Add(this.buttonBusquedaVentasBuscar);
            this.tabPageBuscarVenta.Controls.Add(this.dataGridViewBusquedaVentasVentas);
            this.tabPageBuscarVenta.Controls.Add(this.label65);
            this.tabPageBuscarVenta.Location = new System.Drawing.Point(4, 5);
            this.tabPageBuscarVenta.Name = "tabPageBuscarVenta";
            this.tabPageBuscarVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarVenta.Size = new System.Drawing.Size(954, 562);
            this.tabPageBuscarVenta.TabIndex = 13;
            this.tabPageBuscarVenta.Text = "BusVenta";
            // 
            // numericUpDownBusquedaVentasFolioVenta
            // 
            this.numericUpDownBusquedaVentasFolioVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBusquedaVentasFolioVenta.Location = new System.Drawing.Point(529, 12);
            this.numericUpDownBusquedaVentasFolioVenta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBusquedaVentasFolioVenta.Name = "numericUpDownBusquedaVentasFolioVenta";
            this.numericUpDownBusquedaVentasFolioVenta.Size = new System.Drawing.Size(253, 29);
            this.numericUpDownBusquedaVentasFolioVenta.TabIndex = 92;
            this.numericUpDownBusquedaVentasFolioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(306, 15);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(218, 25);
            this.label62.TabIndex = 91;
            this.label62.Text = "Folio Venta de Producto:";
            // 
            // buttonBusquedaVentasBuscar
            // 
            this.buttonBusquedaVentasBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonBusquedaVentasBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBusquedaVentasBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaVentasBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaVentasBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBusquedaVentasBuscar.Location = new System.Drawing.Point(788, 12);
            this.buttonBusquedaVentasBuscar.Name = "buttonBusquedaVentasBuscar";
            this.buttonBusquedaVentasBuscar.Size = new System.Drawing.Size(155, 33);
            this.buttonBusquedaVentasBuscar.TabIndex = 90;
            this.buttonBusquedaVentasBuscar.Text = "Buscar";
            this.buttonBusquedaVentasBuscar.UseVisualStyleBackColor = false;
            this.buttonBusquedaVentasBuscar.Click += new System.EventHandler(this.buttonBusquedaVentasBuscar_Click);
            // 
            // dataGridViewBusquedaVentasVentas
            // 
            this.dataGridViewBusquedaVentasVentas.AllowUserToAddRows = false;
            this.dataGridViewBusquedaVentasVentas.AllowUserToOrderColumns = true;
            this.dataGridViewBusquedaVentasVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBusquedaVentasVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaVentasVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioVenta,
            this.fechaVenta,
            this.RFCClienteVenta,
            this.nombreClienteVenta,
            this.RFCEmpleadoVenta,
            this.nombreEmpleadoVenta,
            this.cantidadProductosVentas,
            this.estadoVenta,
            this.totalVenta});
            this.dataGridViewBusquedaVentasVentas.Location = new System.Drawing.Point(6, 53);
            this.dataGridViewBusquedaVentasVentas.Name = "dataGridViewBusquedaVentasVentas";
            this.dataGridViewBusquedaVentasVentas.RowHeadersWidth = 51;
            this.dataGridViewBusquedaVentasVentas.Size = new System.Drawing.Size(942, 493);
            this.dataGridViewBusquedaVentasVentas.TabIndex = 77;
            // 
            // folioVenta
            // 
            this.folioVenta.HeaderText = "Folio";
            this.folioVenta.MinimumWidth = 6;
            this.folioVenta.Name = "folioVenta";
            this.folioVenta.Width = 125;
            // 
            // fechaVenta
            // 
            this.fechaVenta.HeaderText = "Fecha";
            this.fechaVenta.MinimumWidth = 6;
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.Width = 125;
            // 
            // RFCClienteVenta
            // 
            this.RFCClienteVenta.HeaderText = "RFC Cliente";
            this.RFCClienteVenta.MinimumWidth = 6;
            this.RFCClienteVenta.Name = "RFCClienteVenta";
            this.RFCClienteVenta.Width = 125;
            // 
            // nombreClienteVenta
            // 
            this.nombreClienteVenta.HeaderText = "Nombre Cliente";
            this.nombreClienteVenta.MinimumWidth = 6;
            this.nombreClienteVenta.Name = "nombreClienteVenta";
            this.nombreClienteVenta.Width = 125;
            // 
            // RFCEmpleadoVenta
            // 
            this.RFCEmpleadoVenta.HeaderText = "RFC Empleado";
            this.RFCEmpleadoVenta.MinimumWidth = 6;
            this.RFCEmpleadoVenta.Name = "RFCEmpleadoVenta";
            this.RFCEmpleadoVenta.Width = 125;
            // 
            // nombreEmpleadoVenta
            // 
            this.nombreEmpleadoVenta.HeaderText = "Nombre Empleado";
            this.nombreEmpleadoVenta.MinimumWidth = 6;
            this.nombreEmpleadoVenta.Name = "nombreEmpleadoVenta";
            this.nombreEmpleadoVenta.Width = 125;
            // 
            // cantidadProductosVentas
            // 
            this.cantidadProductosVentas.HeaderText = "Cantidad Productos";
            this.cantidadProductosVentas.MinimumWidth = 6;
            this.cantidadProductosVentas.Name = "cantidadProductosVentas";
            this.cantidadProductosVentas.Width = 125;
            // 
            // estadoVenta
            // 
            this.estadoVenta.HeaderText = "Estado Venta";
            this.estadoVenta.MinimumWidth = 6;
            this.estadoVenta.Name = "estadoVenta";
            this.estadoVenta.Width = 125;
            // 
            // totalVenta
            // 
            this.totalVenta.HeaderText = "Total";
            this.totalVenta.MinimumWidth = 6;
            this.totalVenta.Name = "totalVenta";
            this.totalVenta.Width = 125;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.White;
            this.label65.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label65.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label65.Location = new System.Drawing.Point(7, 3);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(219, 47);
            this.label65.TabIndex = 70;
            this.label65.Text = "Buscar Venta";
            // 
            // tabPageBuscarBaja
            // 
            this.tabPageBuscarBaja.BackColor = System.Drawing.Color.White;
            this.tabPageBuscarBaja.Controls.Add(this.numericUpDownBusquedaBajasFolioBaja);
            this.tabPageBuscarBaja.Controls.Add(this.dataGridViewBusquedaBajasBajas);
            this.tabPageBuscarBaja.Controls.Add(this.label98);
            this.tabPageBuscarBaja.Controls.Add(this.buttonBusquedaBajasBuscar);
            this.tabPageBuscarBaja.Controls.Add(this.label99);
            this.tabPageBuscarBaja.Location = new System.Drawing.Point(4, 5);
            this.tabPageBuscarBaja.Name = "tabPageBuscarBaja";
            this.tabPageBuscarBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarBaja.Size = new System.Drawing.Size(954, 562);
            this.tabPageBuscarBaja.TabIndex = 18;
            this.tabPageBuscarBaja.Text = "BusBaja";
            // 
            // numericUpDownBusquedaBajasFolioBaja
            // 
            this.numericUpDownBusquedaBajasFolioBaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBusquedaBajasFolioBaja.Location = new System.Drawing.Point(533, 65);
            this.numericUpDownBusquedaBajasFolioBaja.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownBusquedaBajasFolioBaja.Name = "numericUpDownBusquedaBajasFolioBaja";
            this.numericUpDownBusquedaBajasFolioBaja.Size = new System.Drawing.Size(253, 29);
            this.numericUpDownBusquedaBajasFolioBaja.TabIndex = 89;
            this.numericUpDownBusquedaBajasFolioBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewBusquedaBajasBajas
            // 
            this.dataGridViewBusquedaBajasBajas.AllowUserToAddRows = false;
            this.dataGridViewBusquedaBajasBajas.AllowUserToOrderColumns = true;
            this.dataGridViewBusquedaBajasBajas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBusquedaBajasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaBajasBajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioBajaProducto,
            this.fechaBaja,
            this.RFCEmpleadoBaja,
            this.nombreEmpleadoBaja,
            this.codigoProductoBaja,
            this.nombreProductoBaja,
            this.comentarioBajaProducto,
            this.cantidadProductoSaliente});
            this.dataGridViewBusquedaBajasBajas.Location = new System.Drawing.Point(6, 100);
            this.dataGridViewBusquedaBajasBajas.Name = "dataGridViewBusquedaBajasBajas";
            this.dataGridViewBusquedaBajasBajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewBusquedaBajasBajas.RowHeadersWidth = 51;
            this.dataGridViewBusquedaBajasBajas.Size = new System.Drawing.Size(942, 444);
            this.dataGridViewBusquedaBajasBajas.TabIndex = 88;
            // 
            // folioBajaProducto
            // 
            this.folioBajaProducto.HeaderText = "Folio";
            this.folioBajaProducto.MinimumWidth = 6;
            this.folioBajaProducto.Name = "folioBajaProducto";
            this.folioBajaProducto.Width = 125;
            // 
            // fechaBaja
            // 
            this.fechaBaja.HeaderText = "Fecha";
            this.fechaBaja.MinimumWidth = 6;
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.Width = 125;
            // 
            // RFCEmpleadoBaja
            // 
            this.RFCEmpleadoBaja.HeaderText = "RFC Empleado";
            this.RFCEmpleadoBaja.MinimumWidth = 6;
            this.RFCEmpleadoBaja.Name = "RFCEmpleadoBaja";
            this.RFCEmpleadoBaja.Width = 125;
            // 
            // nombreEmpleadoBaja
            // 
            this.nombreEmpleadoBaja.HeaderText = "Nombre Empleado";
            this.nombreEmpleadoBaja.MinimumWidth = 6;
            this.nombreEmpleadoBaja.Name = "nombreEmpleadoBaja";
            this.nombreEmpleadoBaja.Width = 125;
            // 
            // codigoProductoBaja
            // 
            this.codigoProductoBaja.HeaderText = "Codigo";
            this.codigoProductoBaja.MinimumWidth = 6;
            this.codigoProductoBaja.Name = "codigoProductoBaja";
            this.codigoProductoBaja.Width = 125;
            // 
            // nombreProductoBaja
            // 
            this.nombreProductoBaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProductoBaja.HeaderText = "Nombre Producto";
            this.nombreProductoBaja.MinimumWidth = 6;
            this.nombreProductoBaja.Name = "nombreProductoBaja";
            // 
            // comentarioBajaProducto
            // 
            this.comentarioBajaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentarioBajaProducto.HeaderText = "Comentario";
            this.comentarioBajaProducto.MinimumWidth = 6;
            this.comentarioBajaProducto.Name = "comentarioBajaProducto";
            // 
            // cantidadProductoSaliente
            // 
            this.cantidadProductoSaliente.HeaderText = "Cantidad Producto Saliente";
            this.cantidadProductoSaliente.MinimumWidth = 6;
            this.cantidadProductoSaliente.Name = "cantidadProductoSaliente";
            this.cantidadProductoSaliente.Width = 125;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(322, 64);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(206, 25);
            this.label98.TabIndex = 87;
            this.label98.Text = "Folio Baja de Producto:";
            // 
            // buttonBusquedaBajasBuscar
            // 
            this.buttonBusquedaBajasBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonBusquedaBajasBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBusquedaBajasBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaBajasBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBajasBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBusquedaBajasBuscar.Location = new System.Drawing.Point(792, 61);
            this.buttonBusquedaBajasBuscar.Name = "buttonBusquedaBajasBuscar";
            this.buttonBusquedaBajasBuscar.Size = new System.Drawing.Size(155, 33);
            this.buttonBusquedaBajasBuscar.TabIndex = 86;
            this.buttonBusquedaBajasBuscar.Text = "Buscar";
            this.buttonBusquedaBajasBuscar.UseVisualStyleBackColor = false;
            this.buttonBusquedaBajasBuscar.Click += new System.EventHandler(this.buttonBusquedaBajasBuscar_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.White;
            this.label99.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label99.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label99.Location = new System.Drawing.Point(7, 1);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(397, 47);
            this.label99.TabIndex = 84;
            this.label99.Text = "Buscar Baja de Producto";
            // 
            // tabPageBuscarProducto
            // 
            this.tabPageBuscarProducto.BackColor = System.Drawing.Color.White;
            this.tabPageBuscarProducto.Controls.Add(this.numericUpDownBusquedaProductosCodigoBarras);
            this.tabPageBuscarProducto.Controls.Add(this.dataGridViewBusquedaProductosProductos);
            this.tabPageBuscarProducto.Controls.Add(this.label71);
            this.tabPageBuscarProducto.Controls.Add(this.buttonBusquedaProductosBuscar);
            this.tabPageBuscarProducto.Controls.Add(this.label72);
            this.tabPageBuscarProducto.Location = new System.Drawing.Point(4, 5);
            this.tabPageBuscarProducto.Name = "tabPageBuscarProducto";
            this.tabPageBuscarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarProducto.Size = new System.Drawing.Size(954, 562);
            this.tabPageBuscarProducto.TabIndex = 8;
            this.tabPageBuscarProducto.Text = "BusProd";
            // 
            // numericUpDownBusquedaProductosCodigoBarras
            // 
            this.numericUpDownBusquedaProductosCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBusquedaProductosCodigoBarras.Location = new System.Drawing.Point(529, 18);
            this.numericUpDownBusquedaProductosCodigoBarras.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownBusquedaProductosCodigoBarras.Name = "numericUpDownBusquedaProductosCodigoBarras";
            this.numericUpDownBusquedaProductosCodigoBarras.Size = new System.Drawing.Size(253, 29);
            this.numericUpDownBusquedaProductosCodigoBarras.TabIndex = 86;
            this.numericUpDownBusquedaProductosCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewBusquedaProductosProductos
            // 
            this.dataGridViewBusquedaProductosProductos.AllowUserToAddRows = false;
            this.dataGridViewBusquedaProductosProductos.AllowUserToOrderColumns = true;
            this.dataGridViewBusquedaProductosProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBusquedaProductosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaProductosProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.nombreProducto,
            this.descripcionProducto,
            this.precioProducto,
            this.existenciaProducto,
            this.estadoProducto});
            this.dataGridViewBusquedaProductosProductos.Location = new System.Drawing.Point(5, 67);
            this.dataGridViewBusquedaProductosProductos.Name = "dataGridViewBusquedaProductosProductos";
            this.dataGridViewBusquedaProductosProductos.RowHeadersWidth = 51;
            this.dataGridViewBusquedaProductosProductos.Size = new System.Drawing.Size(942, 479);
            this.dataGridViewBusquedaProductosProductos.TabIndex = 83;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 125;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionProducto.HeaderText = "Descripcion";
            this.descripcionProducto.MinimumWidth = 6;
            this.descripcionProducto.Name = "descripcionProducto";
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.MinimumWidth = 6;
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Width = 125;
            // 
            // existenciaProducto
            // 
            this.existenciaProducto.HeaderText = "Existencia ";
            this.existenciaProducto.MinimumWidth = 6;
            this.existenciaProducto.Name = "existenciaProducto";
            this.existenciaProducto.Width = 125;
            // 
            // estadoProducto
            // 
            this.estadoProducto.HeaderText = "Estado";
            this.estadoProducto.MinimumWidth = 6;
            this.estadoProducto.Name = "estadoProducto";
            this.estadoProducto.Width = 125;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(363, 17);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(161, 25);
            this.label71.TabIndex = 82;
            this.label71.Text = "Codigo de barras:";
            // 
            // buttonBusquedaProductosBuscar
            // 
            this.buttonBusquedaProductosBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonBusquedaProductosBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBusquedaProductosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaProductosBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaProductosBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBusquedaProductosBuscar.Location = new System.Drawing.Point(788, 14);
            this.buttonBusquedaProductosBuscar.Name = "buttonBusquedaProductosBuscar";
            this.buttonBusquedaProductosBuscar.Size = new System.Drawing.Size(155, 33);
            this.buttonBusquedaProductosBuscar.TabIndex = 81;
            this.buttonBusquedaProductosBuscar.Text = "Buscar";
            this.buttonBusquedaProductosBuscar.UseVisualStyleBackColor = false;
            this.buttonBusquedaProductosBuscar.Click += new System.EventHandler(this.buttonBusquedaProductosBuscar_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.White;
            this.label72.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label72.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label72.Location = new System.Drawing.Point(6, 3);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(274, 47);
            this.label72.TabIndex = 79;
            this.label72.Text = "Buscar Producto";
            // 
            // tabPageBuscarEmpleado
            // 
            this.tabPageBuscarEmpleado.BackColor = System.Drawing.Color.White;
            this.tabPageBuscarEmpleado.Controls.Add(this.dataGridViewBusquedaEmpleadosEmpleados);
            this.tabPageBuscarEmpleado.Controls.Add(this.label67);
            this.tabPageBuscarEmpleado.Controls.Add(this.buttonBusquedaEmpleadosBuscar);
            this.tabPageBuscarEmpleado.Controls.Add(this.textBoxBusquedaEmpleadosRFC);
            this.tabPageBuscarEmpleado.Controls.Add(this.label68);
            this.tabPageBuscarEmpleado.Location = new System.Drawing.Point(4, 5);
            this.tabPageBuscarEmpleado.Name = "tabPageBuscarEmpleado";
            this.tabPageBuscarEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarEmpleado.Size = new System.Drawing.Size(954, 562);
            this.tabPageBuscarEmpleado.TabIndex = 6;
            this.tabPageBuscarEmpleado.Text = "BusEmp";
            // 
            // dataGridViewBusquedaEmpleadosEmpleados
            // 
            this.dataGridViewBusquedaEmpleadosEmpleados.AllowUserToAddRows = false;
            this.dataGridViewBusquedaEmpleadosEmpleados.AllowUserToOrderColumns = true;
            this.dataGridViewBusquedaEmpleadosEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBusquedaEmpleadosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusquedaEmpleadosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFCEmpleado,
            this.nombreEmpleado,
            this.correoEmpleado,
            this.telefonoEmpleado,
            this.tipoDeUsuarioEmpleado,
            this.estadoEmpleado});
            this.dataGridViewBusquedaEmpleadosEmpleados.Location = new System.Drawing.Point(5, 65);
            this.dataGridViewBusquedaEmpleadosEmpleados.Name = "dataGridViewBusquedaEmpleadosEmpleados";
            this.dataGridViewBusquedaEmpleadosEmpleados.RowHeadersWidth = 51;
            this.dataGridViewBusquedaEmpleadosEmpleados.Size = new System.Drawing.Size(942, 481);
            this.dataGridViewBusquedaEmpleadosEmpleados.TabIndex = 83;
            // 
            // RFCEmpleado
            // 
            this.RFCEmpleado.HeaderText = "RFC";
            this.RFCEmpleado.MinimumWidth = 6;
            this.RFCEmpleado.Name = "RFCEmpleado";
            this.RFCEmpleado.Width = 125;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEmpleado.HeaderText = "Nombre";
            this.nombreEmpleado.MinimumWidth = 6;
            this.nombreEmpleado.Name = "nombreEmpleado";
            // 
            // correoEmpleado
            // 
            this.correoEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoEmpleado.HeaderText = "Correo";
            this.correoEmpleado.MinimumWidth = 6;
            this.correoEmpleado.Name = "correoEmpleado";
            // 
            // telefonoEmpleado
            // 
            this.telefonoEmpleado.HeaderText = "Telefono";
            this.telefonoEmpleado.MinimumWidth = 6;
            this.telefonoEmpleado.Name = "telefonoEmpleado";
            this.telefonoEmpleado.Width = 125;
            // 
            // tipoDeUsuarioEmpleado
            // 
            this.tipoDeUsuarioEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoDeUsuarioEmpleado.HeaderText = "Tipo de Usuario";
            this.tipoDeUsuarioEmpleado.MinimumWidth = 6;
            this.tipoDeUsuarioEmpleado.Name = "tipoDeUsuarioEmpleado";
            // 
            // estadoEmpleado
            // 
            this.estadoEmpleado.HeaderText = "Estado";
            this.estadoEmpleado.MinimumWidth = 6;
            this.estadoEmpleado.Name = "estadoEmpleado";
            this.estadoEmpleado.Width = 125;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(466, 15);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(48, 25);
            this.label67.TabIndex = 82;
            this.label67.Text = "RFC:";
            // 
            // buttonBusquedaEmpleadosBuscar
            // 
            this.buttonBusquedaEmpleadosBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonBusquedaEmpleadosBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonBusquedaEmpleadosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaEmpleadosBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaEmpleadosBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBusquedaEmpleadosBuscar.Location = new System.Drawing.Point(782, 12);
            this.buttonBusquedaEmpleadosBuscar.Name = "buttonBusquedaEmpleadosBuscar";
            this.buttonBusquedaEmpleadosBuscar.Size = new System.Drawing.Size(155, 33);
            this.buttonBusquedaEmpleadosBuscar.TabIndex = 2;
            this.buttonBusquedaEmpleadosBuscar.Text = "Buscar";
            this.buttonBusquedaEmpleadosBuscar.UseVisualStyleBackColor = false;
            this.buttonBusquedaEmpleadosBuscar.Click += new System.EventHandler(this.buttonBusquedaEmpleadosBuscar_Click);
            // 
            // textBoxBusquedaEmpleadosRFC
            // 
            this.textBoxBusquedaEmpleadosRFC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusquedaEmpleadosRFC.Location = new System.Drawing.Point(518, 12);
            this.textBoxBusquedaEmpleadosRFC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBusquedaEmpleadosRFC.MaxLength = 13;
            this.textBoxBusquedaEmpleadosRFC.Multiline = true;
            this.textBoxBusquedaEmpleadosRFC.Name = "textBoxBusquedaEmpleadosRFC";
            this.textBoxBusquedaEmpleadosRFC.Size = new System.Drawing.Size(259, 33);
            this.textBoxBusquedaEmpleadosRFC.TabIndex = 1;
            this.textBoxBusquedaEmpleadosRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.White;
            this.label68.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label68.Location = new System.Drawing.Point(6, 3);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(286, 47);
            this.label68.TabIndex = 79;
            this.label68.Text = "Buscar Empleado";
            // 
            // tabPageRegistrarCliente
            // 
            this.tabPageRegistrarCliente.BackColor = System.Drawing.Color.White;
            this.tabPageRegistrarCliente.Controls.Add(this.radioButtonRegistroClienteModificacion);
            this.tabPageRegistrarCliente.Controls.Add(this.buttonRegistroClienteBuscarCliente);
            this.tabPageRegistrarCliente.Controls.Add(this.textBoxRegistroClienteRFC);
            this.tabPageRegistrarCliente.Controls.Add(this.textBoxRegistroClienteCorreo);
            this.tabPageRegistrarCliente.Controls.Add(this.textBoxRegistroClienteDomicilio);
            this.tabPageRegistrarCliente.Controls.Add(this.textBoxRegistroClienteNombre);
            this.tabPageRegistrarCliente.Controls.Add(this.label9);
            this.tabPageRegistrarCliente.Controls.Add(this.label75);
            this.tabPageRegistrarCliente.Controls.Add(this.label76);
            this.tabPageRegistrarCliente.Controls.Add(this.label77);
            this.tabPageRegistrarCliente.Controls.Add(this.buttonRegistroClienteRegistrarModificar);
            this.tabPageRegistrarCliente.Controls.Add(this.buttonRegistroClienteRegresar);
            this.tabPageRegistrarCliente.Controls.Add(this.label78);
            this.tabPageRegistrarCliente.Location = new System.Drawing.Point(4, 5);
            this.tabPageRegistrarCliente.Name = "tabPageRegistrarCliente";
            this.tabPageRegistrarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarCliente.Size = new System.Drawing.Size(954, 562);
            this.tabPageRegistrarCliente.TabIndex = 15;
            this.tabPageRegistrarCliente.Text = "RegCliente";
            // 
            // radioButtonRegistroClienteModificacion
            // 
            this.radioButtonRegistroClienteModificacion.AutoSize = true;
            this.radioButtonRegistroClienteModificacion.Enabled = false;
            this.radioButtonRegistroClienteModificacion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRegistroClienteModificacion.Location = new System.Drawing.Point(34, 36);
            this.radioButtonRegistroClienteModificacion.Name = "radioButtonRegistroClienteModificacion";
            this.radioButtonRegistroClienteModificacion.Size = new System.Drawing.Size(151, 36);
            this.radioButtonRegistroClienteModificacion.TabIndex = 119;
            this.radioButtonRegistroClienteModificacion.TabStop = true;
            this.radioButtonRegistroClienteModificacion.Text = "Moficacion";
            this.radioButtonRegistroClienteModificacion.UseVisualStyleBackColor = true;
            // 
            // buttonRegistroClienteBuscarCliente
            // 
            this.buttonRegistroClienteBuscarCliente.BackColor = System.Drawing.Color.White;
            this.buttonRegistroClienteBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroClienteBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroClienteBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroClienteBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroClienteBuscarCliente.Location = new System.Drawing.Point(523, 160);
            this.buttonRegistroClienteBuscarCliente.Name = "buttonRegistroClienteBuscarCliente";
            this.buttonRegistroClienteBuscarCliente.Size = new System.Drawing.Size(206, 36);
            this.buttonRegistroClienteBuscarCliente.TabIndex = 118;
            this.buttonRegistroClienteBuscarCliente.Text = "Buscar Cliente";
            this.buttonRegistroClienteBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonRegistroClienteBuscarCliente.Click += new System.EventHandler(this.buttonRegistroClienteBuscarCliente_Click);
            // 
            // textBoxRegistroClienteRFC
            // 
            this.textBoxRegistroClienteRFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroClienteRFC.Location = new System.Drawing.Point(246, 165);
            this.textBoxRegistroClienteRFC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroClienteRFC.MaxLength = 13;
            this.textBoxRegistroClienteRFC.Name = "textBoxRegistroClienteRFC";
            this.textBoxRegistroClienteRFC.Size = new System.Drawing.Size(272, 30);
            this.textBoxRegistroClienteRFC.TabIndex = 91;
            this.textBoxRegistroClienteRFC.TextChanged += new System.EventHandler(this.textBoxRegistroClienteRFC_TextChanged);
            // 
            // textBoxRegistroClienteCorreo
            // 
            this.textBoxRegistroClienteCorreo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroClienteCorreo.Location = new System.Drawing.Point(246, 340);
            this.textBoxRegistroClienteCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroClienteCorreo.MaxLength = 50;
            this.textBoxRegistroClienteCorreo.Name = "textBoxRegistroClienteCorreo";
            this.textBoxRegistroClienteCorreo.Size = new System.Drawing.Size(679, 30);
            this.textBoxRegistroClienteCorreo.TabIndex = 90;
            // 
            // textBoxRegistroClienteDomicilio
            // 
            this.textBoxRegistroClienteDomicilio.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroClienteDomicilio.Location = new System.Drawing.Point(246, 293);
            this.textBoxRegistroClienteDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroClienteDomicilio.MaxLength = 100;
            this.textBoxRegistroClienteDomicilio.Name = "textBoxRegistroClienteDomicilio";
            this.textBoxRegistroClienteDomicilio.Size = new System.Drawing.Size(679, 30);
            this.textBoxRegistroClienteDomicilio.TabIndex = 89;
            // 
            // textBoxRegistroClienteNombre
            // 
            this.textBoxRegistroClienteNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroClienteNombre.Location = new System.Drawing.Point(245, 247);
            this.textBoxRegistroClienteNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroClienteNombre.MaxLength = 50;
            this.textBoxRegistroClienteNombre.Name = "textBoxRegistroClienteNombre";
            this.textBoxRegistroClienteNombre.Size = new System.Drawing.Size(680, 30);
            this.textBoxRegistroClienteNombre.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 98;
            this.label9.Text = "RFC Cliente";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(30, 344);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(58, 21);
            this.label75.TabIndex = 97;
            this.label75.Text = "Correo";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(29, 297);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(76, 21);
            this.label76.TabIndex = 96;
            this.label76.Text = "Domicilio";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(29, 251);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(85, 21);
            this.label77.TabIndex = 95;
            this.label77.Text = "Nombre(s)";
            // 
            // buttonRegistroClienteRegistrarModificar
            // 
            this.buttonRegistroClienteRegistrarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroClienteRegistrarModificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroClienteRegistrarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroClienteRegistrarModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroClienteRegistrarModificar.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroClienteRegistrarModificar.Location = new System.Drawing.Point(472, 477);
            this.buttonRegistroClienteRegistrarModificar.Name = "buttonRegistroClienteRegistrarModificar";
            this.buttonRegistroClienteRegistrarModificar.Size = new System.Drawing.Size(257, 51);
            this.buttonRegistroClienteRegistrarModificar.TabIndex = 92;
            this.buttonRegistroClienteRegistrarModificar.Text = "Guardar Cambios";
            this.buttonRegistroClienteRegistrarModificar.UseVisualStyleBackColor = false;
            this.buttonRegistroClienteRegistrarModificar.Click += new System.EventHandler(this.buttonRegistroClienteRegistrarModificar_Click);
            // 
            // buttonRegistroClienteRegresar
            // 
            this.buttonRegistroClienteRegresar.BackColor = System.Drawing.Color.White;
            this.buttonRegistroClienteRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroClienteRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroClienteRegresar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroClienteRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroClienteRegresar.Location = new System.Drawing.Point(161, 477);
            this.buttonRegistroClienteRegresar.Name = "buttonRegistroClienteRegresar";
            this.buttonRegistroClienteRegresar.Size = new System.Drawing.Size(241, 51);
            this.buttonRegistroClienteRegresar.TabIndex = 93;
            this.buttonRegistroClienteRegresar.Text = "Registro Venta";
            this.buttonRegistroClienteRegresar.UseVisualStyleBackColor = false;
            this.buttonRegistroClienteRegresar.Click += new System.EventHandler(this.buttonRegistroClienteRegresar_Click);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.White;
            this.label78.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label78.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label78.Location = new System.Drawing.Point(337, 25);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(306, 47);
            this.label78.TabIndex = 94;
            this.label78.Text = "Registro de cliente";
            // 
            // tabPageRegistrarVenta
            // 
            this.tabPageRegistrarVenta.BackColor = System.Drawing.Color.White;
            this.tabPageRegistrarVenta.Controls.Add(this.checkBoxRegistrarVentaFactura);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistroVentaFolio);
            this.tabPageRegistrarVenta.Controls.Add(this.label8);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistroVentaFecha);
            this.tabPageRegistrarVenta.Controls.Add(this.label15);
            this.tabPageRegistrarVenta.Controls.Add(this.numericUpDownRegistroVentaCodigoBarras);
            this.tabPageRegistrarVenta.Controls.Add(this.label60);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistroVentaCliente);
            this.tabPageRegistrarVenta.Controls.Add(this.label112);
            this.tabPageRegistrarVenta.Controls.Add(this.label111);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistrarVentaDatoCambio);
            this.tabPageRegistrarVenta.Controls.Add(this.label103);
            this.tabPageRegistrarVenta.Controls.Add(this.label104);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistrarVentaDatoTotal);
            this.tabPageRegistrarVenta.Controls.Add(this.label106);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistrarVentaDatoIva);
            this.tabPageRegistrarVenta.Controls.Add(this.label108);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistrarVentaDatoSubtotal);
            this.tabPageRegistrarVenta.Controls.Add(this.label110);
            this.tabPageRegistrarVenta.Controls.Add(this.labelRegistrarVentaDatoCantidadDeArticulos);
            this.tabPageRegistrarVenta.Controls.Add(this.label101);
            this.tabPageRegistrarVenta.Controls.Add(this.numericUpDownRegistrarVentaRecibido);
            this.tabPageRegistrarVenta.Controls.Add(this.label17);
            this.tabPageRegistrarVenta.Controls.Add(this.label16);
            this.tabPageRegistrarVenta.Controls.Add(this.label1);
            this.tabPageRegistrarVenta.Controls.Add(this.buttonRegistrarVentaRegistrarVenta);
            this.tabPageRegistrarVenta.Controls.Add(this.buttonRegistrarVentaCancelarVenta);
            this.tabPageRegistrarVenta.Controls.Add(this.buttonRegistrarVentaBuscarCliente);
            this.tabPageRegistrarVenta.Controls.Add(this.label12);
            this.tabPageRegistrarVenta.Controls.Add(this.label22);
            this.tabPageRegistrarVenta.Controls.Add(this.textBoxRegistrarVentaRFCCliente);
            this.tabPageRegistrarVenta.Controls.Add(this.buttonRegistrarVentaRegistrarCliente);
            this.tabPageRegistrarVenta.Controls.Add(this.dataGridViewRegistrarVentaProductos);
            this.tabPageRegistrarVenta.Controls.Add(this.label23);
            this.tabPageRegistrarVenta.Controls.Add(this.buttonRegistrarVentaRegistrarCodigoBarras);
            this.tabPageRegistrarVenta.Controls.Add(this.label11);
            this.tabPageRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRegistrarVenta.Location = new System.Drawing.Point(4, 5);
            this.tabPageRegistrarVenta.Name = "tabPageRegistrarVenta";
            this.tabPageRegistrarVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarVenta.Size = new System.Drawing.Size(954, 562);
            this.tabPageRegistrarVenta.TabIndex = 0;
            this.tabPageRegistrarVenta.Text = "RegVent";
            // 
            // labelRegistroVentaFolio
            // 
            this.labelRegistroVentaFolio.AutoSize = true;
            this.labelRegistroVentaFolio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroVentaFolio.Location = new System.Drawing.Point(581, 92);
            this.labelRegistroVentaFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistroVentaFolio.Name = "labelRegistroVentaFolio";
            this.labelRegistroVentaFolio.Size = new System.Drawing.Size(0, 25);
            this.labelRegistroVentaFolio.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(512, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 124;
            this.label8.Text = "Folio:";
            // 
            // labelRegistroVentaFecha
            // 
            this.labelRegistroVentaFecha.AutoSize = true;
            this.labelRegistroVentaFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroVentaFecha.Location = new System.Drawing.Point(573, 123);
            this.labelRegistroVentaFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistroVentaFecha.Name = "labelRegistroVentaFecha";
            this.labelRegistroVentaFecha.Size = new System.Drawing.Size(0, 25);
            this.labelRegistroVentaFecha.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label15.Location = new System.Drawing.Point(504, 123);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 25);
            this.label15.TabIndex = 122;
            this.label15.Text = "Fecha:";
            // 
            // numericUpDownRegistroVentaCodigoBarras
            // 
            this.numericUpDownRegistroVentaCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroVentaCodigoBarras.Location = new System.Drawing.Point(178, 123);
            this.numericUpDownRegistroVentaCodigoBarras.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownRegistroVentaCodigoBarras.Name = "numericUpDownRegistroVentaCodigoBarras";
            this.numericUpDownRegistroVentaCodigoBarras.Size = new System.Drawing.Size(269, 29);
            this.numericUpDownRegistroVentaCodigoBarras.TabIndex = 115;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(601, 47);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(112, 25);
            this.label60.TabIndex = 83;
            this.label60.Text = "RFC Cliente:";
            // 
            // labelRegistroVentaCliente
            // 
            this.labelRegistroVentaCliente.AutoSize = true;
            this.labelRegistroVentaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroVentaCliente.Location = new System.Drawing.Point(616, 14);
            this.labelRegistroVentaCliente.Name = "labelRegistroVentaCliente";
            this.labelRegistroVentaCliente.Size = new System.Drawing.Size(237, 20);
            this.labelRegistroVentaCliente.TabIndex = 82;
            this.labelRegistroVentaCliente.Text = "Cliente de mostrador RFC = 001";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(173, 92);
            this.label112.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(161, 25);
            this.label112.TabIndex = 81;
            this.label112.Text = "Codigo de barras:";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.BackColor = System.Drawing.Color.White;
            this.label111.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label111.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label111.Location = new System.Drawing.Point(11, 14);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(254, 47);
            this.label111.TabIndex = 80;
            this.label111.Text = "Registrar Venta";
            // 
            // labelRegistrarVentaDatoCambio
            // 
            this.labelRegistrarVentaDatoCambio.AutoSize = true;
            this.labelRegistrarVentaDatoCambio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentaDatoCambio.Location = new System.Drawing.Point(849, 370);
            this.labelRegistrarVentaDatoCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarVentaDatoCambio.Name = "labelRegistrarVentaDatoCambio";
            this.labelRegistrarVentaDatoCambio.Size = new System.Drawing.Size(46, 25);
            this.labelRegistrarVentaDatoCambio.TabIndex = 67;
            this.labelRegistrarVentaDatoCambio.Text = "0.00";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(720, 370);
            this.label103.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(81, 25);
            this.label103.TabIndex = 66;
            this.label103.Text = "Cambio:";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(713, 325);
            this.label104.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(88, 25);
            this.label104.TabIndex = 65;
            this.label104.Text = "Recibido:";
            // 
            // labelRegistrarVentaDatoTotal
            // 
            this.labelRegistrarVentaDatoTotal.AutoSize = true;
            this.labelRegistrarVentaDatoTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentaDatoTotal.Location = new System.Drawing.Point(849, 288);
            this.labelRegistrarVentaDatoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarVentaDatoTotal.Name = "labelRegistrarVentaDatoTotal";
            this.labelRegistrarVentaDatoTotal.Size = new System.Drawing.Size(46, 25);
            this.labelRegistrarVentaDatoTotal.TabIndex = 64;
            this.labelRegistrarVentaDatoTotal.Text = "0.00";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label106.Location = new System.Drawing.Point(747, 288);
            this.label106.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(56, 25);
            this.label106.TabIndex = 63;
            this.label106.Text = "Total:";
            // 
            // labelRegistrarVentaDatoIva
            // 
            this.labelRegistrarVentaDatoIva.AutoSize = true;
            this.labelRegistrarVentaDatoIva.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentaDatoIva.Location = new System.Drawing.Point(849, 253);
            this.labelRegistrarVentaDatoIva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarVentaDatoIva.Name = "labelRegistrarVentaDatoIva";
            this.labelRegistrarVentaDatoIva.Size = new System.Drawing.Size(46, 25);
            this.labelRegistrarVentaDatoIva.TabIndex = 62;
            this.labelRegistrarVentaDatoIva.Text = "0.00";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label108.Location = new System.Drawing.Point(763, 253);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(40, 25);
            this.label108.TabIndex = 61;
            this.label108.Text = "Iva:";
            // 
            // labelRegistrarVentaDatoSubtotal
            // 
            this.labelRegistrarVentaDatoSubtotal.AutoSize = true;
            this.labelRegistrarVentaDatoSubtotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentaDatoSubtotal.Location = new System.Drawing.Point(849, 222);
            this.labelRegistrarVentaDatoSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarVentaDatoSubtotal.Name = "labelRegistrarVentaDatoSubtotal";
            this.labelRegistrarVentaDatoSubtotal.Size = new System.Drawing.Size(46, 25);
            this.labelRegistrarVentaDatoSubtotal.TabIndex = 60;
            this.labelRegistrarVentaDatoSubtotal.Text = "0.00";
            this.labelRegistrarVentaDatoSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label110.Location = new System.Drawing.Point(715, 222);
            this.label110.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(86, 25);
            this.label110.TabIndex = 59;
            this.label110.Text = "Subtotal:";
            // 
            // labelRegistrarVentaDatoCantidadDeArticulos
            // 
            this.labelRegistrarVentaDatoCantidadDeArticulos.AutoSize = true;
            this.labelRegistrarVentaDatoCantidadDeArticulos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarVentaDatoCantidadDeArticulos.Location = new System.Drawing.Point(610, 506);
            this.labelRegistrarVentaDatoCantidadDeArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarVentaDatoCantidadDeArticulos.Name = "labelRegistrarVentaDatoCantidadDeArticulos";
            this.labelRegistrarVentaDatoCantidadDeArticulos.Size = new System.Drawing.Size(22, 25);
            this.labelRegistrarVentaDatoCantidadDeArticulos.TabIndex = 58;
            this.labelRegistrarVentaDatoCantidadDeArticulos.Text = "0";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label101.Location = new System.Drawing.Point(411, 506);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(195, 25);
            this.label101.TabIndex = 57;
            this.label101.Text = "Cantidad de articulos:";
            // 
            // numericUpDownRegistrarVentaRecibido
            // 
            this.numericUpDownRegistrarVentaRecibido.DecimalPlaces = 2;
            this.numericUpDownRegistrarVentaRecibido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistrarVentaRecibido.Location = new System.Drawing.Point(811, 323);
            this.numericUpDownRegistrarVentaRecibido.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRegistrarVentaRecibido.Name = "numericUpDownRegistrarVentaRecibido";
            this.numericUpDownRegistrarVentaRecibido.Size = new System.Drawing.Size(124, 33);
            this.numericUpDownRegistrarVentaRecibido.TabIndex = 5;
            this.numericUpDownRegistrarVentaRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRegistrarVentaRecibido.ValueChanged += new System.EventHandler(this.numericUpDownRegistrarVentaRecibido_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(847, 259);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 25);
            this.label17.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label16.Location = new System.Drawing.Point(747, 224);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 25);
            this.label16.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, -125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 46;
            // 
            // buttonRegistrarVentaRegistrarVenta
            // 
            this.buttonRegistrarVentaRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistrarVentaRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistrarVentaRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarVentaRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVentaRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarVentaRegistrarVenta.Location = new System.Drawing.Point(702, 448);
            this.buttonRegistrarVentaRegistrarVenta.Name = "buttonRegistrarVentaRegistrarVenta";
            this.buttonRegistrarVentaRegistrarVenta.Size = new System.Drawing.Size(241, 44);
            this.buttonRegistrarVentaRegistrarVenta.TabIndex = 7;
            this.buttonRegistrarVentaRegistrarVenta.Text = "Registrar Venta";
            this.buttonRegistrarVentaRegistrarVenta.UseVisualStyleBackColor = false;
            this.buttonRegistrarVentaRegistrarVenta.Click += new System.EventHandler(this.buttonRegistrarVentaRegistrarVenta_Click);
            // 
            // buttonRegistrarVentaCancelarVenta
            // 
            this.buttonRegistrarVentaCancelarVenta.BackColor = System.Drawing.Color.White;
            this.buttonRegistrarVentaCancelarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistrarVentaCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarVentaCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVentaCancelarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistrarVentaCancelarVenta.Location = new System.Drawing.Point(702, 498);
            this.buttonRegistrarVentaCancelarVenta.Name = "buttonRegistrarVentaCancelarVenta";
            this.buttonRegistrarVentaCancelarVenta.Size = new System.Drawing.Size(241, 41);
            this.buttonRegistrarVentaCancelarVenta.TabIndex = 8;
            this.buttonRegistrarVentaCancelarVenta.Text = "Cancelar";
            this.buttonRegistrarVentaCancelarVenta.UseVisualStyleBackColor = false;
            this.buttonRegistrarVentaCancelarVenta.Click += new System.EventHandler(this.buttonRegistrarVentaCancelarVenta_Click);
            // 
            // buttonRegistrarVentaBuscarCliente
            // 
            this.buttonRegistrarVentaBuscarCliente.BackColor = System.Drawing.Color.White;
            this.buttonRegistrarVentaBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistrarVentaBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarVentaBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVentaBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistrarVentaBuscarCliente.Location = new System.Drawing.Point(723, 79);
            this.buttonRegistrarVentaBuscarCliente.Name = "buttonRegistrarVentaBuscarCliente";
            this.buttonRegistrarVentaBuscarCliente.Size = new System.Drawing.Size(220, 38);
            this.buttonRegistrarVentaBuscarCliente.TabIndex = 8;
            this.buttonRegistrarVentaBuscarCliente.Text = "Buscar Cliente";
            this.buttonRegistrarVentaBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonRegistrarVentaBuscarCliente.Click += new System.EventHandler(this.buttonRegistrarVentaBuscarCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label12.Location = new System.Drawing.Point(2, 523);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(650, 21);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 25);
            this.label22.TabIndex = 40;
            // 
            // textBoxRegistrarVentaRFCCliente
            // 
            this.textBoxRegistrarVentaRFCCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistrarVentaRFCCliente.Location = new System.Drawing.Point(723, 44);
            this.textBoxRegistrarVentaRFCCliente.MaxLength = 13;
            this.textBoxRegistrarVentaRFCCliente.Multiline = true;
            this.textBoxRegistrarVentaRFCCliente.Name = "textBoxRegistrarVentaRFCCliente";
            this.textBoxRegistrarVentaRFCCliente.Size = new System.Drawing.Size(220, 29);
            this.textBoxRegistrarVentaRFCCliente.TabIndex = 3;
            this.textBoxRegistrarVentaRFCCliente.Text = "001";
            // 
            // buttonRegistrarVentaRegistrarCliente
            // 
            this.buttonRegistrarVentaRegistrarCliente.BackColor = System.Drawing.Color.White;
            this.buttonRegistrarVentaRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistrarVentaRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarVentaRegistrarCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVentaRegistrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistrarVentaRegistrarCliente.Location = new System.Drawing.Point(289, 14);
            this.buttonRegistrarVentaRegistrarCliente.Name = "buttonRegistrarVentaRegistrarCliente";
            this.buttonRegistrarVentaRegistrarCliente.Size = new System.Drawing.Size(280, 34);
            this.buttonRegistrarVentaRegistrarCliente.TabIndex = 4;
            this.buttonRegistrarVentaRegistrarCliente.Text = "Registrar / Modificar Cliente";
            this.buttonRegistrarVentaRegistrarCliente.UseVisualStyleBackColor = false;
            this.buttonRegistrarVentaRegistrarCliente.Click += new System.EventHandler(this.buttonRegistrarVentaRegistrarCliente_Click);
            // 
            // dataGridViewRegistrarVentaProductos
            // 
            this.dataGridViewRegistrarVentaProductos.AllowUserToAddRows = false;
            this.dataGridViewRegistrarVentaProductos.AllowUserToOrderColumns = true;
            this.dataGridViewRegistrarVentaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRegistrarVentaProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewRegistrarVentaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrarVentaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoVenta,
            this.nombreProductoVenta,
            this.precioProductoVenta,
            this.cantidadProductoVenta,
            this.totalProductoVenta});
            this.dataGridViewRegistrarVentaProductos.Location = new System.Drawing.Point(8, 158);
            this.dataGridViewRegistrarVentaProductos.Name = "dataGridViewRegistrarVentaProductos";
            this.dataGridViewRegistrarVentaProductos.RowHeadersWidth = 51;
            this.dataGridViewRegistrarVentaProductos.Size = new System.Drawing.Size(677, 336);
            this.dataGridViewRegistrarVentaProductos.TabIndex = 37;
            this.dataGridViewRegistrarVentaProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRegistrarVentaProductos_CellMouseDoubleClick);
            // 
            // codigoProductoVenta
            // 
            this.codigoProductoVenta.HeaderText = "Código";
            this.codigoProductoVenta.MinimumWidth = 6;
            this.codigoProductoVenta.Name = "codigoProductoVenta";
            this.codigoProductoVenta.Width = 125;
            // 
            // nombreProductoVenta
            // 
            this.nombreProductoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProductoVenta.HeaderText = "Producto";
            this.nombreProductoVenta.MinimumWidth = 6;
            this.nombreProductoVenta.Name = "nombreProductoVenta";
            // 
            // precioProductoVenta
            // 
            this.precioProductoVenta.HeaderText = "Precio c/u";
            this.precioProductoVenta.MinimumWidth = 6;
            this.precioProductoVenta.Name = "precioProductoVenta";
            this.precioProductoVenta.Width = 125;
            // 
            // cantidadProductoVenta
            // 
            this.cantidadProductoVenta.HeaderText = "Cantidad";
            this.cantidadProductoVenta.MinimumWidth = 6;
            this.cantidadProductoVenta.Name = "cantidadProductoVenta";
            this.cantidadProductoVenta.Width = 125;
            // 
            // totalProductoVenta
            // 
            this.totalProductoVenta.HeaderText = "Total";
            this.totalProductoVenta.MinimumWidth = 6;
            this.totalProductoVenta.Name = "totalProductoVenta";
            this.totalProductoVenta.Width = 125;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(173, 48);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 25);
            this.label23.TabIndex = 35;
            // 
            // buttonRegistrarVentaRegistrarCodigoBarras
            // 
            this.buttonRegistrarVentaRegistrarCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistrarVentaRegistrarCodigoBarras.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistrarVentaRegistrarCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarVentaRegistrarCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVentaRegistrarCodigoBarras.ForeColor = System.Drawing.Color.White;
            this.buttonRegistrarVentaRegistrarCodigoBarras.Location = new System.Drawing.Point(14, 119);
            this.buttonRegistrarVentaRegistrarCodigoBarras.Name = "buttonRegistrarVentaRegistrarCodigoBarras";
            this.buttonRegistrarVentaRegistrarCodigoBarras.Size = new System.Drawing.Size(155, 33);
            this.buttonRegistrarVentaRegistrarCodigoBarras.TabIndex = 2;
            this.buttonRegistrarVentaRegistrarCodigoBarras.Text = "Registrar";
            this.buttonRegistrarVentaRegistrarCodigoBarras.UseVisualStyleBackColor = false;
            this.buttonRegistrarVentaRegistrarCodigoBarras.Click += new System.EventHandler(this.buttonRegistrarVentaRegistrarCodigoBarras_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label11.Location = new System.Drawing.Point(7, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 32;
            // 
            // tabPageRegistrarBajaProducto
            // 
            this.tabPageRegistrarBajaProducto.BackColor = System.Drawing.Color.White;
            this.tabPageRegistrarBajaProducto.Controls.Add(this.buttonRegistroBajaCancelar);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.labelRegistroBajaFolio);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label6);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.labelRegistroBajaFecha);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label115);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.numericUpDownRegistroDeBajaCodigoBarras);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label97);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label96);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.textBoxRegistroDeBajaMotivo);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.numericUpDownRegistroDeBajaCantidadProducto);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.dataGridViewRegistroDeBajaBajas);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label94);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.buttonRegistroDeBajaRegistrarProducto);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.buttonRegistroDeBajaRegistrarBaja);
            this.tabPageRegistrarBajaProducto.Controls.Add(this.label95);
            this.tabPageRegistrarBajaProducto.Location = new System.Drawing.Point(4, 5);
            this.tabPageRegistrarBajaProducto.Name = "tabPageRegistrarBajaProducto";
            this.tabPageRegistrarBajaProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarBajaProducto.Size = new System.Drawing.Size(954, 562);
            this.tabPageRegistrarBajaProducto.TabIndex = 17;
            this.tabPageRegistrarBajaProducto.Text = "RegBaja";
            // 
            // buttonRegistroBajaCancelar
            // 
            this.buttonRegistroBajaCancelar.BackColor = System.Drawing.Color.White;
            this.buttonRegistroBajaCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroBajaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroBajaCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroBajaCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroBajaCancelar.Location = new System.Drawing.Point(486, 491);
            this.buttonRegistroBajaCancelar.Name = "buttonRegistroBajaCancelar";
            this.buttonRegistroBajaCancelar.Size = new System.Drawing.Size(246, 48);
            this.buttonRegistroBajaCancelar.TabIndex = 122;
            this.buttonRegistroBajaCancelar.Text = "Cancelar";
            this.buttonRegistroBajaCancelar.UseVisualStyleBackColor = false;
            this.buttonRegistroBajaCancelar.Click += new System.EventHandler(this.buttonRegistroBajaCancelar_Click);
            // 
            // labelRegistroBajaFolio
            // 
            this.labelRegistroBajaFolio.AutoSize = true;
            this.labelRegistroBajaFolio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroBajaFolio.Location = new System.Drawing.Point(87, 3);
            this.labelRegistroBajaFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistroBajaFolio.Name = "labelRegistroBajaFolio";
            this.labelRegistroBajaFolio.Size = new System.Drawing.Size(22, 25);
            this.labelRegistroBajaFolio.TabIndex = 121;
            this.labelRegistroBajaFolio.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(18, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 120;
            this.label6.Text = "Folio:";
            // 
            // labelRegistroBajaFecha
            // 
            this.labelRegistroBajaFecha.AutoSize = true;
            this.labelRegistroBajaFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroBajaFecha.Location = new System.Drawing.Point(819, 131);
            this.labelRegistroBajaFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistroBajaFecha.Name = "labelRegistroBajaFecha";
            this.labelRegistroBajaFecha.Size = new System.Drawing.Size(106, 25);
            this.labelRegistroBajaFecha.TabIndex = 119;
            this.labelRegistroBajaFecha.Text = "24/12/2020";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.label115.Location = new System.Drawing.Point(750, 131);
            this.label115.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(65, 25);
            this.label115.TabIndex = 118;
            this.label115.Text = "Fecha:";
            // 
            // numericUpDownRegistroDeBajaCodigoBarras
            // 
            this.numericUpDownRegistroDeBajaCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroDeBajaCodigoBarras.Location = new System.Drawing.Point(10, 70);
            this.numericUpDownRegistroDeBajaCodigoBarras.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownRegistroDeBajaCodigoBarras.Name = "numericUpDownRegistroDeBajaCodigoBarras";
            this.numericUpDownRegistroDeBajaCodigoBarras.Size = new System.Drawing.Size(269, 29);
            this.numericUpDownRegistroDeBajaCodigoBarras.TabIndex = 114;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(7, 104);
            this.label97.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(62, 21);
            this.label97.TabIndex = 107;
            this.label97.Text = "Motivo:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(309, 41);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(163, 21);
            this.label96.TabIndex = 106;
            this.label96.Text = "Cantidad de producto:";
            // 
            // textBoxRegistroDeBajaMotivo
            // 
            this.textBoxRegistroDeBajaMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeBajaMotivo.Location = new System.Drawing.Point(8, 131);
            this.textBoxRegistroDeBajaMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeBajaMotivo.Multiline = true;
            this.textBoxRegistroDeBajaMotivo.Name = "textBoxRegistroDeBajaMotivo";
            this.textBoxRegistroDeBajaMotivo.Size = new System.Drawing.Size(724, 109);
            this.textBoxRegistroDeBajaMotivo.TabIndex = 3;
            // 
            // numericUpDownRegistroDeBajaCantidadProducto
            // 
            this.numericUpDownRegistroDeBajaCantidadProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroDeBajaCantidadProducto.Location = new System.Drawing.Point(314, 70);
            this.numericUpDownRegistroDeBajaCantidadProducto.Name = "numericUpDownRegistroDeBajaCantidadProducto";
            this.numericUpDownRegistroDeBajaCantidadProducto.Size = new System.Drawing.Size(157, 29);
            this.numericUpDownRegistroDeBajaCantidadProducto.TabIndex = 2;
            // 
            // dataGridViewRegistroDeBajaBajas
            // 
            this.dataGridViewRegistroDeBajaBajas.AllowUserToAddRows = false;
            this.dataGridViewRegistroDeBajaBajas.AllowUserToOrderColumns = true;
            this.dataGridViewRegistroDeBajaBajas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRegistroDeBajaBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistroDeBajaBajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarrasProductoBaja,
            this.nombreProductoBajas,
            this.cantidadProductoBajas,
            this.comentarioProductoBajas});
            this.dataGridViewRegistroDeBajaBajas.Location = new System.Drawing.Point(8, 244);
            this.dataGridViewRegistroDeBajaBajas.Name = "dataGridViewRegistroDeBajaBajas";
            this.dataGridViewRegistroDeBajaBajas.RowHeadersWidth = 51;
            this.dataGridViewRegistroDeBajaBajas.Size = new System.Drawing.Size(942, 218);
            this.dataGridViewRegistroDeBajaBajas.TabIndex = 102;
            this.dataGridViewRegistroDeBajaBajas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRegistroDeBajaBajas_CellMouseDoubleClick);
            // 
            // codigoBarrasProductoBaja
            // 
            this.codigoBarrasProductoBaja.HeaderText = "Código";
            this.codigoBarrasProductoBaja.MinimumWidth = 6;
            this.codigoBarrasProductoBaja.Name = "codigoBarrasProductoBaja";
            this.codigoBarrasProductoBaja.Width = 125;
            // 
            // nombreProductoBajas
            // 
            this.nombreProductoBajas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProductoBajas.HeaderText = "Nombre";
            this.nombreProductoBajas.MinimumWidth = 6;
            this.nombreProductoBajas.Name = "nombreProductoBajas";
            // 
            // cantidadProductoBajas
            // 
            this.cantidadProductoBajas.HeaderText = "Cantidad";
            this.cantidadProductoBajas.MinimumWidth = 6;
            this.cantidadProductoBajas.Name = "cantidadProductoBajas";
            this.cantidadProductoBajas.Width = 125;
            // 
            // comentarioProductoBajas
            // 
            this.comentarioProductoBajas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentarioProductoBajas.HeaderText = "Comentario";
            this.comentarioProductoBajas.MinimumWidth = 6;
            this.comentarioProductoBajas.Name = "comentarioProductoBajas";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(7, 41);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(199, 21);
            this.label94.TabIndex = 101;
            this.label94.Text = "Codigo de barras producto:";
            // 
            // buttonRegistroDeBajaRegistrarProducto
            // 
            this.buttonRegistroDeBajaRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroDeBajaRegistrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroDeBajaRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroDeBajaRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroDeBajaRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroDeBajaRegistrarProducto.Location = new System.Drawing.Point(751, 193);
            this.buttonRegistroDeBajaRegistrarProducto.Name = "buttonRegistroDeBajaRegistrarProducto";
            this.buttonRegistroDeBajaRegistrarProducto.Size = new System.Drawing.Size(183, 45);
            this.buttonRegistroDeBajaRegistrarProducto.TabIndex = 4;
            this.buttonRegistroDeBajaRegistrarProducto.Text = "Registrar";
            this.buttonRegistroDeBajaRegistrarProducto.UseVisualStyleBackColor = false;
            this.buttonRegistroDeBajaRegistrarProducto.Click += new System.EventHandler(this.buttonRegistroDeBajaRegistrarProducto_Click);
            // 
            // buttonRegistroDeBajaRegistrarBaja
            // 
            this.buttonRegistroDeBajaRegistrarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroDeBajaRegistrarBaja.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroDeBajaRegistrarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroDeBajaRegistrarBaja.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroDeBajaRegistrarBaja.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroDeBajaRegistrarBaja.Location = new System.Drawing.Point(230, 491);
            this.buttonRegistroDeBajaRegistrarBaja.Name = "buttonRegistroDeBajaRegistrarBaja";
            this.buttonRegistroDeBajaRegistrarBaja.Size = new System.Drawing.Size(241, 51);
            this.buttonRegistroDeBajaRegistrarBaja.TabIndex = 5;
            this.buttonRegistroDeBajaRegistrarBaja.Text = "Registrar Baja";
            this.buttonRegistroDeBajaRegistrarBaja.UseVisualStyleBackColor = false;
            this.buttonRegistroDeBajaRegistrarBaja.Click += new System.EventHandler(this.buttonRegistroDeBajaRegistrarBaja_Click);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.Color.White;
            this.label95.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label95.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label95.Location = new System.Drawing.Point(693, 0);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(281, 94);
            this.label95.TabIndex = 96;
            this.label95.Text = "Registro de baja \r\nde producto";
            // 
            // tabPageRegistrarProducto
            // 
            this.tabPageRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.tabPageRegistrarProducto.Controls.Add(this.numericUpDownRegistroDeProductoCodigoBarras);
            this.tabPageRegistrarProducto.Controls.Add(this.numericUpDownRegistroDeProductoExistencia);
            this.tabPageRegistrarProducto.Controls.Add(this.label27);
            this.tabPageRegistrarProducto.Controls.Add(this.numericUpDownRegistroDeProductoPrecioPublico);
            this.tabPageRegistrarProducto.Controls.Add(this.label34);
            this.tabPageRegistrarProducto.Controls.Add(this.textBoxRegistroDeProductoDescripcion);
            this.tabPageRegistrarProducto.Controls.Add(this.textBoxRegistroDeProductoNombreProducto);
            this.tabPageRegistrarProducto.Controls.Add(this.label26);
            this.tabPageRegistrarProducto.Controls.Add(this.label30);
            this.tabPageRegistrarProducto.Controls.Add(this.label32);
            this.tabPageRegistrarProducto.Controls.Add(this.buttonRegistroDeProductoRegistrarProducto);
            this.tabPageRegistrarProducto.Controls.Add(this.label5);
            this.tabPageRegistrarProducto.Location = new System.Drawing.Point(4, 5);
            this.tabPageRegistrarProducto.Name = "tabPageRegistrarProducto";
            this.tabPageRegistrarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarProducto.Size = new System.Drawing.Size(954, 562);
            this.tabPageRegistrarProducto.TabIndex = 3;
            this.tabPageRegistrarProducto.Text = "RegProd";
            // 
            // numericUpDownRegistroDeProductoCodigoBarras
            // 
            this.numericUpDownRegistroDeProductoCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroDeProductoCodigoBarras.Location = new System.Drawing.Point(251, 105);
            this.numericUpDownRegistroDeProductoCodigoBarras.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDownRegistroDeProductoCodigoBarras.Name = "numericUpDownRegistroDeProductoCodigoBarras";
            this.numericUpDownRegistroDeProductoCodigoBarras.Size = new System.Drawing.Size(269, 29);
            this.numericUpDownRegistroDeProductoCodigoBarras.TabIndex = 100;
            // 
            // numericUpDownRegistroDeProductoExistencia
            // 
            this.numericUpDownRegistroDeProductoExistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroDeProductoExistencia.Location = new System.Drawing.Point(251, 394);
            this.numericUpDownRegistroDeProductoExistencia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRegistroDeProductoExistencia.Name = "numericUpDownRegistroDeProductoExistencia";
            this.numericUpDownRegistroDeProductoExistencia.Size = new System.Drawing.Size(150, 29);
            this.numericUpDownRegistroDeProductoExistencia.TabIndex = 5;
            this.numericUpDownRegistroDeProductoExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(36, 394);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 21);
            this.label27.TabIndex = 99;
            this.label27.Text = "Existencia:";
            // 
            // numericUpDownRegistroDeProductoPrecioPublico
            // 
            this.numericUpDownRegistroDeProductoPrecioPublico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRegistroDeProductoPrecioPublico.Location = new System.Drawing.Point(251, 345);
            this.numericUpDownRegistroDeProductoPrecioPublico.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRegistroDeProductoPrecioPublico.Name = "numericUpDownRegistroDeProductoPrecioPublico";
            this.numericUpDownRegistroDeProductoPrecioPublico.Size = new System.Drawing.Size(150, 29);
            this.numericUpDownRegistroDeProductoPrecioPublico.TabIndex = 4;
            this.numericUpDownRegistroDeProductoPrecioPublico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(36, 109);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(129, 21);
            this.label34.TabIndex = 97;
            this.label34.Text = "Código de barras";
            // 
            // textBoxRegistroDeProductoDescripcion
            // 
            this.textBoxRegistroDeProductoDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeProductoDescripcion.Location = new System.Drawing.Point(251, 210);
            this.textBoxRegistroDeProductoDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeProductoDescripcion.MaxLength = 255;
            this.textBoxRegistroDeProductoDescripcion.Multiline = true;
            this.textBoxRegistroDeProductoDescripcion.Name = "textBoxRegistroDeProductoDescripcion";
            this.textBoxRegistroDeProductoDescripcion.Size = new System.Drawing.Size(675, 119);
            this.textBoxRegistroDeProductoDescripcion.TabIndex = 3;
            // 
            // textBoxRegistroDeProductoNombreProducto
            // 
            this.textBoxRegistroDeProductoNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeProductoNombreProducto.Location = new System.Drawing.Point(251, 158);
            this.textBoxRegistroDeProductoNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeProductoNombreProducto.MaxLength = 50;
            this.textBoxRegistroDeProductoNombreProducto.Name = "textBoxRegistroDeProductoNombreProducto";
            this.textBoxRegistroDeProductoNombreProducto.Size = new System.Drawing.Size(675, 29);
            this.textBoxRegistroDeProductoNombreProducto.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(34, 213);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 21);
            this.label26.TabIndex = 95;
            this.label26.Text = "Descripcion";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(36, 348);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(120, 21);
            this.label30.TabIndex = 92;
            this.label30.Text = "Precio a público";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(36, 166);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(156, 21);
            this.label32.TabIndex = 89;
            this.label32.Text = "Nombre de Producto";
            // 
            // buttonRegistroDeProductoRegistrarProducto
            // 
            this.buttonRegistroDeProductoRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroDeProductoRegistrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroDeProductoRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroDeProductoRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroDeProductoRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroDeProductoRegistrarProducto.Location = new System.Drawing.Point(383, 485);
            this.buttonRegistroDeProductoRegistrarProducto.Name = "buttonRegistroDeProductoRegistrarProducto";
            this.buttonRegistroDeProductoRegistrarProducto.Size = new System.Drawing.Size(241, 51);
            this.buttonRegistroDeProductoRegistrarProducto.TabIndex = 7;
            this.buttonRegistroDeProductoRegistrarProducto.Text = "Registrar Producto";
            this.buttonRegistroDeProductoRegistrarProducto.UseVisualStyleBackColor = false;
            this.buttonRegistroDeProductoRegistrarProducto.Click += new System.EventHandler(this.buttonRegistroDeProductoRegistrarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label5.Location = new System.Drawing.Point(274, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 47);
            this.label5.TabIndex = 67;
            this.label5.Text = "Registro de producto";
            // 
            // tabPageRegistrarEmpleado
            // 
            this.tabPageRegistrarEmpleado.BackColor = System.Drawing.Color.White;
            this.tabPageRegistrarEmpleado.Controls.Add(this.comboBoxRegistroDeEmpleadoTipoUsuario);
            this.tabPageRegistrarEmpleado.Controls.Add(this.textBoxRegistroDeEmpleadoContrasenia);
            this.tabPageRegistrarEmpleado.Controls.Add(this.textBoxRegistroDeEmpleadoRFC);
            this.tabPageRegistrarEmpleado.Controls.Add(this.textBoxRegistroDeEmpleadoTelefono);
            this.tabPageRegistrarEmpleado.Controls.Add(this.textBoxRegistroDeEmpleadoCorreo);
            this.tabPageRegistrarEmpleado.Controls.Add(this.textBoxRegistroDeEmpleadoNombre);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label28);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label29);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label25);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label13);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label7);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label3);
            this.tabPageRegistrarEmpleado.Controls.Add(this.buttonRegistroDeEmpleadoRegistrar);
            this.tabPageRegistrarEmpleado.Controls.Add(this.label2);
            this.tabPageRegistrarEmpleado.Location = new System.Drawing.Point(4, 5);
            this.tabPageRegistrarEmpleado.Name = "tabPageRegistrarEmpleado";
            this.tabPageRegistrarEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrarEmpleado.Size = new System.Drawing.Size(954, 562);
            this.tabPageRegistrarEmpleado.TabIndex = 1;
            this.tabPageRegistrarEmpleado.Text = "RegEmp";
            // 
            // comboBoxRegistroDeEmpleadoTipoUsuario
            // 
            this.comboBoxRegistroDeEmpleadoTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegistroDeEmpleadoTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegistroDeEmpleadoTipoUsuario.FormattingEnabled = true;
            this.comboBoxRegistroDeEmpleadoTipoUsuario.Items.AddRange(new object[] {
            "Almacen",
            "Ventas",
            "Administracion"});
            this.comboBoxRegistroDeEmpleadoTipoUsuario.Location = new System.Drawing.Point(242, 249);
            this.comboBoxRegistroDeEmpleadoTipoUsuario.Name = "comboBoxRegistroDeEmpleadoTipoUsuario";
            this.comboBoxRegistroDeEmpleadoTipoUsuario.Size = new System.Drawing.Size(435, 31);
            this.comboBoxRegistroDeEmpleadoTipoUsuario.TabIndex = 8;
            // 
            // textBoxRegistroDeEmpleadoContrasenia
            // 
            this.textBoxRegistroDeEmpleadoContrasenia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeEmpleadoContrasenia.Location = new System.Drawing.Point(643, 358);
            this.textBoxRegistroDeEmpleadoContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeEmpleadoContrasenia.MaxLength = 36;
            this.textBoxRegistroDeEmpleadoContrasenia.Name = "textBoxRegistroDeEmpleadoContrasenia";
            this.textBoxRegistroDeEmpleadoContrasenia.PasswordChar = '*';
            this.textBoxRegistroDeEmpleadoContrasenia.Size = new System.Drawing.Size(259, 30);
            this.textBoxRegistroDeEmpleadoContrasenia.TabIndex = 12;
            // 
            // textBoxRegistroDeEmpleadoRFC
            // 
            this.textBoxRegistroDeEmpleadoRFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeEmpleadoRFC.Location = new System.Drawing.Point(241, 358);
            this.textBoxRegistroDeEmpleadoRFC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeEmpleadoRFC.MaxLength = 13;
            this.textBoxRegistroDeEmpleadoRFC.Name = "textBoxRegistroDeEmpleadoRFC";
            this.textBoxRegistroDeEmpleadoRFC.Size = new System.Drawing.Size(254, 30);
            this.textBoxRegistroDeEmpleadoRFC.TabIndex = 11;
            // 
            // textBoxRegistroDeEmpleadoTelefono
            // 
            this.textBoxRegistroDeEmpleadoTelefono.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeEmpleadoTelefono.Location = new System.Drawing.Point(244, 201);
            this.textBoxRegistroDeEmpleadoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeEmpleadoTelefono.MaxLength = 15;
            this.textBoxRegistroDeEmpleadoTelefono.Name = "textBoxRegistroDeEmpleadoTelefono";
            this.textBoxRegistroDeEmpleadoTelefono.Size = new System.Drawing.Size(433, 30);
            this.textBoxRegistroDeEmpleadoTelefono.TabIndex = 4;
            // 
            // textBoxRegistroDeEmpleadoCorreo
            // 
            this.textBoxRegistroDeEmpleadoCorreo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeEmpleadoCorreo.Location = new System.Drawing.Point(244, 150);
            this.textBoxRegistroDeEmpleadoCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeEmpleadoCorreo.MaxLength = 50;
            this.textBoxRegistroDeEmpleadoCorreo.Name = "textBoxRegistroDeEmpleadoCorreo";
            this.textBoxRegistroDeEmpleadoCorreo.Size = new System.Drawing.Size(679, 30);
            this.textBoxRegistroDeEmpleadoCorreo.TabIndex = 3;
            // 
            // textBoxRegistroDeEmpleadoNombre
            // 
            this.textBoxRegistroDeEmpleadoNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroDeEmpleadoNombre.Location = new System.Drawing.Point(242, 95);
            this.textBoxRegistroDeEmpleadoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegistroDeEmpleadoNombre.MaxLength = 50;
            this.textBoxRegistroDeEmpleadoNombre.Name = "textBoxRegistroDeEmpleadoNombre";
            this.textBoxRegistroDeEmpleadoNombre.Size = new System.Drawing.Size(680, 30);
            this.textBoxRegistroDeEmpleadoNombre.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(538, 362);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 21);
            this.label28.TabIndex = 89;
            this.label28.Text = "Contraseña";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(107, 362);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 21);
            this.label29.TabIndex = 87;
            this.label29.Text = "RFC Empleado";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(26, 254);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 21);
            this.label25.TabIndex = 85;
            this.label25.Text = "Tipo de usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 205);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 73;
            this.label13.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre(s)";
            // 
            // buttonRegistroDeEmpleadoRegistrar
            // 
            this.buttonRegistroDeEmpleadoRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.buttonRegistroDeEmpleadoRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegistroDeEmpleadoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistroDeEmpleadoRegistrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistroDeEmpleadoRegistrar.ForeColor = System.Drawing.Color.White;
            this.buttonRegistroDeEmpleadoRegistrar.Location = new System.Drawing.Point(380, 449);
            this.buttonRegistroDeEmpleadoRegistrar.Name = "buttonRegistroDeEmpleadoRegistrar";
            this.buttonRegistroDeEmpleadoRegistrar.Size = new System.Drawing.Size(241, 51);
            this.buttonRegistroDeEmpleadoRegistrar.TabIndex = 13;
            this.buttonRegistroDeEmpleadoRegistrar.Text = "Registrar Empleado";
            this.buttonRegistroDeEmpleadoRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistroDeEmpleadoRegistrar.Click += new System.EventHandler(this.buttonRegistroDeEmpleadoRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(318, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 47);
            this.label2.TabIndex = 40;
            this.label2.Text = "Registro de empleado";
            // 
            // tabPageBienvenida
            // 
            this.tabPageBienvenida.BackColor = System.Drawing.Color.White;
            this.tabPageBienvenida.Controls.Add(this.label82);
            this.tabPageBienvenida.Controls.Add(this.label81);
            this.tabPageBienvenida.Controls.Add(this.pictureBox1);
            this.tabPageBienvenida.Controls.Add(this.label114);
            this.tabPageBienvenida.Location = new System.Drawing.Point(4, 5);
            this.tabPageBienvenida.Name = "tabPageBienvenida";
            this.tabPageBienvenida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBienvenida.Size = new System.Drawing.Size(954, 562);
            this.tabPageBienvenida.TabIndex = 14;
            this.tabPageBienvenida.Text = "Bienvenida";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(441, 223);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(505, 120);
            this.label82.TabIndex = 44;
            this.label82.Text = "Presione alguna de las opciones de la\r\nbarra de navegación para comenzar a \r\nusar" +
    " la aplicación";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, System.Drawing.FontStyle.Italic);
            this.label81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.label81.Location = new System.Drawing.Point(63, 465);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(298, 51);
            this.label81.TabIndex = 43;
            this.label81.Text = "Los Marisqueños";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.Color.White;
            this.label114.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label114.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label114.Location = new System.Drawing.Point(524, 14);
            this.label114.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(348, 81);
            this.label114.TabIndex = 41;
            this.label114.Text = "  Bienvenido";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPageBienvenida);
            this.tabControlMain.Controls.Add(this.tabPageRegistrarEmpleado);
            this.tabControlMain.Controls.Add(this.tabPageRegistrarProducto);
            this.tabControlMain.Controls.Add(this.tabPageRegistrarBajaProducto);
            this.tabControlMain.Controls.Add(this.tabPageRegistrarVenta);
            this.tabControlMain.Controls.Add(this.tabPageRegistrarCliente);
            this.tabControlMain.Controls.Add(this.tabPageBuscarEmpleado);
            this.tabControlMain.Controls.Add(this.tabPageBuscarProducto);
            this.tabControlMain.Controls.Add(this.tabPageBuscarBaja);
            this.tabControlMain.Controls.Add(this.tabPageBuscarVenta);
            this.tabControlMain.Controls.Add(this.tabPageBuscarCliente);
            this.tabControlMain.Controls.Add(this.tabPageModificarEmpleado);
            this.tabControlMain.Controls.Add(this.tabPageModificarProducto);
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlMain.Location = new System.Drawing.Point(1, 36);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(962, 571);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.Tag = "";
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.labelNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNombreUsuario.Location = new System.Drawing.Point(715, 5);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(0, 23);
            this.labelNombreUsuario.TabIndex = 2;
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(47)))), ((int)(((byte)(37)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(637, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // checkBoxRegistrarVentaFactura
            // 
            this.checkBoxRegistrarVentaFactura.AutoSize = true;
            this.checkBoxRegistrarVentaFactura.Location = new System.Drawing.Point(768, 420);
            this.checkBoxRegistrarVentaFactura.Name = "checkBoxRegistrarVentaFactura";
            this.checkBoxRegistrarVentaFactura.Size = new System.Drawing.Size(77, 22);
            this.checkBoxRegistrarVentaFactura.TabIndex = 6;
            this.checkBoxRegistrarVentaFactura.Text = "Factura";
            this.checkBoxRegistrarVentaFactura.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Los Marisqueños";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageModificarProducto.ResumeLayout(false);
            this.tabPageModificarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModificarProductoPrecioPublico)).EndInit();
            this.tabPageModificarEmpleado.ResumeLayout(false);
            this.tabPageModificarEmpleado.PerformLayout();
            this.tabPageBuscarCliente.ResumeLayout(false);
            this.tabPageBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarClienteClientes)).EndInit();
            this.tabPageBuscarVenta.ResumeLayout(false);
            this.tabPageBuscarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaVentasFolioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaVentasVentas)).EndInit();
            this.tabPageBuscarBaja.ResumeLayout(false);
            this.tabPageBuscarBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaBajasFolioBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaBajasBajas)).EndInit();
            this.tabPageBuscarProducto.ResumeLayout(false);
            this.tabPageBuscarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusquedaProductosCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaProductosProductos)).EndInit();
            this.tabPageBuscarEmpleado.ResumeLayout(false);
            this.tabPageBuscarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusquedaEmpleadosEmpleados)).EndInit();
            this.tabPageRegistrarCliente.ResumeLayout(false);
            this.tabPageRegistrarCliente.PerformLayout();
            this.tabPageRegistrarVenta.ResumeLayout(false);
            this.tabPageRegistrarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroVentaCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistrarVentaRecibido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrarVentaProductos)).EndInit();
            this.tabPageRegistrarBajaProducto.ResumeLayout(false);
            this.tabPageRegistrarBajaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeBajaCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeBajaCantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroDeBajaBajas)).EndInit();
            this.tabPageRegistrarProducto.ResumeLayout(false);
            this.tabPageRegistrarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegistroDeProductoPrecioPublico)).EndInit();
            this.tabPageRegistrarEmpleado.ResumeLayout(false);
            this.tabPageRegistrarEmpleado.PerformLayout();
            this.tabPageBienvenida.ResumeLayout(false);
            this.tabPageBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBajaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losMarisqueñiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarBajaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageModificarProducto;
        private System.Windows.Forms.Button buttonModificarProductoBuscarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownModificarProductoCodigoBarras;
        private System.Windows.Forms.NumericUpDown numericUpDownModificarProductoExistencia;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numericUpDownModificarProductoPrecioPublico;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.CheckBox checkBoxModificarProductoActivoInactivo;
        private System.Windows.Forms.TextBox textBoxModificarProductoDescripcion;
        private System.Windows.Forms.TextBox textBoxModificarProductoNombreProducto;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button buttonModificarProductoModificar;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabPage tabPageModificarEmpleado;
        private System.Windows.Forms.ComboBox comboBoxModificarEmpleadoTiposDeUsuario;
        private System.Windows.Forms.Button buttonModificarEmpleadoBuscarEmpleado;
        private System.Windows.Forms.CheckBox checkBoxModificarEmpleadoActivoInactivo;
        private System.Windows.Forms.TextBox textBoxModificarEmpleadoContrasenia;
        private System.Windows.Forms.TextBox textBoxModificarEmpleadoRFC;
        private System.Windows.Forms.TextBox textBoxModificarEmpleadoTelefono;
        private System.Windows.Forms.TextBox textBoxModificarEmpleadoCorreo;
        private System.Windows.Forms.TextBox textBoxModificarEmpleadoNombre;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button buttonModificarEmpleadoModificar;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TabPage tabPageBuscarCliente;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox textBoxBuscarClienteRFC;
        private System.Windows.Forms.DataGridView dataGridViewBuscarClienteClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoCliente;
        private System.Windows.Forms.Button buttonBuscarClienteBuscar;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TabPage tabPageBuscarVenta;
        private System.Windows.Forms.NumericUpDown numericUpDownBusquedaVentasFolioVenta;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button buttonBusquedaVentasBuscar;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaVentasVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCEmpleadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductosVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenta;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TabPage tabPageBuscarBaja;
        private System.Windows.Forms.NumericUpDown numericUpDownBusquedaBajasFolioBaja;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaBajasBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioBajaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCEmpleadoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioBajaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoSaliente;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Button buttonBusquedaBajasBuscar;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TabPage tabPageBuscarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownBusquedaProductosCodigoBarras;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaProductosProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProducto;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Button buttonBusquedaProductosBuscar;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TabPage tabPageBuscarEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewBusquedaEmpleadosEmpleados;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button buttonBusquedaEmpleadosBuscar;
        private System.Windows.Forms.TextBox textBoxBusquedaEmpleadosRFC;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TabPage tabPageRegistrarCliente;
        private System.Windows.Forms.Button buttonRegistroClienteBuscarCliente;
        private System.Windows.Forms.TextBox textBoxRegistroClienteRFC;
        private System.Windows.Forms.TextBox textBoxRegistroClienteCorreo;
        private System.Windows.Forms.TextBox textBoxRegistroClienteDomicilio;
        private System.Windows.Forms.TextBox textBoxRegistroClienteNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button buttonRegistroClienteRegistrarModificar;
        private System.Windows.Forms.Button buttonRegistroClienteRegresar;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TabPage tabPageRegistrarVenta;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroVentaCodigoBarras;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label labelRegistroVentaCliente;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label labelRegistrarVentaDatoTotal;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label labelRegistrarVentaDatoIva;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label labelRegistrarVentaDatoSubtotal;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label labelRegistrarVentaDatoCambio;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistrarVentaRecibido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrarVentaRegistrarVenta;
        private System.Windows.Forms.Button buttonRegistrarVentaCancelarVenta;
        private System.Windows.Forms.Label labelRegistrarVentaDatoCantidadDeArticulos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxRegistrarVentaRFCCliente;
        private System.Windows.Forms.Button buttonRegistrarVentaRegistrarCliente;
        private System.Windows.Forms.DataGridView dataGridViewRegistrarVentaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProductoVenta;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button buttonRegistrarVentaRegistrarCodigoBarras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageRegistrarBajaProducto;
        private System.Windows.Forms.Label labelRegistroBajaFecha;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroDeBajaCodigoBarras;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox textBoxRegistroDeBajaMotivo;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroDeBajaCantidadProducto;
        private System.Windows.Forms.DataGridView dataGridViewRegistroDeBajaBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasProductoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioProductoBajas;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Button buttonRegistroDeBajaRegistrarProducto;
        private System.Windows.Forms.Button buttonRegistroDeBajaRegistrarBaja;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TabPage tabPageRegistrarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroDeProductoCodigoBarras;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroDeProductoExistencia;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numericUpDownRegistroDeProductoPrecioPublico;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxRegistroDeProductoDescripcion;
        private System.Windows.Forms.TextBox textBoxRegistroDeProductoNombreProducto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button buttonRegistroDeProductoRegistrarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageRegistrarEmpleado;
        private System.Windows.Forms.ComboBox comboBoxRegistroDeEmpleadoTipoUsuario;
        private System.Windows.Forms.TextBox textBoxRegistroDeEmpleadoContrasenia;
        private System.Windows.Forms.TextBox textBoxRegistroDeEmpleadoRFC;
        private System.Windows.Forms.TextBox textBoxRegistroDeEmpleadoTelefono;
        private System.Windows.Forms.TextBox textBoxRegistroDeEmpleadoCorreo;
        private System.Windows.Forms.TextBox textBoxRegistroDeEmpleadoNombre;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegistroDeEmpleadoRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageBienvenida;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Label labelRegistroBajaFolio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRegistrarVentaBuscarCliente;
        private System.Windows.Forms.Label labelRegistroVentaFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRegistroVentaFecha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFCEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeUsuarioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEmpleado;
        private System.Windows.Forms.RadioButton radioButtonRegistroClienteModificacion;
        private System.Windows.Forms.Button buttonRegistroBajaCancelar;
        private System.Windows.Forms.CheckBox checkBoxRegistrarVentaFactura;
    }
}