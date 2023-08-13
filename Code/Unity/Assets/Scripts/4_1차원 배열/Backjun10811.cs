using System;
using UnityEngine;

public class Backjun10811 : MonoBehaviour
{
    int[][] data = new int[4][]
    {
        new int[]{ 1, 2 },
        new int[]{ 3, 4 },
        new int[]{ 1, 4 },
        new int[]{ 2, 2 }
    };

    private void Start()
    {
        Algorithm(5, data);
    }

    private void Algorithm(int n, int[][] data)
    {
        int[] basket = new int[n + 1];
        
        for (int i = 1; i < basket.Length; i++)
            basket[i] = i;

        for(int i = 0; i < data.Length; i++)
        {
            int[] temp = new int[data[i][1] - data[i][0] + 1];
            Array.Copy(basket, data[i][0], temp, 0, temp.Length);

            for (int a = 0; a < temp.Length; a++)
                print(i + " ? " + temp[a]);
            Array.Reverse(temp);

            for (int j = 0; j < temp.Length; j++)
                basket[j + data[i][0]] = temp[j];
        }

        string output = basket[1].ToString();

        for (int i = 2; i < basket.Length; i++)
            output += " " + basket[i];

        Debug.Log(output);
    }
}
