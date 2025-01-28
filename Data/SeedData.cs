using System;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> Provinces = new List<Province>() {
            new Province
            {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province
            {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            },
            new Province
            {
                ProvinceCode = "QC",
                ProvinceName = "Quebec"
            }
        };

        return Provinces;
    }

    public static List<City> GetCities() {
        List<City> Cities = new List<City>() {
            new City
            {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City
            {
                CityId = 2,
                CityName = "Victoria",
                Population = 91892,
                ProvinceCode = "BC"
            },
            new City
            {
                CityId = 3,
                CityName = "Kelowna",
                Population = 144576,
                ProvinceCode = "BC"
            },

            // Cities in Ontario
            new City
            {
                CityId = 4,
                CityName = "Toronto",
                Population = 2731579,
                ProvinceCode = "ON"
            },
            new City
            {
                CityId = 5,
                CityName = "Ottawa",
                Population = 994837,
                ProvinceCode = "ON"
            },
            new City
            {
                CityId = 6,
                CityName = "Hamilton",
                Population = 569353,
                ProvinceCode = "ON"
            },

            // Cities in Quebec
            new City
            {
                CityId = 7,
                CityName = "Montreal",
                Population = 1780000,
                ProvinceCode = "QC"
            },
            new City
            {
                CityId = 8,
                CityName = "Quebec City",
                Population = 542298,
                ProvinceCode = "QC"
            },
            new City
            {
                CityId = 9,
                CityName = "Laval",
                Population = 437413,
                ProvinceCode = "QC"
            }
        };

        return Cities;
    }
}
