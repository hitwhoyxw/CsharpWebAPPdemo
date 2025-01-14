﻿using Microsoft.EntityFrameworkCore;
using myWebApplication.Data;

namespace myWebApplication.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null||context.Movie==null) 
                {
                    throw new ArgumentException("null MovieContext");
                }
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                 new Movie
                 {
                     Title = "When Harry Met Sally",
                     Date = DateTime.Parse("1989-2-12"),
                     Genre = "Romantic Comedy",
                     Price = 7.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     Date = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     Date = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Price = 9.99M
                 },

                 new Movie
                 {
                     Title = "Rio Bravo",
                     Date = DateTime.Parse("1959-4-15"),
                     Genre = "Western",
                     Price = 3.99M
                 }
             );
                context.SaveChanges();
            }
        }
    }
}
