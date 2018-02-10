using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Jinyuan Zhang, the first assignment of FM 5092.
namespace FM5092_A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.SetIconAlignment(txtS, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtK, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtsigma, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtr, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtT, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtsteps, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(txtN, ErrorIconAlignment.MiddleRight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Use the user input as the property of an object O1.
            EuroOption O1 = new EuroOption();
            O1.S0 = Convert.ToDouble(txtS.Text);
            O1.K = Convert.ToDouble(txtK.Text);
            O1.sigma = Convert.ToDouble(txtsigma.Text);
            O1.r = Convert.ToDouble(txtr.Text);
            O1.T = Convert.ToDouble(txtT.Text);

            //Generate a matrix with random values.
            int N, steps;
            N = Convert.ToInt32(txtN.Text);
            steps = Convert.ToInt32(txtsteps.Text);
            double[,] R = new double[N, steps + 1];
            R = RandGenerator.Randn(N, steps);

            O1.R = R;

            //Define the option is call option or put option.
            if (radioCall.Checked == true)
            {
                O1.isput = false;
            }
            else if (radioPut.Checked == true)
            {
                O1.isput = true;
            }

            //The following gives the value of option price, greek values, and standard error.
            //We used Math.Truncate to keep only 4 number after the decimal.
            lblPrice.Text = Convert.ToString(Math.Truncate(O1.PriceEuro(steps, N)*10000)/10000);
            lblDelta.Text = Convert.ToString(Math.Truncate(GreeksCalculator.Delta(O1.isput, O1.K, O1.S0, O1.sigma, O1.r, O1.T, steps, N, R)*10000)/10000);
            lblGamma.Text = Convert.ToString(Math.Truncate(GreeksCalculator.Gamma(O1.isput, O1.K, O1.S0, O1.sigma, O1.r, O1.T, steps, N, R)*10000)/10000);
            lblRho.Text = Convert.ToString(Math.Truncate(GreeksCalculator.Rho(O1.isput, O1.K, O1.S0, O1.sigma, O1.r, O1.T, steps, N, R)*10000)/10000);
            lblTheta.Text = Convert.ToString(Math.Truncate(GreeksCalculator.Theta(O1.isput, O1.K, O1.S0, O1.sigma, O1.r, O1.T, steps, N, R)*10000)/10000);
            lblVega.Text = Convert.ToString(Math.Truncate(GreeksCalculator.Vega(O1.isput, O1.K, O1.S0, O1.sigma, O1.r, O1.T, steps, N, R)*10000)/10000);
            lblStd.Text = Convert.ToString(Math.Truncate(O1.Std(steps, N) * 10000) / 10000);

        }

        //In the following section, we used an error provider to handle error inputs.
        //If an user entered a value that is not a number, he will be warned.
        private void txtS_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtS.Text, out num))
                errorProvider1.SetError(txtS, "please enter a number");
            else
                errorProvider1.SetError(txtS, string.Empty);
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtK.Text, out num))
                errorProvider1.SetError(txtK, "please enter a number");
            else
                errorProvider1.SetError(txtK, string.Empty);
        }

        private void txtsigma_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtsigma.Text, out num))
                errorProvider1.SetError(txtsigma, "please enter a number");
            else
                errorProvider1.SetError(txtsigma, string.Empty);
        }

        private void txtr_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtr.Text, out num))
                errorProvider1.SetError(txtr, "please enter a number");
            else
                errorProvider1.SetError(txtr, string.Empty);
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtT.Text, out num))
                errorProvider1.SetError(txtT, "please enter a number");
            else
                errorProvider1.SetError(txtT, string.Empty);
        }

        private void txtsteps_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtsteps.Text, out num))
                errorProvider1.SetError(txtsteps, "please enter a number");
            else
                errorProvider1.SetError(txtsteps, string.Empty);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(txtN.Text, out num))
                errorProvider1.SetError(txtN, "please enter a number");
            else
                errorProvider1.SetError(txtN, string.Empty);
        }
    }
}
