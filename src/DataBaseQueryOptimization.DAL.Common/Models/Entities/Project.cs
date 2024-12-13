namespace DataBaseQueryOptimization.DAL.Common.Models.Entities
{
    public class Project
    {
        public Guid ProjectGuid { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime IterationDate { get; set; }
        public Guid ProjectManagerGuid { get; set; }
        public Guid ResourceManagerGuid { get; set; }
        public Guid? DeliveryManagerGuid { get; set; }
        public Guid? AssociateDeliveryManagerId { get; set; }
        public int NumberOfEmployess { get; set; }
        public Guid ProjectType { get; set; }
        public bool Open { get; set; }
        public decimal Coefficient { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<ProjectEmployee> Allocations { get; set; }
        public virtual Employee ProjectManager { get; set; }
        public virtual Employee ResourceManager { get; set; }
        public virtual Employee DeliveryManager { get; set; }
        public virtual Employee AssociateDeliveryManager { get; set; }
        public Guid? SupervisorDeliveryManagerId { get; set; }
    }
}
