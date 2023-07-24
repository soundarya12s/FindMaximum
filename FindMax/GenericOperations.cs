using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    public class GenericOperations
    {
        public void FindMax<T>(T[] array)
        {
            Array.Sort(array);
            foreach(var data in array){
                 Console.writeLine(data);
            }
           
        }
       
    }
}
