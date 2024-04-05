using System;
using System.Windows;

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
                int totalScore = module1Score + module2Score + module3Score;
                string grade;
                if (module1Score > 22 || module2Score > 38 || module3Score > 20)
                {
                    resultTextBlock.Text="Баллы за модуль не могут превышать максимальное количество.";
                }
                else if (module1Score < 0 || module2Score < 0 || module3Score < 0)
                {
                    resultTextBlock.Text="Баллы не могут принимать отрицательные значения.";
                }
                else if (totalScore >= 56 && totalScore <= 80)
                {
                    grade = "5 (Отлично)";
                    resultTextBlock.Text=$"Общее количество баллов: {totalScore}\nОценка: {grade}";
                }
                else if (totalScore >= 32 && totalScore <= 55)
                {
                    grade = "4 (Хорошо)";
                    resultTextBlock.Text=$"Общее количество баллов: {totalScore}\nОценка: {grade}";
                }
                else if (totalScore >= 16 && totalScore <= 31)
                {
                    grade = "3 (Удовлетворительно)";
                    resultTextBlock.Text=$"Общее количество баллов: {totalScore}\nОценка: {grade}";
                }
                else if (totalScore >= 0 && totalScore <= 15)
                {
                    grade = "2 (Неудовлетворительно)";
                    resultTextBlock.Text=$"Общее количество баллов: {totalScore}\nОценка: {grade}";
                }
                else
                {
                    grade = "Что то пошло не так.";
                }
                
            }
            catch (FormatException)
            {
                resultTextBlock.Text="Введите корректные значения для всех модулей.";
            }

        }
    }
}