namespace DataBaseQueryOptimization.DAL.Common.Models.Common
{
    public class InnerEmployee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameCyr { get; set; }
        public bool? IsWork { get; set; }
        
        public InnerEmployee(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public InnerEmployee(Guid id, string name, bool isWork) : this(id, name)
        {
            IsWork = isWork;
        }

        public InnerEmployee(Guid id,
            string name,
            string nameCyr,
            bool isWork):this(id,
            name,
            isWork)
        {
            NameCyr = nameCyr;
        }

        public InnerEmployee(Guid id, string name, string nameCyr) : this(id, name)
        {
            NameCyr = nameCyr;
        }
    }
}
