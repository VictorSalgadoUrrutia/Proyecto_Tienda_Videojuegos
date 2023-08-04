using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para UserControlAgregarP.xaml
    /// </summary>
    public partial class UserControlAgregarP : UserControl
    {
        private readonly string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";
        public UserControlAgregarP()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            string nombreProducto = txtNombreJuegoP.Text;
            double precio = double.Parse(txtPrecioP.Text); // Suponiendo que el precio es un decimal
            int cantidad = int.Parse(txtCantidadP.Text);     // Suponiendo que la cantidad es un entero

            string query = "INSERT INTO productos (NombreProducto, Precio, Cantidad) VALUES (@NombreProducto, @Precio, @Cantidad)";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                    comando.Parameters.AddWithValue("@Precio", precio);
                    comando.Parameters.AddWithValue("@Cantidad", cantidad);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el producto: " + ex.Message);
                    }

                }
            }
        }

        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT IdProducto, NombreProducto, Precio, Cantidad FROM productos";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ProductTable.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Succedio un erro " + ex.Message);

                // Manejar cualquier excepción que pueda ocurrir al obtener los datos de la base de datos
                // Por ejemplo: MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void ProductTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}