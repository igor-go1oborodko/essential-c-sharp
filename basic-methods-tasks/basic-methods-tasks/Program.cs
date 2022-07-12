enum SortOrder
{
    Ascdending,
    Descengin
}

namespace Application
{
    class Program
    {
        static bool isSorted(int[] arr, SortOrder order)
        {
            if (order == SortOrder.Ascdending)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Transform(int[] arr, SortOrder order)
        {
            bool isArraySorted = isSorted(arr, order);

            if (isArraySorted)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] + i;
                }
            }

        }

        static int MultArithmeticElements(int a, int t, int n)
        {
            if (n == 1)
            {
                return a;
            }

            return a * MultArithmeticElements(a + t, t, n - 1);
        }

        static double SumGeometricElements(double a, double t, double alim)
        {
            if (a <= alim)
            {
                return 0;
            }

            return a + SumGeometricElements(a * t, t, alim);
        }
    }

}