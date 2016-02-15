
using ClassLibrary;
using System.Data.Entity.ModelConfiguration;

namespace DATA.EntityConfig
{
    class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            HasKey(c => c.Clientid);

            Property(c => c.nomClient)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.prenomClient)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.emailClient)
                .HasMaxLength(150);
            Property(c => c.faxClient)
                .HasMaxLength(150);

            Property(c => c.telClient)
                .IsOptional();

            Property(c => c.emailClient)
                .IsRequired();
        }
    }
}
