using MySql.Data.MySqlClient;
using Proyecto_majo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_majo.UserControlsAdmin
{
    /// <summary>
    /// Lógica de interacción para UserControlVentas.xaml
    /// </summary>
    public partial class UserControlVentas : UserControl
    {

        private readonly string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";

        public UserControlVentas()
        {
            InitializeComponent();
            CargarComboBoxVendedores();
            CargarComboBoxClientes();
            CargarComboBoxProductos();


        }

        private void btnRealizarCompra_Click(object sender, RoutedEventArgs e)
        {
            string detalles = txtDetalles.Text;
            double totalCompra;
            int cantidadProductos;
            int idVendedor;
            int idCliente;
            int idProducto;

            if (double.TryParse(txtTotalCompra.Text, out totalCompra) &&
                int.TryParse(txtCantidadProductos.Text, out cantidadProductos) &&
                cmbVendedor.SelectedValue != null &&
                cmbCliente.SelectedValue != null &&
                cmbProducto.SelectedValue != null &&
                int.TryParse(cmbVendedor.SelectedValue.ToString(), out idVendedor) &&
                int.TryParse(cmbCliente.SelectedValue.ToString(), out idCliente) &&
                int.TryParse(cmbProducto.SelectedValue.ToString(), out idProducto))
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(connectionString))
                    {
                        conexion.Open();

                        string query = "INSERT INTO compras (Detalles, TotalCompra, Cantidad, IdVendedor, IdCliente, IdProducto) " +
                                       "VALUES (@Detalles, @TotalCompra, @Cantidad, @IdVendedor, @IdCliente, @IdProducto)";

                        using (MySqlCommand comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@Detalles", detalles);
                            comando.Parameters.AddWithValue("@TotalCompra", totalCompra);
                            comando.Parameters.AddWithValue("@Cantidad", cantidadProductos);
                            comando.Parameters.AddWithValue("@IdVendedor", idVendedor);
                            comando.Parameters.AddWithValue("@IdCliente", idCliente);
                            comando.Parameters.AddWithValue("@IdProducto", idProducto);

                            int filasInsertadas = comando.ExecuteNonQuery();

                            if (filasInsertadas > 0)
                            {
                                MessageBox.Show("Compra realizada correctamente.");
                                LimpiarCampos();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo realizar la compra. Verifica los datos e intenta nuevamente.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la compra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Se realizo la venta correctamente.");
            }
        }

        private void LimpiarCampos()
        {
            txtDetalles.Text = string.Empty;
            txtTotalCompra.Text = string.Empty;
            txtCantidadProductos.Text = string.Empty;
            cmbVendedor.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
        }

        private void CargarComboBoxVendedores()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IdVendedor, NombreVendedor FROM vendedor";
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        List<ComboBoxItem> vendedores = new List<ComboBoxItem>();

                        while (reader.Read())
                        {
                            int vendedorId = reader.GetInt32("IdVendedor");
                            string nombreVendedor = reader.GetString("NombreVendedor");
                            ComboBoxItem item = new ComboBoxItem { Content = nombreVendedor, Tag = vendedorId };
                            vendedores.Add(item);
                        }

                        cmbVendedor.ItemsSource = vendedores;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vendedores: " + ex.Message);
            }
        }


        private void CargarComboBoxClientes()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IdCliente, NombreCliente FROM clientes";
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        List<ComboBoxItem> clientes = new List<ComboBoxItem>();

                        while (reader.Read())
                        {
                            int clienteId = reader.GetInt32("IdCliente");
                            string nombreCliente = reader.GetString("NombreCliente");
                            ComboBoxItem item = new ComboBoxItem { Content = nombreCliente, Tag = clienteId };
                            clientes.Add(item);
                        }

                        cmbCliente.ItemsSource = clientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void CargarComboBoxProductos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IdProducto, NombreProducto FROM productos";
                    MySqlCommand comando = new MySqlCommand(query, conexion);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        List<ComboBoxItem> productos = new List<ComboBoxItem>();

                        while (reader.Read())
                        {
                            int productoId = reader.GetInt32("IdProducto");
                            string nombreProducto = reader.GetString("NombreProducto");
                            ComboBoxItem item = new ComboBoxItem { Content = nombreProducto, Tag = productoId };
                            productos.Add(item);
                        }

                        cmbProducto.ItemsSource = productos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }



        private void cmbVendedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                string palabraBuscada = cmbProducto.Text;
                string query = "SELECT IdProducto, NombreProducto, Precio FROM productos WHERE NombreProducto LIKE @PalabraBuscada";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@PalabraBuscada", "%" + palabraBuscada + "%");

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    // Si hay resultados en el lector
                    if (reader.Read())
                    {
                        // Obtener el precio del producto del lector
                        double precio = reader.GetDouble("Precio");

                        // Crear un objeto Productos y establecer el precio
                        Productos productos = new Productos
                        {
                            Precio = precio
                        };

                        // Hacer lo que necesites con el precio, por ejemplo, mostrarlo en una etiqueta
                        txtTotalCompra.Text = $"Precio: {precio.ToString("C")}";
                    }
                    else
                    {
                        // Si no hay resultados, puede que el producto no exista o no haya coincidencias
                        txtTotalCompra.Text = "Producto no encontrado";
                    }
                }
            }
        }
    }
}
