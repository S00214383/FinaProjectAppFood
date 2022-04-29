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

                Countries c3 = new Countries()
                {
                    CountryName = "France",
                    Continent = "Europe",
                    TraditionalDish = "Ratatouille",
                    Rate = 5,
                
                    DishImage = "/images/ratatouille.jpg"

                };

                Countries c4 = new Countries()
                {
                    CountryName = "Germany",
                    Continent = "Europe",
                    TraditionalDish = "Spatzle",
                    Rate = 5,
              
                    DishImage = "/images/spatzle.jpg"

                };
                
                Countries c5 = new Countries()
                {
                    CountryName = "China",
                    Continent = "Asia",
                    TraditionalDish = "Kung Pao Chicken",
                    Rate = 5,
                 
                    DishImage = "/images/kungpao.jpg"

                };
                
                Countries c6 = new Countries()
                {
                    CountryName = "India",
                    Continent = "Asia",
                    TraditionalDish = "Iasooni Tikka Chicken",
                    Rate = 5,
                  
                    DishImage = "/images/tikka.jpg"

                };
                Countries c7 = new Countries()
                {
                    CountryName = "South Africa",
                    Continent = "Africa",
                    TraditionalDish = "Bobotie",
                    Rate = 5,
              
                    DishImage = "/images/bobotie.jpg"

                }; 
                Countries c8 = new Countries()
                {
                    CountryName = "Marocoo",
                    Continent = "Africa",
                    TraditionalDish = "Tagine",
                    Rate = 5,
                
                    DishImage = "/images/tagine.jpg"

                };
                Countries c9 = new Countries()
                {
                    CountryName = "Australia",
                    Continent = "Oceania",
                    TraditionalDish = "Lamb leg Roast",
                    Rate = 5,
                   
                    DishImage = "/images/lambleg.jpg"

                };

                Countries c10 = new Countries()
                {
                    CountryName = "Fiji",
                    Continent = "Oceania",
                    TraditionalDish = "Kokoda",
                    Rate = 5,
                   
                    DishImage = "/images/kokoda.jpg"

                };






                db.CountriesDishes.Add(c1);
                db.CountriesDishes.Add(c2);
                db.CountriesDishes.Add(c3);
                db.CountriesDishes.Add(c4);
                db.CountriesDishes.Add(c5);
                db.CountriesDishes.Add(c6);
                db.CountriesDishes.Add(c7);
                db.CountriesDishes.Add(c8);
                db.CountriesDishes.Add(c9);
                db.CountriesDishes.Add(c10);



                db.SaveChanges();
                Console.WriteLine("Dish has been added to table");
                Console.ReadLine();


            }
        }
    }
}
