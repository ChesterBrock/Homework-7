/// Chapter No. 7		Exercise No. 1
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Oct 16, 2021
///
/// Problem Statement: Define a class called Counter whose objects count things. 
/// 
/// 
/// 
/// Overall Plan:
/// 1) Create a counter class
/// 2) Created a getter and setter method for the instance variables 
/// 3)  Include methods to set the counter to 0, to increase the count by 1, and to decrease the count by 1.
/// 4) Be sure that no method allows the value of the counter to become negative.  
/// 5) The only method that can set the counter is the one that sets it to 0.
/// 6) Include a ToString methods and a Equals method. 
/// 7) Write a driver program that include a menu to interactively test each method in your program. 
/// 8) 
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            Counter testCounter = new Counter(10); // starting value of 10 
            // creating the menu. 

            do { 
            Console.WriteLine("~~ Menu ~~\n1)Set value to 0\n2)Add 1 to the object\n3)Substract 1 from the object\n4)Display current value\n~~~~~~~\n\nPress 0 to exit");

            
            menuChoice = Int32.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        //set value to 0
                        testCounter.setToZero();
                        break;
                    case 2:
                        //add 1
                        testCounter.addOne();
                        break;
                    case 3:
                        //subtract 1
                        testCounter.subtractOne();
                        break;
                    case 4:
                        // current value 
                        testCounter.currentCount();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (menuChoice != 0) ;
        }
    }
}
