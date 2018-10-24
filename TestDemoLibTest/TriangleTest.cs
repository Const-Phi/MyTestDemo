using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestDemoLib;

namespace TestDemoLibTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ОснованиеОтрицательно_Падаем()
        {
            var result = Triangle.GetArea(-10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ВысотаОтрицательна_Падаем()
        {
            var result = Triangle.GetArea(10, -10);
        }

        [TestMethod]
        public void ПараметрыПравильные_Вычисляем()
        {
            var result = Triangle.GetArea(2, 6);
            Assert.AreEqual(6, result, 1e-6, "Сравниваем результат получения площади");
        }

    }
}
