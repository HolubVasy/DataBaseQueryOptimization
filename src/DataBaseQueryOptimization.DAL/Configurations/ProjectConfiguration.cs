using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBaseQueryOptimization.DAL.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(_ => _.ProjectGuid);

            builder.HasOne(_ => _.ResourceManager)
                .WithMany()
                .HasForeignKey(_ => _.ResourceManagerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(_ => _.ProjectManager)
                .WithMany()
                .HasForeignKey(_ => _.ProjectManagerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(_ => _.DeliveryManager)
                .WithMany()
                .HasForeignKey(_ => _.DeliveryManagerGuid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(_ => _.AssociateDeliveryManager)
                .WithMany()
                .HasForeignKey(_ => _.AssociateDeliveryManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
