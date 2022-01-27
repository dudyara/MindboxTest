namespace UnitTest
{
    using MindboxTest;
    using Xunit;

    /// <summary>
    /// Класс юнит - тестов.
    /// </summary>
    public class UnitTest
    {
        /// <summary>
        /// Тест на прямоугольный треугольник.
        /// </summary>
        [Fact]
        public void RightTriangle()
        {
            var t = new Triangle(3, 4, 5);
            var result = t.IsRightTriangle;
            Assert.True(result);
        }

        /// <summary>
        /// Проверка вычисления площади круга.
        /// </summary>
        [Fact]
        public void CircleArea()
        {
            var t = new Circle(2);
            var result = t.Area;
            Assert.InRange(result,12.5,12.6);
        }

        /// <summary>
        /// Проверка вычисления площади треугольника.
        /// </summary>
        [Fact]
        public void TriangleArea()
        {
            var t = new Triangle(3, 4, 5);
            var result = t.Area;
            Assert.Equal(6, result);
        }
    }
}