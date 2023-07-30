using System;
using UnityEngine;

public class Backjun3053 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1);
        Algorithm(21);
        Algorithm(42);
    }

    private void Algorithm(int n)
    {
        double pie = 3.141593d;
        double euclidArea = Math.Round(n * n * pie, 6);
        double taxiArea = Math.Round(n * n * 2d, 6);

        Debug.Log(string.Format("{0:F6}", euclidArea));
        Debug.Log(string.Format("{0:F6}", taxiArea));
    }
}
