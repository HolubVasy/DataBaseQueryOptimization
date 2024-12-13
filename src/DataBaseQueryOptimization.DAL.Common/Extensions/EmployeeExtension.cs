using DataBaseQueryOptimization.DAL.Common.Models.Common;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;

namespace DataBaseQueryOptimization.DAL.Common.Extensions
{
    public static class EmployeeExtension
    {

        public static string GetName(this Employee employee)
        {
            return string.IsNullOrEmpty(employee.FullNameEn)
                ? employee.FullNameRu
                : employee.FullNameEn;
        }
        
        public static InnerEmployee? GetResourceManagerAsInnerEmployee(this Employee employee)
        {
            return new InnerEmployee(
                employee.ResourceManager.Id,
                employee.ResourceManager.GetName(),
                employee.ResourceManager.IsWork);
        }
    }
}
