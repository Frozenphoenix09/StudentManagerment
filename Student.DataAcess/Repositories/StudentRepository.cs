using Microsoft.EntityFrameworkCore;
using Student.DataAcess.Common;
using Student.DataAcess.EF;
using System.Linq.Dynamic.Core;


namespace Student.DataAcess.Repositories
{
    public interface IStudentRepository : IBaseRepository<Entities.Student>
    {
        List<Entities.Student> GetAllStudent(int pageSize, int skip, string textSearch, string sortColumn, string sortDirection);
    }
    public class StudentRepository : BaseRepository<Entities.Student> , IStudentRepository
    {
        public StudentRepository(StudentManagerDbContext context) : base(context)
        {

        }
        public List<Entities.Student> GetAllStudent(int pageSize, int skip, string textSearch, string sortColumn, string sortDirection)
        {
            var query = Dbset.AsQueryable();

            if(textSearch != null)
            {
                query = query.Where(x => x.Name.Contains(textSearch) || x.Address.Contains(textSearch));
            }
            if (!string.IsNullOrEmpty(sortColumn))
            {
                query = query.OrderBy(string.Concat(sortColumn, " ", sortDirection));
            }
            query = query.Include(x => x.StudentClasses);
            query = query.Skip(skip).Take(pageSize);
            return query.ToList();          
        }
    }
}
