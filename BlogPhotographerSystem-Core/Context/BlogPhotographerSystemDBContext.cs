﻿using BlogPhotographerSystem_Core.Models.Entity;
using BlogPhotographerSystem_Core.Models.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Context
{
    public class BlogPhotographerSystemDBContext: DbContext
    {
        public BlogPhotographerSystemDBContext(DbContextOptions<BlogPhotographerSystemDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryEntityConfigurations());
            modelBuilder.ApplyConfiguration(new LoginEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ContactRequestEntityConfigurations());
            modelBuilder.ApplyConfiguration(new OrderEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceEntityConfigurations());
            modelBuilder.ApplyConfiguration(new UserEntityConfigurations());

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
