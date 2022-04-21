using Student.DataAcess.Common;
using Student.DataAcess.Repositories;
using Student.Model.Models.StudentModels;
using Student.Service.AutoMap;

namespace Student.Service.Service
{
    public interface IStudentService : IEntityService<DataAcess.Entities.Student>
    {
        List<StudentModel> GetAllStudent(int pageSize , int skip , string textSearch , string sortColumn , string sortDirection);
    }
    public class StudentService : EntityService<DataAcess.Entities.Student> , IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IUnitOfWork unitOfWork, IStudentRepository studentRepository) : base(unitOfWork, studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<StudentModel> GetAllStudent(int pageSize, int skip, string textSearch, string sortColumn, string sortDirection)
        {
            return _studentRepository.GetAllStudent(pageSize, skip, textSearch, sortColumn, sortDirection).MapToModels();
        }
    }
}
