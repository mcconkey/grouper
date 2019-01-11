using System;
using System.Linq;
using System.Collections.Generic;
namespace grouper
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<StormerGroup>();
            var solution = new SolutionSet();
            
            //number of groups
            int k = 10;
            
            //number of interations for second solutions
            int x = 10000;
                
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
          
            for(int i = 0; i < x; i++){
                var totalScore = 0;
                //put all the students back in the heap
                stormerHeap.HeapStormersFromGroups(groups);
                
                foreach(var g in groups){
                    g.ResetGroup();
                }
                
                //shuffle students again
                stormerHeap.Shuffle();
                
                //distribute them again
                stormerHeap.Distribute(groups);
                
                //score the group
                foreach(var g in groups){
                    g.ScoreGroup();
                    //g.PrintGroup();
                  //  g.RecordHistory();
                }    
                totalScore = groups.Select(g => g.score).Sum();
                //Console.WriteLine($"Iteration {i} the score was: {totalScore}");
                
                if(solution.score > totalScore || solution.groups.Count == 0){
                    solution.score = totalScore;
                    solution.groups = groups;
                }
            }

            Console.WriteLine($"After {x} iterations the best score was: {solution.score}");
            
        }
    }
}
