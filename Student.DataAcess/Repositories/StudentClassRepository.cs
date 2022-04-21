using Student.DataAcess.Common;
using Student.DataAcess.EF;
using Student.DataAcess.Entities;

namespace Student.DataAcess.Repositories
{
    public interface IStudentClassRepository : IBaseRepository<StudentClass>
    {

    }
    public class StudentClassRepository : BaseRepository<StudentClass>, IStudentClassRepository
    {
        public StudentClassRepository(StudentManagerDbContext context) : base(context)
        {

        }
    }
}
