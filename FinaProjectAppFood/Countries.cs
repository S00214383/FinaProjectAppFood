using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaProjectAppFood
{
   public class Countries
    {

        //properties
        public int CountriesID { get; set; }

        public string CountryName { get; set; }

        public string  TraditionalDish { get; set; }

        public string  Continent { get; set; }

        public int Rate { get; set; }

        public string DishImage { get; set; }




        //constructors

        //methods
        public void RateDish(int rateToAdd)
        {
            Rate += rateToAdd;
        }

        //override method
        public override string ToString()
        {
            return CountryName;
        }

        public string GetDetails()
        {
            return $"Country Name: {CountryName}\n"  +
                $"Continent: {Continent}\n" +
                $"Dish: {TraditionalDish}\n" +
                $"Rate: {Rate}";
                


        }


    }//end of Countries Class

    public class DishData:DbContext
    {
        public DishData() : base("MyDishData1820") {   }

        public DbSet<Countries> CountriesDishes { get; set; }
        public object Countries { get; set; }
    }
}
