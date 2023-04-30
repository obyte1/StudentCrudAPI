using StudentCrud.Data;
using StudentCrud.Model;

namespace StudentCrud.Domain.Repository
{
    public interface IStudentRepository
    {
        Task<Students> GetStudentsbyIDAsync(Guid Id);
        Task<Students> GetStudentsbyEmailAsync(string Email);
        Task<List<Students>> getallStudents();
    }
}
