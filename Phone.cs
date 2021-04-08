using System;
namespace OpConcept
{
    public class Phone
    {
        private string _name;

        private string _brand;

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public void SetBrand(string brand)
        {
            _brand = brand;
        }

    
    }
}