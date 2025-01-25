using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_FunctionsLab
{
    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person(1, "John", "Doe", "Blue", 25, true);
            Person person2 = new Person(2, "Jane", "Doe", "Red", 30, false);

            // Display Person information
            person1.DisplayPersonInfo();
            person2.DisplayPersonInfo();

            // Change favorite color of person1
            person1.ChangeFavoriteColour();
            Console.WriteLine("After changing favorite color:");
            person1.DisplayPersonInfo();

            // Get age in 10 years for person2
            Console.WriteLine($"{person2.FirstName} {person2.LastName}'s age in 10 years will be: {person2.GetAgeInTenYears()}\n");

            // Display all details using ToString
            Console.WriteLine("Person Details:");
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());

            // Create Relation object
            Relation relation = new Relation("Sister");

            // Show relationship
            relation.ShowRelationShip(person2, person1);
        }
    }
}

