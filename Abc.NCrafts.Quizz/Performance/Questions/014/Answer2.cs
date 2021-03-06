﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Abc.NCrafts.Quizz.Performance.Questions._014
{
    public class Answer2
    {
        private static readonly List<int> _values;

        static Answer2()
        {
            var random = new Random();
            _values = Enumerable.Range(0, 200)
                                .Select(_ => random.Next(5000))
                                .ToList();
        }

        public static void Run()
        {
            var sum = 0;
            // begin
            foreach (var value in _values)
            {
                if (value < 10)
                    sum += 1000;
                else if (value < 20)
                    sum += 2000;
                else if (value < 30)
                    sum += 3000;
                else if (value < 40)
                    sum += 4000;
                else if (value >= 100)
                    sum += 42;
                else if (value % 2 == 0)
                    sum += 1;
            }
            // end
            Logger.Log("Sum: {0}", sum);
        }
    }
}
