using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Algorithms.UnitTest
{
    public class ReverseWordsTest
    {
        [Theory]
        [InlineData("Getting Fascinated from the programming paradigm of functional coding.", "gnitteG detanicsaF morf eht gnimmargorp mgidarap fo lanoitcnuf .gnidoc")]

        public void TestReverseWords(string sentence, string actualSentence)
        {
            //Arrange
            ReverseWord reverseWord = new ReverseWord();

            //Act
            var reversedSentence = reverseWord.GetReversedWords(sentence);

            //Assert
            Assert.Equal(reversedSentence, actualSentence);
        }
    }
}
