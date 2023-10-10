using System;
using System.Collections.Generic;

public class FindMajorityElement
{
public int MajorityElement(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int majorityElement = 0;
        int majorityCount = 0;

        foreach (int num in arr)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num]++;
            }

            if (dict[num] > majorityCount)
            {
                majorityCount = dict[num];
                majorityElement = num;
            }
        }

        if (majorityCount > arr.Length / 2)
        {
            return majorityElement;
        }
        else
        {
            throw new Exception("No majority element found");
        }
    }
}