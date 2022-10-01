using Microsoft.EntityFrameworkCore;

namespace atividade_D7.Data;

public class Context : DbContext 
{
	public Context(DbContextOptions<Context> options) : base(options)
	{
		Database.EnsureCreated(); 
	}

	public DbSet<User> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>().HasData(GetUsers()); 
		base.OnModelCreating(modelBuilder);
	}

	private static User[] GetUsers()
	{
		return new User[]
		{
			new User
			{
				Usuario = "admin@email.com",
				Senha = "admin123"
			},
			new User
			{
				Usuario = "a",
				Senha = "a"
			}
		};
	}
}
