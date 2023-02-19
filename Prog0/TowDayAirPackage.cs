
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
//File: TwoDayAirPackage.cs
// This classes inherits from AirPackage and creates a TwoDayAirPackage
// two addresses, length, width, height, weight, delivery type

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TwoDayAirPackage : AirPackage
{
    public enum Delivery { Early, Saver }; // Delivery types
    private Delivery _deliveryType; // TDAP's delivery type (Early or Saver)
    const double DISCOUNT_FACTOR = 0.15; //discount rate for Saver 

    // Precondition:  Length > 0, Width > 0, Height > 0, Weight > 0
    // Postcondition: The two day air package is created with the specified values for
    //                origin address, destination address, length, width, height, weight, and delivery type
    public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width,
         double height, double weight, Delivery delType)
         : base(originAddress, destAddress, length, width, height, weight)
    {
        DeliveryType = delType;
    }      
       
        public Delivery DeliveryType
    {
        // Precondition:  None
        // Postcondition: The two day air package's delivery type has been returned
        get { return _deliveryType; }
        // Precondition:  value must be Early or Saver
        // Postcondition: The two day air package's delivery type has been set to the specified value
        set
        { if (Enum.IsDefined(typeof(Delivery), value))
                _deliveryType = value;
            else
                throw new ArgumentOutOfRangeException(nameof(DeliveryType), value,
                    $"{nameof(DeliveryType)} must be {nameof(Delivery.Early)} " +
                    $"or {nameof(Delivery.Saver)}");
        }
    }  
       
    //Precondition: Delivery type is Early or Saver
    //Postcondition: basecost is returned
    public override decimal CalcCost()
    {
        decimal baseCost;

        baseCost = ((decimal).18 * ((decimal)Length + ((decimal)Width + (decimal)Height))) + ((decimal).20 * (decimal)(Weight));

        if (DeliveryType == Delivery.Saver)
            baseCost *= (1 - (decimal)DISCOUNT_FACTOR);

        return baseCost;

    }
    
    //Precondition: none
    //Postcondition: string with TwoDayAirPackage data is returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"{base.ToString()} {NL}";
    }



}
