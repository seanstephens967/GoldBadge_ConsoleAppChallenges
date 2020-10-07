using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    public class ClaimRepository
    {
        Queue<Claim> _claimDirectory = new Queue<Claim>();

        public Queue<Claim> SeeAllClaims()
        {
            return _claimDirectory;
        }
        public void AddNewClaim(Claim newClaim)
        {
            _claimDirectory.Enqueue(newClaim);
        }
        public void SeedContent()
        {
            Claim claim1 = new Claim("1", ClaimType.Auto, "Front bumper damage", 808.48m, "10/02/2020", "10/03/2020", true);
            Claim claim2 = new Claim("2", ClaimType.Home, "Grease fire", 32000.48m, "09/22/2020", "09/26/2020", true);
            Claim claim3 = new Claim("3", ClaimType.Auto, "Cracked windshield", 808.48m, "04/02/2020", "10/02/2020", false);
            _claimDirectory.Enqueue(claim1);
            _claimDirectory.Enqueue(claim2);
            _claimDirectory.Enqueue(claim3);
        }
    }
}
