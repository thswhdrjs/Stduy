using System;
using UnityEngine;

public class Backjun10814 : MonoBehaviour
{
    string[][] data = new string[3][]
    {
        new string[]{"21", "Junkyu"},
        new string[]{"21", "Dohyun"},
        new string[]{"20", "Sunyoung"}
    };

    private void Start()
    {
        Algorithm(data);
    }

    private void Algorithm(string[][] n)
    {
        string[][] arr = new string[n.Length][];

        for (int i = 0; i < n.Length; i++)
            arr[i] = new string[] { n[i][0], n[i][1], i.ToString() };

        Array.Sort(arr, (s, s2) =>
        {
            if (s[0] == s2[0])
                return int.Parse(s[2]) - int.Parse(s2[2]);
            else
                return int.Parse(s[0]) - int.Parse(s2[0]);
        });

        for (int i = 0; i < n.Length; i++)
            Debug.Log(arr[i][0] + " " + arr[i][1]);
    }
}
