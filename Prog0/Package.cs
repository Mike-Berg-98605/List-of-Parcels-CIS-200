
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
//Package.cs
// This class inherits from Parcel and creates a Package object
//two address lines, length, width, height, weight

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Package : Parcel
{      
   
    private double _length; //Package Length
    private double _width; //Package width
    private double _height; //Package height
    private double _weight; //Package weight

    //Precondition: length, width, height, weight >0
    //Postcondition: Package created with specified values for addresses, length, width, height, weight
    public Package (Address originAddress, Address destAddress,  double length, 
        double width, double height, double weight)
        : base(originAddress,  destAddress)
    {
       
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;

    }

    public double Length // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's length has been returned
        get { return _length; }
        
        set
        {
            // Precondition:  value >= 0
            // Postcondition: The Package's length has been set to the specified value
            if (value > 0)
                _length = value;
            else
                throw new ArgumentOutOfRangeException($"{nameof(Length)}", value,
                    $"{nameof(Length)} must be > 0");
        }
    }

    public double Width // Helper property
    {
        // Precondition:  None
        // Postcondition: The  Package's width has been returned
        get { return _width; }

        set
        {
            // Precondition:  value >= 0
            // Postcondition: The Packages width has been set to the specified value
            if (value > 0)
                _width = value;
            else
                throw new ArgumentOutOfRangeException($"{nameof(Width)}", value,
                    $"{nameof(Width)} must be > 0");
        }
    }

    public double Height // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's height has been returned
        get { return _height; }

        set
        {
            // Precondition:  value >= 0
            // Postcondition: The Package's height has been set to the specified value
            if (value > 0)
                _height = value;
            else
                throw new ArgumentOutOfRangeException($"{nameof(Height)}", value,
                    $"{nameof(Height)} must be > 0");
        }
    }

    public double Weight // Helper property
    {
        // Precondition:  None
        // Postcondition: The Package's weight has been returned
        get { return _weight; }

        set
        {
            // Precondition:  value >= 0
            // Postcondition: The Package's weight has been set to the specified value
            if (value > 0)
                _weight = value;
            else
                throw new ArgumentOutOfRangeException($"{nameof(Weight)}", value,
                    $"{nameof(Weight)} must be > 0");
        }
    }

    // Precondition:  None
    // Postcondition: A String with Package's data has been returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"{base.ToString()}{NL}Length: {Length} {NL}Width: {Width}" +
            $"{NL}Height: {Height} {NL}Weight: {Weight}";


    }
}
