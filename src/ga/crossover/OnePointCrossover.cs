using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.crossover
{
    public class OnePointCrossover : ICrossoverOperator
    {
        private readonly Random _random;

        public OnePointCrossover(Random random)
        {
            _random = random;
        }

        public void Crossover(Chromosome parent1, Chromosome parent2)
        {
            int tmp = _random.Next(1, parent2.Genes.Count - 1);
            Console.WriteLine($"Random = {tmp}");
            for (int i = tmp; i < parent2.Genes.Count; i++)
            {
                Console.WriteLine($"{parent1.Genes[i]} na {parent2.Genes[i]}");
                bool buffer = parent1.Genes[i];
                parent1.Genes[i] = parent2.Genes[i];
                parent2.Genes[i] = buffer;
            }
        }
    }
}
