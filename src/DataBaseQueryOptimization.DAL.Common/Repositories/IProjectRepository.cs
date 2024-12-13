using DataBaseQueryOptimization.DAL.Common.Models.Dto;

namespace DataBaseQueryOptimization.DAL.Common.Repositories
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Gets projects with identifier, title and active status.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithTitleAndActivity();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        /// - title,
        /// - delivery manager info (identifier, name, is he/she working).
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithDeliveryManagerInfo();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        /// - activity status,
        /// - resource manager info (identifier, name, activity status),
        /// - project manager info (identifier, name, activity status),
        /// - delivery manager info (identifier, name, activity status),
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithResourceAndDeliveryAndProjectManagers();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        ///  - employees' identifier',
        /// - resource manager identifier,
        /// - project manager identifier,
        /// - delivery manager identifier,
        /// - delivery manager identifier.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithDeliveryManagerForRoleSearch();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        ///  - employees' identifier',
        /// - resource manager identifier,
        /// - project manager identifier,
        /// - delivery manager identifier,
        /// - delivery manager identifier.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithProjectManagerForRoleSearch();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        ///  - employees' identifier',
        /// - resource manager identifier,
        /// - project manager identifier,
        /// - delivery manager identifier,
        /// - delivery manager identifier.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithAssociateDeliveryManagerForRoleSearch();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        ///  - employees' identifier',
        /// - resource manager identifier,
        /// - project manager identifier,
        /// - delivery manager identifier,
        /// - delivery manager identifier.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithEmployees();

        /// <summary>
        /// Gets projects with its:
        /// - identifier,
        ///  - employees' identifier',
        /// - resource manager identifier,
        /// - project manager identifier,
        /// - delivery manager identifier,
        /// - delivery manager identifier.
        /// </summary>
        /// <returns><see cref="ProjectDto"/> collection with required navigation properties.
        /// </returns>
        IEnumerable<ProjectDto> GetProjectsWithEmployeesAndManagers();

        Task<Guid?> GetProjectIdByNameAsync(string projectName,
            CancellationToken cancellationToken=default);
    }
}
