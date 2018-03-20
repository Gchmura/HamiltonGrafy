using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonianCircuit.Models
{
    public static class RandomService
    {
        private static Random rand = new Random();
        
        public static int GetNoOfEdges(int vertex)
        {
            //Properties.Settings.Default.Probability
            var probability = rand.Next(100);
            int numberOfEdges = 0;
            for (int i = 0; i < vertex; i++)
            {
                if (probability <= ConstsValues.percentageProbability)
                {
                    i++;
                }
              
            }

            return numberOfEdges;
            

        }
    }
}
