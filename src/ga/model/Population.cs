using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.model
{
    class Population
    {
        public List<Individual> Individuals { get; set; }

        private Func<double, double> _fitnessFunction;
        private Random _random;

        public Population(int numberOfIndividuals, int chromosomeLength, Func<double, double> fitnessFunction, 
            Random random)
        {
            _random = random;
            Individuals = Enumerable.Range(0, numberOfIndividuals)
                .Select(x => new Individual(chromosomeLength, random))
                .ToList();
            _fitnessFunction = fitnessFunction;

            UpdateFitness();
        }

        public void UpdateFitness()
        {
            foreach (var individual in Individuals)
            {
                individual.Fitness = _fitnessFunction(individual.Chromosome.Fenotype);
            }
        }

        public Population RouletteSelection()
        {
            var result = new Population(Individuals.Count, Individuals.First().Chromosome.Genes.Count, _fitnessFunction, _random);
            UpdateFitness();
            var sumOfFitness = Individuals.Sum(x => x.Fitness);
            var probabilities = Individuals.Select(x => x.Fitness / sumOfFitness);
            var distribution = new List<double>(probabilities);

            for (int i = 1; i < distribution.Count; i++)
            {
                distribution[i] += distribution[i - 1];
            }

            

            return result;
        }

        private Individual GetIndividual(List<double> distribution)
        {
            var rand = _random.NextDouble();
            Individual result = null;

            for (int i = 0; i < distribution.Count; i++)
            {
                if (rand < distribution[i])
                {
                    result = new Individual(Individuals[i]);
                }
            }

            return result;
        }
    }
}
