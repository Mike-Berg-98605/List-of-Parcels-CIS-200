
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
//File: AirPackage.cs
// This classes inherits from Package and creates an air package object
// two addresses, length, width, heigt, weight

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class AirPackage : Package
{
    //Precondition: none
    //Postcondition: AirPackage created with specified values for addresses, length, width, height, weight
    public AirPackage(Address originAddress, Address destAddress, double length, double width,
        double height, double weight)
        : base(originAddress, destAddress, length, width, height, weight) 
    { }

    //Precondition: none
    //Postcondition: method returns boolian value if packge weight > 75
    public bool IsHeavy()
    {
        bool isHeavy = false;

        if (Weight > 75)
        {
            isHeavy = true;
        }
        return isHeavy;
    }
    //Precondition: none
    //Postcondition: method returns boolian value if length + width + height > 75
    public bool IsLarge()
    {
        bool isLarge = false;

        if (Length + Width + Height > 100)
        {
            isLarge = true;
        }
        return isLarge;
    }
    //Precondition: none
    //Postcondition: a string with AirPackages data is returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"{base.ToString()} {NL}Heavy Item: {IsHeavy()} {NL}Large Item: {IsLarge()}";
    }

}

