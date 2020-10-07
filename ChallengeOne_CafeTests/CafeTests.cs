using System;
using System.Collections.Generic;
using GB_ConsoleApp_Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOne_CafeTests
{
    [TestClass]
    public class CafeTests
    {
        MenuRepository repository = new MenuRepository();
        List<MenuContent> list = new List<MenuContent>();
        MenuContent content;
        [TestMethod]
        public void Arrange()
        {
            content = new MenuContent("4", "Taco", "Regular Taco", "Meat, Shell", 5);
            repository.AddToMenu(content);
        }
        [TestMethod]
        public void ShowAllMenuItems_ShouldReturnCorrectBoolean()
        {
            //Arrange
            Arrange();
            //Act
            var menuContent = repository.ShowAllMenuItems();
            bool wasAdded = menuContent.Contains(content);
            //Assert
            Assert.IsTrue(wasAdded);
        }
        [TestMethod]
        public void DeleteMenuItem_CountShouldBeEqual()
        {
            //Arrange
            Arrange();
            //ACT
            repository.DeleteMenuItem(content);
            int menuCont = list.Count;
            //ASSERT
            Assert.AreEqual(0, menuCont);
        }
    }
}
