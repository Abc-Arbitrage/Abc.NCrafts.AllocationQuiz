﻿namespace Abc.NCrafts.Quizz.Questions._023
{
    public class Answer
    {
        private static readonly string _s1 = "Ncrafts";
        private static readonly char[] _trimedChars = { 's' };

        public static void Run()
        {
            // begin
            var s2 = _s1.Trim(_trimedChars);
            // end

            Logger.Log(s2);
        }
    }
}