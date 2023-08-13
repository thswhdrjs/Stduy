using UnityEngine;

public class Backjun2884 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(10, 10);
        Algorithm(0, 30);
        Algorithm(23, 40);
    }

    private void Algorithm(int h, int m)
    {
        if (!(0 <= h && h <= 23) || !(0 <= m && m <= 59))
            return;

        m -= 45;

        if (m < 0)
        {
            m = 60 - Mathf.Abs(m);
            h -= 1;

            if (h < 0)
                h = 23;
        }

        Debug.Log(h + " " + m);
    }
}
