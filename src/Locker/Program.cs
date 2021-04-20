using System;
using System.Linq;

namespace Locker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Locker";
            const uint numberOfLockers = 9;
            var lockerArray = Execute(numberOfLockers);

            Console.WriteLine($"{lockerArray[0]}");
            Console.ReadLine();
        }

        private static int[] Execute(uint numberOfLockers)
        {
            int[] lockerArray = new int[numberOfLockers];

            for (int i = 0; i < numberOfLockers; i++)
                lockerArray[i] = i + 1;

            int n = 1;
            while (lockerArray.Length > 1)
            {
                int[] unlockedLockers = new int[numberOfLockers];
                for (int i = 0; i < lockerArray.Length; i++)
                {
                    int index = i == 0 ? 0 : (n + 1) * i;
                    if (index >= lockerArray.Length)
                        break;

                    unlockedLockers[i] = lockerArray[index];
                }

                lockerArray = lockerArray.Except(unlockedLockers).ToArray();
                n++;
            }

            return lockerArray;
        }
    }
}
