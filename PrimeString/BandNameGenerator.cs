using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
    class BandNameGenerator
    {
        private string Brand { get; set; }
        public BandNameGenerator(string brand)
        {
            Brand = brand;
            // Happy coding


        }

        public string GetName()
        {
            if (Brand[0] == Brand[Brand.Length - 1])
            {
                var newBrand = FirstUpper(Brand) + Brand.Substring(1);
                return newBrand;
            }
            return "The " + FirstUpper(Brand);
        }

        private static string FirstUpper(string str)
        {
            return str[0].ToString().ToUpper() + str.Substring(1);
        }
    }
}
