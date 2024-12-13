using DataBaseQueryOptimization.BL.Common.Models.Dto;

namespace DataBaseQueryOptimization.BL.Common.Services
{
/// <summary>
/// Provides methods to check access permissions for various functionalities related to
/// an employee's personal information.
/// </summary>
public interface IBaseAccessManagementService
{
    /// <summary>
    /// Checks if the user has access to the position data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoPosition(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the hiring date data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoHiringDate(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the technical level data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoLevel(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the office data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoOffice(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the location data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoLocation(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the current projects data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoProjects(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the project history data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoProjectHistory(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the Certificate tab.
    /// </summary>
    bool HasAccessToCertificateTab(IIdentityUserService userIdentity, EmployeePermissionDto 
        employeePermission);

    /// <summary>
    /// Checks if the user has access to the Employee List.
    /// </summary>
    bool HasAccessToEmployeeList(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has access to the hidden phone number data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoPhoneNumberHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the hidden date of birth data in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoDateOfBirthHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has access to the hidden date of birth data of other employees
    /// in the Personal Info tab.
    /// </summary>
    bool HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);
}
}
