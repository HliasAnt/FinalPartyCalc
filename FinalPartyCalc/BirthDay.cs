using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPartyCalc
{
    class BirthDay : Party
    {
        public string CakeWriting { get; set; } // The text to be Written onThe cake

        public BirthDay(int numberOfPeople,bool fancyDecorations,string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
        
        private int CakeSize()  // Check how mnay people will be at party and returns the size of the Cake
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        public int MaxTextLenght()  // check the Size of the Cake and returns the max size of the Text that can be written on the cake
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        private int CakeCost() // set the cost of the Cake depends the size of it
        {
            if (CakeSize() == 8)
                return 40;
            else
                return 75;
        }

        private int CakeWritingSize()  // Check the Lenght of the text that wil be Written on the cake and returns the lenght or the maxLenght that can be Written
        {

            if (CakeWriting.Length < MaxTextLenght())
                return CakeWriting.Length;
            else
                return MaxTextLenght();
        }

        public bool CakeWritingTooLong()  // check the size of the text that will be written on the cake, We use that method to display a Label when we extend the max size of the Text
        {
            if (CakeWriting.Length >= MaxTextLenght())
            {
                return true;
            }
            else
                return false;
        }

        public override decimal TotalCost()  // calculate the total cost of the birthday party, base party cost + cake cost + cake writing cost
        {
            decimal Cost;
            Cost = base.TotalCost();
            Cost += CakeCost();
            Cost += CakeWritingSize() * 0.25m;
            return Cost;


        }


    }
}
