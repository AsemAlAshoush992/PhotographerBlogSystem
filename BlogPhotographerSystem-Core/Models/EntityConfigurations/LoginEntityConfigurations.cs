﻿using BlogPhotographerSystem_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Models.EntityConfigurations
{
    public class LoginEntityConfigurations : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
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
            builder.Property(x => x.LastLoginTime).IsRequired(false);
            //Not Null Constraint
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            //Unique Constraint
            builder.HasIndex(x => x.UserName).IsUnique();
            builder.HasIndex(x => x.Password).IsUnique();
            //Default values
            builder.Property(x => x.IsLoggedIn).HasDefaultValue(false);
            //Size 
            builder.Property(x => x.Password).HasMaxLength(30);
            //Check Constrain
            builder.ToTable(t => t.HasCheckConstraint("CH_Login_Password",@"Password REGEXP '^(?=.*[A-Z])(?=(?:.*[a-z]){6,})(?=.*[0-9])(?=.*[+=)(*&^%$#@!~]).*$'"));
        }
    }
}
