using DataBaseQueryOptimization.BL.Common;
using DataBaseQueryOptimization.BL.Common.Models.Dto;
using DataBaseQueryOptimization.BL.Common.Services;
using Moq;

namespace DataBaseQueryOptimization.UnitTests.Infrastructure.Builders;

internal class BasePermissionManagementServiceMockBuilder(
    Mock<IBasePermissionManagementService> basePermissionManagementServiceMock)
{
    
    public BasePermissionManagementServiceMockBuilder SetupAll(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsHrSubordinate(It.IsAny<IIdentityUserService>(),It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsLeadHr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsAdmin(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsAssessmentCoordinator(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsRmLineSubordinate(It.IsAny<IIdentityUserService>(),It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsAhr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsHeadOfAhr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsAdminOfActivities(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsHeadOfExperts(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsLAndD(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsItsOwn(It.IsAny<IIdentityUserService>(),It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsHr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        basePermissionManagementServiceMock.Setup(
                x=>
                    x.IsRm(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsItsOwn(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsItsOwn(It.IsAny<IIdentityUserService>(),
                    It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsHrSubordinate(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsHrSubordinate(It.IsAny<IIdentityUserService>(),
                    It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsLeadHr(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsLeadHr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsAdmin(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsAdmin(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsAssessmentCoordinator(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsAssessmentCoordinator(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsRmSubordinate(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsRmLineSubordinate(It.IsAny<IIdentityUserService>(),
                    It.IsAny<EmployeePermissionDto>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsAhr(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsAhr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsHeadOfAhr(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsHeadOfAhr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsAdminOfActivities(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsAdminOfActivities(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsHeadOfExperts(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsHeadOfExperts(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsLAndD(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsLAndD(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsHr(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsHr(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsRm(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsRm(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public BasePermissionManagementServiceMockBuilder SetupIsItDepartment(bool result)
    {
        basePermissionManagementServiceMock.Setup(
                x=>x.IsItDepartment(It.IsAny<IIdentityUserService>()))
            .Returns(result);
        return this;
    }
    
    public IBasePermissionManagementService Build()
    {
        return basePermissionManagementServiceMock.Object;
    }
}