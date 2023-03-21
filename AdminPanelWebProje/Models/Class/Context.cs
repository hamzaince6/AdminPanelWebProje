using System.Data.Entity;

namespace AdminPanelWebProje.Models.Class
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Anasayfa> Anasayfa { get; set; }
        public DbSet<socialicon> Socialicon { get; set; }
    }
}