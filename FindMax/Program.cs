using System;
namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMaxInteger(1, 2, 3);
            operation.FindMaxFloat(1.2f, 1.6f, 1.1f);
            operation.FindMaxString("a", "b", "c");

      
            int[] arr = { 5, 2, 3 ,4};
            float[] Farr = { 1.2f, 1.8f, 2.0f,0.2f };
            string[] Sarr= { "d", "b", "c","a" };

            GenericOperations genericOperation = new GenericOperations();
            Console.WriteLine("\n\nGeneric:\n");

            

            genericOperation.FindMax<int>(arr);
            genericOperation.FindMax<float>(Farr);
            genericOperation.FindMax<string>(Sarr);
        }
    }
}