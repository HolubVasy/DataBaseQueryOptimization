using DataBaseQueryOptimization.DAL.Common.Models.Dto;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;

namespace DataBaseQueryOptimization.DAL.Common.Extensions
{

    public static class ProjectEmployeeExtension
    {
        public static List<EmployeePreviewDto?> MapToEmployeePreviewDtOs(
            this IEnumerable<ProjectEmployee> employees)
        {
            var employeesPreviewDto = new List<EmployeePreviewDto?>();

            if (employees is not null)
            {
                employeesPreviewDto = 
                    new List<EmployeePreviewDto?>(employees.Count());

                foreach (var emp in employees)
                {
                    var previewId = emp.EmployeeId;
                    var previewName = emp.Employee?.GetName();
                    var isWork = emp.Employee?.IsWork;
                    var previewResourceManager = emp.Employee?
                        .GetResourceManagerAsInnerEmployee();
                    var proxyId = emp.ProxyId;
                    employeesPreviewDto.Add(new EmployeePreviewDto()
                    {
                        Id = previewId,
                        Name = previewName,
                        IsWork = isWork.Value,
                        ResourceManager = previewResourceManager,
                    });
                }
            }

            return employeesPreviewDto;
        }
        
    }
}
