using System;
namespace Chapter14
{
    //Question 11
    public class Battery
    {
        public string BatteryModel;
        public BatteryType Batery;
        //Question 13 (2)
        public string BateryTalkTime{get; }
        public Battery(string batterymodel, Battery batery)
        {
            BatteryModel = batterymodel;
            BateryTalkTime = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}