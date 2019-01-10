using System;
using System.Collections.Generic;

namespace grouper
{
    static class ListPop
    {

        /// This method gives Lists some of the function of a stack  (LIFO)
        public static T Pop<T>(this IList<T> list)
        {
            
            // take the value of the last item in the list
            var ret = list[0];
            // remove the first element of the list
            list.RemoveAt(0);
            //return the value of the first item 
            return ret;

        }
    }
}