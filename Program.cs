using System;

namespace Runup
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int output = Goup(input);
            Console.WriteLine($"{output}");
        }

        static int Goup(int i)
        {
            if (i<=2)
                return i;
            else
            {
                int a = 1, b = 2, tmp = 0;
                for(int n=3;n<=i;n++)
                {
                    tmp = a + b;
                    a = b;
                    b = tmp;
                }
                return tmp;
            }
        }
    }
}
