using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console.UI
{
    class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();

        public void Run()
        {
            _claimRepo.SeedContent();
            ClaimMenu();
        }
        private void ClaimMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please select from the following options: \n" +
                    "1. View all claims \n" +
                    "2. Look at next claim \n" +
                    "3. Enter a new claim \n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        ViewOldestClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry \n" +
                            "Press any key to continue....");
                        break;

                }
            }
        }
        private void ViewAllClaims()
        {
            Console.Clear();
            Queue<Claim> claims = _claimRepo.SeeAllClaims();
            Console.WriteLine($"{"Claim ID", -10} {"Claim Type", -12} {"Claim Description", -20}{"Claim Amount", -14}{"Date of Incident", -18} {"Date of Claim", -15} {"Is valid?", -10}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            foreach (Claim content in claims)
            {
                Console.WriteLine($"{content.ClaimID, -10} {content.TypeOfClaim, -12} {content.Description, -20} {content.ClaimAmount, -14} {content.DateOfAccident, -18} {content.DateOfClaim, -15}{content.IsValid, -10}");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }
        private void CreateNewClaim()
        {
            Claim newClaim = new Claim();
            Console.Clear();
            Console.WriteLine("Enter ID # for new claim:");
            newClaim.ClaimID = Console.ReadLine();
            Console.WriteLine("Choose # for claim type: \n" +
                "1. Auto \n" +
                "2. Home \n" +
                "3. Theft");
            string selection = Console.ReadLine();
            switch(selection)
            {
                case "1":
                    newClaim.TypeOfClaim = ClaimType.Auto;
                        break;
                case "2":
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;
            }
            Console.WriteLine("Enter the description of the claim:");
            newClaim.Description = Console.ReadLine();
            Console.WriteLine("Enter the date of the incident in the following format mm/dd/yyyy");
            newClaim.DateOfAccident = Console.ReadLine();
            Console.WriteLine("Enter the date of the claim in the following format mm/dd/yyyy");
            newClaim.DateOfClaim = Console.ReadLine();
            Console.WriteLine("Enter the amount of the claim");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Was the claim created within 30 days of the incident?: \n" +
                "1. Yes \n" +
                "2. No");
            string answer = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    newClaim.IsValid = true;
                    break;
                case "2":
                    newClaim.IsValid = false;
                    break;
            }
            _claimRepo.AddNewClaim(newClaim);

        }
        private void ViewOldestClaim()
        {
            Queue<Claim> allClaims = _claimRepo.SeeAllClaims();
            bool claimInQueue = true;

            while (claimInQueue)
            {
                if (allClaims.Count > 0)
                {
                    var nextClaim = allClaims.Peek();
                    Console.WriteLine();
                    Console.WriteLine($"{"Claim ID",-10} {"Claim Type",-12} {"Claim Description",-20}{"Claim Amount",-14}{"Date of Incident",-18} {"Date of Claim",-15} {"Is valid?",-10}");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    Console.WriteLine($"{nextClaim.ClaimID,-10} {nextClaim.TypeOfClaim,-12} {nextClaim.Description,-20} {nextClaim.ClaimAmount,-14} {nextClaim.DateOfAccident,-18} {nextClaim.DateOfClaim,-15}{nextClaim.IsValid,-10}");
                }
                Console.WriteLine("Do you want to deal with and remove this claim now (y/n)?");
                string selection = Console.ReadLine();
                if (selection == "y")
                {
                    allClaims.Dequeue();
                    Console.WriteLine("Claim has been removed");
                    Console.WriteLine("Press any key to continue....");
                    Console.ReadKey();
                }
                else claimInQueue = false;
            }
        }
    }
}
