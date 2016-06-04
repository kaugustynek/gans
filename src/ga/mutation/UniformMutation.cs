using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.mutation
{
    public class UniformMutation : IMutatationOperator
    {
        private readonly Random _random;
        private readonly double _mutationProbability;

        public UniformMutation(Random random, double mutationProbability)
        {
            _random = random;
            _mutationProbability = mutationProbability;
        }

        public void Mutate(Chromosome chromosome)
        {
            for (int i = 0; i < chromosome.Genes.Count; i++)
            {
                if (_random.NextDouble() <= _mutationProbability)
                {
                    chromosome.Genes[i] = !chromosome.Genes[i];
                }
            }
        }
    }
}
