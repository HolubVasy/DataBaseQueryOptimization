using DataBaseQueryOptimization.DAL.Common.Extensions;
using DataBaseQueryOptimization.DAL.Common.Models.Common;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using DataBaseQueryOptimization.DAL.Enums;

namespace DataBaseQueryOptimization.DAL.Extensions
{
    public static class ProjectExtension
    {
        public static InnerEmployee? GetManagerAsInnerEmployee(this Project project, 
            ProjectManager manager)
        {
            Employee entity;
            
            switch (manager)
            {
                case ProjectManager.ProjectManager:
            case ProjectManager.ResourceManager:
                case ProjectManager.DeliveryManager:
                case ProjectManager.AssociateDeliveryManager:
                    entity = project.ProjectManager;
                    break;
            default : return null;
            }

            var innerEmployee = new InnerEmployee(
                entity.Id,
                entity.GetName(),
                entity.IsWork);

            return innerEmployee;
        }
    }
}