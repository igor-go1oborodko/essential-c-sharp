namespace classes_basics
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public Rectangle(double a)
        {
            this.sideA = a;
            this.sideB = 5;
        }

        public Rectangle()
        {
            this.sideA = 4;
            this.sideB = -3;
        }

        public double getSideA()
        {
            return this.sideA;
        }

        public double getSideB()
        {
            return this.sideB;
        }

        public double Area()
        {
            return this.sideA * this.sideB;
        }

        public double Perimeter()
        {
            return (this.sideA + this.sideB) * 2;
        }

        public bool IsSquare()
        {
            return this.sideA == this.sideB;
        }

        public void ReplaceSides()
        {
            double temp = this.sideA;
            this.sideA = this.sideB;
            this.sideB = temp;
        }
    }
}

