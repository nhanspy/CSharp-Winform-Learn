using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * 1Arraylist
 * stortedlist
 * stack
 * queue
 * dictionary
 * hashtable
 * stringcolection
 * */

namespace ConsoleLearn
{
    class Program
    {
        static void delete(int index, int[] arr)
        {
            bool check = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                    check = true;
                if (check) arr[i] = arr[i + 1];
            }

        }

        static void print(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
        }

        static void sortFunc(int [] arr)
        {
            for (int i = 0; i < arr.Length -1 ; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
                    }
                }
            }
        }

        static int search(int [] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (x == arr[i]) return i;
            return -1;
        }

        public static void Main(string [] args)
        {
            int[] arr = new int[] { 3,4,9,3,5,7};
           // Console.Write(search(arr,4));
            print(arr);

            Console.ReadKey();
        }
    }
}
