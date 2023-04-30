using StudentCrud.Data;
using StudentCrud.Dto;
using StudentCrud.Model;

namespace StudentCrud.Domain.Implementation
{
    public interface IStudentManager
    {
        Task<Response<dynamic>> Register(studentrequest request);
        Task<Response<dynamic>> UpdateStudent(studentrequest request);
        Task<Response<dynamic>> DeleteStudent(Guid StudentId);
        Task<Response<List<Students>>> getAllStudents();
    }
}
