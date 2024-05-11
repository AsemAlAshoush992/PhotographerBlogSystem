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
    internal class ServiceEntityConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            //basic configurations
            builder.HasKey(X => X.ID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            //Not Null Constraint
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.DisacountAmount).IsRequired(false);
            builder.Property(x => x.DiscountType).IsRequired(false);

            //Nvarchar
            builder.Property(x => x.Name).IsUnicode();
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.DiscountType).IsUnicode();
            //Size 
            builder.Property(x => x.Description).HasMaxLength(150);
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Service_Name", "LENGTH(Name) >= 4"));
        }
    }
}
