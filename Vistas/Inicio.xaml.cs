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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio(string tipoDeUsuario)
        {
            InitializeComponent();
            if (tipoDeUsuario.Equals("admin")){
                menuClientes.Visibility = System.Windows.Visibility.Collapsed;
                menuTickets.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                menuButacas.Visibility = System.Windows.Visibility.Collapsed;
                menuPeliculas.Visibility = System.Windows.Visibility.Collapsed;
                menuProyecciones.Visibility = System.Windows.Visibility.Collapsed;
                menuUsuario.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close()
        }
    }
}
