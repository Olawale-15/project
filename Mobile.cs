using System;
namespace OpConcept
{
    public class Mobile : Phone
    {
        private double _screenSize;

        public double GetScreenSize()
        {
            return _screenSize;
        }
        public void SetScreenSize(double screenSize)
        {
            _screenSize = screenSize;
        }
    }
        
    

   
    
        
    
}