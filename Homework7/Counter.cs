/// Chapter No. 7		Exercise No. 1
/// File Name: Counter.cs
/// @author: Chester Brock 
/// Date:  Oct 16, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Counter
    {
        // a counter class whose objects count things 

        // instance variables 
        private int value = 0;

        // constructor 
        public Counter(int value)
        {
            this.setValue(value);
        }

        // getter and setter methods
        public void setValue(int value)
        {
            this.value = value;
            if(this.value < 0) { this.value = 0; };
        }
        public int getValue()
        {
            return this.value;
        }

        // methods 
        public void setToZero()
        {
            this.value = 0;
            Console.WriteLine("The value has been changed to 0");
        }

        public void addOne()
        {
            value++;
            Console.WriteLine("1 has been added to the value");
        }

        public void subtractOne()
        {
            value--;
            Console.WriteLine("1 was taken away from value");
        }
        public  void currentCount()
        {
            Console.WriteLine(value);
        }

        //toString & equals methods
        public string toString()
        {
            return "value[ " + this.value + "] ";
        }

        public bool equals(Object other)
        {
            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }
            Counter that = (Counter)other;
            return this.value == that.value;
        }


    }
}
