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
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (GetSmallestDigit(array[i]) > GetSmallestDigit(array[j]))
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    } else if (GetSmallestDigit(array[i]) == GetSmallestDigit(array[j]))
                    {
                        if (GetFirstDigit(array[i]) > GetFirstDigit(array[j]))
                        {
                            temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        } else if (GetFirstDigit(array[i]) == GetFirstDigit(array[j]))
                        {
                            if (array[i] > array[j])
                            {
                                temp = array[j];
                                array[j] = array[i];
                                array[i] = temp;
                            }
                        }
                    }
                }

            }

        return array;
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
