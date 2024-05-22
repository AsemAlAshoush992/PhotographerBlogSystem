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
    public class ProblemEntityConfigurations : IEntityTypeConfiguration<Problem>
    {
        public void Configure(EntityTypeBuilder<Problem> builder)
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
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Purpose).IsRequired();
            builder.Property(x => x.UserID).IsRequired(false);
            builder.Property(x => x.OrderID).IsRequired(false);
            //Size 
            builder.Property(x => x.Purpose).HasMaxLength(50);
            //Nvarchar
            builder.Property(x => x.Title).IsUnicode();
            builder.Property(x => x.Description).IsUnicode();
            builder.Property(x => x.Purpose).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Problem_Title", "LENGTH(Title) >= 5"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Problem_Title", @"NOT (Title REGEXP '[0-9~!@#$%^&*()_+=-]')"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Problem_Purpose", @"NOT (Purpose REGEXP '[0-9~!@#$%^&*()_+=-]')"));
        }
    }
}
