using GB_ConsoleApp_Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Cafe.UI
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            SeedMeals();
            RunOptions();
        }
        private void RunOptions()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please select from one of the options below: \n" +
                    "1. Create new meal \n" +
                    "2. Show all meals \n" +
                    "3. Delete menu item \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        ShowAllMenuItems();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry try again. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                        
                }
            }
        }
        private void CreateNewMenuItem()
        {
            MenuContent meal = new MenuContent();
            Console.Clear();
            Console.WriteLine("Enter the meal number you would like to create:");
            meal.MealNum = Console.ReadLine();
            Console.WriteLine("Enter the meal name you you would like to create:");
            meal.MealName = Console.ReadLine();
            Console.WriteLine("Enter the meal description you would like to create:");
            meal.Description = Console.ReadLine();
            Console.WriteLine("Enter the ingredients for the meal you would like to create:");
            meal.Ingredients = Console.ReadLine();
            Console.WriteLine("Enter the price of the meal you would like to create:");
            meal.Price = double.Parse(Console.ReadLine());

            _menuRepo.AddToMenu(meal);
        }
        private void ShowAllMenuItems()
        {
            Console.Clear();
            List<MenuContent> itemList = _menuRepo.ShowAllMenuItems();
            foreach(MenuContent content in itemList)
            {
                Console.WriteLine($"Meal #: {content.MealNum} \n" +
               $"Name: {content.MealName} \n" +
               $"Description: {content.Description} \n" +
               $"Ingredients: {content.Ingredients} \n" +
               $"Price: {content.Price} \n" +
               "--------------------------------------");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        private void DeleteMenuItem()
        {
            Console.Clear();
            List<MenuContent> menuItem = _menuRepo.ShowAllMenuItems();
            Console.WriteLine("Enter the Meal # you like to delete?");
            foreach (MenuContent item in menuItem)
            {
                Console.WriteLine($"{item.MealNum} {item.MealName} {item.Description} {item.Ingredients} {item.Price}");
            }
            var deleteitem = Console.ReadLine();

            foreach (MenuContent item in menuItem)
            {
                if (deleteitem == item.MealNum)
                {
                    _menuRepo.DeleteMenuItem(item);
                    Console.WriteLine($"Meal # {deleteitem} has been removed from the menu");
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadKey();
                    break;
                }
            }
        }

        private void SeedMeals()
        {
            MenuContent meal1 = new MenuContent("1", "Cheeseburger", "Meat and cheese on a bun", "Bun, Beef Patty, American Cheese", 8);
            MenuContent meal2 = new MenuContent("2", "Chickem Sandwich", "Chicken on a bun", "Bun, Chicken Breast, Tomato", 7);
            MenuContent meal3 = new MenuContent("3", "Oatmeal", "Just plain old oatmeal", "Oatmeal, Water", 22);
            _menuRepo.AddToMenu(meal1);
            _menuRepo.AddToMenu(meal2);
            _menuRepo.AddToMenu(meal3);

        }
    }
}
