// A Hello World! program in C#.
using System;
using System.Collections.Generic;
using System.Linq;
namespace grouper
{
    class StormerGroup
    {
        public int id = 0;
        public int score = 0;
        public List<Stormer> stormers = new List<Stormer>();
        
        public StormerGroup(int i = 0){
            id = i;
        }
        
        //Debuging fuction which prints out what's in the group
        public void PrintGroup(){
            
            Console.WriteLine($"Group: {id} Score: {score}");
            foreach(Stormer s in stormers){
                Console.WriteLine($"{s.name}: " +string.Join(", ", s.history));
            }
        }
        
        //takes all the student ideas of stormers and adds that to each stormers history
        public void RecordHistory(){
            var groupIds = stormers.Select(s => s.id).ToList();
            foreach(var s in stormers){
                //Adds the group ids to the individuals history 
                s.history = s.history.Union(groupIds.Where(i => i != s.id)).ToList();
                //Console.WriteLine($"{s.name}: " +string.Join(", ", s.history));
            }
            
        }
        
        //score the group based on history of stormers
        // checking to see if each stormer has been in a group
        // with any of the other people in their group before
        public void ScoreGroup(){
            // get current stormer ids
            var stormerIds = stormers.Select(s => s.id).ToList();
            // compary the current stormer history to the current ids
            foreach(var s in stormers){
                score += s.history.Where(h => stormerIds.Contains(h)).Count();
            }
        }
        
        public void ResetGroup(){
            stormers.Clear();
            score = 0;
        }
    }
}