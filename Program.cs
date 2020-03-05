using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue", 1000, 500, 30);

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Steve Brownlee");
            FiveOneTwoEigth.Description();

            Building ThreeSevenThreeSeven = new Building("37 37th Avenue", 800, 700, 10);

            ThreeSevenThreeSeven.Construct();
            ThreeSevenThreeSeven.Purchase("Mo Silvera");
            ThreeSevenThreeSeven.Description();

            Building OneTwoThreeFour = new Building("123 4th Avenue", 500, 500, 25);

            OneTwoThreeFour.Construct();
            OneTwoThreeFour.Purchase("Leah Hoefling");
            OneTwoThreeFour.Description();

        }
    }
}