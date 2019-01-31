﻿using Algorithms.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class ReverseWord :IReverseWord
    {
        public string GetReversedWords(string sentence)
        {
            try
            {
                var wordCollection = sentence?.Trim().Split(' ') ?? new string[] { "" };
                StringBuilder builder = new StringBuilder();
                foreach (var word in wordCollection)
                {
                    var wordAsCharArray = word.ToCharArray();
                    Array.Reverse(wordAsCharArray);
                    builder.Append($"{new string(wordAsCharArray)} ");
                }

                return builder.ToString().Trim();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
