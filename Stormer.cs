// A Hello World! program in C#.
using System;
using System.Collections.Generic;
using System.Linq;

namespace grouper
{
    class Stormer
    {
        public string name = "";
        public int id = 0;
        List<int> history = new List<int>();
        
        public Stormer(string n, int i = 0){
            name = n;
            id = i;
        }

        public void AddHistory(List<int> arr)
        {

            history = history.Union(arr).ToList();

        }

       
    }
}