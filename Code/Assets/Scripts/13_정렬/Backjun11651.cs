using System;
using UnityEngine;

public class Backjun11651 : MonoBehaviour
{
    int[][] data = new int[5][]
    {
        new int[] { 0, 4 },
        new int[] { 1, 2 },
        new int[] { 1, -1 },
        new int[] { 2, 2 },
        new int[] { 3, 3 }
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[][] n)
    {
        Array.Sort(n, (a, b) =>
        {
            if (a[1] == b[1])
                return a[0] - b[0];
            else
                return a[1] - b[1];
        });

        for (int i = 0; i < n.Length; i++)
            Debug.Log(n[i][0] + " / " + n[i][1]);
    }
}
