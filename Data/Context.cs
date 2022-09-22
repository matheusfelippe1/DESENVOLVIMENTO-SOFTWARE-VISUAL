using Microsoft.EntityFrameworkCore;
using Motocicleta.Model;

namespace Motocicleta.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>opt) 
            : base(opt) => Database.EnsureCreated();
        public DbSet<MotoConquistada> MotoConquistada { get; set; }
        public DbSet<MotosSonho> MotoSonho { get; set; }
    }
}
