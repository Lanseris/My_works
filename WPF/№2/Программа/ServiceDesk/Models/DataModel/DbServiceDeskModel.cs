namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbServiceDeskModel : DbContext
    {
        public DbServiceDeskModel()
            : base("name=DbServiceDeskModel")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
    
}