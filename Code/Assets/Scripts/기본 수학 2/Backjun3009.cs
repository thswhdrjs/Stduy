using System;
using UnityEngine;

public class Backjun3009 : MonoBehaviour
{
    int[][] data = new int[3][]
    {
        new int[]{5, 5},
        new int[]{5, 7},
        new int[]{7, 5}
    };

    int[][] data2 = new int[3][]
    {
        new int[]{30, 20},
        new int[]{10, 10},
        new int[]{10, 20}
    };

    private void Start()
    {
        Algorithm(data);
        Algorithm(data2);
    }

    private void Algorithm(int[][] n)
    {
        for (int i = 0; i < n.Length; i++)
        {
            for (int j = 0; j < n[i].Length; j++)
            {
                if (!(0 < n[i][j] && n[i][j] <= 1000))
                    return;
            }
        }

        int minus = 0;
        int common = 0;
        int rest = 0;
        int big = 0;

        for (int i = 0; i < n.Length - 1; i++)
        {
            for (int j = i + 1; j < n.Length; j++)
            {
                if (n[i][0] == n[j][0])
                {
                    common = n[i][0];
                    big = n[i][1] > n[j][1] ? n[i][1] : n[j][1];
                    minus = Math.Abs(n[i][1] - n[j][1]);
                    break;
                }

                if (common != 0)
                    break;
            }
        }

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i][0] == common)
                continue;

            minus *= n[i][1] < big ? 1 : -1;
            rest = n[i][1] + minus;
            Debug.Log(n[i][0] + " " + rest);
        }
    }
}
