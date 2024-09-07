using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
     public class ArrayLogic
    {  private static  readonly ArrayLogic logic = new ();
        public static ArrayLogic Arraylog {  get { return logic; } }
        private Student[] students;
        private int size = 0, quantity = 0;


        public ArrayLogic() { 
        students = new Student[size];
        }

        public void AddStudent(Student newstudent)
        {
            if(quantity >=size)
            {
                size = size == 0 ? 1 : size + 1;
                Array.Resize(ref students, size);
            }
            students[quantity] = newstudent;
            ++quantity;
        }

        public Student[] GetStudents()
        {
    for(int i = 0; i < students.Length; ++i)
            {
                for (int j = 0; j < students.Length - i - 1; j++) {
                    if (students[j].Finalgrades < students[j + 1].Finalgrades)
                    {


                       Student BestGrades = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = BestGrades;
                    }
                        }
               
            }
            return students;
        }

        public bool RemoveStudent(string Carnet)
        {
            var index = Array.FindIndex(students, e => Carnet.Equals(e.carnet));
            if (index < 0)return false;
            for (int i = index; i < quantity - 1; i++)
            {
                students[i] = students[i + 1];
            }
               students[quantity - 1] = null;
                --quantity;
            return true; 
        }
      

        public bool UpdateStudent(Student student)
        {    
            if(string.IsNullOrEmpty(student.carnet))return false;
            var index = Array.FindIndex(students, s=> student.carnet.Equals(s.carnet));
            if (index < 0) return false;


            students[index] = student;
            return true;
        }

        public bool SaveGrades(Student student)
        {
            if (string.IsNullOrEmpty(student.carnet)) return false;
            var index = Array.FindIndex(students, s => student.carnet.Equals(s.carnet));
            if (index < 0) return false;
            students[index].IPar = student.IPar;
            students[index].IIPar = student.IIPar;
            students[index].project = student.project;
            return true;
        }
        public Student[] SearchStudent(string carnet)
        {
            
            var student = Array.Find(students, e => carnet.Equals(e.carnet));

    
            return student != null ? new[] { student } : Array.Empty<Student>();
        }

    }
}
