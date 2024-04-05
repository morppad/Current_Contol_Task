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

namespace Current_Contol_Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            Calculating(int.Parse(module1ScoreTextBox.Text), int.Parse(module2ScoreTextBox.Text), int.Parse(module3ScoreTextBox.Text));
        }
        public void Calculating(int module1Score, int module2Score, int module3Score)
        {
            try
            {
                if (module1Score > 22 || module2Score > 38 || module3Score > 20)
                {
                    MessageBox.Show("Баллы за модуль не могут превышать максимальное количество.");
                    return;
                }

                if (module1Score < 0 || module2Score < 0 || module3Score < 0)
                {
                    MessageBox.Show("Баллы не могут принимать отрицательные значения.");
                    return;
                }

                int totalScore = module1Score + module2Score + module3Score;

                string grade;
                if (totalScore >= 56 && totalScore <= 80)
                {
                    grade = "5 (Отлично)";
                }
                else if (totalScore >= 32 && totalScore <= 55)
                {
                    grade = "4 (Хорошо)";
                }
                else if (totalScore >= 16 && totalScore <= 31)
                {
                    grade = "3 (Удовлетворительно)";
                }
                else
                {
                    grade = "2 (Неудовлетворительно)";
                }

                resultTextBlock.Text = $"Общее количество баллов: {totalScore}\nОценка: {grade}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные значения для всех модулей.");
            }
        }
    }
}