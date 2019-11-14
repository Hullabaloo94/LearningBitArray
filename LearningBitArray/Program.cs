using System;
using System.Collections;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] preload = new bool[3] { true, false, true };
            
            /**enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);**/

            BitArray enemyGrid = new BitArray(preload);

            foreach (var gridItem in enemyGrid)
            {
                Console.WriteLine(gridItem);
            }

        }
    }
}
