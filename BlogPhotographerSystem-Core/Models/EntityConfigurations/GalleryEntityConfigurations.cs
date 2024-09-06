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
    public class GalleryEntityConfigurations : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
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
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();
            builder.Property(x => x.OrderID).IsRequired(false);
            builder.Property(x => x.UserId).IsRequired(false);
            //Size 
            builder.Property(x => x.FileName).HasMaxLength(200);
            //Nvarchar
            builder.Property(x => x.FileName).IsUnicode();
            //Default Constraint
            builder.Property(x => x.FileType).HasDefaultValue((FileType)Enum.Parse(typeof(FileType), "Image"));
            builder.Property(x => x.IsPrivate).HasDefaultValue(false);
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Gallery_FileName", "LENGTH(FileName) >= 3"));
        }
    }
}
