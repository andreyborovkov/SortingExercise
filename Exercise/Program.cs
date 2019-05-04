using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 50, 15, 3, 1, 21 };

            DisplayResults(array);
            Console.ReadKey();
        }


        private static int GetSmallestDigit(int number)
        {
            var n = number;
            var r = 0;
            var sml = 9;

            while (n > 0)
            {
                r = n % 10;

                if (sml > r)
                {
                    sml = r;
                }
                n = n / 10;
            }
            return sml;
        }

        private static int GetFirstDigit(int number)
        {
            int temp = number;

            while (temp >= 10)
            {
                temp /= 10;
            }
            return temp; 
        }

        private static int[] GetSortedArray(int[] array)
        {            

            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    int smallestDigitOfI = GetSmallestDigit(array[i]);
                    int firstDigitOfI = GetFirstDigit(array[i]);
                    int smallestDigitOfJ = GetSmallestDigit(array[j]);
                    int firstDigitOfJ = GetFirstDigit(array[j]);

                    if (smallestDigitOfI > smallestDigitOfJ)
                    {
                        Swap(array, i, j);
                    } else if (smallestDigitOfI == smallestDigitOfJ)
                    {
                        if (firstDigitOfI > firstDigitOfJ)
                        {
                            Swap(array, i, j);
                        } else if (firstDigitOfI == firstDigitOfJ)
                        {
                            if (array[i] > array[j])
                            {
                                Swap(array, i, j);
                            }
                        }
                    }
                }

            }

        return array;
    }


        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }


        private static void DisplayResults(int[] array)
        {
            var sortedArray = GetSortedArray(array);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

        } 

    }
}
