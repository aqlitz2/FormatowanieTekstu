using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormatowanieTekstu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Zmiana rozmiaru czcionki
        private void FontSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TekstBox.FontSize = Slider.Value;
        }

        // Zmiana stanu pogrubienia
        private void BoldChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontWeight = FontWeights.Bold;
        }

        private void BoldUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontWeight = FontWeights.Normal;
        }

        // Zmiana stanu kursywy
        private void ItalicChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontStyle = FontStyles.Italic;
        }

        private void ItalicUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontStyle = FontStyles.Normal;
        }

        // Zmiana stanu podkreślenia
        private void UnderlineChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.TextDecorations = TextDecorations.Underline;
        }

        private void UnderlineUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.TextDecorations = null;
        }

        // Zmiana koloru czcionki
        private void Czarny(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Black;
        }

        private void Czerwony(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Red;
        }


        private void Niebieski(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Blue;
        }

        private void Białe(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.White;
        }

        private void Żółte(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.Yellow;
        }


        private void Zielone(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.Green;
        }






        private void DoLewej(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Left;
        }

        private void DoSrodka(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Center;
        }

        private void DoPrawej(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Right;
        }
      
        






    }
}









