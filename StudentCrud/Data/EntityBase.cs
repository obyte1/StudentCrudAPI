namespace StudentCrud.Data
{
    public class EntityBase
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public string DeletedBy { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}

