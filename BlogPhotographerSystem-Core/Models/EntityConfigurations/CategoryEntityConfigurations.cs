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
    public class CategoryEntityConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
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
            builder.Property(x => x.Description).IsRequired(false);
            //Size 
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Title).HasMaxLength(25);
            //Nvarchar
            builder.Property(x => x.Title).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Category_Title", "LENGTH(Title) >= 5"));
            //Relationships
            builder.HasMany<Service>().WithOne().HasForeignKey(x => x.CategoryID);
        }
    }
}
