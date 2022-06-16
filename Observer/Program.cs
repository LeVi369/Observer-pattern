using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer
{
     class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            ConcreteSubject subject = new ConcreteSubject();

            subject.registerObserver(observer1);
            subject.State = "123";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);

            subject.registerObserver(observer2);
            subject.State = "321";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);

            subject.removeObserver(observer2);
            subject.State = "gg";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);

            Console.ReadLine();  

        }
    }
}
