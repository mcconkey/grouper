// A Hello World! program in C#.
using System;
using System.Collections.Generic;
namespace grouper
{
    class StormerGroup
    {
        public int id = 0;
        public List<Stormer> stormers = new List<Stormer>();
        
        public StormerGroup(int i = 0){
            id = i;
        }
    }
}