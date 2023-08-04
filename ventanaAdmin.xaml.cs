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
using System.Windows.Shapes;
using Proyecto_majo.UserControls;



namespace Proyecto_majo
{
    /// <summary>
    /// Lógica de interacción para ventanaAdmin.xaml
    /// </summary>
    public partial class ventanaAdmin : Window
    {
        public ventanaAdmin()
        {
            InitializeComponent();
        }

        public void BtnAgregarC_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlAgregar();
        }

        public void BtnLeerD_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlLeer();
        }

        public void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlActualizar();
        }

        public void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UserControlEliminar();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            Close();
            login.Show();


        }
    }
    }
