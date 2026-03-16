using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();

        StudentModel getStudentByRollNo(int rollNo);
    }
}
