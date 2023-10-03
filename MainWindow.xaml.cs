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

namespace Tema2_FormatoTexto
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

        private void Caja_TextBox_TextChanged(object sender, TextChangedEventArgs e) 
            => resultado_TextBlock.Text = caja_TextBox.Text;

        private void Negrita_CheckBox_Checked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.FontWeight = FontWeights.Bold;

        private void Negrita_CheckBox_Unchecked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.FontWeight = FontWeights.Thin;

        private void Cursiva_CheckBox_Checked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.FontStyle = FontStyles.Italic;

        private void Cursiva_CheckBox_Unchecked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.FontStyle = FontStyles.Normal;

        private void Rojo_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(resultado_TextBlock != null)
                resultado_TextBlock.Foreground = Brushes.Red;
        }

        private void Azul_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.Foreground = Brushes.Blue;

        private void Verde_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => resultado_TextBlock.Foreground = Brushes.Green;
    }
}
