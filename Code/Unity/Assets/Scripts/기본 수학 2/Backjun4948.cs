using UnityEngine;

public class Backjun4948 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1);
        Algorithm(10);
        Algorithm(13);
        Algorithm(100);
        Algorithm(1000);
        Algorithm(10000);
        Algorithm(100000);
        Algorithm(0);
    }

    private void Algorithm(int n)
    {
        if (!(0 < n && n <= 123456))
            return;

        int count = 0;
        bool[] isPrime = new bool[2 * n + 1];

        for (int i = n + 1; i <= 2 * n; i++)
        {
            if (i == 1)
                continue;

            isPrime[i] = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime[i] = false;
                    break;
                }
            }
        }

        for (int i = n + 1; i <= 2 * n; i++)
        {
            if (isPrime[i])
                count++;
        }

        Debug.Log(count);
    }
}
