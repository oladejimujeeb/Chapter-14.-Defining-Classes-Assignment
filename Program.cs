using System;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Question 7*/
            Console.WriteLine("Question7");
            StudentTest.PrintStudent1();
            Console.WriteLine();
            StudentTest.PrintStudent2();
            Console.WriteLine();
            PhoneTest test1 = new PhoneTest();
            /*Question 14*/
            Console.WriteLine("Question14");
            test1.TestPhone();
            test1.NokiaPhone();
            Console.WriteLine();
            //Question19
            Console.WriteLine("Question19");
            CallTest.DisplayCall();
            //Question 20&21
            Console.WriteLine("Question 20 & 21");
            BookTest.LibraryMenu();
            
        
           

        }
    }
}
