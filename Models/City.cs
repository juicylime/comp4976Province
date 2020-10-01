using System.Collections.Generic;


namespace Province.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string ProvinceCode {get;set;}
        
        public Provinces Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> Cities = new List<City>{
            new City(){
                CityId = 1,
                CityName = "Vancouver",
                Population = 100,
                ProvinceCode = "BC"
                },
            new City(){
                CityId = 2,
                CityName = "Surrey",
                Population = 150,
                ProvinceCode = "BC"
                },
            new City(){
                CityId = 3,
                CityName = "Richmond",
                Population = 90,
                ProvinceCode = "BC"
                },    
            new City(){
                CityId = 4,
                CityName = "Edmonton",
                Population = 191,
                ProvinceCode = "ALB"
                },
            new City(){
                CityId = 5,
                CityName = "Calgary",
                Population = 102,
                ProvinceCode = "ALB"
                },
            new City(){
                CityId = 6,
                CityName = "Red Dear",
                Population = 1000,
                ProvinceCode = "ALB"
                },
            new City(){
                CityId = 7,
                CityName = "Winnipeg",
                Population = 10034,
                ProvinceCode = "MAN"
                },
            new City(){
                CityId = 8,
                CityName = "Brandon",
                Population = 90,
                ProvinceCode = "MAN"
                },
            new City(){
                CityId = 9,
                CityName = "Morden",
                Population = 201,
                ProvinceCode = "MAN"
                }
            };

            return Cities;
        }
    }
}

