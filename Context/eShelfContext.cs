using eShelfAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShelfAPI.Context
{
    public partial class MainContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        private void eShelfModelCreateing(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>(en =>
            {
                en.HasKey(x => x.UserId);
            });
        }
    }
}
