using System;

namespace CSharp
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int maxValue = 0;
            foreach (int score in scores)
            {
                if (score > maxValue)
                {  
                    maxValue = score;
                }
            }
            return maxValue;
        }

        static int GetAverageScore(int[] scores)
        {
            int averageValue = 0;
            foreach (int score in scores)
            {
                averageValue += score;
            }
            averageValue/=scores.Length;
            return averageValue;
        }

        static int GetindexOf(int[] scores, int value)
        {
            
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i;
                } 
            }
            return -1;
        }

        static void sort(int[] scores)
        {
            int lowestScore = 0;
            int[] sortedScores = new int[scores.Length];
            for (int j = 0; j < scores.Length; j++)
            {
                lowestScore = scores[j];

                for (int i = 0; i < scores.Length; i++)
                {
                    if (lowestScore > scores[i])
                    {
                        lowestScore = scores[i];
                        break;
                    }

                    scores[j] = lowestScore;
                }
            }
        }
        static void Main(string[] agrs)
        {
            
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int highestScore = GetHighestScore(scores);
            Console.WriteLine(highestScore) ;

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int indexOf = GetindexOf(scores, 50);
            Console.WriteLine(indexOf);

            sort(scores);
        }
    }
}