using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOptionNamespace
{
    public class YourClassObject
    {//Variable HAS :  As a developer, I want to create a Contestant class that has a first name, last name, email address, and registration number

        //public string Parameter1_string { get; set; }
        //public string Parameter2_string { get; set; }
        //public int Parameter3_int { get; set; }
        
        ////Method CAN DO

        public YourClassObject CreateClassObject1()
        {
            YourClassObject object1 = new YourClassObject();
            Console.WriteLine("do something here");
            Console.ReadLine();
            return object1;
        }
    }
}
