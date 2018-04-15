using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduceYourself
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            Person firstP = new Person("Gosho", 15 );
            Person secondP = new Person("Pesho", 17);

            Console.WriteLine($"I am {firstP.Name} and i'm {firstP.Age} years old and my friend {secondP.Name} is {secondP.Age} years old.");
        }
    }
}
