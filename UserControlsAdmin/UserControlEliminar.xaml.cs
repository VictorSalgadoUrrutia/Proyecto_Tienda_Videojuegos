using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Proyecto_majo.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlEliminar.xaml
    /// </summary>
    public partial class UserControlEliminar : UserControl
    {
        public UserControlEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Obtener el ID ingresado por el usuario desde el TextBox
            if (int.TryParse(txtIdCliente.Text, out int idEliminar))
            {
                try
                {
                    string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Utiliza un comando con parámetros para evitar problemas de seguridad y SQL Injection
                        string query = "DELETE FROM clientes WHERE IdCliente = @IdCliente";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdCliente", idEliminar);
                            int rowsAffected = command.ExecuteNonQuery();

                            // Verificar si se eliminó algún registro
                            if (rowsAffected > 0)
                            {
                                // Mostrar mensaje de éxito o actualizar la lista de datos mostrados en tu aplicación
                                // Por ejemplo: MessageBox.Show("Registro eliminado con éxito");
                            }
                            else
                            {
                                // Mostrar mensaje si no se encontró el ID en la base de datos
                                // Por ejemplo: MessageBox.Show("No se encontró el ID en la base de datos");
                            }
                        }
                    }

                    // Limpiar el TextBox después de realizar la eliminación
                    txtIdCliente.Text = "";
                    MessageBox.Show("Se elimino correctamente el cliente");
                }
                catch (Exception ex)
                {
                    throw new Exception("Succedio un erro " + ex.Message);

                    // Manejar cualquier excepción que pueda ocurrir al realizar la eliminación en la base de datos
                    // Por ejemplo: MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Id ingreado incorrecto");
                // Mostrar mensaje si el ID ingresado no es un número válido
                // Por ejemplo: MessageBox.Show("Ingresa un ID válido");
            }



        }
    }
}
