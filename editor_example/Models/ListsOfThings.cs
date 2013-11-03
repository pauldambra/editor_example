using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace editor_example.Models
{
    public class ListsOfThings
    {
        public IEnumerable<Thing> NewThings {get;set;}
        public IEnumerable<Thing> OldThings {get;set;}

        public static ListsOfThings GetExampleLists()
        {
            var newThings = new List<Thing> 
            {
                new Thing {Id = 1, Name = "First New"},
                new Thing {Id = 2, Name = "Second New"},
                new Thing {Id = 3, Name = "Third New"},
            };
            var oldThings = new List<Thing> 
            {
                new Thing {Id = 4, Name = "First Old"},
                new Thing {Id = 5, Name = "Second Old"},
                new Thing {Id = 6, Name = "Third Old"},
            };
            return new ListsOfThings
                {
                    NewThings = newThings,
                    OldThings = oldThings
                };
        }
    }
}