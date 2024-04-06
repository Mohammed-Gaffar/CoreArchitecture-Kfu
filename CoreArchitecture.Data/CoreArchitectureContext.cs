using Microsoft.EntityFrameworkCore;

namespace CoreArchitecture.Data
{
    public class CoreArchitectureContext : DbContext
    {
        public CoreArchitectureContext(DbContextOptions<CoreArchitectureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Template> Templates { get; set; }
    }
}
