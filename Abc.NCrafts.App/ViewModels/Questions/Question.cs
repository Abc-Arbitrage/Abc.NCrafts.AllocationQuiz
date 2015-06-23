﻿using System;
using System.Collections.Generic;
using MarkdownSharp;

namespace Abc.NCrafts.App.ViewModels.Questions
{
    public class Question
    {
        private static readonly Random _random = new Random();
        private static readonly Dictionary<int, int> _scoresByDifficulty = new Dictionary<int, int> { { 1, 50 }, { 2, 100 }, { 3, 200 } };
        private readonly Markdown _markdown = new Markdown();
        private string _htmlHelpContent;

        public Question()
        {
            Answers = new List<Answer>();
        }

        public int Difficulty { get; set; }
        public Answer SelectedAnswer { get; set; }
        public List<Answer> Answers { get; set; }

        public Answer Answer1 { get { return Answers[0]; } }
        public Answer Answer2 { get { return Answers[1]; } }
        public Answer Answer3 { get { return Answers[2]; } }

        public int Score { get { return _scoresByDifficulty[Difficulty]; } }

        public string MarkdownHelpContent { get; set; }

        public string HtmlHelpContent { get { return _htmlHelpContent ?? (_htmlHelpContent = CreateHtmlHelpContent()); } }

        private string CreateHtmlHelpContent()
        {
            var content = _markdown.Transform(MarkdownHelpContent);
            var css = "code { color: #222; background-color: #EEE; font-family: Consolas; padding: 1 5 1 5; } body { font-family: Helvetica; font-size: 15; line-height: 19.5px; }";
            return string.Format(@"<html><style type='text/css'>{0}</style><body>{1}</body></html>", css, content);
        }

        public void ShuffleAnswers()
        {
            for (var index = 0; index < Answers.Count - 1; index++)
            {
                var randomIndex = _random.Next(index, Answers.Count);
                var tmp = Answers[index];
                Answers[index] = Answers[randomIndex];
                Answers[randomIndex] = tmp;
            }
        }
    }
}