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
    internal class OrderEntityConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
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
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.PaymentMethod).IsRequired();
            builder.Property(x => x.Note).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            //Unique Constraint
            builder.HasIndex(x => x.Note).IsUnique();
            builder.HasIndex(x => x.Title).IsUnique();
            //Size 
            builder.Property(x => x.Note).HasMaxLength(100);
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Order_Title", "LENGTH(Title) >= 5"));
        }
    }
}
