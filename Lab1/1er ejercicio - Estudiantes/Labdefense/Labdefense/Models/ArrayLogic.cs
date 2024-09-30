
using Labdefense.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class ArrayLogic
    {
        private static readonly ArrayLogic logic = new();
        public static ArrayLogic Arraylog { get { return logic; } }
        private Student[] students;
        private int size = 0, quantity = 0;


        public ArrayLogic()
        {
            students = new Student[size];
        }

        public void AddStudent(Student newstudent)
        {


            if (quantity >= size)
            {
                size = size == 0 ? 1 : size + 1;
                Array.Resize(ref students, size);
            }
            students[quantity] = newstudent;
            ++quantity;
        }

        public Student[] GetStudents()
        {
            return students;
        }

        public bool RemoveStudent(string Carnet)
        {
            var index = Array.FindIndex(students, e => Carnet.Equals(e.Carnet));
            if (index < 0) return false;
            for (int i = index; i < quantity - 1; i++)
            {
                students[i] = students[i + 1];
            }

            --quantity;
            Array.Resize(ref students, quantity);
            return true;
        }


        public bool UpdateStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.Carnet)) return false;
            var index = Array.FindIndex(students, s => student.Carnet.Equals(s?.Carnet));
            if (index < 0) return false;


            students[index] = student;
            return true;
        }

        public bool SaveGrades(Student student)
        {
            if (string.IsNullOrEmpty(student.Carnet)) return false;
            var index = Array.FindIndex(students, s => student.Carnet.Equals(s.Carnet));
            if (index < 0) return false;
            students[index].IPar = student.IPar;
            students[index].IIPar = student.IIPar;
            students[index].Project = student.Project;
            Array.Sort(students, (firstParishion, SecondParishion) => SecondParishion?.Finalgrades.CompareTo(firstParishion?.Finalgrades) ?? 0);
            return true;
        }
        public Student[] SearchStudentByCarnet(string carnet)
        {
            return Array.FindAll(students, e => carnet.Equals(e.Carnet)); 
        }

        public Student[] SearchStudentById(string identification)
        {
            return Array.FindAll(students, e => identification.Equals(e.Identification)); 
        }

        public bool CarnetUnique(string carnet)
        {
            return SearchStudentByCarnet(carnet).Length == 0; 
        }

        public bool IdtUnique(string identification)
        {
            return SearchStudentById(identification).Length == 0; 
        }

    }
}
