using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class GenericOperations
    {
        public T FindMax<T>(T[] array)
        {
            Array.Sort(array);
           
            PrintMax(array.Max());
            return array.Max();
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Max value:" + max);
        }
    }
}
