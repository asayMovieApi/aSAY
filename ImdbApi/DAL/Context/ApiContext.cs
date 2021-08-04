
using ImdbApi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ImdbApi.DAL.Context
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // genre - moviegenre
            modelBuilder.Entity<MovieGenre>()
            .HasOne<Genre>(s => s.Genre)
            .WithMany(g => g.MovieGenres)
            .HasForeignKey(s => s.GenreId);
            //movie - moviegenre
            modelBuilder.Entity<MovieGenre>()
            .HasOne<Movie>(s => s.Movie)
            .WithMany(g => g.MovieGenre)
            .HasForeignKey(s => s.MovieId);
            // gender-director
            modelBuilder.Entity<Director>()
           .HasOne<Gender>(s => s.Gender)
           .WithMany(ad => ad.Director)
           .HasForeignKey(ad => ad.GenderId);
            // movie - director
            modelBuilder.Entity<Movie>()
            .HasOne<Director>(s => s.Director)
            .WithMany(g => g.Movies)
            .HasForeignKey(s => s.DirectorId);
        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
      
    }
}
