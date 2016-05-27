using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{/**
     * This class defines a generic Person
     * 
     * @class Person
     * @field {string} _name 
     * @field {int} _age 
     */
    class Person
    {
        //private instance variables:
        //name(string)
        // age(integer)

        private string _name;
        private int _age;
        //++++++++++++++++++++++
        
            /**
         * <summary>
         * This is a public property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
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
        /**
         * <summary>
         * This is a public property for our private _age field
         * </summary>
         * 
         * @property {int} Age
         */
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
        /**
        * <summary>
        * This method outputs the Name value with " says hello" to the console.
        * </summary>
        * 
        * @method SaysHello
        * @param string Name
        * @returns {void}
        */
        public void SayHello(string Name)
        {
            Console.WriteLine(Name + " says hello");
           

        }
        /**
         * <summary>
         * This method outputs the _name and _age values in the following
         * format: _name + " is " + Age + " years old".
         * </summary>
         * 
         * @method ShowAge
         * @param int Age
         * @returns {void}
         */
        public void ShowAge(int Age)
        {
            
            Console.WriteLine(this._name  + " is " + Age + " Years old ");
            
        }


    }
}
