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
using static System.Math;

namespace Practic1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager4.MainFrame = MainFrame;
           // MainFrame.Navigate(new DopZadaniyaPage());
        }

       
        //Задание 1
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox.Text, out double a))
            {
                double Obiem = Pow(a, 3);
                double Plochad = 6 * Pow(a, 2);

                ObiemTextBox.Text = Obiem.ToString();
                PlochadTextBox.Text = Plochad.ToString();
            }
            else
            {
                 MessageBox.Show("Некорректное значение длины ребра куба.");
            }
        }


        //Задание 2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) &&
                double.TryParse(textBoxB.Text, out double b) &&
                double.TryParse(textBoxC.Text, out double c))
            {
                double AC = Abs(a - c);
                double BC = Abs(b - c);
                double product = AC * BC;

                ACTextBox.Text = AC.ToString();
                BCTextBox.Text = BC.ToString();
                ACBCTextBox.Text = product.ToString();
            }
            else
            {
                MessageBox.Show("Некорректные значения координат точек.");
            }
        }
        //Задание 3
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(VtextBox.Text, out double vl) && double.TryParse(VrtextBox.Text, out double vr) && double.TryParse(t1textBox.Text, out double t1) && double.TryParse(t2textBox.Text, out double t2))
            {
                double result = vl * t1 / (vr - vl) + t2;

                // Вывод результата
                OtverTextBox.Text = "Результат: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Введите числовые значения для V лодки, V реки, T1 и T2.");
            }
        }

        //Задание 4

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(xTextBox.Text, out double x) &&
                double.TryParse(aTextBox.Text, out double a))
            {
                double p = (1 / Cos(x)) + Log(Abs(Tan(x / 2))) + (x / (1 + (x / 1 + x)));
                double alfa = Pow(p, 5) * Sqrt(a * Pow(x, 3) + 2) / 2 * Cos(x);
                alfaTextBox.Text = $"Ответ:{alfa:N2}";
            }
            else
            {
                MessageBox.Show("Некорректные значения координат точек.");
            }
        }

        private void BtnDopTask_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DopZadaniyaPage());
        }
    }
}
