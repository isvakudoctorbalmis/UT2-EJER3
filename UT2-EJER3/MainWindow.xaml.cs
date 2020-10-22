using System.Windows;
using System.Windows.Media;

namespace UT2_EJER3
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

     

        private void AltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity =1;
        }

        private void MediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.6;
        }

        private void BajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.3;
        }

        private void RellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch =Stretch.Fill;
        }

        private void UniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void Relleno_uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void noneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }
    }
}
