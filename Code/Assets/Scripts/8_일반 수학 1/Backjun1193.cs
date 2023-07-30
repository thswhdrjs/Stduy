using UnityEngine;

public class Backjun1193 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(1);
        Algorithm(2);
        Algorithm(3);
        Algorithm(4);
        Algorithm(5);
        Algorithm(6);
        Algorithm(7);
        Algorithm(8);
        Algorithm(9);
        Algorithm(14);
    }

    private void Algorithm(long n)
    {
        if (!(0 < n && n <= 10000000))
            return;

        int level = 1;
        int temp = 1;

        while (temp < n)
        {
            level++;
            temp = temp + level;
        }

        int den = temp - (int)n + 1;

        if (level % 2 == 0)
            Debug.Log((level + 1 - den) + "/" + den);
        else
            Debug.Log(den + "/" + (level + 1 - den));
    }
}
