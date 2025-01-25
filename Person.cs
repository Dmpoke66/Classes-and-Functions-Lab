using System;

namespace Classes_and_FunctionsLab
{
    // Person class
    public class Person
    {
        // Attributes
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        // Constructor
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }

        // DisplayPersonInfo method
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}\nPerson ID: {PersonId}\n{FirstName} {LastName}'s favorite color is {FavoriteColour}.\n");
        }

        // ChangeFavoriteColour method
        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        // GetAgeInTenYears method
        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        // ToString override
        public override string ToString()
        {
            return $"Person ID: {PersonId}, Name: {FirstName} {LastName}, Favorite Colour: {FavoriteColour}, Age: {Age}, Is Working: {IsWorking}";
        }
    }

