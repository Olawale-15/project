using System;

namespace OpConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile iPhone = new Mobile();
            Mobile samsung = new Mobile();
            LandLine landLineObject = new LandLine();

            iPhone.SetName("IPhone XR");
            string iphone = iPhone.GetName();

            iPhone.SetScreenSize(6.6);
            double iPhoneScreenSize = iPhone.GetScreenSize();
            
            Console.WriteLine($"I use {iphone} of screen size {iPhoneScreenSize}");

            samsung.SetName("Samsung S25");
            string samsungPhone = samsung.GetName();
            Console.WriteLine(samsungPhone);



        }
    }
}
