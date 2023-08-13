using UnityEngine;

public class Backjun15596 : MonoBehaviour
{
    private long Algorithm(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (!(0 <= a[i] && a[i] <= 1000000) || !(1 <= a.Length && a.Length <= 3000000))
                return -1;
        }

        int sum = 0;

        for (int i = 0; i < a.Length; i++)
            sum += a[i];

        return sum;
    }
}
