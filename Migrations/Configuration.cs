namespace AspnetLab3.Migrations
{
    using AspnetLab3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspnetLab3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(AspnetLab3.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(p => p.ProvinceCode, getProvinces());
            context.SaveChanges();
            context.Cities.AddOrUpdate(c => c.CityName, getCities(context));
        }

        private Province[] getProvinces()
        {
            var provinces = new List<Province>
            {
                new Province() { ProvinceCode = "BC", ProvinceName = "British Columbia" },
                new Province() { ProvinceCode = "ON", ProvinceName = "Ontario" },
                new Province() { ProvinceCode = "AB", ProvinceName = "Alberta" },

            };

            return provinces.ToArray();
        }

        private City[] getCities(ApplicationDbContext model)
        {
            var cities = new List<City>
            {
                new City()
                {
                    CityName = "Vancouver",
                    Population = 102525,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC")
                },

                new City()
                {
                    CityName = "Richmond",
                    Population = 101515,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC")
                },

                new City()
                {
                    CityName = "Burnaby",
                    Population = 101525,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC")
                },

                new City()
                {
                    CityName = "Ottawa",
                    Population = 880000,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "ON")
                },

                new City()
                {
                    CityName = "Toronto",
                    Population = 26666006,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "ON")
                },


                new City()
                {
                    CityName = "Hamilton",
                    Population = 520000,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "ON")
                },

                new City()
                {
                    CityName = "Calgary",
                    Population = 111000,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB")
                },

                new City()
                {
                    CityName = "Edmonton",
                    Population = 820000,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB")
                },

                new City()
                {
                    CityName = "Medicine Hat",
                    Population = 60000,
                    Province = model.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB")
                },

            };

            return cities.ToArray();
        }

    }
}
