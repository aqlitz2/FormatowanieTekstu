using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormatowanieTekstu
{
    public partial class MainWindow : Window
    {
        
        private int LiczbaUstawien = 8;
        private int AktywneUstawienia = 0;

        public MainWindow()
        {
            InitializeComponent();
            AktualizujPasekPostepu();
        }

        
        private void AktualizujPasekPostepu()
        {
            double postep = (double)AktywneUstawienia / LiczbaUstawien * 100;
            PasekPostepu.Value = postep;
        }

      
        private void ZwiekszUstawienie()
        {
            AktywneUstawienia++;
            AktualizujPasekPostepu();
        }


        private void ZmniejszUstawienie()
        {
            AktywneUstawienia = AktywneUstawienia > 0 ? AktywneUstawienia - 1 : 0;
            AktualizujPasekPostepu();
        }

     
        private void FontSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TekstBox.FontSize = Slider.Value;
            ZwiekszUstawienie();
        }

       
        private void BoldChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontWeight = FontWeights.Bold;
            ZwiekszUstawienie();
        }

        private void BoldUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontWeight = FontWeights.Normal;
            ZmniejszUstawienie();
        }

        
        private void ItalicChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontStyle = FontStyles.Italic;
            ZwiekszUstawienie();
        }

        private void ItalicUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.FontStyle = FontStyles.Normal;
            ZmniejszUstawienie();
        }

        
        private void UnderlineChecked(object sender, RoutedEventArgs e)
        {
            TekstBox.TextDecorations = TextDecorations.Underline;
            ZwiekszUstawienie();
        }

        private void UnderlineUnchecked(object sender, RoutedEventArgs e)
        {
            TekstBox.TextDecorations = null;
            ZmniejszUstawienie();
        }

        
        private void Czarny(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Black;
            ZwiekszUstawienie();
        }

        private void Czerwony(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Red;
            ZwiekszUstawienie();
        }

        private void Niebieski(object sender, RoutedEventArgs e)
        {
            TekstBox.Foreground = Brushes.Blue;
            ZwiekszUstawienie();
        }

        private void Białe(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.White;
            ZwiekszUstawienie();
        }

        private void Żółte(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.Yellow;
            ZwiekszUstawienie();
        }

        private void Zielone(object sender, RoutedEventArgs e)
        {
            TekstBox.Background = Brushes.Green;
            ZwiekszUstawienie();
        }

        
        private void DoLewej(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Left;
            ZwiekszUstawienie();
        }

        private void DoSrodka(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Center;
            ZwiekszUstawienie();
        }

        private void DoPrawej(object sender, RoutedEventArgs e)
        {
            TekstBox.TextAlignment = TextAlignment.Right;
            ZwiekszUstawienie();
        }

        
        private void CzcionkaBox(object sender, SelectionChangedEventArgs e)
        {
            if (CzcionkaBoxx.SelectedItem is ComboBoxItem comboBoxItem)
            {
                string selectedFont = comboBoxItem.Content.ToString();
                TekstBox.FontFamily = new FontFamily(selectedFont);
                ZwiekszUstawienie();
            }
        }
    }
}
