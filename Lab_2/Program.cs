using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
 public   class Program
    {
    public    static void Main(string[] args)
        {
            Person personObject = new Person();
            personObject.Name = "Moe";
            personObject.SayHello(personObject.Name);

           
            personObject.ShowAge(28);

        }
    }
}
