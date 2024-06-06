using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Dark Night",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Iron Man",
                    ReleaseDate = DateTime.Parse("2008-5-02"),
                    Genre = "Sci-Fi",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Edward Scissorhands",
                    ReleaseDate = DateTime.Parse("1990-2-23"),
                    Genre = "Romance",
                    Rating = "R",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-4-15"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Memento",
                    ReleaseDate = DateTime.Parse("2000-8-16"),
                    Genre = "Mystery",
                    Rating = "R",
                    Price = 6.99M
                }
            );
            context.SaveChanges();
        }
    }
}