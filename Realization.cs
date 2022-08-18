using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Realization
    {
        public void MEthod()
        {
            Random rand = new();
            const int ROW = 10;
            const int COL = 10;
            
            int[,] ar = new int[ROW, COL];
            for (int k = 0; k < ar.GetLength(0); k++)
            {
                for (int g = 0; g < ar.GetLength(1); g++)
                {
                    ar[k, g] = rand.Next(0, 10);
                }
            }
            
            for(int k =0; k < ar.GetLength(0); k++)
            {
                for(int l = 0; l <ar.GetLength(1); l++)
                {
                    int Min = k;
                    int min = l;
                    for(int i = 0; i < ar.GetLength(0); i++)
                    {
                        for (int j = 0; j < ar.GetLength(1);j++)
                        {
                            if(ar[i,j] > ar[Min, min])
                            {
                                Min = i;
                                min = j;
                            }
                            Swap(ref ar[k, l], ref ar[Min, min]);
                        }
                    }
                }
            }



            for (int k = 0; k < ar.GetLength(0); k++)
            {
                for (int g = 0; g < ar.GetLength(1); g++)
                {
                    Console.Write(ar[k, g] + " ");
                }
                Console.WriteLine();
            }


           

            void Swap(ref int a, ref int b)
            {
                int c = a;
                a = b;
                b = c;
            }
        }


    }
}
