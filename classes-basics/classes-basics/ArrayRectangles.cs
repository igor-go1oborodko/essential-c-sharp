namespace classes_basics
{
    public class ArrayRectangles
    {
        private Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            this.rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(Rectangle[] rectangles)
        {
            this.rectangle_array = rectangles;
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            try
            {
                this.rectangle_array.Append(rectangle);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public int NumberMaxArea()
        {
            double[] areas = new double[this.rectangle_array.Length];
            double currentMaxArea = this.rectangle_array[0].Area();

            for (int i = 1; i < this.rectangle_array.Length; i++)
            {
                if (this.rectangle_array[i] != null)
                {
                    double currentRectArea = this.rectangle_array[i].Area();
                    areas.Append(currentRectArea);

                    if (currentRectArea > currentMaxArea)
                    {
                        currentMaxArea = currentRectArea;
                    }
                }

            }

            return Array.IndexOf(areas, currentMaxArea);
        }

        public int NumberMinPerimeter()
        {
            double[] areas = new double[this.rectangle_array.Length];
            double currentMinArea = this.rectangle_array[0].Area();

            for (int i = 1; i < this.rectangle_array.Length; i++)
            {
                if (this.rectangle_array[i] != null)
                {
                    double currentRectArea = this.rectangle_array[i].Area();
                    areas.Append(currentRectArea);

                    if (currentRectArea < currentMinArea)
                    {
                        currentMinArea = currentRectArea;
                    }
                }

            }

            return Array.IndexOf(areas, currentMinArea);
        }

        public int NumberSquare()
        {
            int numOfSquares = 0;

            for (int i = 0; i < this.rectangle_array.Length; i++)
            {
                if(this.rectangle_array[i].IsSquare())
                {
                    numOfSquares++;
                }
            }

            return numOfSquares;
        }
    }
}

