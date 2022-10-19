using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace VirtoCommerce.AssetsModule.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AssetsDbContext>
    {
        public AssetsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AssetsDbContext>();

            //builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

            builder.UseMySql("server=localhost;user=root;password=virto;database=VirtoCommerce3;", new MySqlServerVersion(new Version(5, 7)));

            return new AssetsDbContext(builder.Options);
        }
    }
}
