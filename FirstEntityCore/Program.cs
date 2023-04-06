using FirstEntityCore.DataContext;
using FirstEntityCore.Models;
using System.Data.SqlTypes;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        AppDbContext db = new AppDbContext();

        //Student st = new Student()
        //{
        //    FirstName= "Valibek",
        //    LastName = "Atabayev",
        //    Age= 22,
        //};
        //db.Students.Add(st);
        //db.SaveChanges();


        //List<Student> students = db.Students.Where(p => p.Age > 19).ToList();

        //foreach(Student student in students)
        //{
        //    Console.WriteLine($"{student.Id} {student.LastName} {student.FirstName} {student.Age}");
        //}

        List<Student> students = new List<Student> 
        { 
            new Student()
            {
                FirstName= "Test12",
                LastName = "Test12",
                Age = 2,
            },
            new Student()
            {
                FirstName= "Test3",
                LastName = "Test3",
                Age = 3,
            },
            new Student()
            {
                FirstName= "Test4",
                LastName = "Test4",
                Age = 4,
            },
        };
        db.Students.AddRange(students);
        db.SaveChanges();

        List<Student> studentList = db.Students.Where(p => p.Age > 19).ToList();

        foreach(Student student in studentList)
        {
            Console.WriteLine($"{student.Id} {student.LastName} {student.FirstName} {student.Age}");
        }

    }
}