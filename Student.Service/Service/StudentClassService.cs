using Student.DataAcess.Common;
using Student.DataAcess.Entities;
using Student.DataAcess.Repositories;


namespace Student.Service.Service
{
    public interface IStudentClassService : IEntityService<StudentClass>
    {

    }
    public class StudentClassService : EntityService<StudentClass>, IStudentClassService
    {
        private readonly IStudentClassRepository _studentClassRepository;
        public StudentClassService(IUnitOfWork unitOfWork, IStudentClassRepository studentClassRepository) : base(unitOfWork, studentClassRepository)
        {
            _studentClassRepository = studentClassRepository;
        }
    }
}