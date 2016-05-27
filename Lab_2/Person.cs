using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Person
    {
        //private instance variables:
        //name(string)
        // age(integer)

        private string _name;
        private int _age;

        public string Name
        {
           get
            {
                return this._name;
             }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        public void SayHello(string Name)
        {
            Console.WriteLine(Name + " says hello");
           

        }
        public void ShowAge(int Age)
        {
            
            Console.WriteLine(this._name + " says hello and" + " is " + Age + " Years old ");
            
        }


    }
}
