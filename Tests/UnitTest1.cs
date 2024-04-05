using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void CalculateButton_Click_Should_Calculate_Grade_Correctly_For_Excellent_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(20, 30, 18);

            Assert.AreEqual("Общее количество баллов: 68\nОценка: 5 (Отлично)", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void CalculateButton_Click_Should_Show_Error_Message_For_Negative_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(-5, 30, 18);

            Assert.AreEqual("Баллы не могут принимать отрицательные значения.", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void CalculateButton_Click_Should_Show_Error_Message_For_Exceeding_Maximum_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(20, 40, 25);

            Assert.AreEqual("Баллы за модуль не могут превышать максимальное количество.", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void CalculateButton_Click_Should_Show_Error_Message_For_Incorrect_Format()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(10, 20, 30);

            Assert.AreEqual("Баллы за модуль не могут превышать максимальное количество.", mainWindow.resultTextBlock.Text);
        }
    }
}