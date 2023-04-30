using StudentCrud.Data;
using StudentCrud.Dto;
using StudentCrud.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentCrud.Model
{
    public class Students : EntityBase
    {
        [Key]
        public Guid StudentId { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StateOfOrigin { get; set; }
        public string Address { get; set; }
        public string Level { get; set; }
        public Gender Gender { get; set; }
        public string PlaceofBirth { get; set; }

        
        public static Students createNew(studentrequest request)
        {
            return new Students
            {
                
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                DateOfBirth = request.DateOfBirth,
                StateOfOrigin = request.StateOfOrigin,
                Address = request.Address,
                Level = request.Level,
                Gender = request.Gender,
                PlaceofBirth = request.PlaceofBirth
            };
        }

        internal void UpdateStudent(studentrequest request)
        {
            
            FirstName = request.FirstName;
            MiddleName = request.MiddleName;
            LastName = request.LastName;
            PhoneNumber = request.PhoneNumber;
            DateOfBirth = request.DateOfBirth;
            StateOfOrigin = request.StateOfOrigin;
            Address = request.Address;
            Level = request.Level;
            Gender = request.Gender;
            PlaceofBirth = request.PlaceofBirth;
        }
    }

    
}
