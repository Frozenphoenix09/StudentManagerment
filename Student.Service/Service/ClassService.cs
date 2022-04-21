using Student.DataAcess.Common;
using Student.DataAcess.Entities;
using Student.DataAcess.Repositories;

namespace Student.Service.Service
{
    public interface IClassService : IEntityService<Class>
    {

    }
    public class ClassService : EntityService<Class>, IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IUnitOfWork unitOfWork, IClassRepository classRepository) : base(unitOfWork, classRepository)
        {
            _classRepository = classRepository;
        }
    }
}
