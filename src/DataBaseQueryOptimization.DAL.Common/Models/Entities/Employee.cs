namespace DataBaseQueryOptimization.DAL.Common.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullNameRu { get; set; }
        public string FullNameEn { get; set; }
        public string Email { get; set; }
        public string EmailCorp { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public int VacationDays { get; set; }
        public int DayOff { get; set; }
        public bool IsWork { get; set; }
        public Guid? SourceManagerGUID { get; set; }
        public string Office { get; set; }
        public Guid? HumanResourceGUID { get; set; }
        
        #region Navigation Properties
        
        public virtual IList<ProjectEmployee> Allocations { get; set; }
        public virtual Employee ResourceManager { get; set; }
        public virtual Employee HumanResource { get; set; }
        #endregion
    }
}
