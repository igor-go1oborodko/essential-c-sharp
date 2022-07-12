using System;

enum SortOrder
{
    Ascdending,
    Descengin
}

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    static bool isSorted(int[] arr, bool order)
    {
        if (order)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
        }
        else
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
        }

        return true;
    }
}