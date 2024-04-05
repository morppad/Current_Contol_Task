using Microsoft.VisualStudio.TestTools.UnitTesting;
using Current_Contol_Task;
using System.Windows.Forms;
using System.IO;

namespace Tests
{
    [TestClass]
    public class ExamGradingTests
    {
        [TestMethod]
        public void TestPositiveCalculation()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();
            mainWindow.module1ScoreTextBox.Text = "20";
            mainWindow.module2ScoreTextBox.Text = "20";
            mainWindow.module3ScoreTextBox.Text = "20";

            // Act
            mainWindow.CalculateButton_Click(null, null);

            // Assert
            Assert.AreEqual("Общее количество баллов: 60\nОценка: 5 (Отлично)", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void TestExcellentGrade()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.module1ScoreTextBox.Text = "22";
            mainWindow.module2ScoreTextBox.Text = "38";
            mainWindow.module3ScoreTextBox.Text = "20";

            mainWindow.CalculateButton_Click(null, null);

            Assert.AreEqual("Общее количество баллов: 80\nОценка: 5 (Отлично)", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void TestNegativeInput()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.module1ScoreTextBox.Text = "text"; 

            mainWindow.CalculateButton_Click(null, null);

            Assert.AreEqual("Введите корректные значения для всех модулей.", MessageBox.Show("Введите корректные значения для всех модулей.").ToString());

        }

        [TestMethod]
        public void TestExceedingMaxScore()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.module1ScoreTextBox.Text = "30"; 

            mainWindow.CalculateButton_Click(null, null);

            string actualErrorMessage = string.Empty;

        }
    }
}