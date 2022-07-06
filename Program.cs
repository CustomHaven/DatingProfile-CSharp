// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-dating-profile
using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Profile.CountProfiles");
            Console.WriteLine(Profile.CountProfiles);
            Profile lisa = new Profile("Lisa Simpson", 17);

            Profile sam = new Profile("Sam Drakkila", 29);

            Profile chuck = new Profile("Chuck Norris", 81, "New York", "USA", adjectives: "strong/powerful");

            sam.SetHobbies(new string[] {
                "Football",
                "Kickboxing",
                "Cricket",
                "Golf"
            });

            chuck.SetHobbies(new string[] {
                "listening to audiobooks and podcasts",
                "playing rec sports like bowling and kickball",
                "writing a speculative fiction novel",
                "reading advice columns"
            });

            // Q8
            Console.WriteLine(lisa.ViewProfile());
            Console.WriteLine();
            Console.WriteLine(sam.ViewProfile());
            Console.WriteLine();
            Console.WriteLine(chuck.ViewProfile());

            Console.WriteLine("Profile.CountProfiles");
            Console.WriteLine(Profile.CountProfiles);
        }
    }
}
