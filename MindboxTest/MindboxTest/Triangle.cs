namespace MindboxTest
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона.
        /// </summary>
        public double FirstSide { get; set; }

        /// <summary>
        /// Вторая сторона.
        /// </summary>
        public double SecondSide { get; set; }

        /// <summary>
        /// Третья сторона.
        /// </summary>
        public double ThirdSide { get; set; }

        /// <summary>
        /// Треугольник является прямоугольным.
        /// </summary>
        public bool IsRightTriangle { get; set; }

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        public Triangle(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
            IsRightTriangle = RightTriangleCheck();
            Area = GetArea();
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        private bool RightTriangleCheck()
        {
            var sides = new List<double>() 
            { 
                FirstSide, 
                SecondSide,
                ThirdSide
            };

            var hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            return PythagoreanCheck(hypotenuse, sides);
        }

        /// <summary>
        /// Проверка действия теоремы Пифагора.
        /// </summary>
        /// <param name="hypotenuse">Гипотенуза.</param>
        /// <param name="sides">Катеты.</param>
        /// <returns></returns>
        private bool PythagoreanCheck(double hypotenuse, List<double> sides)
        {
            return Math.Pow(sides.FirstOrDefault(), 2) + Math.Pow(sides.LastOrDefault(), 2) == Math.Pow(hypotenuse, 2);
        }

        /// <inheritdoc/>
        protected override double GetArea()
        {
            var semiPerimetr = GetSemiPerimetr();
            var calculatedArea = UseGeronFormula(semiPerimetr);
            return calculatedArea;
        }

        /// <summary>
        /// Получение полупериметра.
        /// </summary>
        private double GetSemiPerimetr()
        {
            return (FirstSide + SecondSide + ThirdSide) / 2;
        }

        /// <summary>
        /// Применение формулы Герона.
        /// </summary>
        /// <param name="semiPerimetr">Полупериметр.</param>
        private double UseGeronFormula(double semiPerimetr)
        {
            return Math.Sqrt(semiPerimetr * (semiPerimetr - FirstSide) * (semiPerimetr - SecondSide) * (semiPerimetr - ThirdSide));
        }
    }
}
