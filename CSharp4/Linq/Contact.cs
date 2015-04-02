using System;
using System.Collections.Generic;

namespace CSharp4.Linq
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
    }

    public static class SampleDataExtension
    {
        public static List<Contact> SampleData(this Contact contact)
        {
            return new List<Contact>()
            {
                new Contact 
                {
                    FirstName = "Barney",
                    LastName = "Gottshall",
                    Email = "bgottshall@example.com",
                    Phone = "885 983 8858",
                    DateOfBirth = new DateTime(1945, 10, 19),
                    State = "CA"
                },
                new Contact 
                {
                    FirstName = "Armando",
                    LastName = "Valdes",
                    Email = "avaldes@example.com",
                    Phone = "848 553 8487",
                    DateOfBirth = new DateTime(1973, 12, 9),
                    State = "WA"
                },
                new Contact 
                {
                    FirstName = "Adam",
                    LastName = "Gauwain",
                    Email = "agauwain@example.com",
                    Phone = "115 999 1154",
                    DateOfBirth = new DateTime(1959, 10, 3),
                    State = "AK"
                },
                new Contact 
                {
                    FirstName = "Jeffery",
                    LastName = "Deane",
                    Email = "jdeane@example.com",
                    Phone = "677 602 6774",
                    DateOfBirth = new DateTime(1950, 12, 16),
                    State = "CA"
                },
                new Contact 
                {
                    FirstName = "Collin",
                    LastName = "Zeeman",
                    Email = "czeeman@example.com",
                    Phone = "603 303 6030",
                    DateOfBirth = new DateTime(1935, 2, 10),
                    State = "FL"
                },
                new Contact 
                {
                    FirstName = "Stewart",
                    LastName = "Kagel",
                    Email = "skagel@example.com",
                    Phone = "546 607 5462",
                    DateOfBirth = new DateTime(1950, 2, 20),
                    State = "WA"
                },
                new Contact 
                {
                    FirstName = "Chance",
                    LastName = "Lard",
                    Email = "clard@example.com",
                    Phone = "278 918 2789",
                    DateOfBirth = new DateTime(1951, 10, 21),
                    State = "WA"
                },
                new Contact 
                {
                    FirstName = "Blaine",
                    LastName = "Reifsteck",
                    Email = "breifsteck@example.com",
                    Phone = "715 920 7157",
                    DateOfBirth = new DateTime(1946, 5, 18),
                    State = "TX"
                },
                new Contact 
                {
                    FirstName = "Mack",
                    LastName = "Kamph",
                    Email = "mkamph@example.com",
                    Phone = "364 202 3644",
                    DateOfBirth = new DateTime(1977, 9, 17),
                    State = "TX"
                },
                new Contact 
                {
                    FirstName = "Ariel",
                    LastName = "Hazelgrove",
                    Email = "ahazelgrove@example.com",
                    Phone = "165 737 1656",
                    DateOfBirth = new DateTime(1922, 5, 23),
                    State = "OR"
                },
            }; 
        }
    }
}
