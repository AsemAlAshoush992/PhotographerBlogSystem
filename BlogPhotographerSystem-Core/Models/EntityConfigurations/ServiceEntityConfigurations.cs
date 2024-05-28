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
    public class ServiceEntityConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.CreatorUserId).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatorUserId).HasDefaultValue(1);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.ModifiedUserId).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            //Not Null Constraint
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.DisacountAmount).IsRequired(false);
            builder.Property(x => x.DiscountType).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);

            //Nvarchar
            builder.Property(x => x.Name).IsUnicode();
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.DiscountType).IsUnicode();
            //Size 
            builder.Property(x => x.Description).HasMaxLength(150);
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Service_Name", "LENGTH(Name) >= 4"));
            //Relationships
            builder.HasMany<Order>().WithOne().HasForeignKey(x => x.ServiceID);
        }
    }
}
