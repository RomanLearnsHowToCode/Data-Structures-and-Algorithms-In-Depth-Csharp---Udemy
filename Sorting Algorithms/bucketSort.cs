using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // https://code-maze.com/bucket-sort-csharp/

    /*
     STEPS:

    Sort array = 42, 6, 16, 4, 12, 24, 46, 17

    1) We need to divide these elements into buckets using an identifier.
    To make our example simple, let’s create buckets based on a range of ten values for each bucket: 0 – 9, 10 – 19, 20 – 29, 30 – 39, and 40 – 49.
    
    2) Next, we are going to “scatter” the elements into those buckets based on their range: 

        0 – 9: 6, 4
        10 – 19: 16, 12, 17
        20 – 29: 24
        30 – 39: null
        40 – 49: 42, 56

    3) Now, we sort the items in each bucket using a different algorithm such as bubble sort (to keep our illustration simple):

        0 – 9: 4, 6
        10 – 19: 12, 16, 17
        20 – 29: 24
        30 – 39: null
        40 – 49: 42, 56
     
     4) Finally, we gather the items from each bucket in the correct order, which completes the sorting process: 

        4, 6, 12, 16, 17, 24, 42, 56

     */

    class bucketSort
    {
        int[] array = { 42, 6, 16, 4, 12, 24, 46, 17 };

    }
}
