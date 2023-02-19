
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
//File: GroundPackage.cs
// This class inherits from AirPackage and creates a NextDayAirPackage
// two addresses, length, width, height, weight express fee
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NextDayAirPackage : AirPackage
{

    private decimal _expressFee; // air package's express fee

    //Precondition: express fee > 0
    //Postcondition: NextDayAirPackage created with specified values for addresses, length, width, height, weight, express fee
    public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
        double height, double weight, decimal expressFee)
        : base(originAddress, destAddress, length, width, height, weight)
    {
        ExpressFee = expressFee;
    }
    
    public decimal ExpressFee // Helper property
    {
        // Precondition: express fee > 0
        // Postcondition: The next day air package's express fee has been returned
        get
        {
            return _expressFee;
        }
        // Precondition:  value >= 0
        // Postcondition: The next day air package's express fee has been set to the specified value
        private set // Helper set property
        {
            if (value >= 0)
                _expressFee = value;
            else
                throw new ArgumentOutOfRangeException(nameof(ExpressFee), value,
                    $"{nameof(ExpressFee)} must be >= 0");
        }
    }

    //Precondition: None
    //Postcondition: A string with NextDayAirPackage's data is returned
    public override decimal CalcCost()
    {
        decimal baseCost;

        baseCost = (decimal).35 * ((decimal)Length + ((decimal)Width + (decimal)Height) + (decimal).25 * ((decimal)Weight)) + ExpressFee;

        if (IsHeavy() == true)        
            baseCost += ((decimal).20 * (decimal)Weight);       
       

        if (IsLarge() == true)
            baseCost += ((decimal)0.22 * ((decimal)Length + ((decimal)Width + (decimal)Height)));

        return baseCost;
    }
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"{base.ToString()} {NL}Express Fee: {ExpressFee:C}";
    }
}

