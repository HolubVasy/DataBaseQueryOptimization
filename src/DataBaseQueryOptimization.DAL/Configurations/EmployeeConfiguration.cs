using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBaseQueryOptimization.DAL.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.HasOne(_ => _.ResourceManager)
                .WithMany()
                .HasForeignKey(_ => _.SourceManagerGUID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(_ => _.HumanResource)
                .WithMany()
                .HasForeignKey(_ => _.HumanResourceGUID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
