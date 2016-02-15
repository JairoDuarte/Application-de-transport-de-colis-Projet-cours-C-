using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.EntityConfig
{
    class EmployeConfig : EntityTypeConfiguration<Employe>
    {

        public EmployeConfig()
        {

            HasKey(c => c.Employeid);

            Property(c => c.nomEmploye)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.prenomEmploye)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.emailEmploye)
                .HasMaxLength(150);
            Property(c => c.adresseEmploye)
                .HasMaxLength(150);
           
        }
    }

}
