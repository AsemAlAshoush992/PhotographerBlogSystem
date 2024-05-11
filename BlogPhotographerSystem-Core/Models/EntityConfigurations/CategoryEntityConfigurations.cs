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
            //basic configurations
            builder.HasKey(X => X.ID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
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
        }
    }
