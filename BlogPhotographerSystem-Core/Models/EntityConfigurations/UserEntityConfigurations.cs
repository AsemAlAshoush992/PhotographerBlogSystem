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
    internal class UserEntityConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            //Size 
            builder.Property(x => x.Phone).HasMaxLength(14);
            //Nvarchar
            builder.Property(x => x.FirstName).IsUnicode();
            builder.Property(x => x.LastName).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_User_FirstName", "LENGTH(FirstName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_User_LastName", "LENGTH(LastName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_User_Phone", "Phone LIKE '009627________'"));
            builder.ToTable(t => t.HasCheckConstraint("CH_User_Email", "Email LIKE '%@%.com'"));
            //Relationships
            builder.HasOne<Login>().WithOne().HasForeignKey<Login>(x => x.UserID);
            builder.HasMany<ContactRequest>().WithOne().HasForeignKey(x => x.UserID);
            builder.HasMany<Order>().WithOne().HasForeignKey(x => x.UserID);
        }
    }
}
