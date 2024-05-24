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
    public class ContactRequestEntityConfigurations : IEntityTypeConfiguration<ContactRequest>
    {
        public void Configure(EntityTypeBuilder<ContactRequest> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.CreatorUserId).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.ModifiedUserId).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            //Not Null Constraint
            builder.Property(x => x.ClientName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Purpose).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Budget).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
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
