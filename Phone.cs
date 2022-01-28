using System;

namespace Chapter14
{
    public class MobilePhone
    {
        //QUESTION 8
        public string PhoneType;
        public string Model;
        public double Price;
        public string OwnerName;
        public string ScreenColour;
        //Question 13 (1)
        public string ScreenSize{get;}
        //QUESTION 10
        public static  string NokiaN95;
        private static int newphone = 0;
        //Question 14
        private static MobilePhone[] phones = new MobilePhone[10];
        public void AddToPhone()
        {
            phones[newphone] = this;
        }
        public MobilePhone()
        {
            ScreenSize = "1200 x 320";
            newphone++;
        }
        //QUESTION 9
        public MobilePhone(string phonetype, string model, double price)
        {
            PhoneType = phonetype;
            Model = model;
            Price = price;
            //Question 13 (1)
            
        }
        //QUESTION 9
        public MobilePhone(string ownername, string phonetype, string model, double price)
        {
            OwnerName = ownername;
            PhoneType = phonetype;
            Model = model;
            Price = price;
        }
        public void SetNokia(string nokiaN95)
        {
            NokiaN95 = nokiaN95;
        }
        //QUESTION 10
        public string GetNokia()
        {
            return NokiaN95;
        }

        //Question12
        public string GsmInfo()
        {
            return $"Phone:{PhoneType}, Owner:{OwnerName}, Model:{Model}, Price:{Price}";
        }
        
    }
}