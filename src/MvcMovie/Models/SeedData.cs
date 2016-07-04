using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                 new Movie
                 {
                     Title = "The Singles Ward",
                     ReleaseDate = DateTime.Parse("2002-1-31"),
                     Genre = "Comedy, Drama, Romance",
                     Price = 19.95M,
                     Rating = "PG"
                 },

                 new Movie
                 {
                     Title = "Once I was a Beehive",
                     ReleaseDate = DateTime.Parse("2015-8-14"),
                     Genre = "Comedy, Drama, Family",
                     Price = 24.99M,
                     Rating = "PG"
                 },

                 new Movie
                 {
                     Title = "The Best Two Years",
                     ReleaseDate = DateTime.Parse("2004-2-20"),
                     Genre = "Comedy, Drama",
                     Price = 19.95M,
                     Rating = "PG"
                 },

               new Movie
               {
                   Title = "Meet the Mormons",
                   ReleaseDate = DateTime.Parse("2015-2-26"),
                   Genre = "Documentary",
                   Price = 4.99M,
                   Rating = "PG"
                    
               }
            );
            context.SaveChanges();
        }
    }
}