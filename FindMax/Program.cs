using System;
namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operation operation = new Operation();
            //operation.FindMaxInteger(1, 2, 3);
            //operation.FindMaxFloat(1.2f, 1.6f, 1.1f);
            //operation.FindMaxString("a", "b", "c");


            GenericOperations genericOperation = new GenericOperations();
            Console.WriteLine("\n\nGeneric:\n");

            bool flag = true;
           
            Console.WriteLine("Enter the size of  array:");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the datatype:\n 1.Integer\n 2.Float\n 3.String\n 4.Exit");


            while (flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        int[] arr= new int[size];
                        for(int i = 0; i < size; i++)
                        {
                            arr[i]= Convert.ToInt32(Console.ReadLine());
                        }
                        genericOperation.FindMax<int>(arr);
                        break;
                    case 2:
                        float[] Farr = new float[size];
                        for(int i=0; i < size; i++)
                        {
                            Farr[i]=Convert.ToSingle(Console.ReadLine());
                        }
                        genericOperation.FindMax<float>(Farr);
                        break;
                    case 3:
                        string[] Sarr= new string[size];
                        for(int i = 0; i < size; i++)
                        {
                            Sarr[i] = Console.ReadLine();
                        }
                        genericOperation.FindMax<string>(Sarr);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}