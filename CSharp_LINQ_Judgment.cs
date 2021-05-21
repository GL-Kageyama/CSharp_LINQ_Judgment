using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var judgeClass = new JudgeClass();

            judgeClass.GetJudge();
        }
    }

    class JudgeClass
    {
        List<int> source = new List<int>
        {
            2, 4, 6, 8, 10, 12, 14, 16
        };

        public void GetJudge()
        {
            // All()
            // Determine if all elements meet the conditions
            Console.WriteLine(source.All(e => e >= 6));

            // Any()
            // Determine whether elements that satisfy the conditions are included
            Console.WriteLine(source.Any(e => e >= 14));

            // Contains()
            // Determine if the specified element is included
            Console.WriteLine(source.Contains(11));

            // SequenceEqual()
            // Determine if two sequences are equal
            Console.WriteLine(source.SequenceEqual(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16}));
        }
    }
}