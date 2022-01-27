namespace UnitTest
{
    using MindboxTest;
    using Xunit;

    /// <summary>
    /// ����� ���� - ������.
    /// </summary>
    public class UnitTest
    {
        /// <summary>
        /// ���� �� ������������� �����������.
        /// </summary>
        [Fact]
        public void RightTriangle()
        {
            var t = new Triangle(3, 4, 5);
            var result = t.IsRightTriangle;
            Assert.True(result);
        }

        /// <summary>
        /// �������� ���������� ������� �����.
        /// </summary>
        [Fact]
        public void CircleArea()
        {
            var t = new Circle(2);
            var result = t.Area;
            Assert.InRange(result,12.5,12.6);
        }

        /// <summary>
        /// �������� ���������� ������� ������������.
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