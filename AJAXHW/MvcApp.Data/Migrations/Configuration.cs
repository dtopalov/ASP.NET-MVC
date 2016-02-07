namespace MvcApp.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<MvcAppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        private static readonly Random Rnd = new Random();

        protected override void Seed(MvcAppDbContext context)
        {
            if (!context.Movies.Any())
            {
                var males = new[] { "John", "Jack", "Peter", "James", "Anthony", "Max", "Tom", "Charles", "Pesho", "Gosho" };
                var females = new[] { "An", "Mary", "Amy", "Victoria", "Elizabeth", "Margaret", "Ursula", "Mara", "Siika" };
                var lastNames = new[] { "Jones", "Smith", "Lee", "Giggs", "Jameson", "Walker", "Daniels", "Beam", "Sobieski" };
                var studioNames = new[] { "MGM", "20th Century Fox", "DreamWorks", "TriStar", "Universal", "Warner Bros.", "Disney" };
                var randomWords = new[]
                                      {
                                          "Good", "Bad", "Red", "Green", "Blue", "White", "Black", "Final", "Beach", "Sea",
                                          "Sky", "New", "Old", "Modern", "Breakfast", "Start", "End", "Dinner", "Times"
                                      };

                var maleActors = new List<MaleActor>();
                var femaleActors = new List<FemaleActor>();
                var directors = new List<Director>();
                var studios = new List<Studio>();

                for (int i = 0; i < 10; i++)
                {
                    var male = new MaleActor
                    {
                        FirstName = males[Rnd.Next(0, males.Length)],
                        LastName = lastNames[Rnd.Next(0, lastNames.Length)],
                        BirthDate = new DateTime(Rnd.Next(1920, 2000), Rnd.Next(1, 13), Rnd.Next(1, 29))
                    };

                    maleActors.Add(male);

                    var female = new FemaleActor
                    {
                        FirstName = females[Rnd.Next(0, females.Length)],
                        LastName = lastNames[Rnd.Next(0, lastNames.Length)],
                        BirthDate = new DateTime(Rnd.Next(1920, 2000), Rnd.Next(1, 13), Rnd.Next(1, 29))
                    };

                    femaleActors.Add(female);

                    var director = new Director
                    {
                        FirstName = males[Rnd.Next(0, males.Length)],
                        LastName = lastNames[Rnd.Next(0, lastNames.Length)],
                        BirthDate = new DateTime(Rnd.Next(1920, 2000), Rnd.Next(1, 13), Rnd.Next(1, 29))
                    };

                    directors.Add(director);

                    var studio = new Studio
                    {
                        Name = studioNames[Rnd.Next(0, studioNames.Length)],
                        Address = "The studio address"
                    };

                    studios.Add(studio);
                }

                for (int i = 0; i < 50; i++)
                {
                    var movie = new Movie
                    {
                        Title = "The" + randomWords[Rnd.Next(0, randomWords.Length)] + " " + randomWords[Rnd.Next(0, randomWords.Length)],
                        Director = directors[Rnd.Next(0, directors.Count)],
                        Studio = studios[Rnd.Next(0, studios.Count)],
                        MaleActor = maleActors[Rnd.Next(0, maleActors.Count)],
                        FemaleActor = femaleActors[Rnd.Next(0, femaleActors.Count)],
                        Year = Rnd.Next(1920, 2018)
                    };

                    context.Movies.Add(movie);
                }

                context.SaveChanges();
            }
        }
    }
}
