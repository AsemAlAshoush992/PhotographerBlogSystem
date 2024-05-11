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
    internal class LoginEntityConfigurations : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            //basic configurations
            builder.HasKey(X => X.ID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            //Not Null Constraint
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            //Unique Constraint
            builder.HasIndex(x => x.UserName).IsUnique();
            builder.HasIndex(x => x.Password).IsUnique();
            //Size 
            builder.Property(x => x.Password).HasMaxLength(15);
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Login_Password", "LENGTH(Password) >= 8"));
        }
    }
}
