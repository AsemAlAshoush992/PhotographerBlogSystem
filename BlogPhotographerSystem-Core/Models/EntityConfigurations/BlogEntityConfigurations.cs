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
    public class BlogEntityConfigurations : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
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
            builder.Property(x => x.Article).IsRequired();
            builder.Property(x => x.BlogDate).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            //Size 
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Title).HasMaxLength(30);
            //Nvarchar
            builder.Property(x => x.Title).IsUnicode();
            builder.Property(x => x.Article).IsUnicode();
            builder.Property(x => x.Description).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Blog_Title", "LENGTH(Title) >= 5"));
            //Default Constraint
            builder.Property(x => x.BlogDate).HasDefaultValue(DateTime.Now);
            //Relationships
            builder.HasMany<BlogAttachement>().WithOne().HasForeignKey(x => x.BlogID);
        }
    }
}
