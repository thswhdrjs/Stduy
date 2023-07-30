using System;
using UnityEngine;

public class Backjun2562 : MonoBehaviour
{
    int[] data = new int[9] { 3, 29, 38, 12, 57, 74, 40, 85, 61 };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(int[] data)
    {
        Array.Sort(data);

        for(int i = 0; i < data.Length; i++)
        {
            if(data[i] == data[data.Length - 1])
            {
                Debug.Log(data[data.Length - 1]);
                Debug.Log(i);
                break;
            }
        }
    }
}
