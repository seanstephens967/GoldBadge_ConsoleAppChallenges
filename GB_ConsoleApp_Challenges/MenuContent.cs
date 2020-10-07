using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_ConsoleApp_Challenges
{
    ////public enum Ingredients
    //{
    //    Protein = 1,
    //    Cheese,
    //    Veggie,
    //    Condiment
    //}
    //public enum Veggies
    //{
    //    Lettuce = Ingredients.Lettuce,
    //    Tomato = Ingredients.Tomato,
    //    Onion = Ingredients.Onion,
    //    Pickle = Ingredients.Pickle,
    //    Avocado = Ingredients. Avacado,
    //    Peppers = Ingredients.Pepper
    //}
    //public enum Cheese
    //{
    //    American = Ingredients.American,
    //    Swiss = Ingredients.Swiss,
    //    Cheddar = Ingredients.Cheddar,
    //    Mozzerella = Ingredients.Mozzerella,
    //    Colby = Ingredients.Colby,
    //    PeperJack = Ingredients.PeperJack
    //}
    //public enum Condiments
    //{
    //    Ketchup = Ingredients.Ketchup,
    //    Mustard = Ingredients.Mustard,
    //    BBQ = Ingredients.BBQ,
    //    Mayo = Ingredients.Mayo
    //}
    public class MenuContent
    {
        public string MealNum { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; } 
        public double Price { get; set; }

        public MenuContent() { }
        public MenuContent(string mealNum, string mealName, string description, string ingredients, double price)
        {
            MealNum = mealNum;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}

//A meal number, so customers can say "I'll have the #5"
//    A meal name
//    A description
//    A list of ingredients,
//A price
