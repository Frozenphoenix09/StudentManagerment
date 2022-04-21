using Student.DataAcess.Common;
using Student.DataAcess.EF;
using Student.DataAcess.Entities;

namespace Student.DataAcess.Repositories
{
    public interface IClassRepository : IBaseRepository<Class>
    {

    }
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(StudentManagerDbContext context) : base(context)
        {

        }
    }
}
