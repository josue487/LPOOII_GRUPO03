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

namespace Vistas
{
    /// <summary>
    /// inicio de Login
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

 
        /// <summary>
        /// Cierra el Programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ingresa al sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
                if (txtUsuario.Text.Equals("admin") && txtContraseña.Text.Equals("admin") ||
                    txtUsuario.Text.Equals("vendedor") && txtContraseña.Text.Equals("vendedor"))
                {
                    Inicio inicio = new Inicio(txtUsuario.Text);
                    this.Hide();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("El Usuario y/o Contraseña es incorrecto");
                }
            
        }
    }
}
