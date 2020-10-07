using System;
using System.Collections.Generic;
using ChallengeThree_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeThree_ConsoleTests
{
    [TestClass]
    public class OutingsTests
    {
        OutingRepoisitory repository = new OutingRepoisitory();
        List<Outing> outingList = new List<Outing>();
        Outing outing;

        [TestMethod]
        public void Arrange()
        {
            outing = new Outing(OutingType.Golf, 10, "10/5/2020", 800);
            repository.AddOuting(outing);
        }
        [TestMethod]
        public void AddOuting_ShouldReturnCorrectBoolean()
        {
            //Arrange
            Arrange();
            //Act
            var outingContent = repository.ViewAllOutings();
            bool wasAdded = outingContent.Contains(outing);
            //Assert
            Assert.IsTrue(wasAdded);
        }

    }
}
