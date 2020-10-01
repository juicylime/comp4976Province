using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Province.Models
{
    public class Provinces
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
       // public List<string> CityNames {get;set;}
        [NotMapped]
        public string[] Cities { get; set; }

        public static List<Provinces> GetProvinces(){
            List<Provinces> Provinces = new List<Provinces>{
            new Provinces(){
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
                Cities = new string[] {"Vancouver"}
                },
                new Provinces(){
                ProvinceCode = "ALB",
                ProvinceName = "Alberta",
                // Cities = City.GetCities()
                },
                new Provinces(){
                ProvinceCode = "MAN",
                ProvinceName = "Manitoba",
                // Cities = City.GetCities()
                }
            };

        return Provinces;
    }
    
    
    }
}

