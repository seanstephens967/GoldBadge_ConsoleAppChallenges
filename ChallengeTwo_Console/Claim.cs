using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    public enum ClaimType
    {
        Auto,
        Home,
        Theft
    }
    public class Claim
    {
            public string ClaimID { get; set; }
            public ClaimType TypeOfClaim { get; set; }
            public string Description { get; set; }
            public decimal ClaimAmount { get; set; }
            public string DateOfAccident { get; set; }
            public string DateOfClaim { get; set; }
            public bool IsValid { get; set; }

            public Claim() { }
            public Claim(string claimID, ClaimType claimType, string claimDescription, decimal claimAmount, string dateOfAccident, string dateofClaim, bool isValid)
            {
                ClaimID = claimID;
                TypeOfClaim = claimType;
                Description = claimDescription;
                ClaimAmount = claimAmount;
                DateOfAccident = dateOfAccident;
                DateOfClaim = dateofClaim;
                IsValid = isValid;
            }
        }
    }
    
