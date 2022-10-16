using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    class CustomArray
    {
        public static int Capacity { get; set; }

        public CustomArray(int capacity)
        {
            Capacity = capacity;
        }
        int[] arr = new int[Capacity];

        public int[] AddElement(int newItem)
        {
            if(arr.Length+1 <= Capacity)
            {
                Array.Resize(ref arr, arr.Length+1);
                arr[arr.Length - 1] = newItem;   
            }
            else
            {
                Console.WriteLine("It is overflowing!");
            }
            return arr;
        }

        public int FindIndexOfElement(int element)
        {
            if(arr.Length>0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == element)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int[] RemoveElementByIndex(int indexOfElement)
        {
            int[] newArr = new int[Capacity-1];
            int index = 0;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != indexOfElement)
                    {
                        newArr[index] = arr[i];
                        index++;
                    }
                }
                arr = newArr;
            }
            else
            {
                Console.WriteLine("You must add element to array first!");
            }
            return arr;
        }

        public void DisplayArray()
        {
            if(arr.Length>0)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("There is no element in array!");
            }
        }

        public int FirstElementOfArray()
        {
            if(arr.Length>0)
            {
                return arr[0];
            }
            else
            {
                Console.WriteLine("Array has no elements!");
                return -1;
            }
        }
        public int LastElementOfArray()
        {
            if (arr.Length > 0)
            {
                return arr[arr.Length-1];
            }
            else
            {
                Console.WriteLine("Array has no elements!");
                return -1;
            }
        }
    }
}
