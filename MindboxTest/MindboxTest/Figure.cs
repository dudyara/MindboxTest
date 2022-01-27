namespace MindboxTest
{
    /// <summary>
    /// Класс геометрической фигуры.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Метод вычисления площади.
        /// </summary>
        /// <returns></returns>
        protected virtual double GetArea()
        {
            return Area;
        }
    }
}
