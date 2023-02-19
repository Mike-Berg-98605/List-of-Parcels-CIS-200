
// Program 1A
// CIS 200-50
// Fall 2020
// Due: 9/27/2021
// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog1A
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage G1 = new GroundPackage(a1, a2, 10, 10, 10, 200 ); // Test GroundPackage 1
            GroundPackage G2 = new GroundPackage(a4, a1, 9, 5, 7, 2); // Test GroundPackage 2 

            NextDayAirPackage NDAP1 = new NextDayAirPackage(a4, a1, 9, 15, 6, 100, 100); // Test NextDayAirPackage 1 
            NextDayAirPackage NDAP2 = new NextDayAirPackage(a2, a3, 15, 4.8, 6.99, 99.9, 40); // Test NextDayAirPackage 2

            TwoDayAirPackage TDAP1 = new TwoDayAirPackage(a1, a2, 8, 4, 6, 100, TwoDayAirPackage.Delivery.Early); // Test TwoDayAirPackage 1
            TwoDayAirPackage TDAP2 = new TwoDayAirPackage(a3, a4, 7, 2, 9, 1000, TwoDayAirPackage.Delivery.Saver); // Test TwoDayAirPackage 2

            List<Parcel> parcels = new List<Parcel> {G1, G2, TDAP1, TDAP2, NDAP1, NDAP2}; // Test list of parcels

            // Display data
            WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }
        }
    }
}
