using UnityEngine;

public class Backjun2292 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(13);
    }

    private void Algorithm(long n)
    {
        if (!(0 < n && n <= 1000000000))
            return;

        int length = 0;
        int sixMultiple = 0;

        while (sixMultiple < n)
        {
            length++;
            sixMultiple += 6 * length;
        }

        length += 1;
        Debug.Log(length);
    }
}
