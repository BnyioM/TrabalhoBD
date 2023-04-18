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
using ITAssetsManagement.Data;
using ITAssetsManagement.Models;

namespace ITAssetsManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush whiteColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        public SolidColorBrush blackColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
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

        private void Pesquisa_Funcionarios_Click(object sender, RoutedEventArgs e)
        {
            List<Funcionario_obj> Funcionarios = context.Get_funcionario_nome(Caixa_pesquisa_funcionario.Text);
            foreach (Funcionario_obj funcionario in Funcionarios) {
                Grid grid = new();
                grid.Margin = new Thickness(0, 40, 0, 0);
                grid.Width = 1400;
                grid.Height = 180;
                grid.Background = whiteColor;
                grid.HorizontalAlignment = HorizontalAlignment.Center;
                grid.VerticalAlignment = VerticalAlignment.Top;

                TextBlock nameTextBlock = new();
                nameTextBlock.Text = "Nome: " + funcionario.Nome;
                nameTextBlock.Margin = new Thickness(46, 30, 0, 0);
                nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                nameTextBlock.VerticalAlignment = VerticalAlignment.Top;
                nameTextBlock.FontSize = 32;
                nameTextBlock.Foreground = blackColor;
                grid.Children.Add(nameTextBlock);
                TextBlock statusTextBlock = new();
                statusTextBlock.Text = "CPF: " + funcionario.CPF;
                statusTextBlock.Margin = new Thickness(46, 0, 0, 64);
                statusTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
                statusTextBlock.VerticalAlignment = VerticalAlignment.Bottom;
                statusTextBlock.FontSize = 24;
                statusTextBlock.Foreground = blackColor;
                grid.Children.Add(statusTextBlock);

                Stack_Funcionarios.Children.Add(grid);

            }
        }
    }
}
