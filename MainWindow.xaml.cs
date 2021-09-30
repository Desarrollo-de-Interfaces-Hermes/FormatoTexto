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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBoxNegrita_Checked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.FontWeight = FontWeights.Bold;
        }

        private void CheckBoxCursiva_Checked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.FontStyle = FontStyles.Italic;
        }

        private void RadioAzul_Checked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.Foreground = Brushes.Blue;
        }

        private void RadioRojo_Checked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.Foreground = Brushes.Red;
        }

        private void RadioVerde_Checked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.Foreground = Brushes.Green;
        }

        private void TextoOriginal_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
        }

        private void CheckBoxNegrita_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.FontWeight = FontWeights.Normal;
        }

        private void CheckBoxCursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoResultado.Text = TextoOriginal.Text;
            TextoResultado.FontStyle = FontStyles.Normal;
        }
    }
}
