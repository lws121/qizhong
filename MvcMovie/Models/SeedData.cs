using Microsoft.EntityFrameworkCore;
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
                       Name = "王",
                       Gender="女",
                       Age=20,
                       BirthDate= DateTime.Parse("2000-4-15"),
                       Phone ="15847047563",
                       Temperature="36.5",
                       Date= DateTime.Parse("2022-4-16")
                    },
                     new Movie
                     {
                         Name = "邹",
                         Gender = "男",
                         Age = 20,
                         BirthDate = DateTime.Parse("2000-4-15"),
                         Phone = "15847047563",
                         Temperature = "36.5",
                         Date = DateTime.Parse("2022-4-16")
                     },
                      new Movie
                      {
                          Name = "赵",
                          Gender = "女",
                          Age = 20,
                          BirthDate = DateTime.Parse("2000-4-15"),
                          Phone = "15847047563",
                          Temperature = "36.5",
                          Date = DateTime.Parse("2022-4-16")
                      },
                       new Movie
                       {
                           Name = "周",
                           Gender = "男",
                           Age = 20,
                           BirthDate = DateTime.Parse("2000-4-15"),
                           Phone = "15847047563",
                           Temperature = "36.5",
                           Date = DateTime.Parse("2022-4-16")
                       }


                );
                context.SaveChanges();
            }
        }
    }
}