using Microsoft.EntityFrameworkCore;

namespace iSnippets.Models
{
	public class SnippetDbContext : DbContext
    {
		public DbSet<Snippet> Snippets { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=Snippets.db");
        }
    }
}