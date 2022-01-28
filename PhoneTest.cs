using System;
namespace Chapter14
{
    public class PhoneTest
    {
        //Question 14
        public void TestPhone()
        {
            MobilePhone phone = new MobilePhone("Adewale Bayo", "Tecno","L8 Lite",39500.90);
            Console.WriteLine(phone.GsmInfo());
        }
        //Question 14
        public void NokiaPhone()
        {
            MobilePhone.NokiaN95 ="Nokia 2.4 ";
            MobilePhone nk = new MobilePhone();
            Console.WriteLine(nk.GetNokia());
        }
    }
}