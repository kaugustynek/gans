using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga
{
    public interface ISelectionAlgorithm
    {
        IEnumerable<Chromosome> GenerateParentPopulation(IEnumerable<Chromosome> population)
    }

    public class GeneticAlgorithm
    {
        public GeneticAlgorithm(int numberOfIndividuals, int chromosomeLength)
        {

        }

        Chromosome Solve(Func<double, double> fitnessFunction, ICrossoverOperator crossover, IMutatationOperator mutation, double crossoverProbability, double mutationProbability)
        {
            return new Chromosome(1, new Random());
        }
    }
}
