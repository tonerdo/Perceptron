using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] outputs = new double[] { 1, 1, 1, 1 };
            double[][] inputs = new double[4][] {
											new double[] {1, 0},
											new double[] {0, 1},
											new double[] {1, 2},
											new double[] {0, 3}
										};
            double[] weights = new double[inputs[0].Length];

            Console.Write("Initial Weights: ");
            foreach (double weight in weights)
            {
                Console.Write(weight + " ");
            }
            Console.WriteLine();

            Perceptron perceptron = new Perceptron();
            perceptron.Inputs = inputs;
            perceptron.Outputs = outputs;
            perceptron.Weights = weights;
            perceptron.Train();

            Console.ReadKey(true);
        }
    }
}
