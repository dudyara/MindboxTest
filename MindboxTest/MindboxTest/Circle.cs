namespace MindboxTest 
{
    /// <summary>
    /// Класс круга.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            Radius = r;
            Area = GetArea();
        }

        /// <inheritdoc/>
        protected override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
