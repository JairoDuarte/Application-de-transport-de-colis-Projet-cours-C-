using ClassLibrary;
using DATA.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DATA.Context
{
    public class ProjetContext : DbContext
    {
        public ProjetContext()
            : base("conposte")
        {

        }

        public DbSet<NatureColis> Nuturecolis { get; set; }
        public DbSet<TypeColis> Typecolis { get; set; }
        public DbSet<Ville> Ville { get; set; }
        public DbSet<VoieTransmission> Voietransmission { get; set; }
        public DbSet<TypeEmploye> TypeEmploye { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Colis> Colis { get; set; }


        //public DbSet<Colis> Colis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "id")
                .Configure(p => p.IsKey());
                
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new TypeEmployeConfig());
            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new EmployeConfig());
           
        }
    }
      
}
