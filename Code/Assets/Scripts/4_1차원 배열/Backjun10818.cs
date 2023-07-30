using System;
using UnityEngine;

public class Backjun10818 : MonoBehaviour
{
    int[] data = new int[5] { 20, 10, 35, 30, 7 };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[] data)
    {
        Array.Sort(data);
        Debug.LogFormat("{0} {1}", data[0], data[data.Length - 1]);
    }
}
