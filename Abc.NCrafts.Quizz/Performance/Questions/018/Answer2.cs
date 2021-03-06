﻿using System.Collections;

namespace Abc.NCrafts.Quizz.Performance.Questions._018
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        private static readonly ArrayList _values;

        static Answer2()
        {
            _values = new ArrayList(100 * 1000);
        }

        public static void Run()
        {
            _values.Clear();

            // begin
            for (var i = 0; i < _values.Capacity; i++)
            {
                _values.Add("a" + "b" + "c");
            }
            // end
        }
    }
}