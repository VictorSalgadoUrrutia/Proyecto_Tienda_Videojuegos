using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_majo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
  

        private void Minimizar_Click_1(object sender, RoutedEventArgs e)
        {
             WindowState = WindowState.Minimized;
            
        }

        private void Maximizar_Click_1(object sender, RoutedEventArgs e)
        {
            if(WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }else if(WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }

        }

        private void Cerrar_Click_1(object sender, RoutedEventArgs e)
        {
        Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
         if(e.LeftButton== MouseButtonState.Pressed)
                DragMove();
        }
    }
}
