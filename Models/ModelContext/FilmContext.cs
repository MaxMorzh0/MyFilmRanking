using Microsoft.EntityFrameworkCore;

namespace MyFilmRanking.Models.ModelContext
{
	public class FilmContext : DbContext
	{
		public DbSet<Film> Films { get; set; }

		public FilmContext(DbContextOptions<FilmContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Film>().HasData(
				new Film { Id = 1, Title = "The Shawshank Redemption", Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", ImageUrl = "/Data/Images/download.jpg" , Budget = 25000000, Director = "Frank Darabont", Genre= "prison drama film" },
				new Film { Id = 2, Title = "The Godfather", Description = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.", ImageUrl = "/Data/Images/download (1).jpg", Budget = 7200000, Director = "Francis Ford Coppola", Genre = "epic crime film" },
				new Film { Id = 3, Title = "The Dark Knight", Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", ImageUrl = "/Data/Images/download (2).jpg", Budget = 185000000, Director = "Christopher Nolan", Genre = "superhero film" },
				new Film { Id = 4, Title = "Schindler's List", Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", ImageUrl = "/Data/Images/download (3).jpg", Budget = 22000000, Director = "Steven Spielberg", Genre = "epic historical drama" },
				new Film { Id = 5, Title = "The Lord of the Rings: The Return of the King", Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", ImageUrl = "/Data/Images/download (4).jpg", Budget = 94000000, Director = "Peter Jackson", Genre = "epic fantasy adventure film " }
			);
		}
	}
}
