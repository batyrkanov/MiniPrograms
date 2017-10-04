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

namespace MiniPrograms
{
   
    public partial class MainWindow : Window
    {
        RandomGenerator rand = new RandomGenerator(); //cоздаём объект класса для счётчика
        RandomGenerator randFrom = new RandomGenerator(); //cоздаём объект класса для генератора ОТ
        RandomGenerator randTo = new RandomGenerator(); //cоздаём объект класса для генератора ДО
        RandomGenerator IncrementForRand = new RandomGenerator(); //cоздаём объект класса для счётчика генератора
        RandomGenerator SQRT = new RandomGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        { //метод для кнопки счётчика, увеличивает значения при каждом нажатии
            //передаёт эти значения на отображение в lable
            lblCount.Content = rand.Increment().ToString();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {//метод для кнопки счётчика, сбрасывает значения при каждом нажатии
         //передаёт на отображение в lable
            lblCount.Content = rand.Reset().ToString();
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {//метод для кнопки счётчика, уменьшения значения при каждом нажатии
         //передаёт эти значения на отображение в lable
            lblCount.Content = rand.Dicrement().ToString();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
         //метод для кнопки Генерировать. Использует метод класса, который передаются два параметра вида строка, возвращается число
         //которое преобразуется в строку для дальнейшего отображения
            lblRandom.Content = rand.Generator(lblFirstNum.Content.ToString(), lblSecondNum.Content.ToString()).ToString();
            if (checkBox.IsChecked == true)//если кнопка Без повторений помечена, то
            {
                // нужно проверить на наличие имеющихся цифр
                while (txtbRandom.Text.IndexOf(rand.Generator(lblFirstNum.Content.ToString(), lblSecondNum.Content.ToString()).ToString()) != -1)
                { 
                    // генерируем число и проверяем на наличие
                    rand.Generator(lblFirstNum.Content.ToString(), lblSecondNum.Content.ToString());
                    // тем временем у нас увеличивается значение IncrementForRand
                    IncrementForRand.Increment();
                    // и если его значение превысит 1000, то нужно выйти из цикла
                    if (IncrementForRand.Increment() > 1000) break;
                }
                //если же это не так, то добавлять значения в список
                if (IncrementForRand.Increment() <= 1000) txtbRandom.AppendText(rand.Generator(lblFirstNum.Content.ToString(), lblSecondNum.Content.ToString()) + "\n");
            }
            else // если нет, то записывать всё подряд
            {
                txtbRandom.AppendText(rand.Generator(lblFirstNum.Content.ToString(), lblSecondNum.Content.ToString()) + "\n");
            }
            
        }

        private void btn1Minus_Click(object sender, RoutedEventArgs e)
        {
            //метод для первой кнопки генератора, уменьшения значения при каждом нажатии
            //передаёт эти значения на отображение в lable
            lblFirstNum.Content = randFrom.Dicrement().ToString();
        }

        private void btn1Plus_Click(object sender, RoutedEventArgs e)
        {
            //метод для первой кнопки счётчика, увелечение значения при каждом нажатии
            //передаёт эти значения на отображение в lable
            lblFirstNum.Content = randFrom.Increment().ToString();
        }

        private void btn1Minus1_Click(object sender, RoutedEventArgs e)
        {
            //метод для второй кнопки счётчика, уменьшение значения при каждом нажатии
            //передаёт эти значения на отображение в lable
            lblSecondNum.Content = randTo.Dicrement().ToString();
        }

        private void btn2Plus_Click(object sender, RoutedEventArgs e)
        {
            //метод для второй кнопки счётчика, увелечение значения при каждом нажатии
            //передаёт эти значения на отображение в lable   
            lblSecondNum.Content = randTo.Increment().ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtbRandom.Clear(); // метод очищения текстбокса
        }

        private void btnRandCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtbRandom.Text); //метод копирования из текстбокса
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {

            lblSQRT.Content = SQRT.Squrt(txtbSqrt.Text).ToString();
        }
    }
}
