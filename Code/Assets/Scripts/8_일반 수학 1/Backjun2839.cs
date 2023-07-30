using UnityEngine;

public class Backjun2839 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(18);
        Algorithm(4);
        Algorithm(6);
        Algorithm(9);
        Algorithm(11);
    }

    private void Algorithm(int n)
    {
        if (!(2 < n && n < 5001))
            return;

        int big = 0, small = 0, total = 0;

        if (n % 5 % 3 == 0)
        {
            big = n / 5;
            small = n % 5 / 3;
            total = big + small;
        }
        else if (n > 5 && (n % 5 + 5) % 3 == 0)
        {
            big = n / 5 - 1;
            small = (n % 5 + 5) / 3;
            total = big + small;
        }
        else if (n % 3 == 0)
            total = n / 3;
        else
            total = -1;

        Debug.Log(total);
    }
}
