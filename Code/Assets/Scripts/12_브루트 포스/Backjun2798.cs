using System;
using UnityEngine;

public class Backjun2798 : MonoBehaviour
{
    int[] data = new int[5] { 5, 6, 7, 8, 9 };
    int[] data2 = new int[10] { 93, 181, 245, 214, 315, 36, 185, 138, 216, 295 };

    private void Start()
    {
        Algorithm(21, data);
        Algorithm(500, data2);
    }

    private void Algorithm(int m, int[] num)
    {
        Array.Sort(num);
        Array.Reverse(num);
        int sum = 0;

        for (int i = 0; i < num.Length - 2; i++)
        {
            for (int j = 0; j < num.Length - 1; j++)
            {
                if (i == j)
                    continue;

                for (int k = 0; k < num.Length; k++)
                {
                    if (i == k || j == k)
                        continue;

                    int sum2 = num[i] + num[j] + num[k];

                    if (sum2 > m)
                        continue;
                            
                    if (sum < sum2)
                        sum = sum2;
                }
            }
        }

        Debug.Log(sum);
    }
}
