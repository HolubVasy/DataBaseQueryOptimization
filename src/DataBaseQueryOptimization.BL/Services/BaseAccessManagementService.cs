using DataBaseQueryOptimization.BL.Common;
using DataBaseQueryOptimization.BL.Common.Models.Dto;
using DataBaseQueryOptimization.BL.Common.Services;

namespace DataBaseQueryOptimization.BL.Services
{

/// <inheritdoc/>
public sealed class BaseAccessManagementService : IBaseAccessManagementService
{
    private readonly IBasePermissionManagementService _basePermissionManagementService;

    public BaseAccessManagementService(IBasePermissionManagementService 
        basePermissionManagementService)
    {
        _basePermissionManagementService=basePermissionManagementService;

    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoPosition(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoPosition)} method "+
                $"of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),
                $"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoPosition)} "+
                $"method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoHiringDate(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {

        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),
                $"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoHiringDate)} "+
                $"method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),
                $"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoHiringDate)} "+
                $"method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoLevel(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoLevel)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoLevel)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoOffice(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoOffice)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoOffice)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoLocation(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoLocation)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoLocation)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }
        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoPhoneNumberHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoPhoneNumberHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoPhoneNumberHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return _basePermissionManagementService.IsItsOwn(userIdentity,employeePermission)
            || IsStandardShortPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoDateOfBirthHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoDateOfBirthHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoDateOfBirthHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return _basePermissionManagementService.IsItsOwn(userIdentity,employeePermission)
            || IsStandardShortPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardShortPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoProjects(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoProjects)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoProjects)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToPersonalInfoProjectHistory(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToPersonalInfoProjectHistory)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToPersonalInfoProjectHistory)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission);
    }

    /// <inheritdoc/>
    public bool HasAccessToCertificateTab(IIdentityUserService userIdentity, EmployeePermissionDto employeePermission)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToCertificateTab)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        if (employeePermission is null)
        {
            throw new ArgumentNullException(nameof(employeePermission),$"{nameof(EmployeePermissionDto)} " +
                $"passed in {nameof(HasAccessToCertificateTab)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return IsStandardPermissionsSet(userIdentity,employeePermission)
            && !IsItDepartment(userIdentity); // IT Department role can't see certificates' tab.
                                              // For simplicity of provision access to
                                              // most common personal info data, it was
                                              // included into standard short permission set,
                                              // but because of that should be explicitly
                                              // excluded from roles, which can
                                              // see certificates' tab.
    }

    /// <inheritdoc/>
    public bool HasAccessToEmployeeList(IIdentityUserService userIdentity)
    {
        if (userIdentity is null)
        {
            throw new ArgumentNullException(nameof(userIdentity),$"{nameof(IIdentityUserService)} " +
                $"passed in {nameof(HasAccessToEmployeeList)} method of {nameof(BaseAccessManagementService)}" +
                " is null");
        }

        return _basePermissionManagementService.IsHr(userIdentity)
            || _basePermissionManagementService.IsRm(userIdentity)
            || _basePermissionManagementService.IsHeadOfExperts(userIdentity)
            || _basePermissionManagementService.IsLAndD(userIdentity)
            || IsSuperRoles(userIdentity);
    }

    private bool IsStandardPermissionsSet(IIdentityUserService userIdentity,EmployeePermissionDto employeePermission)
    {
        return _basePermissionManagementService.IsItsOwn(userIdentity,employeePermission)
            || IsHighRoles(userIdentity)
            || IsStandardShortPermissionsSet(userIdentity,employeePermission);

    }

    private bool IsStandardShortPermissionsSet(IIdentityUserService userIdentity,
        EmployeePermissionDto employeePermission)
    {
        return _basePermissionManagementService.IsHrSubordinate(userIdentity,employeePermission)
            || _basePermissionManagementService.IsRmLineSubordinate(userIdentity, employeePermission)
            || IsSuperRoles(userIdentity)
            || IsItDepartment(userIdentity); // Excluded from seeing certificate tab manually.
    }

    /// <summary>
    /// Roles set that have access to all data.
    /// </summary>
    /// <param name="userIdentity"></param>
    /// <returns></returns>
    private bool IsSuperRoles(IIdentityUserService userIdentity)
    {

        return _basePermissionManagementService.IsLeadHr(userIdentity)
            || _basePermissionManagementService.IsAdmin(userIdentity)
            || _basePermissionManagementService.IsAssessmentCoordinator(userIdentity);
    }

    /// <summary>
    /// Roles set that have access to all data except phone number and birthday date.
    /// </summary>
    /// <param name="userIdentity"></param>
    /// <returns></returns>
    private bool IsHighRoles(IIdentityUserService userIdentity)
    {

        return _basePermissionManagementService.IsAhr(userIdentity)
            || _basePermissionManagementService.IsHeadOfAhr(userIdentity)
            || _basePermissionManagementService.IsAdminOfActivities(userIdentity)
            || _basePermissionManagementService.IsHeadOfExperts(userIdentity)
            || _basePermissionManagementService.IsLAndD(userIdentity);
    }

    /// <summary>
    /// Shows if user has IT Department role.
    /// </summary>
    /// <param name="userIdentity"></param>
    /// <returns></returns>
    private bool IsItDepartment(IIdentityUserService userIdentity)
    {
        return _basePermissionManagementService.IsItDepartment(userIdentity);
    }
}
}
