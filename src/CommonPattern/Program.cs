using System;

namespace CommonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Common Pattern";
            //const string input = "contest.txt context.txt";
            const string input = "config.sys config.inf configures";

            var outPut = Execute(input);
            Console.WriteLine(outPut);
            Console.ReadLine();
        }

        private static string Execute(string input)
        {
            string[] splittedInputs = input.Split(' ');
            string outPut = string.Empty;
            string firstSampleValue = splittedInputs[0];

            for (int i = 0; i < firstSampleValue.Length; i++)
            {
                bool isMatched = true;
                for (int j = 1; j < splittedInputs.Length; j++)
                {
                    string firstVal = splittedInputs[j];
                    if (firstSampleValue[i] != firstVal[i])
                    {
                        isMatched = false;
                        break;
                    }
                }

                if (!isMatched)
                {
                    outPut += '?';
                }
                else
                {
                    outPut += firstSampleValue[i];
                }
            }

            return outPut;
        }
    }
}
