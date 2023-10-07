using dota2LobbyGenerator.Entities;
using Microsoft.EntityFrameworkCore;

namespace dota2LobbyGenerator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   
        
        public DbSet<Hero> Heroes { get; set; }     
        
    }
}
