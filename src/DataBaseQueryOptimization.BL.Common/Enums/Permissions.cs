using System.ComponentModel.DataAnnotations;

namespace DataBaseQueryOptimization.BL.Common.Enums
{
    public enum Permissions : short
    {
        NotSet = 0, //error condition


        [Display(Name = "Read Project Team", Description = "Can list project team")]
        ProjectTeamRead = 0x1,

        [Display(GroupName = "EmployeePrivateData", Name = "Read Vacations and DayOff", Description = "Can read alien Vacations and DayOff")]
        ReadPrivateVacations = 0x2,

        [Display(GroupName = "EmployeePrivateData", Name = "Read private birthday", Description = "Can read private birthday")]
        ReadPrivateBirthday = 0x3,
        [Display(GroupName = "EmployeePrivateData", Name = "Read private phone", Description = "Can read private phone")]
        ReadPrivatePhone = 0x4,
        [Display(GroupName = "EmployeePrivateData", Name = "Read extra-mile", Description = "Can read extra-mile")]
        ReadExtraMile = 0x5,
        [Display(GroupName = "EmployeePrivateData", Name = "Read allocations", Description = "Can read employees previous allocation (projects)")]
        ReadEmployeesPreviousAllocation = 0x6,
        [Display(GroupName = "EmployeePrivateData", Name = "Read next assessment date", Description = "Can read next assessment date")]
        ReadNextAssessmentDate = 0x7,
        [Display(GroupName = "EmployeePrivateData", Name = "Read assessment matrix link", Description = "Can read link to assessment matrix (merged) for technology")]
        ReadTechnologyMatrixLink = 0x8,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to one-to-one", Description = "Can read, create and edit one-to-one")]
        FullAccessOneToOne = 0x9,
        [Display(GroupName = "EmployeePrivateData", Name = "Read risk of leaving", Description = "Can read risk of leaving")]
        ReadRiskOfLeaving = 0x10,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to coordinates tab", Description = "Can access to full content for coordinates")]
        FullAccessCoordinates = 0x11,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to EmployeeList", Description = "Can access to EmployeeList")]
        AccessEmployeeList = 0x12,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to feedbacks", Description = "Can read other employees feedbacks")]
        ReadFeedbacks = 0x13,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to employees 'My Vacation' section", Description = "Can read other employees 'My Vacation' section")]
        ReadVacationPlans = 0x14, 
        [Display(GroupName = "EmployeePrivateData", Name = "Access to employees 'Vacation plan requests' section", Description = "Can read other employees 'Vacation plan requests' section")]
        ReadVacationPlanRequests = 0x15,
        [Display(GroupName = "EmployeeFeedbacks", Name = "Request feedbacks", Description = "Can request feedback for employee")]
        CanRequestFeedback = 0x16,
        [Display(GroupName = "EmployeeFeedbacks", Name = "Request external feedbacks", Description = "Can request external feedback for employee")]
        CanRequestFeedbackExternal = 0x17,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to sellers feedbacks", Description = "Can read sellers feedbacks")]
        ReadFeedbacksAboutSellers = 0x18,
        [Display(GroupName = "EmployeeFeedbacks", Name = "Request sellers feedbacks", Description = "Can request feedback for sellers")]
        CanRequestFeedbackAboutSellers = 0x19,
        [Display(GroupName = "EmployeeFeedbacks", Name = "Access to feedbacks", Description = "Access to read feedbacks of working staff")]
        CanReadFeedbacksAboutWorkingStaff = 0x20,


        // 0x20+ assessment permissions 
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee objectives", Description = "Can read employee objectives")]
        ReadEmployeeObjectives = 0x21,
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee salary review history", Description = "Can read employee salary review history")]
        ReadEmployeeSalaryReviews = 0x22,
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee interviews", Description = "Can read employee (as tech interviewer) interviews")]
        ReadTechInterviews = 0x23,
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee objectives", Description = "Can read employee objectives")]
        ReadEmployeeObjectivesByWardRules = 0x24,
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee salary review history", Description = "Can read employee salary review history")]
        ReadEmployeeSalaryReviewsByWardRules = 0x25,
        [Display(GroupName = "EmployeePrivateData", Name = "Read employee interviews", Description = "Can read employee (as tech interviewer) interviews")]
        ReadTechInterviewsByWardRules = 0x26,
        [Display(GroupName = "EmployeePrivateData", Name = "Edit employee objectives", Description = "Can edit employee objectives")]
        EditEmployeeObjectivesByWardRules = 0x27,

        [Display(GroupName = "EdidEmployeeData", Name = "Edit interviewer comment", Description = "Can edit interviewer comment")]
        EditTechInterviewerComment = 0x31,
        [Display(GroupName = "ReadEmployeeTabs", Name = "Read employee tabs", Description = "Can read employee tabs")]
        ReadEmployeeTabs = 0x32,

        [Display(GroupName = "Portal", Name = "View published and unpublished events", Description = "Can view published and unpublished events")]
        ReadUnpublishedEvents = 0x33,

        [Display(Name = "Read Project Team", Description = "Can list project team - according to  additional rules by ward employee")]
        ProjectTeamReadByWardRules = 0x51,
        [Display(GroupName = "EmployeePrivateData", Name = "Read private birthday", 
            Description = "Can read private birthday - according to  additional rules by ward employee")]
        ReadPrivateBirthdayByWardRules = 0x53,
        [Display(GroupName = "EmployeePrivateData", Name = "Read private phone", 
            Description = "Can read private phone - according to  additional rules by ward employee")]
        ReadPrivatePhoneByWardRules = 0x54,
        [Display(GroupName = "EmployeePrivateData", Name = "Read extra-mile", 
            Description = "Can read extra-mile - according to  additional rules by ward employee")]
        ReadExtraMileByWardRules = 0x55,
        [Display(GroupName = "EmployeePrivateData", Name = "Read allocations", 
            Description = "Can read employees previous allocation (projects) - according to  additional rules by ward employee")]
        ReadEmployeesPreviousAllocationByWardRules = 0x56,
        [Display(GroupName = "EmployeePrivateData", Name = "Read next assessment date", 
            Description = "Can read next assessment date - according to  additional rules by ward employee")]
        ReadNextAssessmentDateByWardRules = 0x57,
        [Display(GroupName = "EmployeePrivateData", Name = "Read assessment matrix link", 
            Description = "Can read link to assessment matrix (merged) for technology - according to  additional rules by ward employee")]
        ReadTechnologyMatrixLinkByWardRules = 0x58,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to one-to-one", 
            Description = "Can read, create and edit one-to-one - according to  additional rules by ward employee")]
        FullAccessOneToOneByWardRules = 0x59,
        [Display(GroupName = "EmployeePrivateData", Name = "Read risk of leaving", 
            Description = "Can read risk of leaving - according to  additional rules by ward employee")]
        ReadRiskOfLeavingByWardRules = 0x60,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to coordinates tab", 
            Description = "Can access to full content for coordinates - according to  additional rules by ward employee")]
        FullAccessCoordinatesByWardRules = 0x61,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to one-to-one", 
            Description = "Can read other employees feedbacks - according to  additional rules by ward employee")]
        ReadFeedbacksByWardRules = 0x63,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to employees 'My Vacation' section", 
            Description = "Can read other employees 'My Vacation' section - according to  additional rules by ward employee")]
        ReadVacationPlansByWardRules = 0x64,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to employees 'Vacation plan requests' section", 
            Description = "Can read other employees 'Vacation plan requests' section - according to  additional rules by ward employee")]
        ReadVacationPlanRequestsByWardRules = 0x65,

        [Display(GroupName = "ExpertActivities", Name = "Access to expert activities", Description = "Access to read employees expert activities")]
        CanReadExpertActivities = 0x100,
        [Display(GroupName = "ExpertActivities", Name = "Access to expert activities", Description = "Access to read employees expert activities by rules")]
        CanReadExpertActivitiesByWardRules = 0x101,
        [Display(GroupName = "ExpertActivities", Name = "Edit expert activities", Description = "Access to edit employees expert activities by rules")]
        CanEditExpertActivitiesByWardRules = 0x102,

        [Display(GroupName = "BenchManagement", Name = "Read/export bench report", Description = "Can read and export bench report")]
        ReadBenchReport = 0x110,
        [Display(GroupName = "BenchManagement", Name = "Filter/sort bench report", Description = "Can filter and sort bench report")]
        FilterAndSortBenchReport = 0x111,
        [Display(GroupName = "BenchManagement", Name = "Read comments in bench report", Description = "Can read comments in bench report on employee and downtime start columns")]
        ReadCommentsInBenchReport = 0x112,
        [Display(GroupName = "BenchManagement", Name = "Edit comments in bench report", Description = "Can edit comments in bench report on employee and downtime start columns")]
        EditCommentsInBenchReport = 0x113,
        [Display(GroupName = "BenchManagement", Name = "Edit label, status and cell color in bench report", Description = "Can edit label, status and employee cell color in bench report")]
        EditLabelStatusAndCellColor = 0x114,
        [Display(GroupName = "BenchManagement", Name = "Read conversation with employee/dm, conversation about vacation and result in bench report",
            Description = "Can read conversation with employee/dm, conversation about vacation and result columns in bench report")]
        ReadConversationAndResult = 0x115,
        [Display(GroupName = "BenchManagement", Name = "Edit conversation with employee/dm, conversation about vacation and result in bench report",
            Description = "Can edit conversation with employee/dm, conversation about vacation and result columns in bench report")]
        EditConversationAndResult = 0x116,
        [Display(GroupName = "BenchManagement", Name = "Choose bench report date", Description = "Can choose bench report date")]
        ChooseBenchReportDate = 0x117,
        [Display(GroupName = "BenchManagement", Name = "Read feedbacks from bench report", Description = "Can read feedbacks from bench report")]
        ReadFeedbacksFromBenchReport = 0x118,
        [Display(GroupName = "BenchManagement", Name = "Read employees who left bench", Description = "Can read employees who left bench")]
        ReadEmployeesLeftBench = 0x119,
        [Display(GroupName = "BenchManagement", Name = "Add more columns about employee upcoming interviews", Description = "Can add more columns about employee upcoming interviews")]
        AddColumnsForUpcomingInterviews = 0x120,

        [Display(GroupName = "Certificates", Name = "Read employee certificates", Description = "Can read/print/save last versions of all employee certificates")]
        ReadCertificates = 0x121,
        [Display(GroupName = "Certificates", Name = "Read/edit employee certificates", Description = "Can edit last employee certificate and read/print/save all this versions and other certificates last versions")]
        FullAccessCertificatesByWardRules = 0x122,

        [Display(GroupName = "EmployeePrivateData", Name = "Read average mark", Description = "Can read feedback average mark")]
        ReadFeedbackAverageMark = 0x123,
        [Display(GroupName = "EmployeePrivateData", Name = "Access to PMs feedbacks", Description = "Can read projects PMs feedbacks")]
        ReadFeedbacksAboutProjectPms = 0x124,

        [Display(GroupName = "EmployeeActualLocation", Name = "Access actual location", Description = "Can see actual location of user")]
        ReadCityCountryLocation = 0x125,

        [Display(GroupName = "EmployeeActualLocation", Name = "Access actual location by ward rules", Description = "Can see actual location of user by ward rules")]
        ReadCityCountryLocationByWardRules = 0x126,

        [Display(GroupName = "EmployeeActualLocation", Name = "Access RM School to feedbacks of laboratory assistance", Description = "Access RM School to feedbacks of laboratory assistance")]
        ReadFeedbacksForLaboratoryAssistant = 0x127,

        [Display(GroupName = "EmployeeActualLocation", Name = "Access RM School to one to ones of laboratory assistance", Description = "Access RM School to one to ones of laboratory assistance")]
        ReadOneToOneForLaboratoryAssistant = 0x128,

        [Display(GroupName = "ReleaseNotes", Name = "View the `Release note` section (Editor view)", 
            Description = "https://wiki.andersenlab.com/pages/viewpage.action?pageId=346311556")]
        ReleaseNotesView = 0x200,
        
        [Display(GroupName = "ReleaseNotes", Name = "Create, edit, and delete a release note", 
            Description = " https://wiki.andersenlab.com/pages/viewpage.action?pageId=346312119")]
        ReleaseNotesCreateEditDelete = 0x201,
        
        [Display(GroupName = "ReleaseNotes", Name = "Сreate, edit, and delete a draft of a release note", 
            Description = " https://wiki.andersenlab.com/pages/viewpage.action?pageId=346312272")]
        ReleaseNotesCreateEditDeleteDraft = 0x202,
        
        [Display(GroupName = "SuperAdmin", Name = "AccessAll", Description = "This allows the user to access every feature")]
        AccessAll = Int16.MaxValue,
    }
}
