using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class Sorting
    {
        public void SortByID(List<Human> humans)
        {
            for (var i = 0; i < humans.Count -1; i++)
            for (var j = i; j < humans.Count - i - 1; j++)
            {
                if (humans[j].ID <= humans[j + 1].ID) continue;
                var temp = humans[j];
                humans[j] = humans[j + 1];
                humans[j + 1] = temp;
            }
        }

        public void SortByName(List<Human> humans)
        {
            var result = humans.OrderBy(a => a.Name).ToList();
            for (var i = 0; i < humans.Count; i++)
            {
                humans[i] = result[i];
            }
        }
    }
}