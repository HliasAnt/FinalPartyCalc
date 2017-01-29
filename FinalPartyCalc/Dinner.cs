using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPartyCalc
{
    class Dinner : Party
    {
        public bool HealthyDrinks { get; set; } // Option for Healthy Drinks Or Alcohol

        public Dinner(int numberOfPeople,bool fancyDecorations,bool healthyDrinks)
            :base(numberOfPeople,fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyDrinks = healthyDrinks;

        }

        private decimal HealthyDrinksCost() //Calculate the Cost Of Drinks at Party
        {
            decimal healthyDrinksCost;
            if (HealthyDrinks)
                healthyDrinksCost = NumberOfPeople * 5m;
            else
                healthyDrinksCost = NumberOfPeople * 20m;
            return healthyDrinksCost;
        }

        public override decimal TotalCost() // Total Cost Of Dinner Party, Cost of General Party + the Cost Of drinks
        {
            decimal Cost;
            if (HealthyDrinks)
            {
                Cost = base.TotalCost() + HealthyDrinksCost();
                Cost *= 0.95m;
                return Cost;
            }
            else
            {
                Cost = base.TotalCost() + HealthyDrinksCost();
                return Cost;
            }
        }
    }
}
