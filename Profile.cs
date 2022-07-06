using System;

namespace DatingProfile
{
    public class Profile // Q1
    {
        // FIELDS --- Q2, Q4 make them private to show

        private string name;
        private int age;
        private string city;
        private string country;
        private string adjectives;
        private string[] hobbies;
        private static int countProfiles;

        // CONSTRUCTORS --- Q5

        public Profile(string name, int age, string city, string country, string adjectives = "handsome/beautiful")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.adjectives = adjectives;
            this.hobbies = new string[0];
            countProfiles++;
        }

        //public Profile(string name, int age) : this(name, age, "n/a") { }

        public Profile(string name, int age) : this(name, age, "n/a", "n/a") { }


        // PROPERTIES

        private int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int CountProfiles
        {
            get { return countProfiles; }
            private set { countProfiles = value; }
        }


        // METHODS --- Q7

        public string ViewProfile() // Q7 and Q10
        {
            string bio;
            if (Age < 18)
            {
                bio = $"Sorry {this.name} only a person aged 18 or more can use this APP!";
            }
            else
            {
                bio = $"Name: {this.name},\nAge: {this.age},\nCity: {this.city},\nCountry: {this.country},\nadjectives: {this.adjectives}";

                if (this.hobbies.Length > 0)
                {
                    bio += "\nHobbies:\n";
                    foreach (string hobby in hobbies)
                    {
                        bio += $"- {hobby}\n";
                    }
                }
            }

            return bio;
        }

        public void SetHobbies(string[] hobbies) // Q9
        {
            this.hobbies = hobbies;
        }



    }
}
