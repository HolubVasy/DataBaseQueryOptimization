using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using DataBaseQueryOptimization.DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataBaseQueryOptimization.DAL.DbContexts
{
    public class DataBaseContext : DbContext
    {
        #region Entities
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployee { get; set; }
        
        #endregion

        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Options = options;
        }

        public DbContextOptions<DataBaseContext> Options { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
}
}
