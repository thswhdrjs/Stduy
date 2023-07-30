using UnityEngine;

public class Backjun11653 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(72);
        Algorithm(3);
        Algorithm(6);
        Algorithm(2);
        Algorithm(9991);
    }

    private void Algorithm(int n)
    {
        if (!(0 < n && n <= 10000000))
            return;

        int num = n;
        bool[] isPrime = new bool[n + 1];

        if (num != 1)
        {
            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    isPrime[i] = true;

                    if (num % j != 0)
                        isPrime[i] = false;

                    if (isPrime[i])
                    {
                        while (num % j == 0)
                        {
                            num /= j;
                            Debug.Log(j);
                        }
                    }
                }
            }
        }
    }
}
