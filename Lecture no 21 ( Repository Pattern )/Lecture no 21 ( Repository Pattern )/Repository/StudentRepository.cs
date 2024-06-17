using Lecture_no_21___Repository_Pattern__.Models;

namespace Lecture_no_21___Repository_Pattern__.Repository
{
    //when a class implement or inherit interface so all thsoe abstract methods need to implement inside this class
    public class StudentRepository : IStudent
    {
        public StudentModel GetStudentById(int id)
        {
            // s represent studentmodel
            return DataSource().Where(s => s.Rollno==id).FirstOrDefault();
        }

        public List<StudentModel> GetStudentModels()
        {
            //getting data through linq from our database
            return DataSource();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel> { 
            
                new StudentModel{Rollno = 1 , Name = "Name1" , Gender="G1" , Standard=6},
                new StudentModel{Rollno = 2 , Name = "Name2" , Gender="G2" , Standard=7},
                new StudentModel{Rollno = 3 , Name = "Name3" , Gender="G3" , Standard=8},
                new StudentModel{Rollno = 4 , Name = "Name4" , Gender="G4" , Standard=9}

            };
        }
    }
}
