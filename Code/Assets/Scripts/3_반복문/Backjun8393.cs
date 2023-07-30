using UnityEngine;

public class Backjun8393 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3);
    }

    private void Algorithm(int n)
    {
        if (!(1 <= n && n <= 10000))
            return;

        int sum = 0;

        for (int i = 1; i < n + 1; i++)
            sum += i;

        Debug.Log(sum);
    }
}
