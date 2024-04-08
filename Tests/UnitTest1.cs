using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void Excellent_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(20, 30, 18);

            Assert.AreEqual("Общее количество баллов: 68\nОценка: 5 (Отлично)", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void Negative_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(-5, 30, 18);

            Assert.AreEqual("Баллы не могут принимать отрицательные значения.", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void Exceeding_Maximum_Score()
        {
            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.Calculating(20, 40, 25);

            Assert.AreEqual("Баллы за модуль не могут превышать максимальное количество.", mainWindow.resultTextBlock.Text);
        }

        [TestMethod]
        public void Incorrect_Format()
        {
            // Этот тест пришлось написать используя графические элементы,
            // а не Calculating() напрямую, т.к. он предполагает ввод значеинй типа int
            // и ввод пустых значений такии образом не представляется возможным.

            var mainWindow = new Current_Contol_Task.MainWindow();

            mainWindow.module1ScoreTextBox.Text = "";
            mainWindow.module2ScoreTextBox.Text = "";
            mainWindow.module3ScoreTextBox.Text = "";

            mainWindow.CalculateButton_Click(null, null);

            Assert.AreEqual("Введите корректные значения для всех модулей.", mainWindow.resultTextBlock.Text);
        }
    }
}