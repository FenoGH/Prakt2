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
using LibMas;
using LibMas2;
using System.IO;
using Microsoft.Win32;

namespace Практ2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitProg_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutProg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Борькин Иван ИСП-31 \nВвести n целых чисел. Вычислить косинус (cos) суммы чисел < 3. Результат вывести на экран", "О программе");
            
        }

        private void Rasch_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Strok.Text, out int n);
            int.TryParse(Stolb.Text, out int m);
            if (n > 0)
            {
                mas = new int[m,n] ;
                LibMas1.ZapolnMas(ref mas);
                DataG1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
                //Vivod.Text = $"{LibMas3.Reshenie(mas)}";
            }
            else
            {
                MessageBox.Show("Неверное значение");
                Strok.Clear();
                Strok.Focus();
            }
        }

        private void Ochistka_Click(object sender, RoutedEventArgs e)
        {
            LibMas1.OchistMas(ref mas);
            DataG1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            Vivod.Clear();
        }

        private void SaveMas_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveMas = new SaveFileDialog();
            saveMas.Filter = "Текстовые файлы | *.txt";
            saveMas.FilterIndex = 1;
            if (mas == null)
            {
                MessageBox.Show("Массив не может быть пустым!");
            }
            else if (saveMas.ShowDialog() == true)
            {
                LibMas1.SaveMas(mas, saveMas.FileName);
            }
        }

        private void LoadMas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openMas = new OpenFileDialog();
            openMas.Filter = "Текстовые файлы | *.txt";
            openMas.FilterIndex = 1;
            if (openMas.ShowDialog() == true)
            {
                LibMas1.UploadMas(ref mas, openMas.FileName);
                DataG1.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
        }
    }
}
