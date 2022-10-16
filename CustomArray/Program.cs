using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray arr1 = new CustomArray(5);
            arr1.AddElement(0);
            arr1.AddElement(1);
            arr1.AddElement(2);
            arr1.AddElement(3);
            arr1.AddElement(4);
            arr1.DisplayArray();
            
        }
    }
}
