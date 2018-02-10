using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM5092_A1
{
    //We creat an options class, and will use it as a parent class for all kinds of options.
    public class Options
    {
        //We difined several property of the objects in the option class.
        //Isput indicates that if this objects is put option or call option.
        public bool isput = false;
        //S0 is the underlying price, K is the strike price, r is the risk free rate, sigma is volatility, T is tenor.
        public double S0, K, r, sigma, T;
        //In order to calculate greek values, I set the random variables matrix R as a property for now. 
        //Actually I don't think this is a good idea, and I will find some way to improve this.
        public double[,] R;
        //This method is used to get the results of the Simulator.Simulate method.
        public double[,] Getsim(int steps, int N)
        {
            double[,] sims;
            sims = Simulator.Simulate(S0, sigma, r, T, steps, N, R);
            return sims;
        }
    }

    //We created another class named EuroOption, which inherited the parent class Options.
    public class EuroOption : Options
    {
        //This method is used to calculate the European option price.
        public double PriceEuro(int steps, int N)
        {
            double sum = 0;
            int i;
            //We used the simulation matrix we obtained.
            double[,] sims;
            sims = Getsim(steps, N);
            for (i = 0; i < N; i++)
            {
                if (isput == false)
                {
                    //Gives the option price of call option.
                    sum += Math.Max(sims[i, steps] - K, 0);
                }
                else
                {
                    //Gives the option price of put option.
                    sum += Math.Max(K - sims[i, steps], 0);
                }
            }
            return (sum / N) * Math.Exp(-r * T);
        }
        //This method is used to calculate the standard error.
        public double Std(int steps, int N)
        {
            double[,] sims;
            sims = Getsim(steps, N);
            int i;
            double sums = 0;
            double price = PriceEuro(steps, N);
            for (i = 0; i < N; i++)
            {
                //Use the formula directly.
                sums += Math.Pow((sims[i, steps] * Math.Exp(-r * T) - price), 2);
            }
            //Give the output by difinition.
            return Math.Sqrt(sums / (N - 1) / N);
        }
    }


}
