using System;
using System.Collections.Generic;

namespace Chapter14
{
    //QUESTION 15
    public class Call
    {
        public DateTime Time {get; set; } 
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        //Question16
        List<DateTime> _listCallHistroy = new List<DateTime>();

        //Question15
        public TimeSpan CallDuratn()
        {
           return Duration = StartTime - Time;
        }

        //Question16
        public void CallHistroy()
        {
            DateTime callHistory = DateTime.Now;
            _listCallHistroy.Add(callHistory);
        }
        //Question17
        public void DeleteCall(DateTime callhis)
        {
            foreach (var call in _listCallHistroy)
            {
                if (callhis == call)
                {
                    _listCallHistroy.Remove(call);
                }
            }
        }
        //Question17
        public void DeleteAllCall()
        {
            _listCallHistroy.Clear();
        }
        
        //question 18
        public void TotalAmountOfCall()
        {
            float allCallAMount = 0;
            foreach (var call in _listCallHistroy)
            {
                float price = 0.37f;
                int calls = call.Minute;
                allCallAMount += price * calls;
            }
            Console.WriteLine($"#{allCallAMount}");
        }

    }
}