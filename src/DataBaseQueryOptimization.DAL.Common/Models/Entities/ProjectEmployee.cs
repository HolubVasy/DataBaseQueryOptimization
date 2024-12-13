namespace DataBaseQueryOptimization.DAL.Common.Models.Entities
{
    public class ProjectEmployee
    {
        public Guid ProjectEmployeeGuid { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ProjectGuid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public Guid RoleGuid { get; set; }
        public int Hours { get; set; }
        public Guid AllocationTypeGuid { get; set; }
        public bool Rate { get; set; }
        public Guid? ProxyId { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
