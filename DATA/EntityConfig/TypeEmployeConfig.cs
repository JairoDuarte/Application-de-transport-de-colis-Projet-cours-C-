using ClassLibrary;
using System.Data.Entity.ModelConfiguration;

namespace DATA.Context
{
    internal class TypeEmployeConfig : EntityTypeConfiguration<TypeEmploye>
    {
        public TypeEmployeConfig()
        {
            HasKey(c => c.TypeEmployeid);

            Property(c => c.nomTypeEmploye)
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}