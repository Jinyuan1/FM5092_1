using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM5092_A1
{
    //Here we created a class named Simulator. Which is used to do the Monte Carlo simulation.
    class Simulator
    {
        //The method Simulate is used to do the Monte Carlo Simulation.
        //The input of this method are, underlying price S0, volatility sigma, risk free rate r, tenor T, the number of steps steps, the number of trails N,
        //and a matrix of normal distributed random variable R which is given by the RandGenerator class.
        public static double[,] Simulate(double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double dt;
            int i, j;
            dt = T / steps;//Here we difine the time lenth of every steps.
            //We define a N * steps+1 matrix, which will be used as output later.
            double[,] S = new double[N, steps + 1];


            for (i = 0; i < N; i++)
            {
                S[i, 0] = S0;//Firstly, We difine that, in every trials, the first steps of the underlying price is S0.
            }
            for (j = 0; j < N; j++)
            {
                for (i = 1; i <= steps; i++)
                {
                    //Then using the formula of Monte Carlo simulation, we can have the underlying price of every steps.
                    //The random value R[j, i-1] we used here is given by the RandGenerator class, and it can be used later.
                    S[j, i] = S[j, i - 1] * Math.Exp((r - sigma * sigma / 2) * dt + sigma * Math.Sqrt(dt) * R[j, i - 1]);
                }
            }
            //The output of this method is matrix S. S[i,j] is the underlying price of the i-th step, the j-th trial.
            return S;
        }
    }
}
