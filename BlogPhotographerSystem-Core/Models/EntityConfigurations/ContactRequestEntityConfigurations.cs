using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Models.EntityConfigurations
{
    internal class ContactRequestEntityConfigurations : IEntityTypeConfiguration<ContactRequest>
    {
        public void Configure(EntityTypeBuilder<ContactRequest> builder)
        {
            //basic configurations
            builder.HasKey(X => X.ID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            //Not Null Constraint
            builder.Property(x => x.ClientName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Purpose).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Budget).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            //Unique Constraint
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            //Size 
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(14);
            //Nvarchar
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.ClientName).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_ContactRequest_ClientName", "LENGTH(ClientName) >= 5"));
            builder.ToTable(t => t.HasCheckConstraint("CH_ContactRequest_Phone", "Phone LIKE '009627________'"));
            builder.ToTable(t => t.HasCheckConstraint("CH_ContactRequest_Email", "Email LIKE '%@%.com'"));
        }
    }
}
