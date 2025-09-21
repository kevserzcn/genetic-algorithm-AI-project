using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Odev
{
    public class Chromosome
    {
        public double[] Genes { get; set; }
        public double Fitness { get; set; }

        public Chromosome(int dimension)
        {
            Genes = new double[dimension];
        }

        public Chromosome Clone()
        {
            Chromosome clone = new Chromosome(Genes.Length);
            Genes.CopyTo(clone.Genes, 0);
            clone.Fitness = Fitness;
            return clone;
        }
    }
}
