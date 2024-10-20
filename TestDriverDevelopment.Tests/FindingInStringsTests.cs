using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestDriverDevelopment.Tests
{
    [TestClass]
    public class FindingInStringsTests
    {
        [TestMethod]
        public void ShortestWord_findShortestWord_Mnereturned()
        {
            string text = "Мне очень нравится город Москва";
            string expected = "Мне";

            FindingInStrings findingInStrings = new FindingInStrings();
            string actual = findingInStrings.ShortestWord(text);

            Assert.IsNotNull(actual, "Слово не может быть NULL");
            Assert.IsTrue(actual.All(c => !char.IsDigit(c)), "В слове не может быть цифр");
            Assert.AreEqual(expected, actual, "Неправильное короткое слово");
        }

        [TestMethod]
        public void CountWords_countingWord_returned6()
        {
            string text = "Технология разработки и защиты баз данных";
            int expected = 6;

            FindingInStrings findingInStrings = new FindingInStrings();
            int actual = findingInStrings.CountWords(text);

            Assert.IsFalse(actual == 0, "Количество слов не может быть 0");
            Assert.AreEqual(expected, actual, "Неправильное количество слов");
        }

        [TestMethod]
        public void CountChars_couningChars_returned1()
        {
            string text = "Я думаю, что следующий год будет лучше";
            int expected = 38;

            FindingInStrings findingInStrings = new FindingInStrings();
            int actual = findingInStrings.CountChars(text);

            Assert.IsNotNull(actual, "Количество символов не может быть NULL");
            Assert.AreEqual(expected, actual, "Неправильное количество символов (с пробелами)");
        }

        [TestMethod]
        public void NinthChar_findChar_returnedх()
        {
            string text = "Я люблю ходить в зал";
            char? expected = 'х';

            FindingInStrings findingInStrings = new FindingInStrings();
            char? actual = findingInStrings.NinthChar(text);

            Assert.IsNotNull(actual, "Девятый символ не может быть NULL");
            Assert.IsFalse(char.IsDigit((char)actual), "Девятый символ не должен быть цифрой");
            Assert.AreEqual(expected, actual, "Неправильный девятый символ");
        }

        [TestMethod]
        public void CountNumbers_countingNumbers_returned14()
        {
            string text = "Всего существует 10 цифр: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9." +
                "Но в этом предложении в сумме 14 цифр";
            int expected = 14;

            FindingInStrings findingInStrings = new FindingInStrings();
            int actual =findingInStrings.CountNumbers(text);

            Assert.IsNotNull(actual, "Количество цифр не может быть NULL");
            Assert.IsTrue(actual > 0, "Количество цифр должно быть больше 0");
            Assert.AreEqual(expected, actual, "Неправильное количество цифр");
        }

        [TestMethod]
        public void LargestConsecutiveNumbers_findConsecutiveNumbers_retruned7()
        {
            string text = "Маша в 1 классе выучила 3 новых числа: 5683, 758913, 1991206";
            int expected = 7;

            FindingInStrings findingInStrings = new FindingInStrings();
            int actual = findingInStrings.LargestConsecutiveNumbers(text);

            Assert.IsTrue(actual > 0, "Последовательность цифр не была найдена");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSubstring_findingSubstring_returned2()
        {
            string text = "Звучание амбиентной музыки создавало умиротворенную атмосферу в зале. " +
                "Амфора на столе добавляла еще больше амбиента";
            int expected = 2;

            FindingInStrings findingInStrings = new FindingInStrings();
            int actual = findingInStrings.FindSubstring(text);

            Assert.AreEqual(expected, actual);
        }
    }
}