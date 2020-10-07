using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    public class OutingRepoisitory
    {
        private List<Outing> _outingsDirectory = new List<Outing>();

        public void AddOuting(Outing outing)
        {
            _outingsDirectory.Add(outing);
        }
        public List<Outing> ViewAllOutings()
        {
            return _outingsDirectory;
        }
        public decimal TotalGolfOutings()
        {
            decimal total = 0.0m;

            foreach (var outing in _outingsDirectory)
            {
                if (outing.OutingType == OutingType.Golf)
                {
                    total += outing.FinalCost;
                }
            }
            return total;
        }
        public decimal TotalBowlingOutings()
        {
            decimal total = 0.0m;

            foreach (var outing in _outingsDirectory)
            {
                if (outing.OutingType == OutingType.Bowling)
                {
                    total += outing.FinalCost;
                }
            }
            return total;
        }
        public decimal TotalParkOutings()
        {
            decimal total = 0.0m;

            foreach (var outing in _outingsDirectory)
            {
                if (outing.OutingType == OutingType.AmusementPark)
                {
                    total += outing.FinalCost;
                }
            }
            return total;
        }
        public decimal TotalConcertOutings()
        {
            decimal total = 0.0m;

            foreach (var outing in _outingsDirectory)
            {
                if (outing.OutingType == OutingType.Concert)
                {
                    total += outing.FinalCost;
                }
            }
            return total;
        }
        public void SeedOutings()
        {
            Outing outing1 = new Outing(OutingType.Golf, 12, "9/12/2020", 1200m);
            Outing outing2 = new Outing(OutingType.Bowling, 17, "9/30/2020", 750.64m);
            Outing outing3 = new Outing(OutingType.Concert, 11, "10/3/2020", 874.23m);
            _outingsDirectory.Add(outing1);
            _outingsDirectory.Add(outing2);
            _outingsDirectory.Add(outing3);


        }
    }
}
