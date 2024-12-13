using DataBaseQueryOptimization.BL.Common;
using DataBaseQueryOptimization.BL.Common.Enums;
using DataBaseQueryOptimization.BL.Common.Models.Dto;
using DataBaseQueryOptimization.BL.Common.Services;

namespace DataBaseQueryOptimization.BL.Services
{

/// <inheritdoc/>
public sealed class BasePermissionManagementService : IBasePermissionManagementService
{
    /// <inheritdoc/>
    public bool IsHrSubordinate(IIdentityUserService? userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsHrSubordinate)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.HR.ToString())
            && employeePermission.HumanResourceId.HasValue
            && userIdentity.UserId == employeePermission.HumanResourceId;

    }

    /// <inheritdoc/>
    public bool IsHr(IIdentityUserService? userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsHrSubordinate)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.HR.ToString());

    }

    /// <inheritdoc/>
    public bool IsLeadHr(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsLeadHr)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.LeadHR.ToString());
    }

    /// <inheritdoc/>
    public bool IsAdmin(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsAdmin)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.Admin.ToString());
    }

    /// <inheritdoc/>
    public bool IsAssessmentCoordinator(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsAssessmentCoordinator)} "+
                $"method of {nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.AssessmentCoordinator.ToString());
    }

    /// <inheritdoc/>
    public bool IsRmSubordinate(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsRmSubordinate)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.RM.ToString())
            && employeePermission.ResourceManagerId.HasValue
            && userIdentity.UserId == employeePermission.ResourceManagerId;
    }

    /// <inheritdoc/>
    public bool IsRm(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsRmSubordinate)} method "+
                $"of {nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.RM.ToString());
    }

    /// <inheritdoc/>
    public bool IsAhr(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(
                nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsAhr)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.AHR.ToString());
    }

    /// <inheritdoc/>
    public bool IsHeadOfAhr(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsHeadOfAhr)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.HeadOfAHR.ToString());
    }

    /// <inheritdoc/>
    public bool IsAdminOfActivities(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsAdminOfActivities)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.AdminOfActivities.ToString());
    }

    /// <inheritdoc/>
    public bool IsHeadOfExperts(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsHeadOfExperts)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.HeadOfExperts.ToString());
    }

    /// <inheritdoc/>
    public bool IsLAndD(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsLAndD)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.LearningAndDevelopment.ToString());
    }

    /// <inheritdoc/>
    public bool IsItsOwn(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermissionDto)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsItsOwn)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserId == employeePermissionDto.EmployeeId;
    }

    /// <inheritdoc/>
    public bool IsItDepartment(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsItDepartment)} method of "+
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.ITDepartment.ToString());
    }

    /// <inheritdoc/>
    public bool IsRmLineSubordinate(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(IsRmLineSubordinate)} method of " +
                $"{nameof(BasePermissionManagementService)}" +
                " is null");
        }

        return userIdentity.UserHasRole(DefaultRoles.RM.ToString())
            && (employeePermission.RmLineIds is not null
                && employeePermission.RmLineIds.Contains(userIdentity.UserId));
    }
}
}
