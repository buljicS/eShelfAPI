using Microsoft.EntityFrameworkCore;

namespace eShelfAPI.Context
{
    public partial class MainContext:DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            eShelfModelCreateing(modelBuilder);
        }
    }
}
