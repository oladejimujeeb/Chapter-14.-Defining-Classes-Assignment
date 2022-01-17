using System;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student();
            student1.Fullname = "Ayeyemi Olugenga";
            student1.Email = "Aolugenga@gmail.com";
            student1.Course = "Mathematics";
            student1.PhoneNumber = "+234703600490";
            student1.University ="Federal University Of Technology, Akure";

           Student student2 = new Student("Awwal Olasile", "Federal University Of Agriculture, Abeokuta"
                                                    ,"Computer Science","Computer Science","+2348136794915",
                                                    "awwal@gmail.com");
           student1.StudentInfo();
           Console.WriteLine();
           student2.StudentInfo();
           Console.WriteLine(Student.Studentcount);

        }
    }
}
