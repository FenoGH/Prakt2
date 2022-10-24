using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMas2
{
    public class LibMas3
    {
        public static double Reshenie( int[] mas)
        {
            int d;
            double sum = 0;
            for ( int i = 0; i < mas.Length; i++)
            {
                d = mas[i];
                if (d < 3)
                {
                    sum += d;
                }
                
            }
            
            return Math.Cos(sum);


        }

        public static object Reshenie(int[,] mas)
        {
            throw new NotImplementedException();
        }
    }
}
