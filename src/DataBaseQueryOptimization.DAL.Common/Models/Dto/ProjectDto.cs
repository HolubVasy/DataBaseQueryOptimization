using DataBaseQueryOptimization.DAL.Common.Models.Common;

namespace DataBaseQueryOptimization.DAL.Common.Models.Dto
{
    public class ProjectDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TeamQty { get; set; }
        public bool IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public InnerEmployee ProjectManager { get; set; }
        public InnerEmployee ResourceManager { get; set; }
        public InnerEmployee DeliveryManager { get; set; }
        public InnerEmployee AssociateDeliveryManager { get; set; }
        public IEnumerable<EmployeePreviewDto> Employees { get; set; }
        public Guid? SupervisorDeliveryManagerId { get; set; }
    }
}
