using UnityEngine;

public class Backjun1085 : MonoBehaviour
{
    private void Start()
    {
        Algorithm(6, 2, 10, 3);
        Algorithm(1, 1, 5, 5);
        Algorithm(653, 375, 1000, 1000);
        Algorithm(161, 181, 762, 375);
    }

    private void Algorithm(int n, int n2, int n3, int n4)
    {
        if (!(0 < n && n < n3) && !(0 < n2 && n2 < n4) && !(0 < n3 && n3 <= 1000) && !(0 < n4 && n4 <= 1000))
            return;

        int min = 1000;
        int[] condition = new int[4];
        condition[0] = n;
        condition[1] = n2;
        condition[2] = n3 - n;
        condition[3] = n4 - n2;

        for (int i = 0; i < 4; i++)
        {
            if (condition[i] < min)
                min = condition[i];
        }

        Debug.Log(min);
    }
}
