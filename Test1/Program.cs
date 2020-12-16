using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 0; x <= 4; x++)
            {
                Console.WriteLine();
                //for(int y = 0; y < x; y++)
                //{
                //    Console.Write("*");
                //}     
                for(int z = 0; z < x ; z++)
                {
                    Console.Write("*");
                }



            }
        }
    }
}
