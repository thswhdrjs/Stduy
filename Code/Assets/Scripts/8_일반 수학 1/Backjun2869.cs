using UnityEngine;

public class Backjun2869 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(2, 1, 5);
        Algorithm(5, 1, 6);
        Algorithm(100, 99, 1000000000);
    }

    private void Algorithm(long n, long n2, long n3)
    {
        if (!(0 < n2) || !(n2 <= n) || !(n <= n3) || !(n3 <= 1000000000))
            return;

        long day = 1;
        long height = n;

        while (height < n3)
        {
            height -= n2;
            day++;
            height += n;
        }

        Debug.Log(day);
    }
}
