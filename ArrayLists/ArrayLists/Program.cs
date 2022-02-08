using System;
using System.Collections;
using System.Collections.Concurrent;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaring an ArrayList - Requires using System.Collections above
            ArrayList myArrayList = new ArrayList(); // undefined amount of objects
            ArrayList myArrayList2 = new ArrayList(100); // defined with 100 objects

            myArrayList.Add(25);
            myArrayList.Add("hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            Console.WriteLine(myArrayList.Count);
            myArrayList.Remove(13); //delete element with specific value the array list - the first element it finds
            myArrayList.RemoveAt(0); // delete element at a specific position in the ArrayList
            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach(object obj in myArrayList)  // object is the highest level class there is, everything inherits from it
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine($"The string is {obj}");
                }

                Console.WriteLine($"The running sum is {sum}");
            }

            Console.WriteLine($"The final sum total = {sum}");
        }
    }
}
