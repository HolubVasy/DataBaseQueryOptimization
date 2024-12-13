using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBaseQueryOptimization.DAL.Configurations
{
    internal class ProjectEmployeeConfiguration : IEntityTypeConfiguration<ProjectEmployee>
    {
        public void Configure(EntityTypeBuilder<ProjectEmployee> builder)
        {
            builder.HasKey(pe => pe.ProjectEmployeeGuid);

            builder.HasOne(e => e.Employee)
                .WithMany(pe => pe.Allocations)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Project)
                .WithMany(pe => pe.Allocations)
                .HasForeignKey(e => e.ProjectGuid)
                .OnDelete(DeleteBehavior.Cascade);;
        }
    }
}
