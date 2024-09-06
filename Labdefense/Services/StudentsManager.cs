using Labdefense.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Services
{
    public class StudentsManager
    {
        private Student[] students;
        public StudentsManager(Student[] studentsInitial) {
            students = new Student[studentsInitial.Length];
            Array.Copy(studentsInitial, students, studentsInitial.Length);
        }

        public Student[] GetStudents()
        {
            Student[] studentcopy = new Student[students.Length];
            Array.Copy(students, studentcopy, students.Length);

            return studentcopy;
        }

        public void AddStudent(Student newstudent)
        {
            Student[] newstudents = new Student[students.Length + 1];
            Array.Copy(students, newstudents, students.Length);
            newstudents[newstudents.Length] = newstudent;
            students = newstudents;

        }

        public void RemoveStudent(Student studentToRemove)
        {
            students = students.Where(s=> s != (studentToRemove)).ToArray();
        }

        public void UpgradeStudents(Student studentUpgrade) 
        {
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].id == studentUpgrade.id) {  
                students[i] = studentUpgrade;
                    break;
                    }
            }
        }
    }
}
