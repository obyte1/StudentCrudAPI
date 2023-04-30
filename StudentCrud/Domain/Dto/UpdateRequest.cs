using StudentCrud.Enums;

namespace StudentCrud.Dto
{
    public class UpdateRequest
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StateOfOrigin { get; set; }
        public string Address { get; set; }
        public string Level { get; set; }
        public Gender Gender { get; set; }
        public string PlaceofBirth { get; set; }
    }
}
