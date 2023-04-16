using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // https://www.youtube.com/watch?v=POHHNcCqt8A
    class radixSort2
    {
        // sort inegers -> sort the most significant, 101 304 400
        // 1 4 0 
        // 400 101 304, then compare the next digit
        // 0 0 0 
        // left most
        // 101 304 400

        static int[] radixSort(int[] data)
        {
            int[] temp = new int[data.Length];

            for(int shift = 31; shift > -1; shift--)
            {
                int j = 0;

                for(int i = 0; i < data.Length; i++)
                {
                    bool move = (data[i] << shift) >= 0;

                    // 
                    if(shift == 0 ? !move : move)
                    {
                        data[i - j] = data[i];
                    }
                    else
                    {
                        temp[j++] = data[i];
                    }
                }

            Array.Copy(temp, 0, data, data.Length - j, j);
            }
            return data;
        }
       
    }
}
