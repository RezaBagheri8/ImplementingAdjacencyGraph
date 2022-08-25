using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyGraph
{
    public class RecursiveFinding
    {
        int[,] numArray;
        int nodeQuantity;
        int firstChar = 65;
        int secondChar = 65;
        public RecursiveFinding()
        {
            nodeQuantity = int.Parse(Console.ReadLine());
            numArray = new int[nodeQuantity, nodeQuantity];
            GetInput();
        }

        public void GetInput(int i = 0, int j = 0)
        {
            if (j == nodeQuantity)
            {
                j = 0;
                i++;
            }
            if (i >= nodeQuantity)
            {
                return;
            }
            int value = int.Parse(Console.ReadLine());
            numArray[i, j] = value;
            GetInput(i, ++j);

        }

        public void FindAdjacency(int i = 0, int j = 0)
        {
            if (j == nodeQuantity)
            {
                j = 0;
                i++;
                secondChar = 65;
                firstChar++;
                Console.WriteLine("-----------------");
            }
            if (i >= nodeQuantity)
            {
                return;
            }
            if (numArray[i, j] == 1)
            {
                Console.WriteLine($"{(char)firstChar} -> {(char)secondChar}");
            }
            secondChar++;

            FindAdjacency(i, ++j);
        }
    }
}
