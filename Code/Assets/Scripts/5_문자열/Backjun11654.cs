using System;
using UnityEngine;

public class Backjun11654 : MonoBehaviour
{
    private void Start()
    {
        Algorithm('A');
        Algorithm('C');
        Algorithm('0');
        Algorithm('9');
        Algorithm('a');
        Algorithm('z');
    }

    private void Algorithm(char c)
    {
        int x = Convert.ToInt32(c);
        Debug.Log(x);
    }
}
