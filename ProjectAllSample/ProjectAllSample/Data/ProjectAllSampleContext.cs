using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAllSample.Models;

namespace ProjectAllSample.Data
{
    public class ProjectAllSampleContext : DbContext
    {
        public ProjectAllSampleContext (DbContextOptions<ProjectAllSampleContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectAllSample.Models.Member> Member { get; set; } = default!;

        public DbSet<ProjectAllSample.Models.Book>? Book { get; set; }

        public DbSet<ProjectAllSample.Models.Publishers>? Publishers { get; set; }

        public DbSet<ProjectAllSample.Models.Author>? Author { get; set; }

        public DbSet<ProjectAllSample.Models.Loans>? Loans { get; set; }
    }
}
