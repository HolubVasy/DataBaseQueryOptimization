using System.Linq.Expressions;
using AutoMapper;
using DataBaseQueryOptimization.DAL.Builders;
using DataBaseQueryOptimization.DAL.Common.Extensions;
using DataBaseQueryOptimization.DAL.Common.Models.Dto;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;
using DataBaseQueryOptimization.DAL.Common.Repositories;
using DataBaseQueryOptimization.DAL.DbContexts;
using DataBaseQueryOptimization.DAL.Enums;
using DataBaseQueryOptimization.DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DataBaseQueryOptimization.DAL.Repositories
{
    public sealed class ProjectRepository : IProjectRepository
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;

        public ProjectRepository(DataBaseContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of Employee and
        /// related entities,
        /// copying only the required properties for each entity. This can help reduce the
        /// amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithTitleAndActivity()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.Title)
                .Take(x => x.ProjectGuid)
                .Take(x => x.IsActive)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of Employee
        /// and related entities,
        /// copying only the required properties for each entity. This can help reduce the
        /// amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithDeliveryManagerInfo()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Title)
                .Take(x => x.IsActive)
                .Take(x => x.DeliveryManager) // Nested property is not implemented fully,
                                              // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of Employee and
        /// related entities,
        /// copying only the required properties for each entity. This can help reduce the amount
        /// of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithResourceAndDeliveryAndProjectManagers()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.IsActive)
                .Take(x => x.DeliveryManager) // Nested property is not implemented fully,
                                              // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Take(x => x.ProjectManager) // Nested property is not implemented fully,
                                             // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Take(x => x.ResourceManager) // Nested property is not implemented fully,
                                              // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        public IEnumerable<ProjectDto> GetProjectsWithDeliveryManagerForRoleSearch()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Title)
                .Take(x => x.IsActive)
                .Take(x => x.DeliveryManager) // Nested property is not implemented fully,
                                              // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of
        /// Employee and related entities,
        /// copying only the required properties for each entity.
        /// This can help reduce the amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithProjectManagerForRoleSearch()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Title)
                .Take(x => x.IsActive)
                .Take(x => x.ProjectManager) // Nested property is not implemented fully,
                                             // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of
        /// Employee and related entities,
        /// copying only the required properties for each entity.
        /// This can help reduce the amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithAssociateDeliveryManagerForRoleSearch()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Title)
                .Take(x => x.IsActive)
                .Take(x => x
                    .AssociateDeliveryManager) 
                // Nested property is not implemented fully, only indicated property
                // inside With() method are used in the query.
                .With<Employee>(cws => cws.Id)
                .With<Employee>(cws => cws.FullNameRu)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws => cws.IsWork)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            return _mapper.Map<List<ProjectDto>>(projects);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of
        /// Employee and related entities,
        /// copying only the required properties for each entity.
        /// This can help reduce the amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithEmployees()
        {
            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Title)
                .Take(x => x.IsActive)
                .Build();

            // Gets all projects.
            var projects = ApplyProjection(_context.Project, projectsProjection);

            // Converts projects into dictionary with projects' identifier as a key.
            var projectDictionary = projects
                .ToDictionary(p => p.ProjectGuid, p => p);

            var projectEmployeesProjection = 
                new ProjectionBuilder<ProjectEmployee>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.Employee) // Nested property is not implemented fully,
                                       // only indicated property
                // inside With() method are used in the query.
                .With<Employee>(x => x.Id)
                .With<Employee>(x => x.FullNameEn)
                .With<Employee>(x => x.FullNameRu)
                .With<Employee>(x => x.IsWork)
                .Build();

            // Gets all project employees.
            var projectEmployees = ApplyProjection(
                _context.ProjectEmployee, projectEmployeesProjection);

            // Attach project employees into the projects as Allocations navigation property.
            projectDictionary.FillWithDependency(
                projectEmployees,
                pe => pe.ProjectGuid,
                p => p.Allocations);

            // Map C1Project list into ProjectDto list.
            return _mapper.Map<List<ProjectDto>>(projectDictionary.Values);
        }

        /// <inheritdoc />
        /// <remarks>The method performs a projection, creating new instances of Employee and
        /// related entities, copying only the required properties for each entity.
        /// This can help reduce the amount of data retrieved
        /// from the database and improve performance.</remarks>
        public IEnumerable<ProjectDto> GetProjectsWithEmployeesAndManagers()
        {
            // Retrieves projects with required attribute; it means that only with them attributes,
            // that are used of this project collection consumers.

            var projectsProjection = new ProjectionBuilder<Project>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.DeliveryManager) // Nested property is not implemented fully,
                                                    // only indicated property
                                                    // inside With() method are used in the query.
                .With<Employee>(x => x.Id)
                .Take(x => x.ProjectManager)  // Nested property is not implemented fully,
                                                    // only indicated property
                                                    // inside With() method are used in the query.
                .With<Employee>(x => x.Id)
                .Take(x => x.ResourceManager) // Nested property is not implemented fully,
                                                    // only indicated property
                                                    // inside With() method are used in the query.
                .With<Employee>(x => x.Id)
                .Take(x => x.AssociateDeliveryManager) // Nested property is not implemented
                                                             // fully, only indicated property
                                                             // inside With() method are used in
                                                             // the query.
                .With<Employee>(x => x.Id)
                .Build();

            var projects = ApplyProjection(_context.Project, projectsProjection);

            // Converts projects enumeration into dictionary with projects' identifiers as
            // keys for further attaching to its allocation collection simplification.
            var projectsDictionary = projects.ToDictionary(p => p.ProjectGuid, p => p);

            var projectEmployeesProjection = 
                new ProjectionBuilder<ProjectEmployee>()
                .Take(x => x.ProjectGuid)
                .Take(x => x.EmployeeId)
                .Take(x => x.Employee)
                .With<Employee>(cws => cws.FullNameEn)
                .With<Employee>(cws=> cws.FullNameRu)
                .Build();

            var projectEmployees = ApplyProjection(_context.ProjectEmployee, 
                projectEmployeesProjection);

            // Attaches to the project dictionary, based on projects' identifiers,
            // allocation properties' values.
            projectsDictionary.FillWithDependency(
                projectEmployees,
                pe => pe.ProjectGuid,
                cp => cp.Allocations);

            return GetProjectsDtoFromDictionary(projectsDictionary);

        }

        public async Task<Guid?> GetProjectIdByNameAsync(string projectName,
            CancellationToken cancellationToken=default)
        {
            var project = await _context.Project
                .AsNoTracking()
                .FirstOrDefaultAsync(p =>
                    p.Title.Equals(projectName,
                            StringComparison.OrdinalIgnoreCase),
                    cancellationToken:cancellationToken);

            return project?.ProjectGuid;
        }

        private IEnumerable<ProjectDto> GetProjectsDtoFromDictionary(
            Dictionary<Guid,Project> projectsDictionary)
        {
            var projectDtos = new List<ProjectDto>(projectsDictionary.Count);

            foreach (var entity in projectsDictionary)
            {
                var projectEntity = entity.Value;
                var id = projectEntity.ProjectGuid;
                var startDate = projectEntity.StartDate;
                var supervisorDeliveryManagerId = projectEntity.SupervisorDeliveryManagerId;
                var name = projectEntity.Title;
                var teamQty = projectEntity.NumberOfEmployess;
                var isActive = projectEntity.IsActive;
                var stopDate = projectEntity.FinalDate;
                var projectManager = projectEntity.
                    GetManagerAsInnerEmployee(ProjectManager.ProjectManager);
                var resourceManager = projectEntity
                    .GetManagerAsInnerEmployee(ProjectManager.ResourceManager);
                var deliveryManager = projectEntity.GetManagerAsInnerEmployee(
                    ProjectManager.DeliveryManager);
                var associateDeliveryManager = projectEntity.
                    GetManagerAsInnerEmployee(ProjectManager.AssociateDeliveryManager);
                var employees = projectEntity.Allocations != null ?
                    projectEntity.Allocations
                        .Where(a => !a.FinalDate.HasValue || 
                            DateTime.Today <= a.FinalDate)
                        .OrderBy(a => a.Employee.GetName()) : null;
                var employeesPreviewDto =
                    employees?.MapToEmployeePreviewDtOs();

                projectDtos.Add(new ProjectDto
                {
                    Id = id,
                    StartDate = startDate,
                    SupervisorDeliveryManagerId = supervisorDeliveryManagerId,
                    Name = name,
                    TeamQty = teamQty,
                    IsActive = isActive,
                    StopDate = stopDate,
                    ProjectManager = projectManager,
                    ResourceManager = resourceManager,
                    DeliveryManager = deliveryManager,
                    AssociateDeliveryManager = associateDeliveryManager,
                    Employees = employeesPreviewDto
                });
            }
            return projectDtos;
        }

        /// <summary>
        /// Create to apply projection to the <see cref="DbSet{T}"/> type.
        /// </summary>
        /// <param name="dbSet"><see cref="DbSet{T}"/> instance.</param>
        /// <param name="projection">Projection for improvement of the quire performance due to
        /// decreasing network bandwidth.</param>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <returns>Collection of the <see cref="T"/> typed element.</returns>
        /// <remarks>Created not to forget to apply ToList() method.</remarks>
        private List<T> ApplyProjection<T>(IQueryable<T> dbSet, Expression<Func<T, T>> projection)
        where T : class
        {
            return dbSet.Select(projection).ToList();
        }
    }
}
