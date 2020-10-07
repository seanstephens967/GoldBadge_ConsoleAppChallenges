using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console.UI
{
    class ProgramUI
    {
        OutingRepoisitory _outingRepo = new OutingRepoisitory();
        public void Run()
        {
            _outingRepo.SeedOutings();
            OutingMenu();
        }
        private void OutingMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please select from the following options: \n" +
                    "1. View all outings\n" +
                    "2. Add new outing\n" +
                    "3. View cost of outings by type\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        DisplayAll();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        CostOfEachOuting();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                }
            }
        }
        private void DisplayAll()
        {
            Console.Clear();
            List<Outing> outings = _outingRepo.ViewAllOutings();
            Console.WriteLine($"{"Outing Type",-18} {"Attendance",-14} {"Date of Outing",-20}{"Final Cost",-14}{"Cost Per Person",-14}");
            foreach (Outing content in outings)
            {
                Console.WriteLine($"{content.OutingType,-18} {content.Attendance,-14} {content.DateOfOuting,-20} {content.FinalCost,-14} {content.CostPerPerson,-14}");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        public void AddOuting()
        {
            Outing newOuting = new Outing();
            Console.Clear();
            Console.WriteLine("What is the event type? \n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    newOuting.OutingType = OutingType.Golf;
                    break;
                case "2":
                    newOuting.OutingType = OutingType.Bowling;
                    break;
                case "3":
                    newOuting.OutingType = OutingType.AmusementPark;
                    break;
                case "4":
                    newOuting.OutingType = OutingType.Concert;
                    break;
            }
            Console.Write("What was the number in attendance?");
            newOuting.Attendance = int.Parse(Console.ReadLine());
            Console.Write("What was the total cost?");
            newOuting.FinalCost = decimal.Parse(Console.ReadLine());
            Console.Write("Date of outing in the following format mm/dd/yyyy");
            newOuting.DateOfOuting = Console.ReadLine();
            _outingRepo.AddOuting(newOuting);
        }
        private void CostOfEachOuting()
        {
            Console.Clear();
            var totalGolf = _outingRepo.TotalGolfOutings();
            var totalBowling = _outingRepo.TotalBowlingOutings();
            var totalPark = _outingRepo.TotalParkOutings();
            var totalConcert = _outingRepo.TotalConcertOutings();
            Console.WriteLine($"Total cost of Golf outings = {totalGolf}\n" +
                $"Total cost of Bowling outings = {totalBowling}\n" +
                $"Total cost of Amusement Park outings = {totalPark}\n" +
                $"Total cost of Concert outings = {totalConcert}\n" +
                $"Press any key to continue....");
            Console.ReadKey();
        }
    }
}
