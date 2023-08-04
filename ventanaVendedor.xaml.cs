using MySql.Data.MySqlClient;
using Proyecto_majo.Entities;
using Proyecto_majo.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Proyecto_majo.UserControlsAdmin;

namespace Proyecto_majo
{
    /// <summary>
    /// Lógica de interacción para ventanaVendedor.xaml
    /// </summary>
    public partial class ventanaVendedor : Window
    {

        private readonly string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";


        public ventanaVendedor()
        {
            InitializeComponent();
            //CargarDatos();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void Maximizar_Click(object sender, RoutedEventArgs e)
        //{
        //    if (WindowState == WindowState.Normal)
        //    {
        //        WindowState = WindowState.Maximized;
        //    }
        //    else if (WindowState == WindowState.Maximized)
        //    {
        //        WindowState = WindowState.Normal;
        //    }

        //}

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {







        }

        private void ProductTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void CargarDatos()
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = "SELECT IdProducto, NombreProducto, Precio, Cantidad FROM productos";
        //            using (MySqlCommand command = new MySqlCommand(query, connection))
        //            {
        //                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //                DataTable dataTable = new DataTable();
        //                adapter.Fill(dataTable);

        //                ProductTable.ItemsSource = dataTable.DefaultView;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar cualquier excepción que pueda ocurrir al obtener los datos de la base de datos
        //        // Por ejemplo: MessageBox.Show("Error al cargar los datos: " + ex.Message);
        //    }
        //}

        private void BtnProductosP_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlTablaProductos();
        }

        private void BtnAgregarP_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlAgregarP();
        }

        private void BtnActualizarP_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlActualizarP();
        }

        private void BtnEliminarP_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlEliminarP();
        }

        private void BtnEditarP_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlVentas();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            Close();
            login.Show();

        }
    }
}
