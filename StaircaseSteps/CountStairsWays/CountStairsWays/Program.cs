using System;

namespace CountStairsWays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] possibleSteps = { 1, 2};
            int totalSteps = 4;
            int[] result = new int[totalSteps];
            printWays(totalSteps, result, possibleSteps, 0, 0);
        }

        private static void printWays(int totalSteps, int[] path, int[] possibilities, int pathIndex, int sumSoFar)
        {
            if(sumSoFar == totalSteps)
            {
                printPathUptoIndex(path, pathIndex);
                return;
            }

            foreach(int p in possibilities)
            {
                if((sumSoFar + p) <= totalSteps)
                {
                    path[pathIndex] = p;
                    printWays(totalSteps, path, possibilities, pathIndex + 1, sumSoFar + p);
                }
            }
        }

        private static void printPathUptoIndex(int[] path, int pathIndex)
        {
            for(int i = 0; i < pathIndex; i++)
            {
                Console.Write(path[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
