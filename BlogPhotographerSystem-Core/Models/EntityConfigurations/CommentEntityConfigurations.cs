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
    public class CommentEntityConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
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
            builder.Property(x => x.AuthorName).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.BlogId).IsRequired();
            //Size 
            builder.Property(x => x.Content).HasMaxLength(100);
            builder.Property(x => x.AuthorName).HasMaxLength(25);
            //Nvarchar
            builder.Property(x => x.AuthorName).IsUnicode();
            builder.Property(x => x.Content).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Comment_AuthorName", "LENGTH(AuthorName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Comment_Content", "LENGTH(Content) >= 3"));
        }
    }
}
