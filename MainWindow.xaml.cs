using Microsoft.EntityFrameworkCore;
using Proyecto_majo.Entities;
using Proyecto_majo.Proyecto_MajoDbContext;
using Proyecto_majo.Services;
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
using System.Xaml;

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

        UsuarioServicess services = new UsuarioServicess();
        private void Minimizar_Click_1(object sender, RoutedEventArgs e)
        {
             WindowState = WindowState.Minimized;
            
        }

        //private void Maximizar_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if(WindowState == WindowState.Normal)
        //    {
        //        WindowState = WindowState.Maximized;
        //    }else if(WindowState == WindowState.Maximized)
        //    {
        //        WindowState = WindowState.Normal;
        //    }
        //}

        private void Cerrar_Click_1(object sender, RoutedEventArgs e)
        {
        Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
         if(e.LeftButton== MouseButtonState.Pressed)
                DragMove();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string user = txtUsuario.Text;
            string pasword = txtContraseña.Password.ToString();
            var responser = services.Login(user, pasword);
            if (responser.Roles.RoleName == "Admin")
            {
                ventanaAdmin admin = new ventanaAdmin();
                Close();
                admin.Show();
            }
            else if (responser.Roles.RoleName == "Vendedor")
            {
                ventanaVendedor vendedor = new ventanaVendedor();
                Close();
                vendedor.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }

        }
       
    }
   
}
