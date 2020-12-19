using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LosMariquenios.Clases;

namespace LosMariquenios
{
    public partial class MainForm : Form
    {
        private string rfc_empleado;
        public MainForm(string rfc_empleado, string nombre)
        {
            InitializeComponent();
            this.rfc_empleado = rfc_empleado;
            labelNombreUsuario.Text = $@"{nombre}";

            //funciones
            bloquearOpcionesModificacionEmpleado();
            bloquearOpcionesModificacionProducto();
        }
        //------------------------------------------------------MENU----------------------------------------------------------- 
        private void losMarisqueñiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBienvenida;
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarEmpleado;
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBuscarEmpleado;
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bloquearOpcionesModificacionEmpleado();
            tabControlMain.SelectedTab = tabPageModificarEmpleado;
        }
        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarProducto;
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBuscarProducto;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageModificarProducto;
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarVenta;
        }

        private void buscarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBuscarVenta;
        }

        private void registrarBajaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarBajaProducto;
        }

        private void buscarBajaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBuscarBaja;
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarCliente;
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageBuscarCliente;
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // END MENU----------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------EMPLEADOS------------------------------------------------
        // Registro Empleado
        private void buttonRegistroDeEmpleadoRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxRegistroDeEmpleadoNombre.Text;
            string correo = textBoxRegistroDeEmpleadoCorreo.Text;
            string telefono = textBoxRegistroDeEmpleadoTelefono.Text;
            string tipoUsuario = comboBoxRegistroDeEmpleadoTipoUsuario.Text;
            string rfc = textBoxRegistroDeEmpleadoRFC.Text;
            string contrasena = textBoxRegistroDeEmpleadoContrasenia.Text;

            if(nombre == "" || correo == "" || telefono == "" || tipoUsuario == "" || rfc == "" || contrasena == "")
            {
                MessageBox.Show("Aun quedan campos por rellenar para registrar al empleado", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Empleado empleado = new Empleado(rfc, nombre, correo, telefono, tipoUsuario, contrasena, true);

            try
            {
                empleado.InsertEmployee();

                MessageBox.Show("Empleado Registrado Correctamente", "Empleado Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxRegistroDeEmpleadoNombre.Clear();
                textBoxRegistroDeEmpleadoCorreo.Clear();
                textBoxRegistroDeEmpleadoTelefono.Clear();
                comboBoxRegistroDeEmpleadoTipoUsuario.TabIndex = 0;
                textBoxRegistroDeEmpleadoRFC.Clear();
                textBoxRegistroDeEmpleadoContrasenia.Clear();
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //------------------
        // Buscar Empleados
        private void buttonBusquedaEmpleadosBuscar_Click(object sender, EventArgs e)
        {
            string rfc = textBoxBusquedaEmpleadosRFC.Text;

            List<string>[] lista = Empleado.getAllEmployees(rfc);

            dataGridViewBusquedaEmpleadosEmpleados.Rows.Clear();

            for (int i = 0; i < lista[0].Count; i++)
            {
                string[] row = { lista[1][i], lista[2][i], lista[3][i], lista[4][i], lista[5][i], lista[6][i] };
                dataGridViewBusquedaEmpleadosEmpleados.Rows.Add(row);
            }
        }
        //------------------
        // Modificar Empleados
        private void buttonModificarEmpleadoBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string rfc = textBoxModificarEmpleadoRFC.Text;
            Empleado empleado = null;
            try
            {
                empleado = new Empleado(rfc);

                textBoxModificarEmpleadoNombre.Text = empleado.Nombre;
                textBoxModificarEmpleadoCorreo.Text = empleado.Correo;
                comboBoxModificarEmpleadoTiposDeUsuario.Text = empleado.TipoDeUsuario;
                textBoxModificarEmpleadoTelefono.Text = empleado.Telefono;
                textBoxModificarEmpleadoContrasenia.Text = empleado.Contrasena;
                checkBoxModificarEmpleadoActivoInactivo.Checked = empleado.Estado == 'A' ? true : false;

                habilitarOpcionesModificacionEmpleado();
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonModificarEmpleadoModificar_Click(object sender, EventArgs e)
        {
            string rfc = textBoxModificarEmpleadoRFC.Text;
            string nombre = textBoxModificarEmpleadoNombre.Text;
            string correo = textBoxModificarEmpleadoCorreo.Text;
            string telefono = textBoxModificarEmpleadoTelefono.Text;
            string tipoUsuario = comboBoxModificarEmpleadoTiposDeUsuario.Text;
            string contrasena = textBoxModificarEmpleadoContrasenia.Text;

            Empleado empleado = new Empleado(rfc, nombre, correo, telefono, tipoUsuario, contrasena, checkBoxModificarEmpleadoActivoInactivo.Checked);

            try
            {
                empleado.UpdateEmployeeData(rfc);

                MessageBox.Show("Empleado Modificado Correctamente", "Empleado Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxModificarEmpleadoRFC.Clear();
                textBoxModificarEmpleadoNombre.Clear();
                textBoxModificarEmpleadoCorreo.Clear();
                comboBoxModificarEmpleadoTiposDeUsuario.Text = "";
                textBoxModificarEmpleadoTelefono.Clear();
                textBoxModificarEmpleadoContrasenia.Clear();

                bloquearOpcionesModificacionEmpleado();
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //------------------
        // END EMPLEADOS-------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------PRODUCTOS------------------------------------------------
        // Registro Productos
        private void buttonRegistroDeProductoRegistrarProducto_Click(object sender, EventArgs e)
        {
            string codigo_barras = Convert.ToString(numericUpDownRegistroDeProductoCodigoBarras.Value);
            string nombre = textBoxRegistroDeProductoNombreProducto.Text;
            string descripcion = textBoxRegistroDeProductoDescripcion.Text;
            int existencia = Convert.ToInt32(numericUpDownRegistroDeProductoExistencia.Value);
            float precio = (float)Convert.ToDouble(numericUpDownRegistroDeProductoPrecioPublico.Value);
            if (codigo_barras == "" || nombre == "" || descripcion == "" )
            {
                MessageBox.Show("Aun quedan campos por rellenar para registrar al empleado", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (existencia < 0 || precio < 0)
            {
                MessageBox.Show("No podemos registrar valores negativos", "Campos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Producto producto = new Producto(codigo_barras, nombre, descripcion, existencia, precio, true);

            try
            {
                producto.InsertProduct();

                MessageBox.Show("Producto Registrado Correctamente", "Producto Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numericUpDownRegistroDeProductoCodigoBarras.Value = 0;
                textBoxRegistroDeProductoNombreProducto.Clear();
                textBoxRegistroDeProductoDescripcion.Clear();
                numericUpDownRegistroDeProductoPrecioPublico.Value = 0;
                numericUpDownRegistroDeProductoExistencia.Value = 0;
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //------------------
        // Buscar Productos

        private void buttonBusquedaProductosBuscar_Click(object sender, EventArgs e)
        {
            string codigo_barras = Convert.ToString(numericUpDownBusquedaProductosCodigoBarras.Value);

            List<string>[] lista = codigo_barras == "0" ? Producto.getAllProducts() : Producto.getAllProducts(codigo_barras);

            dataGridViewBusquedaProductosProductos.Rows.Clear();

            for (int i = 0; i < lista[0].Count; i++)
            {
                string[] row = { lista[1][i], lista[2][i], lista[3][i], lista[4][i], lista[5][i], lista[6][i] };
                dataGridViewBusquedaProductosProductos.Rows.Add(row);
            }
        }

        //------------------
        // Modificar Productos

        private string codigo_barras = "";
        private void buttonModificarProductoBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo_barras = Convert.ToString(numericUpDownModificarProductoCodigoBarras.Value);
            Producto producto = null;
            try
            {
                producto = new Producto(codigo_barras);
                if(producto.Nombre == null)
                {
                    MessageBox.Show("Producto no encontrado", "Codigo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    textBoxModificarProductoNombreProducto.Text = producto.Nombre;
                    textBoxModificarProductoDescripcion.Text = producto.Descripcion;
                    numericUpDownModificarProductoExistencia.Value = producto.Existencia;
                    numericUpDownModificarProductoPrecioPublico.Value = (decimal)producto.Precio;
                    checkBoxModificarProductoActivoInactivo.Checked = producto.Estado == 'V' ? true : false;

                    habilitarOpcionesModificacionProducto();
                    this.codigo_barras = codigo_barras;
                }
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificarProductoModificar_Click(object sender, EventArgs e)
        {
            string codigo_barras =  this.codigo_barras;
            string nombre = textBoxModificarProductoNombreProducto.Text;
            string descripcion = textBoxModificarProductoDescripcion.Text;
            float precio = (float)numericUpDownModificarProductoPrecioPublico.Value; 
            int existencia = Convert.ToInt32(numericUpDownModificarProductoExistencia.Value);

            Producto producto = new Producto(codigo_barras, nombre, descripcion, existencia, precio, checkBoxModificarProductoActivoInactivo.Checked);

            try
            {
                producto.UpdateProductData(codigo_barras);

                MessageBox.Show("Producto Modificado Correctamente", "Producto Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numericUpDownModificarProductoCodigoBarras.Value = 0;
                textBoxModificarProductoNombreProducto.Clear();
                textBoxModificarProductoDescripcion.Clear();
                numericUpDownModificarProductoExistencia.Value = 0;
                numericUpDownModificarProductoPrecioPublico.Value = 0;

                bloquearOpcionesModificacionProducto();
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------
        // END pRODUCTOS-------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------CLIENTES------------------------------------------------
        // Registro / Modificacion Clientes

        private bool modificar = false;
        private void buttonRegistroClienteBuscarCliente_Click(object sender, EventArgs e)
        {
            string rfc = textBoxRegistroClienteRFC.Text;
            Cliente cliente = null;
            try
            {
                cliente = new Cliente(rfc);

                if(cliente.Nombre == null)
                {
                    MessageBox.Show("No se encontro a ningun cliente con el rfc especificado", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBoxRegistroClienteNombre.Text = cliente.Nombre;
                    textBoxRegistroClienteDomicilio.Text = cliente.Domicilio;
                    textBoxRegistroClienteCorreo.Text = cliente.Correo;

                    modificar = true;
                    radioButtonRegistroClienteModificacion.Checked = true;
                }
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxRegistroClienteRFC_TextChanged(object sender, EventArgs e)
        {
            modificar = false;
            radioButtonRegistroClienteModificacion.Checked = false;
        }
        private void buttonRegistroClienteRegistrarModificar_Click(object sender, EventArgs e)
        {
            string rfc = textBoxRegistroClienteRFC.Text;
            string nombre = textBoxRegistroClienteNombre.Text;
            string domicilio = textBoxRegistroClienteDomicilio.Text;
            string correo = textBoxRegistroClienteCorreo.Text;

            Cliente cliente = new Cliente(rfc, nombre, domicilio, correo);

            try
            {
                if (!modificar)
                {
                    cliente.InsertClient();
                    MessageBox.Show("Cliente Registrado Correctamente", "Cliente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.UpdateClientData(rfc);
                    MessageBox.Show("Cliente Moficado Correctamente", "Modificacion Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBoxRegistroClienteRFC.Clear();
                textBoxRegistroClienteNombre.Clear();
                textBoxRegistroClienteDomicilio.Clear();
                textBoxRegistroClienteCorreo.Clear();
                modificar = false;
                radioButtonRegistroClienteModificacion.Checked = false;

            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRegistroClienteRegresar_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarVenta;
        }
        //------------------
        // Buscar Clientes
        private void buttonBuscarClienteBuscar_Click(object sender, EventArgs e)
        {
            string rfc_cliente = textBoxBuscarClienteRFC.Text;

            List<string>[] lista = Cliente.getAllClients(rfc_cliente);

            dataGridViewBuscarClienteClientes.Rows.Clear();

            for (int i = 0; i < lista[0].Count; i++)
            {
                string[] row = { lista[1][i], lista[2][i], lista[3][i], lista[4][i]};
                dataGridViewBuscarClienteClientes.Rows.Add(row);
            }
        }
        //------------------
        // END CLIENTES -----------------------------------------------------------------------------------------------------

        //----------------------------------------------------------BAJAS--------------------------------------------------
        // Registro Bajas

        private List<DetalleBaja> detallesBaja = new List<DetalleBaja>(); //Esta lista es la que utilizamos para registrar todos nuestros detalles a la hora de registrar una nueva baja
        private void buttonRegistroDeBajaRegistrarProducto_Click(object sender, EventArgs e)
        {
            bool changes = false;
            string codigo_barras = Convert.ToString(numericUpDownRegistroDeBajaCodigoBarras.Value);
            int i = (detallesBaja.FindIndex(item => item.Codigo_Barras_Producto == codigo_barras));
            int cantidad = Convert.ToInt32(numericUpDownRegistroDeBajaCantidadProducto.Value);
            if (i != -1)
            {
                if ((detallesBaja[i].Cantidad + cantidad) > detallesBaja[i].Cantidad_Maxima)
                {
                    MessageBox.Show("La cantidad de producto introducida es mayor a la existente", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    changes = true;
                    detallesBaja[i].Cantidad += cantidad;
                }
            }
            else
            {

                string motivo = textBoxRegistroDeBajaMotivo.Text;
                DetalleBaja detalleBaja = new DetalleBaja(codigo_barras, cantidad, motivo);

                if (cantidad > detalleBaja.Cantidad_Maxima)
                {
                    MessageBox.Show("La cantidad de producto introducida es mayor a la existente", "Cantidad invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (detalleBaja.Nombre == null)
                {
                    MessageBox.Show("Producto no encontrado", "Codigo de barras invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    changes = true;
                    detallesBaja.Add(detalleBaja);
                }
            }
            if (changes)
            {
                actualizarTablaBajas();
            }
        }
        private void dataGridViewRegistroDeBajaBajas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void buttonRegistroDeBajaRegistrarBaja_Click(object sender, EventArgs e)
        {
            string fecha = labelRegistroBajaFecha.Text;
            string rfc_empleado = this.rfc_empleado;

            if(detallesBaja.Count <= 0)
            {
                MessageBox.Show("Para registrar una baja es necesario ingresar por lo menos 1 articulo para dar de baja.", "Registros de baja faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Baja baja = new Baja(rfc_empleado, detallesBaja);

            try
            {
                baja.InsertExit();
                MessageBox.Show("Baja Registrada Correctamente", "Baja Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numericUpDownRegistroDeBajaCodigoBarras.Value = 0;
                numericUpDownRegistroDeBajaCodigoBarras.Value = 0;
                textBoxRegistroDeBajaMotivo.Clear();
                detallesBaja.Clear();

                actualizarTablaBajas();
            }
            catch (ArgumentException err)
            {
                string errorMessage = err.Message;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistroBajaCancelar_Click(object sender, EventArgs e)
        {
            detallesBaja.Clear();

            actualizarTablaBajas();
        }
        //------------------
        // Busqueda Registro Bajas
        private void buttonBusquedaBajasBuscar_Click(object sender, EventArgs e)
        {
            string folio_baja = Convert.ToString(numericUpDownBusquedaBajasFolioBaja.Value);

            List<string>[] lista = Baja.getAllExits(folio_baja);

            dataGridViewBusquedaBajasBajas.Rows.Clear();

            for (int i = 0; i < lista[0].Count; i++)
            {
                string[] row = { lista[1][i], lista[2][i], lista[3][i], lista[4][i], lista[5][i], lista[6][i], lista[7][i], lista[8][i] };
                dataGridViewBusquedaBajasBajas.Rows.Add(row);
            }
        }
        //-----------------------
        // END BAJAS -----------------------------------------------------------------------------------------------------

        //----------------------------------------------------------VENTAS--------------------------------------------------
        // Registro Ventas

        private List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
        private float total = 0;
        private bool ventaClienteRegistrado = false;
        private void buttonRegistrarVentaRegistrarCliente_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageRegistrarCliente;

        }
        private void buttonRegistrarVentaBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxRegistrarVentaRFCCliente.Text != "001" || false)// tratar de validar que el valor ingresado sea un rfc
            {

            }

            string rfc_cliente = textBoxRegistrarVentaRFCCliente.Text;
            try
            {
                Cliente cliente = new Cliente(rfc_cliente);
                if(cliente.Nombre == null)
                {
                    MessageBox.Show("Cliente no encontrado", "RFC invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    labelRegistroVentaCliente.Text = $@"Cliente: {cliente.Nombre}";
                    ventaClienteRegistrado = true;
                }
            }
            catch (ArgumentException err)
            {

            }
        }

        private void buttonRegistrarVentaRegistrarCodigoBarras_Click(object sender, EventArgs e)
        {
            bool changes = false;
            string codigo_barras = Convert.ToString(numericUpDownRegistroVentaCodigoBarras.Value);
            int i = (detallesVenta.FindIndex(item => item.Codigo_Barras_Producto == codigo_barras));
            if (i != -1)
            {
                if ((detallesVenta[i].Cantidad + 1) > detallesVenta[i].Cantidad_Maxima)
                {
                    MessageBox.Show("No hay mas productos de este tipo", "Producto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    changes = true;
                    detallesVenta[i].Cantidad += 1;
                }
            }
            else
            {

                string motivo = textBoxRegistroDeBajaMotivo.Text;
                DetalleVenta detalleVenta = new DetalleVenta(codigo_barras, 1);

                if (detalleVenta.Nombre == null) 
                {
                    MessageBox.Show("Producto no encontrado", "Codigo de barras invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (1 > detalleVenta.Cantidad_Maxima)
                {
                    MessageBox.Show("No hay mas productos de este tipo", "Producto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    changes = true;
                    detallesVenta.Add(detalleVenta);
                }
            }
            if (changes)
            {
                int  cantidad = 0;
                float subtotal = 0;

                actualizarTablaVentas(out subtotal, out cantidad);

                float iva = (float) (subtotal * .16);
                total = (float)(subtotal + iva);

                actualizarPreciosVentas(Convert.ToString(subtotal), Convert.ToString(iva), Convert.ToString(total), Convert.ToString(cantidad));
            }


            //Checar productos ya registrados
            //SI un producto ya esta registrado hacemos matematicas y ya
            //SI NO tenemos que pedir el nombre del producto a la base de datos

            //Cosas a checar tenemos que actualizar todo de la mejor manera
        }

        private void dataGridViewRegistrarVentaProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void numericUpDownRegistrarVentaRecibido_ValueChanged(object sender, EventArgs e)
        {
            if (total > 0)
            {
                float recibido = (float)numericUpDownRegistrarVentaRecibido.Value;
                float cambio = recibido - total;
                actualizarCambioVentas(Convert.ToString(cambio));
            }
            else if (numericUpDownRegistrarVentaRecibido.Value == 0)
            {

            }
            else
            {
                MessageBox.Show("No puedes ingresar el saldo sin haber registrado algun producto");
                numericUpDownRegistrarVentaRecibido.Value = 0;
            }
        }
        private void buttonRegistrarVentaRegistrarVenta_Click(object sender, EventArgs e)
        {
            //Mostrar mensajes
            if ((float)numericUpDownRegistrarVentaRecibido.Value < total)
            {
                MessageBox.Show("Monto recibido no suficiente para realizar compra", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ventaClienteRegistrado)
            {
                MessageBox.Show("Cliente no registrado", "Cliente Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (detallesVenta.Count() < 0)
            {
                MessageBox.Show("Productos no registrados", "No se han registrado productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string rfc_empleado = this.rfc_empleado;
                string rfc_cliente = textBoxRegistrarVentaRFCCliente.Text;

                char estado = checkBoxRegistrarVentaFactura.Checked? 'F': 'N';

                Venta venta = new Venta(rfc_empleado, rfc_cliente, estado, detallesVenta);

                try
                {
                    venta.InsertSell();
                    MessageBox.Show("Venta Registrada Correctamente", "Venta Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ventaClienteRegistrado = false;
                    textBoxRegistrarVentaRFCCliente.Text = "001";
                    labelRegistroVentaCliente.Text = "Cliente de mostrador RFC = 001";
                    detallesVenta.Clear();

                    numericUpDownRegistroVentaCodigoBarras.Value = 0;
                    numericUpDownRegistrarVentaRecibido.Value = 0;
                    checkBoxRegistrarVentaFactura.Checked = false;

                    int cantidad = 0;
                    float subtotal = 0;

                    actualizarTablaVentas(out subtotal, out cantidad);
                    actualizarCambioVentas();

                    float iva = (float)(subtotal * .16);
                    float total = (float)(subtotal + iva);

                    actualizarPreciosVentas(Convert.ToString(subtotal), Convert.ToString(iva), Convert.ToString(total), Convert.ToString(cantidad));

                    actualizarFolionVentas();
                }
                catch (ArgumentException err)
                {
                    string errorMessage = err.Message;
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRegistrarVentaCancelarVenta_Click(object sender, EventArgs e)
        {
            ventaClienteRegistrado = false;
            textBoxRegistrarVentaRFCCliente.Text = "001";
            labelRegistroVentaCliente.Text = "Cliente de mostrador RFC = 001";
            detallesVenta.Clear();

            numericUpDownRegistroVentaCodigoBarras.Value = 0;
            numericUpDownRegistrarVentaRecibido.Value = 0;
            checkBoxRegistrarVentaFactura.Checked = false;

            int cantidad = 0;
            float subtotal = 0;

            actualizarTablaVentas(out subtotal, out cantidad);
            actualizarCambioVentas();

            float iva = (float)(subtotal * .16);
            float total = (float)(subtotal + iva);

            actualizarPreciosVentas(Convert.ToString(subtotal), Convert.ToString(iva), Convert.ToString(total), Convert.ToString(cantidad));

            actualizarFolionVentas();
        }
        //------------------
        // Busqueda Registro Ventas
        private void buttonBusquedaVentasBuscar_Click(object sender, EventArgs e)
        {
            string folio_venta = Convert.ToString(numericUpDownBusquedaVentasFolioVenta.Value);

            List<string>[] lista = Venta.getAllSells(folio_venta);

            dataGridViewBusquedaVentasVentas.Rows.Clear();

            for (int i = 0; i < lista[0].Count; i++)
            {
                string[] row = { lista[1][i], lista[2][i], lista[3][i], lista[4][i], lista[5][i], lista[6][i], lista[7][i], lista[8][i], lista[9][i] };
                dataGridViewBusquedaVentasVentas.Rows.Add(row);
            }
        }
        //-----------------------

        // END VENTAS ----------------------------------------------------------------------------------------------------
        //-------------------------------------------------------SCRIPTS---------------------------------------------------


        private void bloquearOpcionesModificacionProducto()
        {
            buttonModificarProductoModificar.Enabled = false; 
            textBoxModificarProductoNombreProducto.Enabled = false;
            textBoxModificarProductoDescripcion.Enabled = false;
            numericUpDownModificarProductoExistencia.Enabled = false;
            numericUpDownModificarProductoPrecioPublico.Enabled = false;
            checkBoxModificarProductoActivoInactivo.Enabled = false;
        }

        private void bloquearOpcionesModificacionEmpleado()
        {
            checkBoxModificarEmpleadoActivoInactivo.Enabled = false;
            textBoxModificarEmpleadoNombre.Enabled = false;
            textBoxModificarEmpleadoContrasenia.Enabled = false;
            textBoxModificarEmpleadoCorreo.Enabled = false;
            textBoxModificarEmpleadoTelefono.Enabled = false;
            buttonModificarEmpleadoModificar.Enabled = false;
            comboBoxModificarEmpleadoTiposDeUsuario.Enabled = false;
        }

        private void habilitarOpcionesModificacionProducto()
        {
            buttonModificarProductoModificar.Enabled = true;
            textBoxModificarProductoNombreProducto.Enabled = true;
            textBoxModificarProductoDescripcion.Enabled = true;
            numericUpDownModificarProductoExistencia.Enabled = true;
            numericUpDownModificarProductoPrecioPublico.Enabled = true;
            checkBoxModificarProductoActivoInactivo.Enabled = true;
        }

        private void habilitarOpcionesModificacionEmpleado()
        {
            checkBoxModificarEmpleadoActivoInactivo.Enabled = true;
            textBoxModificarEmpleadoNombre.Enabled = true;
            textBoxModificarEmpleadoContrasenia.Enabled = true;
            textBoxModificarEmpleadoCorreo.Enabled = true;
            textBoxModificarEmpleadoTelefono.Enabled = true;
            buttonModificarEmpleadoModificar.Enabled = true;
            comboBoxModificarEmpleadoTiposDeUsuario.Enabled = true;
        }
        private void actualizarInformacionBajas()
        {
            labelRegistroBajaFolio.Text = Convert.ToString(Baja.getExitsFolio());
            labelRegistroBajaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void actualizarTablaBajas()
        {
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            foreach (DetalleBaja detalleBaja in detallesBaja)
            {
                list[0].Add((list[0].Count + 1).ToString());
                list[1].Add(detalleBaja.Codigo_Barras_Producto);
                list[2].Add(detalleBaja.Nombre);
                list[3].Add(Convert.ToString(detalleBaja.Cantidad));
                list[4].Add(detalleBaja.Motivo);
            }

            dataGridViewRegistroDeBajaBajas.Rows.Clear();

            for (int i = 0; i < list[0].Count; i++)
            {
                string[] row = { list[1][i], list[2][i], list[3][i], list[4][i] };
                dataGridViewRegistroDeBajaBajas.Rows.Add(row);
            }
        }
        private void actualizarFolionVentas(string nombre_cliente = "Cliente de mostrador RFC = 0000000000001")
        {

            labelRegistroVentaFolio.Text = Convert.ToString(Venta.getSellsFolio());
            labelRegistroVentaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void actualizarInformacionVentas(string nombre_cliente = "Cliente de mostrador RFC = 0000000000001")
        {
            labelRegistroVentaCliente.Text = nombre_cliente;
        }

        private void actualizarPreciosVentas(string subtotal = "0.00", string iva = "0.00", string totalLabel = "0.00", string articulos = "0")
        {
            labelRegistrarVentaDatoCantidadDeArticulos.Text = articulos;
            labelRegistrarVentaDatoSubtotal.Text = subtotal;
            labelRegistrarVentaDatoIva.Text = iva;
            labelRegistrarVentaDatoTotal.Text = totalLabel;
        }

        private void actualizarCambioVentas(string cambio = "0.00")
        {
            labelRegistrarVentaDatoCambio.Text = cambio;
        }
        private void actualizarTablaVentas(out float subtotal, out int cantidadArticulos)
        {
            cantidadArticulos = 0;
            subtotal = 0;
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            foreach (DetalleVenta detalleVenta in detallesVenta)
            {
                list[0].Add((list[0].Count + 1).ToString());
                list[1].Add(detalleVenta.Codigo_Barras_Producto);
                list[2].Add(detalleVenta.Nombre);
                list[3].Add(Convert.ToString(detalleVenta.Precio));
                list[4].Add(Convert.ToString(detalleVenta.Cantidad));
                cantidadArticulos += detalleVenta.Cantidad;
                list[5].Add(Convert.ToString(detalleVenta.Total));
                subtotal += detalleVenta.Total;
            }

            dataGridViewRegistrarVentaProductos.Rows.Clear();

            for (int i = 0; i < list[0].Count; i++)
            {
                string[] row = { list[1][i], list[2][i], list[3][i], list[4][i], list[5][i] };
                dataGridViewRegistrarVentaProductos.Rows.Add(row);
            }

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageRegistrarBajaProducto)
            {
                actualizarInformacionBajas();
            }
            if (tabControlMain.SelectedTab == tabPageRegistrarVenta)
            {
                actualizarFolionVentas();
            }

        }

        




















































        // END SCRIPTS -------------------------------------------------------------------------------------------------
    }
}
