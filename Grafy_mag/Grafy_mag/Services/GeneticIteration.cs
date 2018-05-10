using Grafy_mag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy_mag.Services
{
    class GeneticIteration
    {
        public static Population Next(Population starting, int functions, int[][][] permutationMatrices, double mutationProbability)
        {
            foreach (Cycle cycle in starting.Cycles)
            {
                MutationNodeSwap.Mutation(cycle, mutationProbability);
            }

            var split = starting.Split(functions);

            List<Cycle>[] winners = new List<Cycle>[functions];
            for (int i = 0; i < functions; i++)
            {
                winners[i] = Tourney.Eliminate(split[i], permutationMatrices[i]);
            }
            Population NewPop = new Population(starting.Cycles.Count - winners.Sum(x => x.Count), starting.NodeCount);
            NewPop.Cycles.AddRange(winners.SelectMany(x => x));

            return NewPop;
        }
    }
}
