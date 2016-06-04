using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.model
{
    public class Chromosome
    {
        public List<bool> Genes { get; set; }

        public double Fenotype
        {
            get
            {
                return CalculateFenotype();
            }
        }

        public Chromosome(int chromosomeLength, Random random)
        {
            Genes = Enumerable.Range(0, chromosomeLength)
                .Select(x => random.NextDouble() <= 0.5)
                .ToList();
        }

        private double CalculateFenotype()
        {
            double wynik = 0;
            for (int i = Genes.Count-1, j = 0; i >= 0; i--, j++)
            {
                wynik += Convert.ToDouble(Genes[i]) * Math.Pow(2, j);
            }
            Console.WriteLine($"x: {wynik}");

            return wynik;
        }
    }
}
