using Grafy_mag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy_mag.Services
{
    public static class Helper
    {
        public static Edge? GetEdge(this List<Edge> l, int nodeF, int nodeS)
        {
            if (nodeS < nodeF)
            {
                var t = nodeF;
                nodeF = nodeS;
                nodeS = t;
            }

            foreach (var edge in l)
            {
                if (nodeF == edge.NodeFirst && nodeS == edge.NodeSecond)
                {
                    return edge;
                }
            }
            return null;
        }

        public static int[] GetRandomCycle(int nodeCount)
        {
            var r = new Random();
            var cycle = new int[nodeCount + 1];
            var nodesToRoll = new List<int>(nodeCount);
            for (var i = 0; i < nodeCount; i++)
            {
                nodesToRoll.Add(i);
            }

            for (var i = 0; i < nodeCount; i++)
            {
                var rolledIndex = r.Next(nodesToRoll.Count);
                cycle[i] = nodesToRoll[rolledIndex];
                nodesToRoll.RemoveAt(rolledIndex);
            }
            cycle[nodeCount] = cycle[0];

            return cycle;
        }

        public static Tuple<int, int> OrderNodes(int i, int j)
        {
            if (i < j)
            {
                return Tuple.Create(i, j);
            }
            else if (j < i)
            {
                return Tuple.Create(j, i);
            }
            else
            {
                return null;
            }
        }

        public static int CountCost(int[][] permutationsMatrix, int[] cycle)
        {
            var cost = 0;

            for (var i = 0; i < permutationsMatrix.GetLength(0); i++)
            {
                var nodes = Helper.OrderNodes(cycle[i], cycle[i + 1]);
                cost += permutationsMatrix[nodes.Item2][nodes.Item1];
            }
            return cost;
        }

        public static bool IsSame(this int[] c, int[] other)
        {
            if (c.Length != other.Length)
            {
                return false;
            }

            for (var i = 0; i < c.Length; i++)
            {
                if (c[i] != other[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static Cycle GetBest(this IEnumerable<Cycle> cycles, int[][] perms)
        {
            Cycle best = new Cycle();
            foreach (Cycle cycle in cycles)
            {
                if (cycle.GetCost(perms) < best.GetCost(perms))
                {
                    best = cycle;
                }
            }
            return best;
        }

    }
}
