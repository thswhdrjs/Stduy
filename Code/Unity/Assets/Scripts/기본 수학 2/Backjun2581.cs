using UnityEngine;

public class Backjun2581 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(60, 100);
        Algorithm(64, 65);
    }

    private void Algorithm(int n, int n2)
    {
        if (!(0 < n && n <= n2) && !(n2 <= 10000))
            return;

        int sumPrime = -1, min = 0;
        bool[] isPrime = new bool[n2 + 1];


        for (int i = n; i <= n2; i++)
        {
            if (i == 1)
                continue;

            isPrime[i] = true;

            for (int j = 2; j * j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime[i] = false;
                    break;
                }
            }

            if (isPrime[i])
            {
                if (min == 0)
                    min = i;

                sumPrime += i;
            }
        }

        if (sumPrime != -1)
            Debug.Log(sumPrime + 1);
        else
            Debug.Log(sumPrime);

        if (min != 0)
            Debug.Log(min);
    }
}
