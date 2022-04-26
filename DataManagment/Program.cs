using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinaProjectAppFood;

namespace DataManagment
{
    class Program
    {
        static void Main(string[] args)
        {

           DishData db = new DishData();

            using (db)

            {
                Countries c1 = new Countries()
                {
                    CountryName = "Brazil",
                    Continent = "South America",
                    TraditionalDish = "Feijoada",
                    Rate = 5,
                    DishImage = "/images/feijoada.jpg"

                };

                Countries c2 = new Countries()
                {
                    CountryName = "Mexico",
                    Continent = "Central America",
                    TraditionalDish = "Chilaquiles",
                    Rate = 5,
                    DishImage = "/images/chilaquiles.jpg"

                };



                db.CountriesInfos.Add(c1);
                db.CountriesInfos.Add(c2);


                db.SaveChanges();
                Console.WriteLine("Dish has been added to table");
                Console.ReadLine();


            }
        }
    }
}
