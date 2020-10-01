using Microsoft.EntityFrameworkCore;
using Province.Models;

public static class DummyData {

  public static void Seed (this ModelBuilder modelBuilder) {
      modelBuilder.Entity<City>().HasData (
          City.GetCities ()
      );
      modelBuilder.Entity<Provinces>().HasData (
          Provinces.GetProvinces ()
      );
  }
}