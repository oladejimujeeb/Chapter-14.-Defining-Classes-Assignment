using System;
namespace Chapter14;

public class CallTest
{
    //Question19
    public static void DisplayCall()
    {
        Call cal = new Call();
        cal.Time = Convert.ToDateTime("1/27/2022 1:30:58 AM");
        cal.StartTime = Convert.ToDateTime("1/27/2022 1:45:08 AM");
        Console.WriteLine($"Call duration: {cal.CallDuratn()}");
        cal.CallHistroy();
        cal.TotalAmountOfCall();
    }


}