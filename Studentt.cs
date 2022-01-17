// using System;

// namespace Chapter14
// {
//     public class Studentt
//     {
//         //Question 5
//         private string Fullname;
//         private string Course;
//         private string Subject;
//         private string University;
//         private string Email;
//         private string PhoneNumber;

//         public Studentt()
//         {

//         }
//         public Studentt(string fullname)
//         {
//             Fullname = fullname;
//         }

//         public Studentt(string fullname, string phoneNumber, string email)
//         {
//             Fullname = fullname;
//             PhoneNumber = phoneNumber;
//             Email = email;
//         }
//         public Studentt(string fullname, string university, string subject, string course)
//         {
//             Fullname = fullname;
//             University = university;
//             Subject = subject;
//             Course = course;
//         }
//         public string Getname
//         {
//             get{ return Fullname;}
//             set{Fullname = value;}
//         }
//         public string GetPhoneno
//         {
//             get{ return PhoneNumber;}
//             set{PhoneNumber = value;}
//         }
//         public string GetEmail
//         {
//             get{ return Email;}
//             set{Email = value;}
//         }

//         public string GetCourse
//         {
//             get{ return Course;}
//             set{Course = value;}
//         }

//         public string GetUniversity
//         {
//             get{return University;}
//             set{University = value;}
//         }
        
//         public void StudenttInfo()
//         {
//             Console.WriteLine($"Studentt Name: {Fullname} \nSchool: {University}\nCourse/Subject:{Course}");
//             Console.WriteLine($"Phone Number: {PhoneNumber} \nEmail: {Email}");
//         }
//     }
// }