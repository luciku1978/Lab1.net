using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class DataSeeder
    {
        public static void Initialize (IntroDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any movies
            if(context.Movies.Any())
            { return; //DB has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "Terminator",
                    Runtime = 10,
                    Rating = 9.5,
                    Storyline = "War of humans against machines"
                },
                 new Movie
                 {
                     Title = "Harry Potter",
                     Runtime = 15,
                     Rating = 8.5,
                     Storyline = "A story about wizards"
                 });

            context.SaveChanges();
        }

    }
}
