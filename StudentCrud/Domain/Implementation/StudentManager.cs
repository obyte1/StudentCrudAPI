using StudentCrud.Data;
using StudentCrud.Domain.Repository;
using StudentCrud.Dto;
using StudentCrud.Model;

namespace StudentCrud.Domain.Implementation
{
    
    
    public class StudentManager : IStudentManager
    {
        private readonly IRepository<Students> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IRepository<Students> _repository, IUnitOfWork _unitOfWork, IStudentRepository _studentRepository)
        {
            this._repository = _repository;
            this._unitOfWork = _unitOfWork;
            this._studentRepository = _studentRepository;
        }

        public async Task<Response<dynamic>> Register(studentrequest request)
        {
            var student = await _studentRepository.GetStudentsbyEmailAsync(request.Email);
            if(student != null)
            {
                return Response<dynamic>.Fail("Student Already Exist");
                
            }
            student = Students.createNew(request);
            await _repository.InsertAsync(student);
            await _unitOfWork.SavechangesAsync();
            return Response<dynamic>.Success("Student Registered Successfully", student, 200);
        }

        public async Task<Response<dynamic>> UpdateStudent(studentrequest request)
        {
            var student = await _studentRepository.GetStudentsbyEmailAsync(request.Email);
            if (student == null)
            {
                return Response<dynamic>.Fail("Student not found");

            }
            student.UpdateStudent(request);
            _repository.Update(student);
            await _unitOfWork.SavechangesAsync();
            return Response<dynamic>.Success("Student Updated", student, 200);
        }

        public async Task<Response<dynamic>> DeleteStudent(Guid StudentId)
        {
            var student = await _studentRepository.GetStudentsbyIDAsync(StudentId);
            if (student == null)
            {
                return Response<dynamic>.Fail("Student not found");
            }            
            await _repository.SoftDeleteAsync(student);
            await _unitOfWork.SavechangesAsync();
            return Response<dynamic>.Success("Student Deleted", student, 200);
        }

        public async Task<Response<List<Students>>> getAllStudents()
        {
            var student = await _studentRepository.getallStudents();
            return Response<List<Students>>.Success("All Students", student, 200);
        }

        public async Task<Response<dynamic>> getStudent(Guid StudentId)
        {
            var student = await _studentRepository.GetStudentsbyIDAsync(StudentId);
            return Response<dynamic>.Success("Student", student, 200);
        }

    }
}
