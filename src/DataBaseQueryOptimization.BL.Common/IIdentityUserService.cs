using System.Security.Claims;
using DataBaseQueryOptimization.BL.Common.Enums;

namespace DataBaseQueryOptimization.BL.Common
{
    public interface IIdentityUserService
    {
        ClaimsPrincipal User { get; }
        Guid UserId { get; }
        Permissions[] UserPermissions { get; }
        bool BasicAuthType { get; }
        string[] Roles{get;}
        
        bool UserHasThisPermission(Permissions permissionToCheck);
        bool UserHasRole(string role);
        bool UserHasRole(DefaultRoles role);
    }
}
