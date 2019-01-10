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
        
        public void Shuffle(){
            stormers.Shuffle();
        }
        
        public void PrintHeap(){
            foreach(Stormer s in stormers){
                Console.WriteLine($"{s.name}");
            }
        }
    }
    
}