using System;
using System.Collections.Generic;
using ChallengeTwo_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwo_ConsoleTests
{
    [TestClass]
    public class ClaimsTests
    {
        ClaimRepository repository = new ClaimRepository();
        Queue<Claim> claimQueue = new Queue<Claim>();
        Claim claim;
        [TestMethod]
        public void Arrange()
        {
            claim = new Claim("3", ClaimType.Auto, "Flat tire", 230, "10/01/2020", "10/02/2020", true);
        }
        [TestMethod]
        public void AddNewClaim_ShouldReturnCorrectBoolean()
        {
            //Arrange
            Arrange();
            //Act
            repository.AddNewClaim(claim);
            Queue<Claim> claimList = repository.SeeAllClaims();
            bool wasAdded = claimList.Contains(claim);
            //Assert
            Assert.IsTrue(wasAdded);
        }
    }
}
