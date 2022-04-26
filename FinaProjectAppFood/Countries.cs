using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaProjectAppFood
{
   public class Countries
    {

        //properties
        public string CountryName { get; set; }

        public string  TraditionalDish { get; set; }

        public string  Continent { get; set; }

        public int Rate { get; set; }




        //constructors

        //methods
        public void RateDish(int rateToAdd)
        {
            Rate += rateToAdd;
        }

    }
}
