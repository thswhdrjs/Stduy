using UnityEngine;

public class Backjun9020 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(8);
        Algorithm(10);
        Algorithm(16);
    }

    private void Algorithm(int n)
    {
        if (!(3 < n && n <= 10000) && !(n % 2 == 0))
            return;

        int[] goldbach = new int[2];
        bool[] isPrime = new bool[n + 1];

        for (int i = n / 2; i <= n; i++)
        {
            isPrime[i] = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime[i] = false;
                    break;
                }
            }

            if (isPrime[i])
            {
                goldbach[0] = n - i;
                goldbach[1] = i;

                if (goldbach[0] % 3 == 0 && goldbach[0] < 4)
                    break;
                else if (goldbach[0] % 3 != 0)
                    break;
            }
        }

        Debug.Log(goldbach[0] + " " + goldbach[1]);
    }
}
