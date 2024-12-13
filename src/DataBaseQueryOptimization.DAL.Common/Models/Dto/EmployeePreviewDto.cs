using DataBaseQueryOptimization.DAL.Common.Models.Common;

namespace DataBaseQueryOptimization.DAL.Common.Models.Dto
{
    public class EmployeePreviewDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsWork { get; set; }
        public InnerEmployee? ResourceManager { get; set; }
    }
}
