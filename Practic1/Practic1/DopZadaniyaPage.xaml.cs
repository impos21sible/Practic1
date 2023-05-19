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

namespace Practic1
{
    /// <summary>
    /// Логика взаимодействия для DopZadaniyaPage.xaml
    /// </summary>
    public partial class DopZadaniyaPage : Page
    {
        public DopZadaniyaPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(a1TextBox.Text, out double a1)&&
                double.TryParse(a2TextBox.Text, out double a2) &&
                double.TryParse(b1TextBox.Text, out double b1) &&
                double.TryParse(b2TextBox.Text, out double b2) &&
                double.TryParse(c1TextBox.Text, out double c1) &&
                double.TryParse(c2TextBox.Text, out double c2))

            {
                double d = a1 * b2 - a2 * b1;
                double x = (c1 * b2 - c2 * b1) / d;
                double y = (a1 * c2 - a2 * c1) / d;

                dTextBox.Text = $"Ответ: {d:N2}";
                xTextBox.Text = $"Ответ: {x:N2}";
                yTextBox.Text = $"Ответ: {y:N2}";
            }
            else
            {
                MessageBox.Show("Некорректное значение длины ребра куба.");
            }
        }
    }
}
