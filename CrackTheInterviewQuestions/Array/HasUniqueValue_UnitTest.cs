using CrackTheInterviewQuestions_UnitTest.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheInterviewQuestions.Array
{
    [TestClass]
    public class HasUniqueValue_UnitTest
    {
        [TestMethod]
        public void HasUniqueCharacters_Test()
        {
            //Arrange
            HasUniqueValue hasUniqueValue = new HasUniqueValue();
            string text = "Lets check if has multiple character.";

            //Act
            bool result = hasUniqueValue.HasuniqueCharacters(text);

            //Assert
            Assert.IsFalse(result); ;
        }

        [TestMethod]
        public void HasUniqueValueSpaceEfficient_Test()
        {
            //Arrange
            HasUniqueValue hasUniqueValue = new HasUniqueValue();
            string text = "Lets check if has multiple character.";

            //Act
            bool result = hasUniqueValue.HasUniqueValueSpaceEfficient(text);

            //Assert
            Assert.IsFalse(result);
        }
    }
}