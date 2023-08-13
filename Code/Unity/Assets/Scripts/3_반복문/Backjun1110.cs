using UnityEngine;

public class Backjun1110 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(26);
        Algorithm(55);
        Algorithm(1);
        Algorithm(0);
        Algorithm(71);
    }

    private void Algorithm(int n)
    {
        if (!(0 <= n && n <= 99))
            return;

        int count = 0;
        int origin = n;

        while (true)
        {
            int sum = 0;
            int tens = 0;
            int units = n % 10;

            if (n > 9)
                tens = n / 10;

            sum = units + tens;
            sum = units * 10 + sum % 10;
            n = sum;
            count++;

            if (sum == origin)
                break;
        }

        Debug.Log(count);
    }
}
