using System.Collections.Generic;
using MVC_InMemory_CRUD_Demo.Models;

namespace MVC_InMemory_CRUD_Demo.Service{
    public class StudentService
    {
        private static List<Student> StudList;
        public static int nextId=106;
        static StudentService()
        {
            StudList = new List<Student>
            {
                new Student{Id=1, Name="John Doe",  Marks=12},
                new Student{Id=2, Name="Jane Smith",  Marks=56},
                new Student{Id=3, Name="Michael Johnson", Marks=79}
            };
        }

        public static List<Student> GetAll()
        {
            return StudList;
        }

        public static Student GetStudentById(int id)
        {
            return StudList.Find(x => x.Id == id);
        }

        public static void AddStudent(Student stud)
        {
            stud.Id = nextId;
            StudList.Add(stud);
            stud.Id = nextId++;
        }
        public static void Update(Student modified){
            int index = StudList.FindIndex(m=>m.Id == modified.Id);
            if(index==-1)return;
            else StudList[index]=modified;
        }

        public static void Delete(int id){
            StudList.RemoveAll(m=>m.Id == id);
        }
    }
}