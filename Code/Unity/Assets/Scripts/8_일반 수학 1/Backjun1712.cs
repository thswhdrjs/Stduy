using UnityEngine;

public class Backjun1712 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1000, 70, 170);
        Algorithm(3, 2, 1);
        Algorithm(2100000000, 9, 10);
    }

    private void Algorithm(long n, long n2, long n3)
    {
        if (!(0 < n && n <= 2100000000) || !(0 < n2 && n2 <= 2100000000) || !(0 < n3 && n3 <= 2100000000))
            return;

        if (n2 > n3)
            Debug.Log("-1");
        else
        {
            long count = 1, income = 0, cost = 0;

            do
            {
                income = n3 * count;
                cost = n + n2 * count;
                count++;
            }
            while (income < cost);

            Debug.Log(count);
        }
    }
}
