using UnityEngine;

public class Backjun2739 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(2);
    }

    private void Algorithm(int n)
    {
        if (!(1 <= n && n <= 9))
            return;

        for (int i = 1; i < 10; i++)
            Debug.Log(n + " * " + i + " = " + n * i);
    }
}
