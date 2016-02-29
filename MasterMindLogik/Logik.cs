using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindLogik
{
    public class Logik
    {
        public static int[] RandomArray()
        {
            var random = new int[4] {1,0,0,0};
            //Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //for (int i = 0; i < 4; i++)
            //{
            //      random[i] = rnd.Next(10);
            //}
            return random;
        }
        public static int[] SpielLogik(int[] random, int[] input)
        {
            int[] inputCopy = new int[input.Length];
            int[] randomCopy = new int[4];
            int[] trefferListe = new int[4];
            int indexCount = 0;
            int numberCount = 0;
            Array.Copy(input, inputCopy, input.Length);
            Array.Copy(random, randomCopy, random.Length);
            
            for (int i = 0; i < 4; i++)
            {
                if (random[i] == input[i])
                {
                    inputCopy[i] = -1;
                    randomCopy[i] = -1;
                    indexCount++;
                }
            }
            for (int i = 0; i < randomCopy.Length; i++)
            {
                if (randomCopy[i] >= 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (inputCopy[j] >= 0)
                        {
                            if (randomCopy[i] == inputCopy[j])
                            {
                                randomCopy[i] = -2;
                                inputCopy[j] = -2;
                                numberCount++;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < indexCount; i++)
            {
                trefferListe[i] = -1;
            }
            for (int j = indexCount; j < indexCount + numberCount; j++)
            {
                trefferListe[j] = -2;
            }
            return trefferListe;
        }
        public static bool Won(int[] trefferListe)
        {
            bool won = false;
            if (trefferListe.All(x => x == -1))
            {
                won = true;
            }
            return won;
        }
    }
}
