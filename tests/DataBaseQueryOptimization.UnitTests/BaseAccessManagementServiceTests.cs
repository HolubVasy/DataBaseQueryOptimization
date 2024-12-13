using DataBaseQueryOptimization.BL.Common;
using DataBaseQueryOptimization.BL.Common.Models.Dto;
using DataBaseQueryOptimization.BL.Common.Services;
using DataBaseQueryOptimization.BL.Services;
using DataBaseQueryOptimization.UnitTests.Infrastructure.Builders;
using FluentAssertions;
using Moq;

namespace DataBaseQueryOptimization.UnitTests;

[TestFixture]
public partial class BaseAccessManagementServiceTests
{
    private IBaseAccessManagementService _sut;
    private Mock<IIdentityUserService> _identityUserServiceMock;
    private Mock<IBasePermissionManagementService> _basePermissionManagementServiceMock;
    
    
    [SetUp]
    public void Setup()
    {
        _basePermissionManagementServiceMock = new Mock<IBasePermissionManagementService>();
        _identityUserServiceMock = new Mock<IIdentityUserService>();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoPosition(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoHiringDate(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoLevel(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());

        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoOffice(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoLocation(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsHeadOfAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsAdminOfActivities_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsHeadOfExperts_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsLAndD_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsHeadOfAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsAdminOfActivities_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsHeadOfExperts_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsLAndD_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoDateOfBirthHidden(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoProjects(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoProjectHistory(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectHistory_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenForItsOwn_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsHeadOfAhr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsAdminOfActivities_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenIsRmWithoutDirectFirstSubordinate_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object,
            new EmployeePermissionDto());
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToCertificateTab(null, new EmployeePermissionDto());
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToCertificateTab_WhenPermissionIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object, null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenForItsOwn_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItsOwn(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenHrForItsSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHrSubordinate(true);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsLeadHr_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLeadHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsAdmin_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdmin(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsAssessmentCoordinator_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAssessmentCoordinator(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsRmSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRmSubordinate(true);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsHeadOfAhr_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfAhr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsAdminOfActivities_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsAdminOfActivities(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsHeadOfExperts_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHeadOfExperts(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsLAndD_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsLAndD(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenNoRoles_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsHrButWithoutDirectFirstSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsHr(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenIsRmWithoutDirectFirstSubordinate_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsRm(true);
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder
            .Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToEmployeeList(_identityUserServiceMock.Object);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public void HasAccessToEmployeeList_WhenUserIdentityIsNull_Throws()
    {
        // Act
        void Action() => _sut.HasAccessToEmployeeList(null);
        
        // Assert
        Assert.Throws<ArgumentNullException>(Action);
    }
    
    #region IT Department
    
    [Test]
    public void HasAccessToPersonalInfoPosition_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPosition(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoHiringDate_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoHiringDate(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoLevel_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLevel(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoOffice_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoOffice(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoLocation_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoLocation(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoPhoneNumberHidden_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoPhoneNumberHidden(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthHidden_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthHidden(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoDateOfBirthWithoutMySelfHidden(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjects_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjects(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToPersonalInfoProjectsHistory_WhenIsItDepartment_ReturnsTrue()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Adapted for IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToPersonalInfoProjectHistory(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeTrue(); // Assert that ITDepartment has access
    }
    
    [Test]
    public void HasAccessToCertificates_WhenIsItDepartment_ReturnsFalse()
    {
        var basePermissionManagementServiceMockBuilder = new BasePermissionManagementServiceMockBuilder(
            _basePermissionManagementServiceMock);
        basePermissionManagementServiceMockBuilder.SetupAll(false);
        basePermissionManagementServiceMockBuilder.SetupIsItDepartment(true);  // Specific to IT Department
        var basePermissionManagementServiceMock = basePermissionManagementServiceMockBuilder.Build();
        
        _sut = new BaseAccessManagementService(basePermissionManagementServiceMock);
        
        var result = _sut.HasAccessToCertificateTab(_identityUserServiceMock.Object, new EmployeePermissionDto());
        
        result.Should().BeFalse(); // Assert that ITDepartment does not have access
    }
    
    #endregion
    
    #region Infrastructure
    
    #endregion
    
}