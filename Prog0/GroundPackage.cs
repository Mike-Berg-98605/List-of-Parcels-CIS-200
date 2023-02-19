
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
//File: GroundPackage.cs 
// This class inherits from Package and Creates a Ground Package
// two addresses, length, width, height weight

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class GroundPackage : Package
{
    const int FIRST_DIGIT_FACTOR = 10000; //used to find first digit value of Zip code

    //Precondition: none
    //Postcondition: GroundPackade is created with specified values for addresses, length, width, height, weight
    public GroundPackage(Address originAddress, Address destAddress, double length,
        double width, double height, double weight)
        : base(originAddress, destAddress, length, width, height, weight)
    {
        ZoneDistance = Math.Abs((originAddress.Zip / FIRST_DIGIT_FACTOR) - (destAddress.Zip / FIRST_DIGIT_FACTOR)); //Zip code equation
    }

    
    public int ZoneDistance //read only helper property
    { get; }
        
    //Procondition: none
    //PostCondition: GroundPackage cost is returned
    public override decimal CalcCost()
    {
        double Cost = .15 * (Length + Width + Height) + .07 * (ZoneDistance + 1) * (Weight);

        return (decimal)Cost;
    }

    //Precondition: none
    //Postcondition: a string with GroundPackage's data is returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return  $"{base.ToString()} {NL}ZoneDistance: {ZoneDistance}";
    }
}

