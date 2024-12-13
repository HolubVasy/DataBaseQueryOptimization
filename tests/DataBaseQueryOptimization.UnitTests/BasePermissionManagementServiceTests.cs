using DataBaseQueryOptimization.BL.Common;
using DataBaseQueryOptimization.BL.Common.Enums;
using DataBaseQueryOptimization.BL.Common.Models.Dto;
using DataBaseQueryOptimization.BL.Common.Services;
using DataBaseQueryOptimization.BL.Services;
using FluentAssertions;
using Moq;

namespace DataBaseQueryOptimization.UnitTests
{

[TestFixture]
public class BasePermissionManagementServiceTests
{
    private Mock<IIdentityUserService> _identityUserServiceMock;
    private IBasePermissionManagementService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new BasePermissionManagementService();
        _identityUserServiceMock = new Mock<IIdentityUserService>();
    }

    [TestCase(DefaultRoles.HR,true)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsHrSubordinate_WhenUserIsHrAndEmployeeHisSubordinate_ReturnsTrue(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());
        var employeePermission = CreateEmployeePermissionWithHrId(_identityUserServiceMock.Object.UserId);

        // Act
        var result = _sut.IsHrSubordinate(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsHrSubordinate_WhenUserIdentityIsNull_Throws()
    {
        // Arrange
        EmployeePermissionDto employeePermission = CreateEmployeePermission();

        // Act
        void Action() => _sut.IsHrSubordinate(null, employeePermission);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsHrSubordinate_WhenUserIsHrAndEmployeeIsNotHisSubordinate_ReturnsFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(DefaultRoles.HR.ToString());
        var employeePermission = CreateEmployeePermissionWithRmId(_identityUserServiceMock.Object.UserId);

        // Act
        var result = _sut.IsHrSubordinate(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    [TestCase(DefaultRoles.HR,true)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsHr_WhenUserIsHr_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsHr(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsHr_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsHr(null);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,true)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsLeadHr_WhenUserIsLeadHr_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsLeadHr(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsLeadHr_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsLeadHr(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,true)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsAdmin_WhenUserIsAdmin_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsAdmin(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsAdmin_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsAdmin(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,true)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsAssessmentCoordinator_WhenUserIsAssessmentCoordinator_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsAssessmentCoordinator(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsAssessmentCoordinator_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsAssessmentCoordinator(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,true)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsRmSubordinate_WhenUserIsRmAndEmployeeSubordinate_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());
        var employeePermission = CreateEmployeePermissionWithRmId(_identityUserServiceMock.Object.UserId);

        // Act
        var result = _sut.IsRmLineSubordinate(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsRmSubordinate_WhenUserIdentityIsNull_Throws()
    {
        // Arrange
        var employeePermission = CreateEmployeePermission();

        // Act
        void Action() => _sut.IsRmLineSubordinate(null!, employeePermission);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsRmSubordinate_WhenUserIsRmButEmployeeNotSubordinate_ReturnsFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());
        var employeePermission = CreateEmployeePermissionWithHrId(_identityUserServiceMock.Object.UserId);

        // Act
        var result = _sut.IsRmLineSubordinate(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,true)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsRm_WhenUserIsRm_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsRm(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsRm_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsRm(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,true)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsAhr_WhenUserIsAhr_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsAhr(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsAhr_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsAhr(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,true)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsHeadOfAhr_WhenUserIsHeadOfAhr_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsHeadOfAhr(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsHeadOfAhr_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsHeadOfAhr(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,true)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsAdminOfActivities_WhenUserIsAdminOfActivities_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsAdminOfActivities(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsAdminOfActivities_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsAdminOfActivities(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,true)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsHeadOfExperts_WhenUserIsHeadOfExperts_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsHeadOfExperts(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsHeadOfExperts_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsHeadOfExperts(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,true)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsLAndD_WhenUserIsLAndD_ReturnsTrueOtherwiseFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());

        // Act
        var result = _sut.IsLAndD(_identityUserServiceMock.Object);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsLAndD_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.IsLAndD(null!);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,true)]
    [TestCase(DefaultRoles.OfficeHR,true)]
    [TestCase(DefaultRoles.RegionHR,true)]
    [TestCase(DefaultRoles.LeadHR,true)]
    [TestCase(DefaultRoles.RM,true)]
    [TestCase(DefaultRoles.Supervisor,true)]
    [TestCase(DefaultRoles.Admin,true)]
    [TestCase(DefaultRoles.AssessmentCoordinator,true)]
    [TestCase(DefaultRoles.ContentManager,true)]
    [TestCase(DefaultRoles.Manager,true)]
    [TestCase(DefaultRoles.AHR,true)]
    [TestCase(DefaultRoles.HeadOfAHR,true)]
    [TestCase(DefaultRoles.HeadOfSales,true)]
    [TestCase(DefaultRoles.AdminOfActivities,true)]
    [TestCase(DefaultRoles.HeadOfExperts,true)]
    [TestCase(DefaultRoles.RMExpert,true)]
    [TestCase(DefaultRoles.BenchManager,true)]
    [TestCase(DefaultRoles.Auditor,true)]
    [TestCase(DefaultRoles.LearningAndDevelopment,true)]
    [TestCase(DefaultRoles.RmSchool,true)]
    [TestCase(DefaultRoles.ITDepartment,true)]
    public void IsItsOwn_WhenUserIsItsOwnForAnyRole_ReturnsTrue(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());
        var employeePermission = CreateEmployeePermissionWithEmployeeId(_identityUserServiceMock.Object.UserId);

        // Act
        var result = _sut.IsItsOwn(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Test]
    public void IsItsOwn_WhenUserIdentityIsNull_Throws()
    {
        // Arrange
        var employeePermission = CreateEmployeePermission();

        // Act
        void Action() => _sut.IsItsOwn(null!, employeePermission);

        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }

    [TestCase(DefaultRoles.HR,false)]
    [TestCase(DefaultRoles.OfficeHR,false)]
    [TestCase(DefaultRoles.RegionHR,false)]
    [TestCase(DefaultRoles.LeadHR,false)]
    [TestCase(DefaultRoles.RM,false)]
    [TestCase(DefaultRoles.Supervisor,false)]
    [TestCase(DefaultRoles.Admin,false)]
    [TestCase(DefaultRoles.AssessmentCoordinator,false)]
    [TestCase(DefaultRoles.ContentManager,false)]
    [TestCase(DefaultRoles.Manager,false)]
    [TestCase(DefaultRoles.AHR,false)]
    [TestCase(DefaultRoles.HeadOfAHR,false)]
    [TestCase(DefaultRoles.HeadOfSales,false)]
    [TestCase(DefaultRoles.AdminOfActivities,false)]
    [TestCase(DefaultRoles.HeadOfExperts,false)]
    [TestCase(DefaultRoles.RMExpert,false)]
    [TestCase(DefaultRoles.BenchManager,false)]
    [TestCase(DefaultRoles.Auditor,false)]
    [TestCase(DefaultRoles.LearningAndDevelopment,false)]
    [TestCase(DefaultRoles.RmSchool,false)]
    [TestCase(DefaultRoles.ITDepartment,false)]
    public void IsItsOwn_WhenUserIsNotItsOwnForAnyRole_ReturnsFalse(DefaultRoles role,
        bool expectedResult)
    {
        // Arrange
        SetupSpecificUserRoleAndAnyUserId(role.ToString());
        var employeePermission = CreateEmployeePermission();

        // Act
        var result = _sut.IsItsOwn(_identityUserServiceMock.Object, employeePermission);

        // Assert
        result.Should().Be(expectedResult);
    }

    #region Infrastructure

    private void SetupSpecificUserRoleAndAnyUserId(string role)
    {
        _identityUserServiceMock.Setup(service => service
                .UserHasRole(It.Is<string>(r => r == role)))
            .Returns(true);

        _identityUserServiceMock.Setup(service => service
                .UserHasRole(It.Is<string>(r => r != role)))
            .Returns(false);

        // Setup UserId property return any Guid.
        _identityUserServiceMock.Setup(service => service.UserId)
            .Returns(Guid.NewGuid());
    }

    private EmployeePermissionDto CreateEmployeePermission()
    {
        var employeePermissionDto = new EmployeePermissionDto
        {
            EmployeeId = Guid.NewGuid(),
            HumanResourceId = Guid.NewGuid(),
            ResourceManagerId = Guid.NewGuid()
        };
        return employeePermissionDto;
    }

    private EmployeePermissionDto CreateEmployeePermissionWithHrId(Guid? humanResourceId)
    {
        var employeePermissionDto = new EmployeePermissionDto
        {
            EmployeeId = Guid.NewGuid(),
            HumanResourceId = humanResourceId,
            ResourceManagerId = Guid.NewGuid()
        };
        return employeePermissionDto;
    }

    private EmployeePermissionDto CreateEmployeePermissionWithRmId(Guid? resourceManagerId)
    {
        var employeePermissionDto = new EmployeePermissionDto
        {
            EmployeeId = Guid.NewGuid(),
            HumanResourceId = Guid.NewGuid(),
            ResourceManagerId = resourceManagerId,
            RmLineIds = new HashSet<Guid> {resourceManagerId!.Value}
        };
        return employeePermissionDto;
    }

    private EmployeePermissionDto CreateEmployeePermissionWithEmployeeId(Guid employeeId)
    {
        var employeePermissionDto = new EmployeePermissionDto
        {
            EmployeeId = employeeId,
            HumanResourceId = Guid.NewGuid(),
            ResourceManagerId = Guid.NewGuid()
        };
        return employeePermissionDto;
    }

    #endregion
}
}
