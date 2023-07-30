using System;
using UnityEngine;

public class Backjun11650 : MonoBehaviour
{
    int[,] data = new int[5, 2]
    {
        { 3, 4 },
        { 1, 1 },
        { 1, -1 },
        { 2, 2 },
        { 3, 3 }
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[,] n)
    {
        (int x, int y)[] temp = new (int x, int y)[n.GetLength(0)];

        for (int i = 0; i < n.GetLength(0); i++)
            temp[i] = (n[i, 0], n[i, 1]);

        Array.Sort(temp);

        for (int i = 0; i < temp.Length; i++)
            Debug.Log(temp[i].x + " " + temp[i].y);
    }
}
