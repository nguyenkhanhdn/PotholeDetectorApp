using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PotholeDetectorApp.Models
{
    public class PotholeDetectorDbContext:DbContext
    {
        public PotholeDetectorDbContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Pothole> Potholes { get; set; }
    }
}