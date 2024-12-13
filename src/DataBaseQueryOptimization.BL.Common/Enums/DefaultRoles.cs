using System.ComponentModel;

namespace DataBaseQueryOptimization.BL.Common.Enums
{
    public enum DefaultRoles
    {
        [Description("Supervisor")]
        Supervisor,
        [Description("HR Manager")]
        HR,
        [Description("Office HR Manager")]
        OfficeHR,
        [Description("Region HR Manager")]
        RegionHR,
        [Description("Lead HR Manager")]
        LeadHR,
        //[Description("Employee")]
        //Employee,
        [Description("Admin")]
        Admin,
        [Description("Assessment Coordinator")]
        AssessmentCoordinator,
        [Description("Content Manager")]
        ContentManager,
        [Description("Resource Manager")]
        RM,
        [Description("Manager")]
        Manager,
        [Description("Кадровик")]
        AHR,
        [Description("Глава кадрового отдела")]
        HeadOfAHR,
        [Description("Глава отдела продаж")]
        HeadOfSales,
        [Description("Admin of Activities")]
        AdminOfActivities,
        [Description("Head of Experts")]
        HeadOfExperts,
        [Description("RM Expert")]
        RMExpert,
        [Description("Bench Manager")]
        BenchManager,
        [Description("Auditor")]
        Auditor,
        [Description("L&D")]
        LearningAndDevelopment,
        [Description("RM School")]
        RmSchool,
        [Description("IT Department")]
        ITDepartment,
        [Description("Editor")]
        Editor
    }
}
