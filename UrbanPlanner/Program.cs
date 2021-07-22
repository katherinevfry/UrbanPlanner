using System;
using UrbanPlanner.Buildings;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var ThirtyTwoTen = new Building("3210 McGavock Pk");
            ThirtyTwoTen.Stories = 5;
            ThirtyTwoTen.Width = 40;
            ThirtyTwoTen.Depth = 15;

            ThirtyTwoTen.Construct();
            ThirtyTwoTen.Purchase("Katy Fry");

            var TwoTwoOneB = new Building("221b Baker St");
            TwoTwoOneB.Stories = 2;
            TwoTwoOneB.Width = 10;
            TwoTwoOneB.Depth = 20;

            TwoTwoOneB.Construct();
            TwoTwoOneB.Purchase("Mr. Sherlock Holmes");

            var NumberThree = new Building("Number 3 Bagshot Row");
            NumberThree.Stories = 1;
            NumberThree.Width = 15;
            NumberThree.Depth = 15;

            NumberThree.Construct();
            NumberThree.Purchase("Samwise Gamgee");

        }
    }
}
