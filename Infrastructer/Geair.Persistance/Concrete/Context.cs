﻿using Geair.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geair.Persistance.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=77.245.159.27;initial catalog=GeairDb;user=Geair;password=G_admin?.;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Banner> Banners{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<CompanyAddress> CompanyAddresses{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<FlightOptions> FlightOptions{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Newsletter> Newsletters{ get; set; }
    }
}
