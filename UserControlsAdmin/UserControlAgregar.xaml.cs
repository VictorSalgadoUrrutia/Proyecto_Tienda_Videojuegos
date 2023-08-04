using Microsoft.Extensions.Options;
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
using Proyecto_majo.UserControls;


namespace Proyecto_majo.UserControls
{
    /// <summary>
    /// Lógica de interacción para UserControlAgregar.xaml
    /// </summary>
    public partial class UserControlAgregar : UserControl
    {
        public UserControlAgregar()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {

            string nuevoDato = txtAgregar.Text;

            // Validar si el TextBox no está vacío antes de realizar la inserción
            if (!string.IsNullOrEmpty(nuevoDato))
            {
                try
                {
                    string connectionString = "server=localhost;port=3306;user=root;password=;database=ventasbd;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Utiliza un comando con parámetros para evitar problemas de seguridad y SQL Injection
                        string query = "INSERT INTO clientes (NombreCliente) VALUES (@NombreCliente)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NombreCliente", nuevoDato);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Limpiar el TextBox después de agregar el dato
                    txtAgregar.Text = "";

                    // Puedes mostrar un mensaje de éxito o actualizar la lista de datos mostrados en tu aplicación
                    // Por ejemplo: MessageBox.Show("Dato agregado con éxito");
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir al realizar la inserción en la base de datos
                    // Por ejemplo: MessageBox.Show("Error al agregar el dato: " + ex.Message);
                }
            }
        }
    }
}
