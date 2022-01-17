using System;

namespace Chapter14
{
    public class Student
    {
       
        public string Fullname;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public string PhoneNumber;
        //Question 3
        public static int Studentcount = 0;

        public Student()
        {
            Studentcount++;
        }

         public Student(string fullname)
         {
            Fullname = fullname;
            Studentcount++;

         }

        public Student(string fullname, string phoneNumber, string email)
        {
            Fullname = fullname;
            PhoneNumber = phoneNumber;
            Email = email;
            Studentcount++;
        }
        public Student(string fullname, string university, string subject,string course, string phoneNumber, string email)
        {
            Fullname = fullname;
            University = university;
            Subject = subject;
            Course = course;
            PhoneNumber = phoneNumber;
            Email = email;
            Studentcount++;
        }

        /*Question 4*/
        public void StudentInfo()
        {
            Console.WriteLine($"Student Name: {Fullname} \nSchool: {University}\nCourse/Subject:{Course} Phone Number: {PhoneNumber}  \nEmail: {Email}");
        }
    }

    /*Question 6*/
    public class StudentTest:Student
    {
          
    }
}