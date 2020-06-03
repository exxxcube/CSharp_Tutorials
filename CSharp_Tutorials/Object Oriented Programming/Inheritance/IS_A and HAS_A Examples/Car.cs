using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IS_A_And_HAS_A
{
    class Car // This is the Base class
    {        
        internal string Brand { get; set; }
        internal string Manufacturer { get; set; }
        internal string Model { get; set; }
        internal int Wheels { get; set; }
        internal void InitCar(string brand, string manufacturer, string model, int wheels)
        {
            Brand = brand;
            Manufacturer = manufacturer;
            Model = model;
            Wheels = wheels;
        }        
    }    
    class Model : Car // This is an example of IS_A relationship in inheritance
    {
        // This is an example of HAS_A relationship in inheritance        
        Motor motor;  // means the class Model HAS_A class Motor.
        
        internal void StartEngine()
        {
            motor.Horsepower = 100;
        }
    }
    class Motor
    {        
        internal int Horsepower { get; set; }
    }   
}
