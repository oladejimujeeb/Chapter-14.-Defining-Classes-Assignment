using System;
namespace Chapter14
{
    public class StudentTest
    {
        /*Question 6*/
        public static string Fullname;
        public static string Course;
        public static string University;
        public static string Email;
        
        public static void PrintStudent1()
        {
            Student student1 = new Student();
            student1.Fullname = "Ayeyemi Olugenga";
            student1.Email = "Aolugenga@gmail.com";
            student1.Course = "Mathematics";
            student1.PhoneNumber = "+234703600490";
            student1.University = "Federal University Of Technology, Akure";
            student1.StudentInfo();

        }
        public static void PrintStudent2()
        {
            Student student2 = new Student("Awwal Olasile", "Federal University Of Agriculture, Abeokuta"
                                                    , "Computer Science", "Computer Science", "+2348136794915",
                                                    "awwal@gmail.com");
            student2.StudentInfo();
        }
    }
}