﻿namespace Abc.NCrafts.Quizz.Performance2018.Questions._012
{
    public class Answer2
    {
        public void Run()
        {
            var o = GetInstance();

            // begin
            if (!(o is string))
                return;

            var s = (string)o;

            if (s.Length < 10)
                UseShortString(s);
            else if(s.Length >= 10)
                UseLongString(s);
            // end
        }

        private object GetInstance() => "lol";

        private void UseShortString(string s)
        {
        }

        private void UseLongString(string s)
        {
        }
    }
}
