using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    
    class Program
    {
        public static int randomNumber()
        {
            Random r = new Random();
            return r.Next(2);
            
        }
        static void Main(string[] args)
        {
            int[,] array = new int[,] { {1,0,0,0,0,0,0},
                                        {0,1,0,0,0,0,0},
                                        {0,0,1,0,0,0,0},
                                        {0,0,0,1,0,0,0},
                                        {0,0,0,0,1,0,0},
                                        {0,0,0,0,0,1,0},
                                        {0,0,0,0,0,0,1},
                                         };


            int[] test = new int[array.GetLength(0)];
            int sum = 0;
            

            Random r = new Random();
            
            //for(int i=0;i<4;i++)
            //{
            //    for(int j=0;j<4;j++)
            //    {
            //        array[i, j] = r.Next(2);
            //    }
            //}
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[i, j]+" ");
                    if(i==j)
                    {
                        test[i] = array[i, j];
                    }
                }
                Console.WriteLine();
            }
            for (int i=0;i<test.Length;i++)
            {
                sum += test[i];
            }
            Console.WriteLine(test.Length);
            if(sum==test.Length)
            {
                Console.WriteLine("diagonal ones");
            }
            else
            {
                Console.WriteLine("connected ");
            }



            Console.ReadKey();
        }
    }
}
