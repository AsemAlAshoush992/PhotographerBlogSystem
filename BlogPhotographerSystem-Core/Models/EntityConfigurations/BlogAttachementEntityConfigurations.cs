using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlogPhotographerSystem_Core.Helper.Enums.Enums;

namespace BlogPhotographerSystem_Core.Models.EntityConfigurations
{
    public class BlogAttachementEntityConfigurations : IEntityTypeConfiguration<BlogAttachement>
    {
        public void Configure(EntityTypeBuilder<BlogAttachement> builder)
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
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();
            //Size 
            builder.Property(x => x.FileName).HasMaxLength(25);
            //Nvarchar
            builder.Property(x => x.FileName).IsUnicode();
            //Default Constraint
            builder.Property(x => x.FileType).HasDefaultValue((FileType)Enum.Parse(typeof(FileType), "Image"));
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_BlogAttachement_FileName", "LENGTH(FileName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_BlogAttachement_FileName", @"NOT (FileName REGEXP '[0-9~!@#$%^&*()_+=-]')"));   
        }
    }
}
