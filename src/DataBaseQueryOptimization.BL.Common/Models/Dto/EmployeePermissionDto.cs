namespace DataBaseQueryOptimization.BL.Common.Models.Dto
{

/// <summary>
/// Minimal set of data, required for calculating accesses.
/// </summary>
/// <remarks>Created in regard with the <see href="https://jira.andersenlab.com/browse/PRTM-7750">.
/// </see></remarks>
public sealed record EmployeePermissionDto
{
    /// <summary>
    /// Employee identifier.
    /// </summary>
    public Guid EmployeeId { get; init; }

    /// <summary>
    /// Human resource manager identifier.
    /// </summary>
    public Guid? HumanResourceId { get; init; }

    /// <summary>
    /// Resource manager identifier.
    /// </summary>
    public Guid? ResourceManagerId { get; init; }

    /// <summary>
    /// Resource manager lines identifiers.
    /// </summary>
    public HashSet<Guid>? RmLineIds { get; init; }
}
}
