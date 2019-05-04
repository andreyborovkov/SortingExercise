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
            int[] array = { 58, 22, 18, 23, 13, 17, 30 };

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

        private static int[] GetSmallestDigitsArray(int[] array)
        {
           var smallestDigitsArray = new int[array.Length];

           for (int i = 0; i < array.Length; i++)
            {
                smallestDigitsArray[i] = GetSmallestDigit(array[i]);
            }

            return smallestDigitsArray;
        }


        private static int[] GetSortedArrayBySmallestDigits(int[] array)
        {
            var smallestDigitsArray = GetSmallestDigitsArray(array);
            int temp;
            int temp2;

            for (int j = 0; j <= smallestDigitsArray.Length - 2; j++)
            {
                for (int i = 0; i <= smallestDigitsArray.Length - 2; i++)
                {
                    if (smallestDigitsArray[i] > smallestDigitsArray[i + 1])
                    {
                        temp = smallestDigitsArray[i + 1];
                        temp2 = array[i + 1];

                        smallestDigitsArray[i + 1] = smallestDigitsArray[i];
                        array[i + 1] = array[i];

                        smallestDigitsArray[i] = temp;
                        array[i] = temp2;
                    }
                }
            }

            return array;
        }


        private static void DisplayResults(int[] array)
        {
            var sortedArray = GetSortedArrayBySmallestDigits(array);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

        } 


    }
}
