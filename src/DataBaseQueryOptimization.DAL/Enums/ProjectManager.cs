using System.ComponentModel;

namespace DataBaseQueryOptimization.DAL.Enums
{
    public enum ProjectManager
    {
        [Description("ProjectManager")]
        ProjectManager = 0,

        [Description("ResourceManager")]
        ResourceManager = 1,

        [Description("DeliveryManager")]
        DeliveryManager = 2,

        [Description("AssociateDeliveryManager")]
        AssociateDeliveryManager = 3
    }


}

