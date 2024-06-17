using Lecture_no_21___Repository_Pattern__.Models;

namespace Lecture_no_21___Repository_Pattern__.Repository
{
    public interface IStudent
    {
        List<StudentModel> GetStudentModels();
        StudentModel GetStudentById(int id);
    }
}
