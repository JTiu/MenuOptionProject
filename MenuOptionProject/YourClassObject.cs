using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOptionNamespace
{
    public class YourClassObject
    {
        
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
