using System;
using UnityEngine;

public class Backjun11720 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("1");
        Algorithm("54321");
        Algorithm("7000000000000000000000000");
        Algorithm("10987654321");
    }

    private void Algorithm(string s)
    {
        int[] arr = new int[s.Length];
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
            arr[i] = (int)Char.GetNumericValue(s[i]);

        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        Debug.Log(sum);
    }
}
