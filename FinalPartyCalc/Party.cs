using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPartyCalc
{
    class Party
    {
        public int NumberOfPeople { get; set; }    //number of people for the party
        public const int CostPerPerson = 25;       // Standar Cost for each person in party
        public bool FancyDecorations { get; set; } // option for FancyDecors or not at Party

        public Party(int numberOfPeople,bool fancydecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancydecorations;
        }

        private decimal FancyDecorCost()  //calculate the cost of FancyDecors
        {
            decimal fancyDecorCost;
            if (FancyDecorations)
                fancyDecorCost = (NumberOfPeople * 15m) + 50m;
            else
                fancyDecorCost = (NumberOfPeople * 7.5m) + 30m;
            return fancyDecorCost;
        }

        virtual public decimal TotalCost()  //Calculate the Totalcost ofParty
        {
            decimal Cost;
            Cost = NumberOfPeople * CostPerPerson;
            Cost += FancyDecorCost();
            if (NumberOfPeople >= 12)
            {
                Cost += 100;
                return Cost;
            }
            else
                return Cost;

            
        }



    }
}
