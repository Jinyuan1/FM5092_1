using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM5092_A1
{
    //We created a class named GreeksCalculator to calculate the greek values.
    class GreeksCalculator
    {
        //This method is used to calculate vega.
        //Input includes, isput (call or put), underlying price S0, strike price K, volatility sigma, risk free rate r, tenor T, steps, number of trails N, and random variable matrix R.
        public static double Vega(Boolean isput, double K, double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double d = 0.0001 * sigma;
            //We creat an object with the same property of user's input.
            EuroOption O1 = new EuroOption();
            O1.isput = isput;
            O1.S0 = S0;
            O1.K = K;
            O1.sigma = sigma + d * sigma;
            O1.T = T;
            O1.r = r;
            //This R is same with the random matrix we used in calculating PriceEuro. 
            O1.R = R;
            //Define p1 as the option price with volatility (1+d)*digma
            double p1 = O1.PriceEuro(steps, N);
            O1.sigma = sigma - d * sigma;
            //Define p2 as the option price with volatility (1-d)*digma
            double p2 = O1.PriceEuro(steps, N);
            //Return vega.
            return (p1 - p2) / (2 * d * sigma);
        }
        //This method is used to calculate Delta.
        //Inputs are same with above.
        public static double Delta(Boolean isput, double K, double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double d = 0.0001 * S0;
            //We creat an object with the same property of user's input.
            EuroOption O1 = new EuroOption();
            O1.isput = isput;
            O1.S0 = S0 + d;
            O1.K = K;
            O1.sigma = sigma;
            O1.T = T;
            O1.r = r;
            O1.R = R;
            //Define a is the option price with initial underlying price (1+d)*S0.
            double a = O1.PriceEuro(steps, N);
            O1.S0 = S0 - d;
            //Define b is the option price with initial underlying price (1-d)*S0.
            double b = O1.PriceEuro(steps, N);
            //Return the value of delta.
            return (a - b) / (2 * d);
        }
        //This method is used to calculate rho.
        //Inputs are same with above.
        public static double Rho(Boolean isput, double K, double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double d = 0.0001 * r;
            //We creat an object with the same property of user's input.
            EuroOption O1 = new EuroOption();
            O1.isput = isput;
            O1.S0 = S0;
            O1.K = K;
            O1.sigma = sigma;
            O1.T = T;
            O1.r = r + d;
            O1.R = R;
            //Define a is the option price with risk free rate (1+d)*r.
            double a = O1.PriceEuro(steps, N);
            O1.r = r - d;
            //Define b is the option price with risk free rate (1-d)*r.
            double b = O1.PriceEuro(steps, N);
            //Return the value of rho.
            return (a - b) / (2 * d);
        }
        //This method is used to calculate gamma.
        //Inputs are same with above.
        public static double Gamma(Boolean isput, double K, double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            double d = 0.0001 * S0;
            //We creat an object with the same property of user's input.
            EuroOption O1 = new EuroOption();
            O1.isput = isput;
            O1.S0 = S0 + d;
            O1.K = K;
            O1.sigma = sigma;
            O1.T = T;
            O1.r = r;
            O1.R = R;
            //Define a is the option price with initial underlying price (1+d)*S0.
            double a = O1.PriceEuro(steps, N);
            O1.S0 = S0;
            //Define b is the option price with initial underlying price S0.
            double b = O1.PriceEuro(steps, N);
            O1.S0 = S0 - d;
            //Define c is the option price with initial underlying price (1-d)*S0.
            double c = O1.PriceEuro(steps, N);
            //Return the value of gamma.
            return (a + c - b - b) / (d * d);
        }
        //This method is used to calculate theta.
        //Inputs are same with above.
        public static double Theta(Boolean isput, double K, double S0, double sigma, double r, double T, int steps, int N, double[,] R)
        {
            //We creat an object with the same property of user's input.
            EuroOption O1 = new EuroOption();
            O1.isput = isput;
            O1.S0 = S0;
            O1.K = K;
            O1.sigma = sigma;
            O1.T = T - T / steps;
            O1.r = r;
            O1.R = R;
            //Define p1 as the option price with tenor T-T/steps.
            double p1 = O1.PriceEuro(steps - 1, N);
            O1.T = T;
            //Define p2 as the option price with tenor T.
            double p2 = O1.PriceEuro(steps, N);
            //Return the value of theta.
            return (p1 - p2) / (T / steps);
        }
    }
}
