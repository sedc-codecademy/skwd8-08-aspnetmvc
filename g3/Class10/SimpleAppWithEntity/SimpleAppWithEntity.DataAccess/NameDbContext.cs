using Microsoft.EntityFrameworkCore;
using SimpleAppWithEntity.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAppWithEntity.DataAccess
{
    // Install nugets:
    // Microsoft.EntityFrameworkCore 2.1.1
    // Microsoft.EntityFrameworkCore.SqlServer 2.1.1
    // Microsoft.EntityFrameworkCore.Design 2.1.1
    public class NameDbContext : DbContext
    {
        public NameDbContext(DbContextOptions opstions) : base(opstions) {}

        public DbSet<Name> Names { get; set; }
    }
}
