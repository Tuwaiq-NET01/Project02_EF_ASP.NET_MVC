using Microsoft.EntityFrameworkCore;
using MovieApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace MovieApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<GenreModel> Genres { get; set; }

        public DbSet<ReviewModel> Reviews { get; set; }

        public DbSet<GenreMovieModel> GenreMovie { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            using (var client = new HttpClient())
            {
                List<MoviesDeserialize> movies;
                List<Genre> Genres;

                var MovieListUri = new Uri(
                    "https://api.themoviedb.org/3/movie/popular?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US&page=1");
                var MovieListResponse = client.GetAsync(MovieListUri);
                MovieListResponse.Wait();
                var MovieListResuls = MovieListResponse.Result.Content.ReadAsStringAsync();
                movies = JsonSerializer.Deserialize<Root>(MovieListResuls.Result).results;
                int count = 0;

                for (int i = 0; i < movies.Count; i++)
                {
                    var movie = movies[i];
                    var MovieUri = new Uri(
                        $"https://api.themoviedb.org/3/movie/{movie.id}?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US");
                    var MovieResponse = client.GetAsync(MovieUri);
                    MovieResponse.Wait();
                    var MovieResult = MovieResponse.Result.Content.ReadAsStringAsync();
                    // Seed GenreMovie table
                    movies[i] = JsonSerializer.Deserialize<MoviesDeserialize>(MovieResult.Result);

                    for (int j = 0; j < movies[i].genres.Count; j++)
                    {
                        // Seed GenreMovie Here
                        modelBuilder.Entity<GenreMovieModel>().HasData(
                                new GenreMovieModel()
                                {
                                    Id = (count + (j + 1)), GenreId = movies[i].genres[j].id, MovieId = movies[i].id
                                })
                            ;
                    }

                    count += movies[i].genres.Count;
                    
                    // Seed Movie 
                    
                    var CurrentMovie = movies[i];

                    modelBuilder.Entity<MovieModel>().HasData(
                        new MovieModel()
                        {
                            backdrop_path = CurrentMovie.backdrop_path, id = CurrentMovie.id,
                            imdb_id = CurrentMovie.imdb_id,
                            overview = CurrentMovie.overview, poster_path = CurrentMovie.poster_path,
                            release_date = CurrentMovie.release_date,
                            title = CurrentMovie.title, runtime = CurrentMovie.runtime,
                            vote_average = CurrentMovie.vote_average
                        }
                    );
                }

                var GenreUri = new Uri(
                    "https://api.themoviedb.org/3/genre/movie/list?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US");
                var GenreResponse = client.GetAsync(GenreUri);
                GenreResponse.Wait();
                var GenreResult = GenreResponse.Result.Content.ReadAsStringAsync();

                Genres = JsonSerializer.Deserialize<Root>(GenreResult.Result).genres;

                foreach (var genre in Genres)
                {
                    // Seed Here
                    modelBuilder.Entity<GenreModel>().HasData(new GenreModel()
                    {
                        id = genre.id, name = genre.name
                    });
                }
            }
        }
    }
}