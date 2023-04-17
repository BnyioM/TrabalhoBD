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

namespace ITAssetsManagement
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

        private void Funcionario_init_Click(object sender, RoutedEventArgs e)
        {
            Menu_Inicial.Visibility = Visibility.Hidden;
            Pesquisa_Funcionario.Visibility = Visibility.Visible;
        }

        private void Software_init_Click(object sender, RoutedEventArgs e)
        {
            Menu_Inicial.Visibility = Visibility.Hidden;
            Pesquisa_Software.Visibility = Visibility.Visible;
        }

        private void Hardware_init_Click(object sender, RoutedEventArgs e)
        {
            Menu_Inicial.Visibility = Visibility.Hidden;
            Pesquisa_Hardware.Visibility = Visibility.Visible;
        }

        private void Fornecedor_init_Click(object sender, RoutedEventArgs e)
        {
            Menu_Inicial.Visibility = Visibility.Hidden;
            Pesquisa_Fornecedor.Visibility = Visibility.Visible;
        }

        private void Retorna_Inicio_Click(object sender, RoutedEventArgs e)
        {
            Pesquisa_Fornecedor.Visibility = Visibility.Hidden;
            Pesquisa_Funcionario.Visibility = Visibility.Hidden;
            Pesquisa_Hardware.Visibility = Visibility.Hidden;
            Pesquisa_Software.Visibility = Visibility.Hidden;
            Menu_Inicial.Visibility = Visibility.Visible;
        }
    }
}
