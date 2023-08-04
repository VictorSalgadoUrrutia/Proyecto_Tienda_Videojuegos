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
    /// Lógica de interacción para UserControlActualizar.xaml
    /// </summary>
    public partial class UserControlActualizar : UserControl
    {
        public UserControlActualizar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {

            // Obtener el ID ingresado por el usuario desde el TextBox
            if (int.TryParse(txtIdClienteActualizar.Text, out int idBuscar))
            {
                // Obtener el nuevo nombre ingresado por el usuario desde el TextBox
                string nuevoNombre = txtNActualizar.Text;

                try
                {
                    string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Utiliza un comando con parámetros para evitar problemas de seguridad y SQL Injection
                        string query = "UPDATE clientes SET NombreCliente = @NuevoNombre WHERE IdCliente = @IdCliente";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                            command.Parameters.AddWithValue("@IdCliente", idBuscar);
                            int rowsAffected = command.ExecuteNonQuery();

                            // Verificar si se actualizó algún registro
                            if (rowsAffected > 0)
                            {
                           
                                // Mostrar mensaje de éxito o actualizar la lista de datos mostrados en tu aplicación
                                MessageBox.Show("Cliente actualizado con éxito");
                            }
                            else
                            {
                                // Mostrar mensaje si no se encontró el ID en la base de datos
                                MessageBox.Show("No se encontró el ID en la base de datos");
                            }
                        }
                    }

                    // Limpiar los TextBox después de realizar la actualización
                    txtIdClienteActualizar.Text = "";
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("Succedio un erro " + ex.Message);

                    // Manejar cualquier excepción que pueda ocurrir al realizar la actualización en la base de datos
                    // Por ejemplo: MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
            else
            {

                // Mostrar mensaje si el ID ingresado no es un número válido
                MessageBox.Show("Ingresa un ID válido");
            }






        }
    }
}
