using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    public enum OutingType
    {
        Golf, 
        Bowling, 
        AmusementPark, 
        Concert
    }

    public class Outing
    {
        public OutingType OutingType { get; set; }
        public int Attendance { get; set; }
        public string DateOfOuting { get; set; }
        public decimal FinalCost { get; set; }
        public decimal CostPerPerson
        {
            get
            { return Math.Round(FinalCost / Attendance); }
        }

        public Outing(OutingType eventType, int attendance, string dateOfOuting, decimal finalCost)
        {
            OutingType = eventType;
            Attendance = attendance;
            DateOfOuting = dateOfOuting;
            FinalCost = finalCost;
        }
        public Outing() { }
    }
}
