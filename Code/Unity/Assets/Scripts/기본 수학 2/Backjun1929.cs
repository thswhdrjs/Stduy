using UnityEngine;

public class Backjun1929 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(3, 16);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n <= n2) && !(n2 <= 1000000))
            return;

        bool[] isPrime = new bool[n2 + 1];

        for (int i = n; i <= n2; i++)
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

        for (int i = n; i <= n2; i++)
        {
            if (isPrime[i])
                Debug.Log(i);
        }
    }
}
