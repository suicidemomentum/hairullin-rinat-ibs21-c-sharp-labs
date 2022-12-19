using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class PeopleNames
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    internal static class LocalClass
    {
        public static List<Country> FillCountryList()
        {
            List<Country> countries = new List<Country>()
            {
            new Country(1, "Russia"),
            new Country(2, "United States"),
            new Country(3, "United Kingdom"),
            new Country(4, "Germany")
            };

            return countries;
        }

        public static List<City> FillCityList()
        {
            List<City> cities = new List<City>()
            {
                new City(1, 1, "Saratov"),
                new City(2, 1, "Moscow"),
                new City(3, 2, "New York"),
                new City(4, 2, "Los Angeles"),
                new City(5, 3, "London"),
                new City(6, 4, "Frankfurt"),
                new City(7, 4, "Berlin")
            };

            return cities;
        }

        public static List<Street> FillStreetList()
        {
            List<Street> streets = new List<Street>()
            {
                new Street(1, 1, "2nd Sadovaya"),
                new Street(2, 1, "Bolshaya Sadovaya"),
                new Street(3, 2, "Red Square"),
                new Street(4, 3, "Fifth Avenue"),
                new Street(5, 4, "Sunset Boulevard"),
                new Street(6, 5, "Buckingham Palace Road"),
                new Street(7, 6, "Hauptwache"),
                new Street(8, 7, "Friedrichstraße")
            };

            return streets;
        }

        public static List<HomeAddress> FillHomeAddressList()
        {
            List<HomeAddress> homeAddresses = new List<HomeAddress>()
            {
                new HomeAddress(1, 1, "31-35", 1),
                new HomeAddress(2, 1, "17", 2),
                new HomeAddress(3, 2, "25", 32),
                new HomeAddress(4, 3, "45", 4),
                new HomeAddress(5, 4, "60", 55),
                new HomeAddress(6, 5, "71", 62),
                new HomeAddress(7, 6, "55", 66),
                new HomeAddress(8, 7, "90", 63),
                new HomeAddress(9, 8, "11", 61)
            };

            return homeAddresses;
        }

        public static List<People> FillPeopleList()
        {
            List<People> people = new List<People>()
            {
                new People(1, "John", "Doe", new DateTime(1985, 1, 1), 2, 2),
                new People(2, "Jane", "Doe", new DateTime(1987, 2, 2), 3, 4),
                new People(3, "Bob", "Smith", new DateTime(1970, 3, 3), 5, null),
                new People(4, "Alice", "Soprano", new DateTime(2000, 1, 5), 7, 1),
                new People(5, "Adriane", "Maltisanti", new DateTime(2005, 3, 7), 8, 3),
                new People(6, "James", "Fring", new DateTime(1998, 4, 4), 9, null),
                new People(7, "Kate", "Salamca", new DateTime(1991, 2, 1), 3, 7),
                new People(8, "Jimmy", "Shreder", new DateTime(1978, 3, 5), 8, 2),
                new People(9, "Saul", "Goodman", new DateTime(1985, 3, 1), 3, 1),
                new People(10, "Based", "Kiddy", new DateTime(2010, 3, 7), 8, 3),
                new People(10, "Tupac", "Shakur", new DateTime(1999, 3, 5), 2, 3),
                new People(10, "Biggy", "Smalls", new DateTime(1990, 3, 2), 2, 3),
            };

            return people;
        }

        public static List<PeopleNames> GetAdults(List<People> people, DateTime date)
        {
            List<PeopleNames> list = new List<PeopleNames>();
            list = (from p in people
                    where p.Birthday.AddYears(18) < date
                    select new PeopleNames
                         {
                             FirstName = p.FirstName,
                             LastName = p.LastName
                         }).ToList();

            return list;
        }

        public static List<(string, string)> GetAdultsAsTuple(List<People> people, DateTime date) //change in foreach item.Item1 and item.Item2
        {
            List<(string, string)> list = new List<(string, string)>();
            list = (from p in people
                   where p.Birthday.AddYears(18) < date
                   select (p.FirstName, p.LastName)).ToList();

            return list;
        }

        public static List<PeopleNames> GetSaratovPeople(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities)
        {
            List<PeopleNames> list = new List<PeopleNames>();
            list = (from p in people
                    join h in homeAddresses on p.LiveID equals h.ID
                    join s in streets on h.StreetID equals s.ID
                    join c in cities on s.CityID equals c.ID
                    where c.Title == "Saratov"
                    select new PeopleNames
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName
                    }).ToList();

            return list;
        }

        public static List<string> GetCityTitlesContainsSadovaya(List<Street> streets, List<City> cities)
        {
            List<string> list = new List<string>();

            list = ((from s in streets
                    join c in cities on s.CityID equals c.ID
                    where s.Title.Contains("Sadovaya")
                    select c.Title).Distinct()).ToList();

            return list;
        }

        public static List<(string, string, string, string, string, string, int)> GetAllPeoplesInfoAsTuple(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries) //change in foreach item.Item1 and item.Item2
        {
            List<(string, string, string, string, string, string, int)> list = new List<(string, string, string, string, string, string, int)>();

            list = (from p in people
                    join h in homeAddresses on p.RegistrationID equals h.ID
                    join s in streets on h.StreetID equals s.ID
                    join c in cities on s.CityID equals c.ID
                    join countrie in countries on c.CountryID equals countrie.ID
                    select (p.LastName, p.FirstName, countrie.Title, c.Title, s.Title, h.HomeNumber, h.Apartment)).ToList();

            return list;
        }

        public static double GetAverageAgeOfRussiaSaratov2ndSadovskaya17HomeHumber(List<People> people, List<HomeAddress> homeAddresses, List<Street> streets, List<City> cities, List<Country> countries, DateTime date)
        {
            double averageAge = (from p in people
                              join h in homeAddresses on p.RegistrationID equals h.ID
                              join s in streets on h.StreetID equals s.ID
                              join c in cities on s.CityID equals c.ID
                              join countrie in countries on c.CountryID equals countrie.ID
                              where countrie.Title == "Russia" && c.Title == "Saratov" && s.Title == "2nd Sadovaya" && h.HomeNumber == "17"
                              select date.Year - p.Birthday.Year).Average();

            return averageAge;
        }

        public static void PrintSeparator()
        {
            Console.WriteLine("#============#");
        }
    }
}
