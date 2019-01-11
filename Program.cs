using System;
using System.Linq;
using System.Collections.Generic;
namespace grouper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StormerGroup> groups = new List<StormerGroup>();
            int k = 10;
                
            //Create a dataset of n students
            var stormerHeap = new StormerHeap();
            stormerHeap.GenerateStormers(100);
            
            //Create k number of groups
            for(int i = 0; i < k; i++){
                groups.Add(new StormerGroup(i));
            }
            
            //shuffle students
            stormerHeap.Shuffle();
            //stormerHeap.PrintHeap();
            //distribute students among groups
            stormerHeap.Distribute(groups);
            //foreach(var g in groups){
             //   g.PrintGroup();
           // }
            //record groups to student's history
            foreach(var g in groups){
                g.RecordHistory();
            }
          
            //put all the students back in the heap
            stormerHeap.HeapStormersFromGroups(groups);
            
            //shuffle students again
            stormerHeap.Shuffle();
            
            //distribute them again
            stormerHeap.Distribute(groups);
            
            //score the group
            foreach(var g in groups){
                g.ScoreGroup();
                g.PrintGroup();
                g.RecordHistory();
            }
            
            
            //put all the students back in the heap
            stormerHeap.HeapStormersFromGroups(groups);
            
            //shuffle students again
            stormerHeap.Shuffle();
            
            //distribute them again
            stormerHeap.Distribute(groups);
            
             //score the group
            foreach(var g in groups){
                g.ScoreGroup();
                g.PrintGroup();
                g.RecordHistory();
            }
            
            
        }
    }
}
