using Student.Model.Models.StudentModels;

namespace Student.Service.AutoMap
{
    public static class StudentMapper
    {
        public static StudentModel MapToModel (this Student.DataAcess.Entities.Student entity)
        {
            return new StudentModel
            {
                StudentId = entity.StudentId,
                Name = entity.Name,
                DateOfBirth = entity.DateOfBirth,
                Address = entity.Address,
                StudentClasses = entity.StudentClasses
            };                 
        }
        public static DataAcess.Entities.Student MapToEntity(this StudentModel model)
        {
            return new DataAcess.Entities.Student
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                Address = model.Address,
            };
        }
        public static List<StudentModel> MapToModels(this List<DataAcess.Entities.Student> entities)
        {
            return entities.Select(x => x.MapToModel()).ToList();
        }
        public static List<DataAcess.Entities.Student> MapToEntities(this List<StudentModel> models)
        {
            return models.Select(x =>x.MapToEntity()).ToList();
        }
    }
}
