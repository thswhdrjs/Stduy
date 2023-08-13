using UnityEngine;

public class Backjun2231 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(216);
    }

    private void Algorithm(int n)
    {
        int num = n;
        int sum = 0;
        int digit = 0;
        int constructor = 0;

        while (true)
        {
            digit += 9;

            if (num / 10 != 0)
                num /= 10;
            else
                break;
        }

        for (int i = n - digit; i < n; i++)
        {
            num = i;
            sum = 0;

            while (true)
            {
                sum += num % 10;

                if (num / 10 != 0)
                    num /= 10;
                else
                    break;
            }

            if (i + sum == n)
            {
                constructor = i;
                break;
            }
        }

        Debug.Log(constructor);
    }
}
