using System;
using UnityEngine;

public class Backjun4344 : MonoBehaviour
{
    int[][] data = new int[5][]
    {
        new int[]{50, 50, 70, 80, 100},
        new int[]{100, 95, 90, 80, 70, 60, 50},
        new int[]{70, 90, 80},
        new int[]{70, 90, 81},
        new int[]{100, 99, 98, 97, 96, 95, 94, 93, 91}
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[][] data)
    {
        float[] average = new float[data.Length];
        float aboveAverage = 0;

        for (int i = 0; i < data.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < data[i].Length; j++)
                sum += data[i][j];

            average[i] = (float)sum / data[i].Length;
        }

        for (int i = 0; i < data.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < data[i].Length; j++)
            {
                if (average[i] < data[i][j])
                    count++;
            }

            aboveAverage = (float)count / data[i].Length * 100;
            Debug.Log(Math.Round(aboveAverage, 3) + "%");
        }
    }
}
