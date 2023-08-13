using UnityEngine;

public class Backjun1065 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(110);
        Algorithm(1);
        Algorithm(210);
        Algorithm(1000);
        Algorithm(500);
    }

    private void Algorithm(int n)
    {
        if (!(0 < n && n <= 1000))
            return;

        int count = 0;

        if (n <= 100)
            count = n;
        else
        {
            int[] arr = new int[3];
            count = 99;

            for (int i = 101; i <= n; i++)
            {
                int temp = i;

                for (int j = 0; j < 3; j++)
                {
                    arr[j] = temp % 10;

                    if (temp != 0)
                        temp /= 10;
                }

                if (arr[2] - arr[1] == arr[1] - arr[0])
                    count++;
            }
        }

        Debug.Log(count);
    }
}
