using DataBaseQueryOptimization.BL.Common.Models.Dto;

namespace DataBaseQueryOptimization.BL.Common.Services
{
/// <summary>
/// Interface for the Permission Service.
/// </summary>
public interface IBasePermissionManagementService
{
    /// <summary>
    /// Checks if the user has the HR system role and this user requests accesses
    /// for a subordinate, which data contained in the permissionDto.
    /// </summary>
    bool IsHrSubordinate(IIdentityUserService userIdentity, 
        EmployeePermissionDto employeePermission);

    /// <summary>
    /// Checks if the user has the Lead HR system role.
    /// </summary>
    bool IsLeadHr(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has the Admin system role.
    /// </summary>
    bool IsAdmin(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has the Assessment Coordinator system role.
    /// </summary>
    bool IsAssessmentCoordinator(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has ARM, RM, SRM or RD roles and this user requests
    /// accesses for a subordinate, which data contained in the permissionDto.
    /// </summary>
    bool IsRmSubordinate(IIdentityUserService userIdentity, EmployeePermissionDto 
        employeePermissionDto);

    /// <summary>
    /// Checks if the user has the AHR system role.
    /// </summary>
    bool IsAhr(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has the Head of AHR system role.
    /// </summary>
    bool IsHeadOfAhr(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has the Admin of Activities system role.
    /// </summary>
    bool IsAdminOfActivities(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has the Head of Experts system role.
    /// </summary>
    bool IsHeadOfExperts(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has L&D system role.
    /// </summary>
    bool IsLAndD(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user requests access for its own data.
    /// </summary>
    bool IsItsOwn(IIdentityUserService userIdentity, 
        EmployeePermissionDto employeePermissionDto);

    /// <summary>
    /// Checks if the user has HR system role.
    /// </summary>
    bool IsHr(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has RM system role.
    /// </summary>
    bool IsRm(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has IT the Department role.
    /// </summary>
    bool IsItDepartment(IIdentityUserService userIdentity);

    /// <summary>
    /// Checks if the user has RM roles and is requesting access for a subordinate
    /// in the RM line.
    /// </summary>
    /// <param name="userIdentity">The identity of the user.</param>
    /// <param name="employeePermission">The permission details of the subordinate.</param>
    /// <returns>True if the user is an RM with RM line access to a subordinate;
    /// otherwise, false.</returns>
    bool IsRmLineSubordinate(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission);
}
}
