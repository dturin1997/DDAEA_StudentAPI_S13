using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace DDAEA_StudentAPI_S13.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
