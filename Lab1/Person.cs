using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        public int PersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FavoriteColour { get; private set; }
        public int Age { get; private set; }
        public bool IsWorking { get; private set; }

        public Person()
        {
            PersonId = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColour = string.Empty;
            Age = 0;
            IsWorking = false;
        }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            if (personId <= 0)
            {
                throw new ArgumentException("ID must be a positive integer.");
            }
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First and last name cannot be empty.");
            }

            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            return $"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}.";
        }
        public void ChangeFavoriteColour(string newColour)
        {
            FavoriteColour = newColour;
        }
        public string GetAgeInTenYears()
        {
            return $"{FirstName} {LastName}'s Age in 10 years is: {Age + 10}";
        }
        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\n" +
            $"FavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
        }
    }
}
