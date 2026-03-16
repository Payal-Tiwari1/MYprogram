using ModelsInASPCore.Models;
using System.Reflection.Metadata.Ecma335;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();

        }

        public StudentModel getStudentByRollNo(int rollNo)
        {
            if (rollNo <= 0)
            {
                return null;
            }
            else
            {
                return DataSource().Where(x => x.rollNo == rollNo).FirstOrDefault();
            }
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Payal", Gender = "Female", Standard = 10 },
                new StudentModel { rollNo = 2, Name =  "Sonal",Gender = "Female",Standard = 11 },
                new StudentModel { rollNo = 3, Name =  "Durgesh",Gender = "Male",Standard = 12 },
                new StudentModel { rollNo = 4, Name =  "Jheel",Gender = "Female",Standard = 10 },
                new StudentModel { rollNo = 5, Name =  "Dishank",Gender = "Male",Standard = 11 }
            };
        }
    }
}

