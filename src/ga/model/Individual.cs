using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.model
{
    public class Individual
    {
        public double Fitness { get; set; }
        public Chromosome Chromosome { get; set; }

        public Individual(int chromosomeLength, Random random)
        {
            Chromosome = new Chromosome(chromosomeLength, random);
        }
    }
}
