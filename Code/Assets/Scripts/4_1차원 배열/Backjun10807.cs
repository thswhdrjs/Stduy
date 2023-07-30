using System;
using UnityEngine;

public class Backjun10807 : MonoBehaviour
{
    int[] data = new int[11] { 1, 4, 1, 2, 4, 2, 4, 2, 3, 4, 4 };
    int[] data2 = new int[11] { 1, 4, 1, 2, 4, 2, 4, 2, 3, 4, 4 };

    private void Start()
    {
        Algorithm(data, 2);
        Algorithm(data2, 5);
    }

    private void Algorithm(int[] data, int findNum)
    {
        int sum = 0;

        foreach(int n in data)
        {
            if (n == findNum)
                sum++;
        }

        Debug.Log(sum);
    }
}
