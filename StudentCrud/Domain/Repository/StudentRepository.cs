using StudentCrud.Data;
using StudentCrud.Model;

namespace StudentCrud.Domain.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IRepository<Students> _repository;
        public StudentRepository(IRepository<Students> repository)
        {
            _repository = repository;
        }

        public async Task<Students> GetStudentsbyIDAsync(Guid Id)
        {
            return await _repository.GetFirstAsync(x => x.StudentId == Id);
        }

        public async Task<Students> GetStudentsbyEmailAsync(string Email)
        {
            return await _repository.GetFirstAsync(x=>x.Email == Email);
        }

        public async Task<List<Students>> getallStudents()
        {
            return (List<Students>)await _repository.GetAllAsync();
        }

    }
}
