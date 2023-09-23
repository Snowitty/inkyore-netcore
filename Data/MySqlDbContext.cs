using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace inkyore_netcore.Data
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {

        }
    }
}
