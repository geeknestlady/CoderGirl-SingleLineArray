using System;

namespace SingleLineArray
{
    public static class Program
    {
        public static void Main()
        {
            int[] allTheSingleLadies = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int lady in allTheSingleLadies)
            {
                Console.WriteLine(lady);
            }
            // TODO: Initialize a single line an array with the following values: 1, 1, 2, 3, 5, 8. 

            // TODO: Loop through the array using foreach and print out each value on its own line.

            Console.ReadLine();
        }
    }
}
