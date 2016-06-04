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

        public Population(int numberOfIndividuals, int chromosomeLength, Func<double, double> fitnessFunction, 
            Random random)
        {
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
    }
}
