using ga.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga
{
    class Program
    {
        static void Main(string[] args)
        {
            Population populacja = new Population(5, 3, n => n*n, new Random());
        }
    }
}
