using CoreTask2_Moon.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask2_Moon.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<AppDetail> AppDetails { get; set; }
        public DbSet<Audience> Audiences { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Client> Clients { get; set; }
}
}
