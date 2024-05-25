using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            //a
            Person p1 = new(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new(2, "Gina", "James", "Green", 18, false);
            Person p3 = new(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new(4, "Mary", "Beals", "Yellow", 28, true);

            //b
            Console.WriteLine(p2.DisplayPersonInfo());

            //c
            Console.WriteLine(p3.ToString());

            //d
            p1.ChangeFavoriteColour("White");
            Console.WriteLine(p1.DisplayPersonInfo());

            //e
            Console.WriteLine(p4.GetAgeInTenYears());

            //f
            Relation sisters = new Relation("Sister");
            Console.WriteLine(sisters.ShowRelationShip(p2, p4));
            Relation brothers = new Relation("Brother");
            Console.WriteLine(brothers.ShowRelationShip(p1, p3));

            //g
            List <Person> personList = [p1,p2,p3,p4];
            Console.WriteLine($"Average age is: {(personList[0].Age + personList[1].Age + 
                personList[2].Age + personList[3].Age) / (double)personList.Count}");


            int smallAge = 0;
            int bigAge = 0;

            foreach (Person person in personList)
            {
                int age = person.Age;

                if (age < smallAge)
                {
                    smallAge = age;
                }
                if (age > bigAge)
                {
                    bigAge = age;
                }
                foreach (Person otherPerson in personList)
                {
                    if (person == otherPerson)
                    {
                        continue;
                    }
                    if (otherPerson.Age < person.Age)
                    {
                        smallAge = otherPerson.Age;
                    }
                    if (otherPerson.Age > person.Age)
                    {
                        bigAge = otherPerson.Age;
                    }
                }
                
                if (smallAge == person.Age)
                {
                    Console.WriteLine($"The youngest person is: {person.FirstName}");
                }
                if (bigAge == person.Age)
                {
                    Console.WriteLine($"The oldest person is: {person.FirstName}");
                }
            }


            foreach (Person person in personList)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }
            }

            foreach (Person person in personList)
            {
                if (person.FavoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}