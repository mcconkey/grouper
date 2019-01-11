using System;
using System.Linq;
using System.Collections.Generic;

namespace grouper
{
    class StormerHeap
    {
        public List<Stormer> stormers = new List<Stormer>();
        
        
        public void GenerateStormers(int n = 100){
            for(int i = 0; i < n; i++){
               stormers.Add(new Stormer($"guy{i}", i)); 
            }    
        }
        
        //shuffle's heap using extension fuction in ListShuffle.cs
        public void Shuffle(){
            stormers.Shuffle();
        }
        
        ///Debuging fuction which prints out what's in the heap
        public void PrintHeap(){
            foreach(Stormer s in stormers){
                Console.WriteLine($"{s.name}");
            }
        }
        
        //passed a list of stormers this fuction distributes all the stormers evenly accross the groups
        public void Distribute(List<StormerGroup> groups){
            var groupsIndex = 0;
            while(stormers.Count > 0 ){
                groups[groupsIndex].stormers.Add(stormers.Pop());
                groupsIndex = groupsIndex < (groups.Count - 1) ? (groupsIndex + 1) : 0; 
            }  
        }
        
        public void HeapStormersFromGroups(List<StormerGroup> groups){
            foreach(var g in groups){
                //add all the stormers to the heap
                stormers = stormers.Concat(g.stormers).ToList();
                //remove all the stormers from the group
                g.stormers.Clear();
            }
        }
        
        
    }
    
}