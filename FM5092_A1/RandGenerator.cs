using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM5092_A1
{
    // I created a class named RandGenerator, which aimed to generate a set of normal distributed random variables.
    public class RandGenerator
    {
        //Here created a method. It uses uniform distributed random variable as an input, and use polar rejection
        //to transfrom it to a normal distributed random variable.
        public static double Polar(Random rnd)
        {
            double a, b, w, c;
            do
            {
                a = -1.0 + 2 * rnd.NextDouble();
                b = -1.0 + 2 * rnd.NextDouble();
                w = a * a + b * b;
            }
            while (w > 1);
            c = Math.Sqrt(-2 * Math.Log(w) / w);
            return c * a;
        }

        //We created a method named Randn, which will give a N * steps+1 matrix of normal distributed random variables.
        //N and steps are inputs.
        public static double[,] Randn(int N, int steps)
        {
            Random rnd = new Random();
            int i, j;
            //We define a N * steps+1 matrix, which will be used as output later.
            double[,] R = new double[N, steps + 1];
            //Then use for loop to define the elements in the matrix.
            for (j = 0; j < N; j++)
            {
                for (i = 1; i <= steps; i++)
                {
                    //Here we difined every elements in the matrix by using the Polar method we difined before.
                    //In this way, every elements in the matrix will be normal distributed.
                    R[j, i - 1] = RandGenerator.Polar(rnd);
                }
            }
            return R;
        }
    }
}
