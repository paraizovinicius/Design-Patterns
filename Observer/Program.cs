using System;
using System.Collections.Generic;
namespace Observer{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating observed class
            Subject subject = new Subject();

            // Creating two observer classes
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            // Registering observers into the subject class
            subject.Attach(observer1);
            subject.Attach(observer2);

            // Altering the observed subject's value
            subject.SetValue(100);

            // Removing observer2 from the subject class
            subject.Detach(observer2);

            // Altering again the subject's value
            subject.SetValue(200); //This time, Class2 won't change because it was removed from our observer list

            Console.ReadKey();
        }
    }
}
