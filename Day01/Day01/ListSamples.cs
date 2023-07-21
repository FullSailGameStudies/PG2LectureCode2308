using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    /*                    List<T>       
             
    
            Vocabulary:
        
                  List<T>: https://www.tutorialsteacher.com/csharp/csharp-list#:~:text=C%23%20-%20List%3CT%3E%201%20List%3CT%3E%20Characteristics%20List%3CT%3E%20equivalent,8%20Check%20Elements%20in%20List%20...%20More%20items
                    a collection of strongly typed objects that can be accessed by index. Indexes start at 0.

                  
             Lecture videos:
                  LIST LECTURE:
                  https://fullsailedu-my.sharepoint.com/:v:/g/personal/ggirod_fullsail_com/ERG1iZHKJgFIoj6W8dhxPPgBIIY-Ot1b6Ueh-50Ggfcikg?e=goT9d6
                  Chapters: Array Basics through Looping Examples.

    */
    internal class ListSamples
    {
        public void CodeSamples()
        {
            //creating a List<T>
            //  replace T with the type you want to store in the list
            List<string> names;

            //initialize the list with some values
            names = new List<string>() { "Joker", "Bane", "Riddler" };

            //initialize an empty list
            names = new List<string>();


            //add items to the List
            names.Add("Batman");
            names.Add("The Bats");
            names.Add("Bruce");
            names.Add("Alfred");


            //looping over the list
            //  use .Count in the for loop condition
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]); // use [ ] to access the item at a specific index. use 'i' as the index.
            }


            //Removing from a list
            //  RemoveAt(index)
            names.RemoveAt(1);  //indexes are zero-based. In this example, 1 refers to the 2nd item in the list.


            //Removing from a list
            //  Remove(item)
            names.Remove("Alfred"); //will remove the first item from the list that matches the value passed to Remove.
        }
    }
}
