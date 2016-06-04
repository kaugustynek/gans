using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga.mutation
{
    public interface IMutatationOperator
    {
        void Mutate(Chromosome chromosome);
    }
}
