using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Perceptron
    {
        public double LearningRate { get; set; }
        public double Threshold { get; set; }
        public double[][] Inputs { get; set; }
        public double[] Outputs { get; set; }
        public double[] Weights { get; set; }
        private int Length { get; set; }

        public Perceptron()
        {
            this.LearningRate = 0.1;
            this.Threshold = 0.5;
        }

        public void Train()
        {
            this.Length = Weights.Length;

            for (int a = 0; a < 100; a++)
            {
                for (int i = 0; i < this.Inputs.Length; i++)
                {
                    double[] c = new double[this.Inputs.Length];
                    double s = 0;
                    double n = 0;
                    double e = 0;
                    double d = 0;

                    for (int j = 0; j < this.Length; j++)
                    {
                        c[j] = this.Inputs[i][j] * this.Weights[j];
                    }

                    s = c.Sum();
                    n = ActivationFunction(s);
                    e = this.Outputs[i] - n;
                    d = this.LearningRate * e;

                    for (int k = 0; k < this.Weights.Length; k++)
                    {
                        this.Weights[k] = this.Weights[k] + (this.Inputs[i][k] * d);
                    }

                    Console.WriteLine("Iteration: " + (a + 1));
                    Console.WriteLine("Target Output: " + this.Outputs[i]);
                    Console.WriteLine("Network Output: " + n);
                    Console.WriteLine("Error: " + e);
                    Console.Write("Weights: ");
                    foreach (double weight in this.Weights)
                    {
                        Console.Write(weight + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

        }

        public double ActivationFunction(double output)
        {
            if (output > this.Threshold)
                return 1;
            else
                return 0;
            //return output;
            //return Math.Round(output);
        }
    }
}
