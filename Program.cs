using System;
using System.Linq;
using System.Collections.Generic;
namespace grouper
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Create a dataset of n students
            var stormerHeap = new StormerHeap();
            stormerHeap.GenerateStormers(100);
            
            //Create k number of groups
            
            //shuffle students
            stormerHeap.Shuffle();
            stormerHeap.PrintHeap();
            //distribute students among groups
            
            //record groups to student's history
            
            //shuffle students again
            
            //score the group
            
            
        }
    }
}
