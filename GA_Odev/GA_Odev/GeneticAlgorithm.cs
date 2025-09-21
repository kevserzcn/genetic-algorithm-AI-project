using System;
using System.Collections.Generic;
using System.Linq;

namespace GA_Odev
{
    public class GeneticAlgorithm
    {
        private static Random rand = new Random();

        public int PopulationSize { get; set; }
        public int Dimension { get; set; }
        public double CrossoverRate { get; set; }
        public double MutationRate { get; set; }
        public int ElitismCount { get; set; }

        private List<Chromosome> population;
        public Chromosome BestIndividual { get; private set; }

        private double lowerBound = -50.0;
        private double upperBound = 50.0;

        public GeneticAlgorithm(int populationSize, int dimension,
                                double crossoverRate, double mutationRate,
                                int elitismCount)
        {
            PopulationSize = populationSize;
            Dimension = dimension;
            CrossoverRate = crossoverRate;
            MutationRate = mutationRate;
            ElitismCount = elitismCount;
        }
        public List<double> Run(int maxGenerations)
        {

            population = InitializePopulation();


            BestIndividual = new Chromosome(Dimension);
            double bestFitness = double.MaxValue;


            List<double> bestFitnessHistory = new List<double>();

            for (int generation = 0; generation < maxGenerations; generation++)
            {

                foreach (var ind in population)
                {
                    ind.Fitness = RosenbrockFunc(ind.Genes);
                }


                var currentBest = population.OrderBy(ind => ind.Fitness).First();
                if (currentBest.Fitness < bestFitness)
                {
                    bestFitness = currentBest.Fitness;
                    BestIndividual = currentBest.Clone();
                }

                bestFitnessHistory.Add(bestFitness);

                List<Chromosome> newPopulation = new List<Chromosome>();

                population.Sort((a, b) => a.Fitness.CompareTo(b.Fitness));
                for (int i = 0; i < ElitismCount; i++)
                {
                    newPopulation.Add(population[i].Clone());
                }

                while (newPopulation.Count < PopulationSize)
                {
                    Chromosome parent1 = TournamentSelection(population);
                    Chromosome parent2 = TournamentSelection(population);

                    (Chromosome child1, Chromosome child2) = Crossover(parent1, parent2);

                    Mutate(child1);
                    Mutate(child2);

                    newPopulation.Add(child1);
                    if (newPopulation.Count < PopulationSize)
                        newPopulation.Add(child2);
                }

                population = newPopulation;
            }

            return bestFitnessHistory;
        }

        private List<Chromosome> InitializePopulation()
        {
            var initialPopulation = new List<Chromosome>();

            for (int i = 0; i < PopulationSize; i++)
            {
                var individual = new Chromosome(Dimension);

                for (int j = 0; j < Dimension; j++)
                {
                    individual.Genes[j] = rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
                }

                initialPopulation.Add(individual);
            }

            return initialPopulation;
        }


        private Chromosome TournamentSelection(List<Chromosome> pop)
        {
            int tournamentSize = 2;
            Chromosome best = null;

            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = rand.Next(pop.Count);
                Chromosome contender = pop[randomIndex];

                if (best == null || contender.Fitness < best.Fitness)
                {
                    best = contender;
                }
            }

            return best;
        }
        
        private (Chromosome, Chromosome) Crossover(Chromosome parent1, Chromosome parent2)
        {
            Chromosome child1 = parent1.Clone();
            Chromosome child2 = parent2.Clone();

            if (rand.NextDouble() < CrossoverRate)
            {
                int crossoverPoint = rand.Next(1, Dimension);

                for (int i = crossoverPoint; i < Dimension; i++)
                {
                    double temp = child1.Genes[i];
                    child1.Genes[i] = child2.Genes[i];
                    child2.Genes[i] = temp;
                }
            }

            return (child1, child2);
        }


        private void Mutate(Chromosome individual)
        {
            for (int i = 0; i < Dimension; i++)
            {
                if (rand.NextDouble() < MutationRate)
                {
                    double mutationStrength = 0.1;
                    double delta = (rand.NextDouble() * 2.0 - 1.0) * mutationStrength;
                    individual.Genes[i] += delta;


                    if (individual.Genes[i] < lowerBound) individual.Genes[i] = lowerBound;
                    if (individual.Genes[i] > upperBound) individual.Genes[i] = upperBound;
                }
            }
        }
        public double RosenbrockFunc(double[] genes)
        {
            double fitness = 0.0;

            for (int i = 0; i < genes.Length - 1; i++)
            {
                double xi = genes[i];
                double xi1 = genes[i + 1];

                fitness += 100 * Math.Pow(xi1 - xi * xi, 2) + Math.Pow(xi - 1, 2);
            }

            return fitness;
        }
     
    }
}
