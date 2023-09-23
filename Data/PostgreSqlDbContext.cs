using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace inkyore_netcore.Data
{
    public class PostgreSqlDbContext : DbContext
    {
        public PostgreSqlDbContext(DbContextOptions<PostgreSqlDbContext> options) : base(options) { }
    }
}
