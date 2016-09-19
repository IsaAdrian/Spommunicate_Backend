using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSportCommManager
{
    public class SportContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<PersonChat> PersonChats { get; set; }

        public SportContext() : base("Name=SportDb")
        {
            //Database.SetInitializer(new SchoolContextInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
    public class SportRepository<T> : EFRepository<T, SportContext> where T : class { }


}
