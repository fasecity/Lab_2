using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Project : Lab 2 - Objects and classes
 * Student : Mohamoud Mohamed
 * Student#: 300435435
 * Version : .02 includes documentation
 
     */



namespace Lab_2
{/**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     * 
     */
    public class Program
    {/**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class called personObject
            Person personObject = new Person();
            //setting the value of Name to Moe {string}
            personObject.Name = "Moe";
            //running the SaysHello Method
            personObject.SayHello(personObject.Name);

           //running the ShowsAge method & inputing 28 int as Age parameter
            personObject.ShowAge(28);

        }
    }
}
