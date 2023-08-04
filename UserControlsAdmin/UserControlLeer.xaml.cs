using MySql.Data.MySqlClient;
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

namespace Proyecto_majo.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlLeer.xaml
    /// </summary>
    public partial class UserControlLeer : UserControl
    {
        public UserControlLeer()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el ID ingresado por el usuario desde el TextBox
            if (int.TryParse(txtIdClienteLeer.Text, out int idBuscar))
            {
                try
                {
                    string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Utiliza un comando con parámetros para evitar problemas de seguridad y SQL Injection
                        string query = "SELECT NombreCliente FROM clientes WHERE IdCliente = @IdCliente";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdCliente", idBuscar);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Mostrar los datos del cliente en los TextBox correspondientes
                                    txtNombreCLeer.Text = reader["NombreCliente"].ToString();
                                    
                                }
                                else
                                {
                                    // Mostrar mensaje si no se encontró el ID en la base de datos
                                   MessageBox.Show("No se encontró el ID en la base de datos");
                                    txtNombreCLeer.Text = "";
                         
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Succedio un erro " + ex.Message);

               
                }
            }
            else
            {
                // Mostrar mensaje si el ID ingresado no es un número válido
                MessageBox.Show("Ingresa un ID válido");
                txtNombreCLeer.Text = "";
             
            }
        }
    }
}
